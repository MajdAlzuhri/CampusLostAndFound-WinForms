using System;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound.AdminForms
{
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        private clsUser _User;

        // Constructor for Add New Mode
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        // Constructor for Update Mode
        public frmAddEditUser(int userID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = userID;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                _User = new clsUser();
            }
            else
            {
                lblTitle.Text = "Update User";
            }

            lblUserID.Text = "???";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRole.SelectedIndex = 1; // Default: User
            chkIsActive.Checked = true;
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUsername.Text = _User.Username;
            txtPassword.Text = _User.Password;
            cbRole.SelectedIndex = cbRole.FindString(_User.Role);
            chkIsActive.Checked = _User.IsActive;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();


            if (clsGlobal.CurrentUser != null && _User.UserID == clsGlobal.CurrentUser.UserID)
            {
                cbRole.Enabled = false;
                chkIsActive.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername.Text.Trim();

            if (!username.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)
                || username.Length <= "@gmail.com".Length
                || username.Contains(" "))
            {
                MessageBox.Show("Username must be a valid Gmail address without spaces ending with '@gmail.com' (e.g., user@gmail.com).",
                                "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (_Mode == enMode.AddNew || _User.Username.ToLower() != username.ToLower())
            {
                if (clsUser.IsUserExists(username))
                {
                    MessageBox.Show("This username is already taken. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Focus();
                    return;
                }
            }

            _User.Username = username;
            _User.Password = txtPassword.Text.Trim();
            _User.Role = cbRole.Text;
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";

                if (clsGlobal.CurrentUser != null && _User.UserID == clsGlobal.CurrentUser.UserID)
                    clsGlobal.CurrentUser = _User;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Was Not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}