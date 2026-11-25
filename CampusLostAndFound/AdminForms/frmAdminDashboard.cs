using CampusLostAndFound.AdminForms;
using System;
using System.Windows.Forms;

namespace CampusLostAndFound
{
    public partial class frmAdminDashboard : Form
    {
        private Form _activeForm = null;

        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, string pageTitle)
        {
            lblPageTiltle.Text = pageTitle;

            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            uiPanel2.Controls.Add(childForm);
            uiPanel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private string _GetDashboardTitle()
        {
            return (clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.Role == "Admin")
                ? "Admin Dashboard"
                : "User Dashboard";
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.Activate();

            if (clsGlobal.CurrentUser != null)
            {
                bool isAdmin = (clsGlobal.CurrentUser.Role == "Admin");

                // Hide Admin-only modules from regular users
                btnUserManagement.Visible = isAdmin;
            }

            string dashboardTitle = _GetDashboardTitle();
            this.Text = dashboardTitle;

            // Open Dashboard Home by default on startup
            OpenChildForm(new frmDashboardHome(), dashboardTitle);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGlobal.CurrentUser = null;
                this.Close();
            }
        }

        private void btnDahboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboardHome(), _GetDashboardTitle());
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageUsers(), "User Management");
        }

        private void btn_LostItems_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageLostItems(), "Manage Lost Items");
        }

        private void btn_FoundItems_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.frmManageFoundItems(), "Manage Found Items");
        }

        private void btn_Claims_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForms.frmManageClaims(), "Claims Management");
        }
    }
}