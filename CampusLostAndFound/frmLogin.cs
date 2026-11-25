using CampusLostAndFound.BLL;
using Sunny.UI.Win32;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CampusLostAndFound
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.RectColor = Color.RoyalBlue;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.RectColor = Color.LightGray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.RectColor = Color.RoyalBlue;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.RectColor = Color.LightGray;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool hasError = false;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(txtUsername, "Please enter your Username.");
                hasError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(txtPassword, "Please enter your Password.");
                hasError = true;
            }

            if (hasError) return;

            string emailPattern = @"^[a-zA-Z0-9.]+@gmail\.com$";
            if (!Regex.IsMatch(username, emailPattern))
            {
                errorProvider1.SetError(txtUsername, "Invalid Username. It must contain only English characters and end with '@gmail.com'.");
                return;
            }

            string passwordPattern = @"^[0-9]+$";
            if (!Regex.IsMatch(password, passwordPattern))
            {
                errorProvider1.SetError(txtPassword, "Invalid Password. It must contain only numbers (0-9).");
                return;
            }

            clsUser CurrentUser = clsUser.Find(username, password);

            if (CurrentUser != null)
            {
                if (!CurrentUser.IsActive)
                {
                    MessageBox.Show("Your account is inactive. Please contact support.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                clsGlobal.CurrentUser = CurrentUser;

                if (CurrentUser.Role == "Admin" || CurrentUser.Role == "User")
                {
                    this.Hide();
                    frmAdminDashboard dashboard = new frmAdminDashboard();
                    dashboard.FormClosed += (s, args) =>
                    {
                        txtPassword.Clear();
                        this.Show();
                    };
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}