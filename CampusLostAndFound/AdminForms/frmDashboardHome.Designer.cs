namespace CampusLostAndFound
{
    partial class frmDashboardHome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.iconLost = new Sunny.UI.UISymbolLabel();
            this.lblLostCount = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.iconFound = new Sunny.UI.UISymbolLabel();
            this.lblFoundCount = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.iconClaims = new Sunny.UI.UISymbolLabel();
            this.lblClaimsCount = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.iconUsers = new Sunny.UI.UISymbolLabel();
            this.lblUsersCount = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dgvRecentItems = new Sunny.UI.UIDataGridView();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.lblWelcome.Location = new System.Drawing.Point(25, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(920, 32);
            this.lblWelcome.Style = Sunny.UI.UIStyle.Custom;
            this.lblWelcome.StyleCustomMode = true;
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "System Overview";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1 (Lost Items - Red)
            // 
            this.uiPanel1.Controls.Add(this.iconLost);
            this.uiPanel1.Controls.Add(this.lblLostCount);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(220, 38, 38);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(25, 56);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 16;
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(218, 125);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            // 
            // iconLost
            // 
            this.iconLost.BackColor = System.Drawing.Color.Transparent;
            this.iconLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconLost.Location = new System.Drawing.Point(14, 34);
            this.iconLost.Name = "iconLost";
            this.iconLost.Size = new System.Drawing.Size(58, 58);
            this.iconLost.Style = Sunny.UI.UIStyle.Custom;
            this.iconLost.StyleCustomMode = true;
            this.iconLost.Symbol = 61736;
            this.iconLost.SymbolColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.iconLost.SymbolSize = 44;
            this.iconLost.TabIndex = 2;
            this.iconLost.Text = "";
            this.iconLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLostCount
            // 
            this.lblLostCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLostCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblLostCount.ForeColor = System.Drawing.Color.White;
            this.lblLostCount.Location = new System.Drawing.Point(75, 48);
            this.lblLostCount.Name = "lblLostCount";
            this.lblLostCount.Size = new System.Drawing.Size(130, 52);
            this.lblLostCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblLostCount.StyleCustomMode = true;
            this.lblLostCount.TabIndex = 1;
            this.lblLostCount.Text = "0";
            this.lblLostCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.uiLabel1.Location = new System.Drawing.Point(75, 16);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(130, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Lost Items";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2 (Found Items - Green)
            // 
            this.uiPanel2.Controls.Add(this.iconFound);
            this.uiPanel2.Controls.Add(this.lblFoundCount);
            this.uiPanel2.Controls.Add(this.uiLabel3);
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.uiPanel2.FillColor2 = System.Drawing.Color.FromArgb(5, 150, 105);
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(259, 56);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 16;
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(218, 125);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel2.StyleCustomMode = true;
            this.uiPanel2.TabIndex = 2;
            this.uiPanel2.Text = null;
            // 
            // iconFound
            // 
            this.iconFound.BackColor = System.Drawing.Color.Transparent;
            this.iconFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconFound.Location = new System.Drawing.Point(14, 34);
            this.iconFound.Name = "iconFound";
            this.iconFound.Size = new System.Drawing.Size(58, 58);
            this.iconFound.Style = Sunny.UI.UIStyle.Custom;
            this.iconFound.StyleCustomMode = true;
            this.iconFound.Symbol = 61530;
            this.iconFound.SymbolColor = System.Drawing.Color.FromArgb(209, 250, 229);
            this.iconFound.SymbolSize = 44;
            this.iconFound.TabIndex = 2;
            this.iconFound.Text = "";
            this.iconFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoundCount
            // 
            this.lblFoundCount.BackColor = System.Drawing.Color.Transparent;
            this.lblFoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblFoundCount.ForeColor = System.Drawing.Color.White;
            this.lblFoundCount.Location = new System.Drawing.Point(75, 48);
            this.lblFoundCount.Name = "lblFoundCount";
            this.lblFoundCount.Size = new System.Drawing.Size(130, 52);
            this.lblFoundCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblFoundCount.StyleCustomMode = true;
            this.lblFoundCount.TabIndex = 1;
            this.lblFoundCount.Text = "0";
            this.lblFoundCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(236, 253, 245);
            this.uiLabel3.Location = new System.Drawing.Point(75, 16);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(130, 28);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 0;
            this.uiLabel3.Text = "Found Items";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3 (Total Claims - Amber)
            // 
            this.uiPanel3.Controls.Add(this.iconClaims);
            this.uiPanel3.Controls.Add(this.lblClaimsCount);
            this.uiPanel3.Controls.Add(this.uiLabel4);
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.uiPanel3.FillColor2 = System.Drawing.Color.FromArgb(217, 119, 6);
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(493, 56);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Radius = 16;
            this.uiPanel3.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel3.Size = new System.Drawing.Size(218, 125);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel3.StyleCustomMode = true;
            this.uiPanel3.TabIndex = 3;
            this.uiPanel3.Text = null;
            // 
            // iconClaims
            // 
            this.iconClaims.BackColor = System.Drawing.Color.Transparent;
            this.iconClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconClaims.Location = new System.Drawing.Point(14, 34);
            this.iconClaims.Name = "iconClaims";
            this.iconClaims.Size = new System.Drawing.Size(58, 58);
            this.iconClaims.Style = Sunny.UI.UIStyle.Custom;
            this.iconClaims.StyleCustomMode = true;
            this.iconClaims.Symbol = 61788;
            this.iconClaims.SymbolColor = System.Drawing.Color.FromArgb(254, 243, 199);
            this.iconClaims.SymbolSize = 44;
            this.iconClaims.TabIndex = 2;
            this.iconClaims.Text = "";
            this.iconClaims.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClaimsCount
            // 
            this.lblClaimsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblClaimsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblClaimsCount.ForeColor = System.Drawing.Color.White;
            this.lblClaimsCount.Location = new System.Drawing.Point(75, 48);
            this.lblClaimsCount.Name = "lblClaimsCount";
            this.lblClaimsCount.Size = new System.Drawing.Size(130, 52);
            this.lblClaimsCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblClaimsCount.StyleCustomMode = true;
            this.lblClaimsCount.TabIndex = 1;
            this.lblClaimsCount.Text = "0";
            this.lblClaimsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(255, 251, 235);
            this.uiLabel4.Location = new System.Drawing.Point(75, 16);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(130, 28);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.StyleCustomMode = true;
            this.uiLabel4.TabIndex = 0;
            this.uiLabel4.Text = "Total Claims";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4 (Total Users - Blue)
            // 
            this.uiPanel4.Controls.Add(this.iconUsers);
            this.uiPanel4.Controls.Add(this.lblUsersCount);
            this.uiPanel4.Controls.Add(this.uiLabel5);
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.uiPanel4.FillColor2 = System.Drawing.Color.FromArgb(29, 78, 216);
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(727, 56);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Radius = 16;
            this.uiPanel4.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel4.Size = new System.Drawing.Size(218, 125);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel4.StyleCustomMode = true;
            this.uiPanel4.TabIndex = 4;
            this.uiPanel4.Text = null;
            // 
            // iconUsers
            // 
            this.iconUsers.BackColor = System.Drawing.Color.Transparent;
            this.iconUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconUsers.Location = new System.Drawing.Point(14, 34);
            this.iconUsers.Name = "iconUsers";
            this.iconUsers.Size = new System.Drawing.Size(58, 58);
            this.iconUsers.Style = Sunny.UI.UIStyle.Custom;
            this.iconUsers.StyleCustomMode = true;
            this.iconUsers.Symbol = 61632;
            this.iconUsers.SymbolColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.iconUsers.SymbolSize = 44;
            this.iconUsers.TabIndex = 2;
            this.iconUsers.Text = "";
            this.iconUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblUsersCount.ForeColor = System.Drawing.Color.White;
            this.lblUsersCount.Location = new System.Drawing.Point(75, 48);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(130, 52);
            this.lblUsersCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblUsersCount.StyleCustomMode = true;
            this.lblUsersCount.TabIndex = 1;
            this.lblUsersCount.Text = "0";
            this.lblUsersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.uiLabel5.Location = new System.Drawing.Point(75, 16);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(130, 28);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.StyleCustomMode = true;
            this.uiLabel5.TabIndex = 0;
            this.uiLabel5.Text = "Total Users";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.uiLabel2.Location = new System.Drawing.Point(25, 200);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(320, 30);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "Recent Reported Items";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRecentItems
            // 
            this.dgvRecentItems.AllowUserToAddRows = false;
            this.dgvRecentItems.AllowUserToDeleteRows = false;
            this.dgvRecentItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvRecentItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecentItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(0, 90, 156);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 90, 156);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentItems.ColumnHeadersHeight = 40;
            this.dgvRecentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentItems.EnableHeadersVisualStyles = false;
            this.dgvRecentItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvRecentItems.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvRecentItems.Location = new System.Drawing.Point(25, 238);
            this.dgvRecentItems.MultiSelect = false;
            this.dgvRecentItems.Name = "dgvRecentItems";
            this.dgvRecentItems.ReadOnly = true;
            this.dgvRecentItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecentItems.RowHeadersVisible = false;
            this.dgvRecentItems.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvRecentItems.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecentItems.RowTemplate.Height = 36;
            this.dgvRecentItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentItems.Size = new System.Drawing.Size(920, 415);
            this.dgvRecentItems.StripeOddColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvRecentItems.Style = Sunny.UI.UIStyle.Custom;
            this.dgvRecentItems.StyleCustomMode = true;
            this.dgvRecentItems.TabIndex = 7;
            // 
            // frmDashboardHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.dgvRecentItems);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiPanel4);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboardHome";
            this.Text = "Dashboard Home";
            this.Load += new System.EventHandler(this.frmDashboardHome_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentItems)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblWelcome;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolLabel iconLost;
        private Sunny.UI.UILabel lblLostCount;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolLabel iconFound;
        private Sunny.UI.UILabel lblFoundCount;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UISymbolLabel iconClaims;
        private Sunny.UI.UILabel lblClaimsCount;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UISymbolLabel iconUsers;
        private Sunny.UI.UILabel lblUsersCount;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDataGridView dgvRecentItems;
    }
}