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

        private void _RefreshUsersList()
        {
            _dtAllUsers = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUsers;
            lblRecordCount.Text = dgvUsers.Rows.Count.ToString();

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[1].HeaderText = "Username";
                dgvUsers.Columns[2].HeaderText = "Role";
                dgvUsers.Columns[3].HeaderText = "Is Active";
            }
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

            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            frmAddEditUser frm = new frmAddEditUser(userID);
            frm.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (clsGlobal.CurrentUser != null && userID == clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("You cannot delete your own currently logged-in account!",
                                "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.CurrentRow.Cells[1].Value.ToString();

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

            int userID = (int)dgvUsers.CurrentRow.Cells[0].Value;

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