using System;
using System.Data;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

 namespace CampusLostAndFound.AdminForms
{
    public partial class frmManageFoundItems : Form
    {
        private DataTable _dtFoundItems;

        public frmManageFoundItems()
        {
            InitializeComponent();
        }

        private void _RefreshFoundItemsList()
        {
            _dtFoundItems = clsItem.GetAllFoundItems();
            dgvFoundItems.DataSource = _dtFoundItems;
            lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();

            if (dgvFoundItems.Rows.Count > 0)
            {
                dgvFoundItems.Columns[0].HeaderText = "Item ID";
                dgvFoundItems.Columns[1].HeaderText = "Item Name";
                dgvFoundItems.Columns[2].HeaderText = "Category";
                dgvFoundItems.Columns[3].HeaderText = "Color";
                dgvFoundItems.Columns[4].HeaderText = "Location";
                dgvFoundItems.Columns[5].HeaderText = "Date Found";
                dgvFoundItems.Columns[6].HeaderText = "Status";
            }

            dgvFoundItems.ClearSelection();
        }

        private void frmManageFoundItems_Load(object sender, EventArgs e)
        {
            _RefreshFoundItemsList();
            cbFilterBy.SelectedIndex = 0;

            // Only Admin can delete items
            if (clsGlobal.CurrentUser != null &&
                !string.Equals(clsGlobal.CurrentUser.Role, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                deleteItemToolStripMenuItem.Visible = false;
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
                else if (_dtFoundItems != null)
                {
                    _dtFoundItems.DefaultView.RowFilter = "";
                    lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
                }
            }
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtFoundItems == null) return;

            if (cbStatusFilter.Text == "All")
                _dtFoundItems.DefaultView.RowFilter = "";
            else
                _dtFoundItems.DefaultView.RowFilter = string.Format("[Status] = '{0}'", cbStatusFilter.Text);

            lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtFoundItems == null) return;
            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Item ID":
                    filterColumn = _dtFoundItems.Columns[0].ColumnName; 
                    break;
                case "Item Name":
                    filterColumn = "ItemName";
                    break;
                case "Category":
                    filterColumn = "Category";
                    break;
                case "Color":
                    filterColumn = "Color";
                    break;
                case "Location":
                    filterColumn = "Location";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            string rawText = txtFilterValue.Text.Trim();

            if (rawText == "" || filterColumn == "None")
            {
                _dtFoundItems.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.Text == "Item ID")
            {
                if (int.TryParse(rawText, out int id))
                    _dtFoundItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, id);
            }
            else
            {
                string safeValue = clsGlobal.EscapeRowFilterValue(rawText);
                _dtFoundItems.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, safeValue);
            }

            lblRecordCount.Text = dgvFoundItems.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Item ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmsFoundItems_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvFoundItems.Rows.Count == 0 || dgvFoundItems.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            string status = dgvFoundItems.CurrentRow.Cells["Status"].Value.ToString();
            markAsClaimedToolStripMenuItem.Enabled = (status == "Open");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddEditItem frm = new frmAddEditItem("Found");
            frm.ShowDialog();
            _RefreshFoundItemsList();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;
            int itemID = (int)dgvFoundItems.CurrentRow.Cells[0].Value;
            frmAddEditItem frm = new frmAddEditItem(itemID);
            frm.ShowDialog();
            _RefreshFoundItemsList();
        }

        private void markAsClaimedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;
            int itemID = (int)dgvFoundItems.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Mark Found Item #{itemID} as Claimed?", "Confirm Status Change",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsItem item = clsItem.Find(itemID);
                if (item != null)
                {
                    item.Status = "Claimed";
                    if (item.Save())
                    {
                        MessageBox.Show("Item status updated to Claimed.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshFoundItemsList();
                    }
                }
            }
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoundItems.CurrentRow == null) return;
            int itemID = (int)dgvFoundItems.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure you want to delete Found Item #{itemID}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsItem.DeleteItem(itemID))
                {
                    MessageBox.Show("Item Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshFoundItemsList();
                }
            }
        }
    }
}