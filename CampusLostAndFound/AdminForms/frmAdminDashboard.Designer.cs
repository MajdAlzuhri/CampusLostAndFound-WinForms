namespace CampusLostAndFound
{
    partial class frmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_Claims = new Sunny.UI.UISymbolButton();
            this.btn_Logout = new Sunny.UI.UISymbolButton();
            this.btn_FoundItems = new Sunny.UI.UISymbolButton();
            this.btn_LostItems = new Sunny.UI.UISymbolButton();
            this.btnUserManagement = new Sunny.UI.UISymbolButton();
            this.btnDahboard = new Sunny.UI.UISymbolButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPageTiltle = new Sunny.UI.UISmoothLabel();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.uiPanel1.Controls.Add(this.btn_Claims);
            this.uiPanel1.Controls.Add(this.btn_Logout);
            this.uiPanel1.Controls.Add(this.btn_FoundItems);
            this.uiPanel1.Controls.Add(this.btn_LostItems);
            this.uiPanel1.Controls.Add(this.btnUserManagement);
            this.uiPanel1.Controls.Add(this.btnDahboard);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.uiPanel1.Size = new System.Drawing.Size(300, 713);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Claims
            // 
            this.btn_Claims.BackColor = System.Drawing.Color.Transparent;
            this.btn_Claims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Claims.FillColor = System.Drawing.Color.Transparent;
            this.btn_Claims.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Claims.FillHoverColor = System.Drawing.Color.Gold;
            this.btn_Claims.FillPressColor = System.Drawing.Color.Transparent;
            this.btn_Claims.FillSelectedColor = System.Drawing.Color.Transparent;
            this.btn_Claims.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Claims.Image = global::CampusLostAndFound.Properties.Resources.paper;
            this.btn_Claims.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Claims.Location = new System.Drawing.Point(13, 289);
            this.btn_Claims.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Claims.Name = "btn_Claims";
            this.btn_Claims.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btn_Claims.Radius = 20;
            this.btn_Claims.RectColor = System.Drawing.Color.Transparent;
            this.btn_Claims.Size = new System.Drawing.Size(260, 50);
            this.btn_Claims.SymbolOffset = new System.Drawing.Point(-15, 0);
            this.btn_Claims.TabIndex = 6;
            this.btn_Claims.Text = "        Claims";
            this.btn_Claims.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Claims.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Claims.Click += new System.EventHandler(this.btn_Claims_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Logout.FillHoverColor = System.Drawing.Color.Gold;
            this.btn_Logout.FillPressColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FillSelectedColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Image = global::CampusLostAndFound.Properties.Resources.logout;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(10, 650);
            this.btn_Logout.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btn_Logout.Radius = 20;
            this.btn_Logout.RectColor = System.Drawing.Color.Transparent;
            this.btn_Logout.Size = new System.Drawing.Size(260, 50);
            this.btn_Logout.SymbolOffset = new System.Drawing.Point(-15, 0);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "        Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_FoundItems
            // 
            this.btn_FoundItems.BackColor = System.Drawing.Color.Transparent;
            this.btn_FoundItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FoundItems.FillColor = System.Drawing.Color.Transparent;
            this.btn_FoundItems.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_FoundItems.FillHoverColor = System.Drawing.Color.Gold;
            this.btn_FoundItems.FillPressColor = System.Drawing.Color.Transparent;
            this.btn_FoundItems.FillSelectedColor = System.Drawing.Color.Transparent;
            this.btn_FoundItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FoundItems.Image = global::CampusLostAndFound.Properties.Resources.found_items;
            this.btn_FoundItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FoundItems.Location = new System.Drawing.Point(10, 233);
            this.btn_FoundItems.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_FoundItems.Name = "btn_FoundItems";
            this.btn_FoundItems.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btn_FoundItems.Radius = 20;
            this.btn_FoundItems.RectColor = System.Drawing.Color.Transparent;
            this.btn_FoundItems.Size = new System.Drawing.Size(260, 50);
            this.btn_FoundItems.SymbolOffset = new System.Drawing.Point(-15, 0);
            this.btn_FoundItems.TabIndex = 3;
            this.btn_FoundItems.Text = "        Found Items";
            this.btn_FoundItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FoundItems.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_FoundItems.Click += new System.EventHandler(this.btn_FoundItems_Click);
            // 
            // btn_LostItems
            // 
            this.btn_LostItems.BackColor = System.Drawing.Color.Transparent;
            this.btn_LostItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LostItems.FillColor = System.Drawing.Color.Transparent;
            this.btn_LostItems.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_LostItems.FillHoverColor = System.Drawing.Color.Gold;
            this.btn_LostItems.FillPressColor = System.Drawing.Color.Transparent;
            this.btn_LostItems.FillSelectedColor = System.Drawing.Color.Transparent;
            this.btn_LostItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LostItems.Image = global::CampusLostAndFound.Properties.Resources.lost_items;
            this.btn_LostItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LostItems.Location = new System.Drawing.Point(10, 182);
            this.btn_LostItems.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_LostItems.Name = "btn_LostItems";
            this.btn_LostItems.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btn_LostItems.Radius = 20;
            this.btn_LostItems.RectColor = System.Drawing.Color.Transparent;
            this.btn_LostItems.Size = new System.Drawing.Size(260, 50);
            this.btn_LostItems.SymbolOffset = new System.Drawing.Point(-15, 0);
            this.btn_LostItems.TabIndex = 2;
            this.btn_LostItems.Text = "        Lost Items";
            this.btn_LostItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LostItems.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_LostItems.Click += new System.EventHandler(this.btn_LostItems_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.FillColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.FillColor2 = System.Drawing.Color.Transparent;
            this.btnUserManagement.FillHoverColor = System.Drawing.Color.Gold;
            this.btnUserManagement.FillPressColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.FillSelectedColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Image = global::CampusLostAndFound.Properties.Resources.user_management;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Location = new System.Drawing.Point(10, 131);
            this.btnUserManagement.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btnUserManagement.Radius = 20;
            this.btnUserManagement.RectColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.Size = new System.Drawing.Size(260, 50);
            this.btnUserManagement.SymbolOffset = new System.Drawing.Point(-15, 0);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "        User Management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnDahboard
            // 
            this.btnDahboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDahboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDahboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDahboard.FillColor2 = System.Drawing.Color.Transparent;
            this.btnDahboard.FillHoverColor = System.Drawing.Color.Gold;
            this.btnDahboard.FillPressColor = System.Drawing.Color.Transparent;
            this.btnDahboard.FillSelectedColor = System.Drawing.Color.Transparent;
            this.btnDahboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDahboard.Image = global::CampusLostAndFound.Properties.Resources.dashboard;
            this.btnDahboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDahboard.Location = new System.Drawing.Point(10, 80);
            this.btnDahboard.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDahboard.Name = "btnDahboard";
            this.btnDahboard.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.btnDahboard.Radius = 20;
            this.btnDahboard.RectColor = System.Drawing.Color.Transparent;
            this.btnDahboard.Size = new System.Drawing.Size(260, 50);
            this.btnDahboard.SymbolOffset = new System.Drawing.Point(-20, 0);
            this.btnDahboard.TabIndex = 0;
            this.btnDahboard.Text = "        Dashboard";
            this.btnDahboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDahboard.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDahboard.Click += new System.EventHandler(this.btnDahboard_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.BackColor = System.Drawing.Color.White;
            this.uiPanel2.Controls.Add(this.pictureBox1);
            this.uiPanel2.Controls.Add(this.lblPageTiltle);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.FillColor2 = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(300, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(962, 713);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CampusLostAndFound.Properties.Resources.Administrator;
            this.pictureBox1.Location = new System.Drawing.Point(270, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPageTiltle
            // 
            this.lblPageTiltle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPageTiltle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageTiltle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPageTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTiltle.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageTiltle.Location = new System.Drawing.Point(0, 0);
            this.lblPageTiltle.Name = "lblPageTiltle";
            this.lblPageTiltle.RectColor = System.Drawing.Color.Transparent;
            this.lblPageTiltle.Size = new System.Drawing.Size(962, 60);
            this.lblPageTiltle.TabIndex = 0;
            this.lblPageTiltle.Text = "Admin";
            this.lblPageTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 713);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.frmAdminDashboard_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UISymbolButton btnDahboard;
        private Sunny.UI.UISmoothLabel lblPageTiltle;
        private Sunny.UI.UISymbolButton btnUserManagement;
        private Sunny.UI.UISymbolButton btn_LostItems;
        private Sunny.UI.UISymbolButton btn_FoundItems;
        private Sunny.UI.UISymbolButton btn_Logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton btn_Claims;
    }
}