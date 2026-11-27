using System;
using System.Data;
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

            DataTable dtRecent = clsDashboard.GetRecentItems();

            if (!dtRecent.Columns.Contains("RowNo"))
            {
                dtRecent.Columns.Add("RowNo", typeof(int));
                dtRecent.Columns["RowNo"].SetOrdinal(0);
            }

            for (int i = 0; i < dtRecent.Rows.Count; i++)
            {
                dtRecent.Rows[i]["RowNo"] = i + 1;
            }

            dgvRecentItems.DataSource = dtRecent;

            if (dgvRecentItems.Columns.Count > 0)
            {
                dgvRecentItems.Columns["RowNo"].HeaderText = "#";
                dgvRecentItems.Columns["RowNo"].Width = 45;

                // إخفاء الـ ID الحقيقي إن كان راجعاً من الاستعلام
                if (dgvRecentItems.Columns.Contains("ItemID"))
                    dgvRecentItems.Columns["ItemID"].Visible = false;
            }

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