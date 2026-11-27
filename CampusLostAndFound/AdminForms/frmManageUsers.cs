using CampusLostAndFound.AdminForms;
using CampusLostAndFound.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CampusLostAndFound
{
    public partial class frmManageUsers : Form
    {
        private DataTable _dtAllUsers;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _ReNumberRows()
        {
            if (dgvUsers.Columns.Contains("RowNo"))
            {
                for (int i = 0; i < dgvUsers.Rows.Count; i++)
                {
                    dgvUsers.Rows[i].Cells["RowNo"].Value = i + 1;
                }
            }
        }

        private void _RefreshUsersList()
        {
            _dtAllUsers = clsUser.GetAllUsers();

            if (!_dtAllUsers.Columns.Contains("RowNo"))
            {
                _dtAllUsers.Columns.Add("RowNo", typeof(int));
                _dtAllUsers.Columns["RowNo"].SetOrdinal(0);
            }

            for (int i = 0; i < _dtAllUsers.Rows.Count; i++)
            {
                _dtAllUsers.Rows[i]["RowNo"] = i + 1;
            }

            dgvUsers.DataSource = _dtAllUsers;
            lblRecordCount.Text = dgvUsers.Rows.Count.ToString();

            if (dgvUsers.Columns.Count > 0)
            {
                dgvUsers.Columns["RowNo"].HeaderText = "#";
                dgvUsers.Columns["RowNo"].Width = 45;

                // إخفاء الـ ID الحقيقي المخزن في قاعدة البيانات
                dgvUsers.Columns["UserID"].Visible = false;

                dgvUsers.Columns["Username"].HeaderText = "Username";
                dgvUsers.Columns["Role"].HeaderText = "Role";
                dgvUsers.Columns["IsActive"].HeaderText = "Is Active";
            }

            dgvUsers.ClearSelection();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();
            cbFilterBy.SelectedIndex = 0; // Select "None" by default
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.BringToFront();
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0; // Select "All"
            }
            else
            {
                cbIsActive.Visible = false;
                txtFilterValue.Visible = (cbFilterBy.Text != "None");

                if (txtFilterValue.Visible)
                {
                    txtFilterValue.BringToFront();
                    txtFilterValue.Text = "";
                    txtFilterValue.Focus();
                }
                else if (_dtAllUsers != null)
                {
                    _dtAllUsers.DefaultView.RowFilter = "";
                    _ReNumberRows();
                    lblRecordCount.Text = dgvUsers.Rows.Count.ToString();
                }
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllUsers == null) return;

            switch (cbIsActive.Text)
            {
                case "All":
                    _dtAllUsers.DefaultView.RowFilter = "";
                    break;
                case "Yes":
                    _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 1";
                    break;
                case "No":
                    _dtAllUsers.DefaultView.RowFilter = "[IsActive] = 0";
                    break;
            }

            _ReNumberRows();
            lblRecordCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllUsers == null) return;

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    filterColumn = "UserID";
                    break;
                case "Username":
                    filterColumn = "Username";
                    break;
                case "Role":
                    filterColumn = "Role";
                    break;
                case "Is Active":
                    filterColumn = "IsActive";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            string rawText = txtFilterValue.Text.Trim();

            if (rawText == "" || filterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                _ReNumberRows();
                lblRecordCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "UserID")
            {
                if (int.TryParse(rawText, out int id))
                    _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, id);
            }
            else if (filterColumn == "IsActive")
            {
                if (rawText == "1" || rawText.Equals("true", StringComparison.OrdinalIgnoreCase))
                    _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = 1", filterColumn);
                else if (rawText == "0" || rawText.Equals("false", StringComparison.OrdinalIgnoreCase))
                    _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = 0", filterColumn);
            }
            else
            {
                string safeValue = clsGlobal.EscapeRowFilterValue(rawText);
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, safeValue);
            }

            _ReNumberRows();
            lblRecordCount.Text = dgvUsers.Rows.Count.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            frmAddEditUser frm = new frmAddEditUser(userID);
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            if (clsGlobal.CurrentUser != null && userID == clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("You cannot delete your own currently logged-in account!",
                                "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete user [{username}]?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(userID))
                {
                    MessageBox.Show("User Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
                else
                {
                    MessageBox.Show("User was not deleted because it is linked to other records in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toggleActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;

            if (clsGlobal.CurrentUser != null && userID == clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("You cannot deactivate your own currently logged-in account!",
                                "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsUser user = clsUser.Find(userID);

            if (user != null)
            {
                user.IsActive = !user.IsActive;
                if (user.Save())
                {
                    MessageBox.Show($"User status changed to {(user.IsActive ? "Active" : "Inactive")}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsersList();
                }
            }
        }

        private void cmsUsers_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cmsUsers.Enabled = (dgvUsers.Rows.Count > 0);
        }
    }
}