using System;
using System.Data;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmManageClaims : Form
    {
        private DataTable _dtClaims;

        public frmManageClaims()
        {
            InitializeComponent();
        }

        private void _RefreshClaimsList()
        {
            _dtClaims = clsClaim.GetAllClaims();
            dgvClaims.DataSource = _dtClaims;
            lblRecordCount.Text = dgvClaims.Rows.Count.ToString();

            if (dgvClaims.Rows.Count > 0)
            {
                dgvClaims.Columns[0].HeaderText = "Claim ID";
                dgvClaims.Columns[1].HeaderText = "Item ID";
                dgvClaims.Columns[2].HeaderText = "Item Name";
                dgvClaims.Columns[3].HeaderText = "Claimant Name";
                dgvClaims.Columns[4].HeaderText = "Phone";
                dgvClaims.Columns[5].HeaderText = "Verification Notes";
                dgvClaims.Columns[6].HeaderText = "Status";
                dgvClaims.Columns[7].HeaderText = "Processed By";
            }
        }

        private void frmManageClaims_Load(object sender, EventArgs e)
        {
            _RefreshClaimsList();
            cbFilterBy.SelectedIndex = 0;

            // Only Admin can delete claims
            if (clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.Role != "Admin")
            {
                deleteClaimToolStripMenuItem.Visible = false;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Status")
            {
                txtFilterValue.Visible = false;
                cbStatusFilter.Visible = true;
                cbStatusFilter.BringToFront();
                cbStatusFilter.Focus();
                cbStatusFilter.SelectedIndex = 0;
            }
            else
            {
                cbStatusFilter.Visible = false;
                txtFilterValue.Visible = (cbFilterBy.Text != "None");

                if (txtFilterValue.Visible)
                {
                    txtFilterValue.BringToFront();
                    txtFilterValue.Text = "";
                    txtFilterValue.Focus();
                }
                else if (_dtClaims != null)
                {
                    _dtClaims.DefaultView.RowFilter = "";
                    lblRecordCount.Text = dgvClaims.Rows.Count.ToString();
                }
            }
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtClaims == null) return;

            if (cbStatusFilter.Text == "All")
                _dtClaims.DefaultView.RowFilter = "";
            else
                _dtClaims.DefaultView.RowFilter = string.Format("[ClaimStatus] = '{0}'", cbStatusFilter.Text);

            lblRecordCount.Text = dgvClaims.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtClaims == null) return;
            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Claim ID": filterColumn = "ClaimID"; break;
                case "Item ID": filterColumn = "ItemID"; break;
                case "Claimant Name": filterColumn = "ClaimantName"; break;
                case "Phone": filterColumn = "Phone"; break;
                default: filterColumn = "None"; break;
            }

            if (txtFilterValue.Text.Trim() == "" || filterColumn == "None")
            {
                _dtClaims.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvClaims.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "ClaimID" || filterColumn == "ItemID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int id))
                    _dtClaims.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, id);
            }
            else
            {
                string safeValue = clsGlobal.EscapeRowFilterValue(txtFilterValue.Text.Trim());
                _dtClaims.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilterValue.Text.Trim().Replace("'", "''"));
            }

            lblRecordCount.Text = dgvClaims.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Claim ID" || cbFilterBy.Text == "Item ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsClaims_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvClaims.Rows.Count == 0 || dgvClaims.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            string status = dgvClaims.CurrentRow.Cells[6].Value.ToString();
            bool isPending = (status == "Pending");

            approveClaimToolStripMenuItem.Enabled = isPending;
            rejectClaimToolStripMenuItem.Enabled = isPending;
        }

        private void approveClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClaims.CurrentRow == null) return;

            int claimID = (int)dgvClaims.CurrentRow.Cells[0].Value;
            string claimant = dgvClaims.CurrentRow.Cells[3].Value.ToString();

            if (MessageBox.Show($"Approve claim #{claimID} for [{claimant}]?\nThis will automatically mark the linked item as Claimed.",
                "Approve Claim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsClaim claim = clsClaim.Find(claimID);
                if (claim != null && claim.Approve("Ownership verified and approved."))
                {
                    MessageBox.Show("Claim Approved! Linked item status updated to Claimed.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClaimsList();
                }
                else
                {
                    MessageBox.Show("Unable to approve claim. Another claim for this item may already be approved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rejectClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClaims.CurrentRow == null) return;

            int claimID = (int)dgvClaims.CurrentRow.Cells[0].Value;
            string claimant = dgvClaims.CurrentRow.Cells[3].Value.ToString();

            if (MessageBox.Show($"Reject claim #{claimID} for [{claimant}]?",
                "Reject Claim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsClaim claim = clsClaim.Find(claimID);
                if (claim != null && claim.Reject("Ownership verification failed."))
                {
                    MessageBox.Show("Claim Rejected.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClaimsList();
                }
            }
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            frmAddEditClaim frm = new frmAddEditClaim();
            frm.ShowDialog();
            _RefreshClaimsList();
        }

        private void editClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClaims.CurrentRow == null) return;
            int claimID = (int)dgvClaims.CurrentRow.Cells[0].Value;
            frmAddEditClaim frm = new frmAddEditClaim(claimID);
            frm.ShowDialog();
            _RefreshClaimsList();
        }

        private void deleteClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvClaims.CurrentRow == null) return;

            int claimID = (int)dgvClaims.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete Claim #{claimID}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsClaim.DeleteClaim(claimID))
                {
                    MessageBox.Show("Claim Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshClaimsList();
                }
            }
        }
    }
}