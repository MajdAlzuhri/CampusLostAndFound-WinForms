using System;
using System.Windows.Forms;
using CampusLostAndFound.BLL;

namespace CampusLostAndFound
{
    public partial class frmDashboardHome : Form
    {
        public frmDashboardHome()
        {
            InitializeComponent();
        }

        private void _LoadDashboardData()
        {
            if (clsGlobal.CurrentUser != null)
            {
                lblWelcome.Text = $"Welcome back, {clsGlobal.CurrentUser.Username} ({clsGlobal.CurrentUser.Role})";
            }

            clsDashboard summary = clsDashboard.GetSummary();

            lblLostCount.Text = summary.TotalLostItems.ToString();
            lblFoundCount.Text = summary.TotalFoundItems.ToString();
            lblClaimsCount.Text = summary.TotalClaims.ToString();
            lblUsersCount.Text = summary.TotalUsers.ToString();

            dgvRecentItems.DataSource = clsDashboard.GetRecentItems();
            dgvRecentItems.ClearSelection();
        }

        private void frmDashboardHome_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.Role != "Admin")
            {
                uiPanel4.Visible = false; // استبدل uiPanel4 باسم الكارد/البانل الخاص بـ Total Users عندك
            }
            _LoadDashboardData();
            
        }
    }
}