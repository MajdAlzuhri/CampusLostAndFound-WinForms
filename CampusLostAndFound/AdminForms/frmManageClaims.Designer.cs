namespace CampusLostAndFound.AdminForms
{
    partial class frmManageClaims
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbHeaderIcon = new Sunny.UI.UISymbolLabel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.lblFilterBy = new Sunny.UI.UILabel();
            this.cbFilterBy = new Sunny.UI.UIComboBox();
            this.txtFilterValue = new Sunny.UI.UITextBox();
            this.cbStatusFilter = new Sunny.UI.UIComboBox();
            this.btnAddClaim = new Sunny.UI.UISymbolButton();
            this.dgvClaims = new Sunny.UI.UIDataGridView();
            this.cmsClaims = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsText = new Sunny.UI.UILabel();
            this.lblRecordCount = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).BeginInit();
            this.cmsClaims.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHeaderIcon
            // 
            this.pbHeaderIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pbHeaderIcon.Location = new System.Drawing.Point(445, 12);
            this.pbHeaderIcon.MinimumSize = new System.Drawing.Size(1, 1);
            this.pbHeaderIcon.Name = "pbHeaderIcon";
            this.pbHeaderIcon.Size = new System.Drawing.Size(70, 65);
            this.pbHeaderIcon.Style = Sunny.UI.UIStyle.Custom;
            this.pbHeaderIcon.StyleCustomMode = true;
            this.pbHeaderIcon.Symbol = 61788;
            this.pbHeaderIcon.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.pbHeaderIcon.SymbolSize = 54;
            this.pbHeaderIcon.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.lblTitle.Location = new System.Drawing.Point(320, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.StyleCustomMode = true;
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Claims";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblFilterBy.Location = new System.Drawing.Point(25, 142);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(85, 30);
            this.lblFilterBy.Style = Sunny.UI.UIStyle.Custom;
            this.lblFilterBy.StyleCustomMode = true;
            this.lblFilterBy.TabIndex = 2;
            this.lblFilterBy.Text = "Filter By:";
            this.lblFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DataSource = null;
            this.cbFilterBy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbFilterBy.FillColor = System.Drawing.Color.White;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbFilterBy.ItemHeight = 28;
            this.cbFilterBy.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Claimant Name",
            "Phone",
            "Status"});
            this.cbFilterBy.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Location = new System.Drawing.Point(115, 138);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilterBy.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.cbFilterBy.Size = new System.Drawing.Size(195, 38);
            this.cbFilterBy.Style = Sunny.UI.UIStyle.Custom;
            this.cbFilterBy.StyleCustomMode = true;
            this.cbFilterBy.SymbolSize = 24;
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFilterBy.Watermark = "";
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFilterValue.Location = new System.Drawing.Point(322, 138);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(5);
            this.txtFilterValue.Radius = 10;
            this.txtFilterValue.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.txtFilterValue.ShowText = false;
            this.txtFilterValue.Size = new System.Drawing.Size(230, 38);
            this.txtFilterValue.Style = Sunny.UI.UIStyle.Custom;
            this.txtFilterValue.StyleCustomMode = true;
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.Watermark = "Type to search...";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DataSource = null;
            this.cbStatusFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbStatusFilter.FillColor = System.Drawing.Color.White;
            this.cbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbStatusFilter.ItemHeight = 28;
            this.cbStatusFilter.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Rejected"});
            this.cbStatusFilter.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Location = new System.Drawing.Point(322, 138);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusFilter.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatusFilter.Radius = 10;
            this.cbStatusFilter.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.cbStatusFilter.Size = new System.Drawing.Size(195, 38);
            this.cbStatusFilter.Style = Sunny.UI.UIStyle.Custom;
            this.cbStatusFilter.StyleCustomMode = true;
            this.cbStatusFilter.SymbolSize = 24;
            this.cbStatusFilter.TabIndex = 5;
            this.cbStatusFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatusFilter.Visible = false;
            this.cbStatusFilter.Watermark = "";
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClaim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.btnAddClaim.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnAddClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddClaim.Location = new System.Drawing.Point(790, 135);
            this.btnAddClaim.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Radius = 12;
            this.btnAddClaim.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.btnAddClaim.Size = new System.Drawing.Size(155, 42);
            this.btnAddClaim.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddClaim.StyleCustomMode = true;
            this.btnAddClaim.Symbol = 61543;
            this.btnAddClaim.SymbolSize = 20;
            this.btnAddClaim.TabIndex = 6;
            this.btnAddClaim.Text = "New Claim";
            this.btnAddClaim.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // dgvClaims
            // 
            this.dgvClaims.AllowUserToAddRows = false;
            this.dgvClaims.AllowUserToDeleteRows = false;
            this.dgvClaims.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvClaims.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClaims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClaims.BackgroundColor = System.Drawing.Color.White;
            this.dgvClaims.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClaims.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClaims.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClaims.ColumnHeadersHeight = 42;
            this.dgvClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClaims.ContextMenuStrip = this.cmsClaims;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClaims.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClaims.EnableHeadersVisualStyles = false;
            this.dgvClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvClaims.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvClaims.Location = new System.Drawing.Point(25, 192);
            this.dgvClaims.MultiSelect = false;
            this.dgvClaims.Name = "dgvClaims";
            this.dgvClaims.ReadOnly = true;
            this.dgvClaims.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClaims.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClaims.RowHeadersVisible = false;
            this.dgvClaims.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvClaims.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClaims.RowTemplate.Height = 38;
            this.dgvClaims.SelectedIndex = -1;
            this.dgvClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClaims.Size = new System.Drawing.Size(920, 420);
            this.dgvClaims.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvClaims.Style = Sunny.UI.UIStyle.Custom;
            this.dgvClaims.StyleCustomMode = true;
            this.dgvClaims.TabIndex = 7;
            // 
            // cmsClaims
            // 
            this.cmsClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmsClaims.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsClaims.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveClaimToolStripMenuItem,
            this.rejectClaimToolStripMenuItem,
            this.toolStripSeparator1,
            this.editClaimToolStripMenuItem,
            this.deleteClaimToolStripMenuItem});
            this.cmsClaims.Name = "cmsClaims";
            this.cmsClaims.Size = new System.Drawing.Size(188, 106);
            this.cmsClaims.Opening += new System.ComponentModel.CancelEventHandler(this.cmsClaims_Opening);
            // 
            // approveClaimToolStripMenuItem
            // 
            this.approveClaimToolStripMenuItem.Name = "approveClaimToolStripMenuItem";
            this.approveClaimToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.approveClaimToolStripMenuItem.Text = "Approve Claim";
            this.approveClaimToolStripMenuItem.Click += new System.EventHandler(this.approveClaimToolStripMenuItem_Click);
            // 
            // rejectClaimToolStripMenuItem
            // 
            this.rejectClaimToolStripMenuItem.Name = "rejectClaimToolStripMenuItem";
            this.rejectClaimToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.rejectClaimToolStripMenuItem.Text = "Reject Claim";
            this.rejectClaimToolStripMenuItem.Click += new System.EventHandler(this.rejectClaimToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // editClaimToolStripMenuItem
            // 
            this.editClaimToolStripMenuItem.Name = "editClaimToolStripMenuItem";
            this.editClaimToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.editClaimToolStripMenuItem.Text = "Edit Claim";
            this.editClaimToolStripMenuItem.Click += new System.EventHandler(this.editClaimToolStripMenuItem_Click);
            // 
            // deleteClaimToolStripMenuItem
            // 
            this.deleteClaimToolStripMenuItem.Name = "deleteClaimToolStripMenuItem";
            this.deleteClaimToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.deleteClaimToolStripMenuItem.Text = "Delete Claim";
            this.deleteClaimToolStripMenuItem.Click += new System.EventHandler(this.deleteClaimToolStripMenuItem_Click);
            // 
            // lblRecordsText
            // 
            this.lblRecordsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecordsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblRecordsText.Location = new System.Drawing.Point(25, 628);
            this.lblRecordsText.Name = "lblRecordsText";
            this.lblRecordsText.Size = new System.Drawing.Size(95, 28);
            this.lblRecordsText.Style = Sunny.UI.UIStyle.Custom;
            this.lblRecordsText.StyleCustomMode = true;
            this.lblRecordsText.TabIndex = 8;
            this.lblRecordsText.Text = "# Records:";
            this.lblRecordsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.lblRecordCount.Location = new System.Drawing.Point(122, 628);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(80, 28);
            this.lblRecordCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblRecordCount.StyleCustomMode = true;
            this.lblRecordCount.TabIndex = 9;
            this.lblRecordCount.Text = "0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmManageClaims
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecordsText);
            this.Controls.Add(this.dgvClaims);
            this.Controls.Add(this.btnAddClaim);
            this.Controls.Add(this.cbStatusFilter);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbHeaderIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClaims";
            this.Text = "Manage Claims";
            this.Load += new System.EventHandler(this.frmManageClaims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).EndInit();
            this.cmsClaims.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel pbHeaderIcon;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblFilterBy;
        private Sunny.UI.UIComboBox cbFilterBy;
        private Sunny.UI.UITextBox txtFilterValue;
        private Sunny.UI.UIComboBox cbStatusFilter;
        private Sunny.UI.UISymbolButton btnAddClaim;
        private Sunny.UI.UIDataGridView dgvClaims;
        private System.Windows.Forms.ContextMenuStrip cmsClaims;
        private System.Windows.Forms.ToolStripMenuItem approveClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editClaimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClaimToolStripMenuItem;
        private Sunny.UI.UILabel lblRecordsText;
        private Sunny.UI.UILabel lblRecordCount;
    }
}