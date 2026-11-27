namespace CampusLostAndFound.AdminForms
{
    partial class frmManageFoundItems
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

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
            this.btnAddItem = new Sunny.UI.UISymbolButton();
            this.dgvFoundItems = new Sunny.UI.UIDataGridView();
            this.cmsFoundItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsClaimedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsText = new Sunny.UI.UILabel();
            this.lblRecordCount = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundItems)).BeginInit();
            this.cmsFoundItems.SuspendLayout();
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
            this.pbHeaderIcon.Symbol = 61530;
            this.pbHeaderIcon.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.pbHeaderIcon.SymbolSize = 54;
            this.pbHeaderIcon.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.lblTitle.Location = new System.Drawing.Point(310, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.StyleCustomMode = true;
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Manage Found Items";
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
            this.lblFilterBy.TabIndex = 8;
            this.lblFilterBy.Text = "Filter By:";
            this.lblFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DataSource = null;
            this.cbFilterBy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbFilterBy.FillColor = System.Drawing.Color.White;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbFilterBy.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Item Name",
            "Category",
            "Color",
            "Location",
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
            this.cbFilterBy.TabIndex = 7;
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
            this.txtFilterValue.TabIndex = 6;
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
            this.cbStatusFilter.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Open",
            "Claimed",
            "Returned"});
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
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnAddItem.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.Location = new System.Drawing.Point(775, 135);
            this.btnAddItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Radius = 12;
            this.btnAddItem.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnAddItem.Size = new System.Drawing.Size(170, 42);
            this.btnAddItem.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddItem.StyleCustomMode = true;
            this.btnAddItem.Symbol = 61543;
            this.btnAddItem.SymbolSize = 20;
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Found Item";
            this.btnAddItem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvFoundItems
            // 
            this.dgvFoundItems.AllowUserToAddRows = false;
            this.dgvFoundItems.AllowUserToDeleteRows = false;
            this.dgvFoundItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvFoundItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoundItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoundItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoundItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvFoundItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoundItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvFoundItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoundItems.ColumnHeadersHeight = 42;
            this.dgvFoundItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFoundItems.ContextMenuStrip = this.cmsFoundItems;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoundItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoundItems.EnableHeadersVisualStyles = false;
            this.dgvFoundItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvFoundItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvFoundItems.Location = new System.Drawing.Point(25, 192);
            this.dgvFoundItems.MultiSelect = false;
            this.dgvFoundItems.Name = "dgvFoundItems";
            this.dgvFoundItems.ReadOnly = true;
            this.dgvFoundItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoundItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoundItems.RowHeadersVisible = false;
            this.dgvFoundItems.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvFoundItems.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFoundItems.RowTemplate.Height = 38;
            this.dgvFoundItems.SelectedIndex = -1;
            this.dgvFoundItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundItems.Size = new System.Drawing.Size(920, 420);
            this.dgvFoundItems.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvFoundItems.Style = Sunny.UI.UIStyle.Custom;
            this.dgvFoundItems.StyleCustomMode = true;
            this.dgvFoundItems.TabIndex = 3;
            // 
            // cmsFoundItems
            // 
            this.cmsFoundItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFoundItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem,
            this.markAsClaimedToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteItemToolStripMenuItem});
            this.cmsFoundItems.Name = "cmsFoundItems";
            this.cmsFoundItems.Size = new System.Drawing.Size(197, 88);
            this.cmsFoundItems.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFoundItems_Opening);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // markAsClaimedToolStripMenuItem
            // 
            this.markAsClaimedToolStripMenuItem.Name = "markAsClaimedToolStripMenuItem";
            this.markAsClaimedToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.markAsClaimedToolStripMenuItem.Text = "Mark as Claimed";
            this.markAsClaimedToolStripMenuItem.Click += new System.EventHandler(this.markAsClaimedToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // lblRecordsText
            // 
            this.lblRecordsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecordsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRecordsText.Location = new System.Drawing.Point(25, 628);
            this.lblRecordsText.Name = "lblRecordsText";
            this.lblRecordsText.Size = new System.Drawing.Size(95, 28);
            this.lblRecordsText.Style = Sunny.UI.UIStyle.Custom;
            this.lblRecordsText.StyleCustomMode = true;
            this.lblRecordsText.TabIndex = 2;
            this.lblRecordsText.Text = "# Records:";
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
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "0";
            // 
            // frmManageFoundItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecordsText);
            this.Controls.Add(this.dgvFoundItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cbStatusFilter);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbHeaderIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageFoundItems";
            this.Load += new System.EventHandler(this.frmManageFoundItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundItems)).EndInit();
            this.cmsFoundItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Sunny.UI.UISymbolLabel pbHeaderIcon;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblFilterBy;
        private Sunny.UI.UIComboBox cbFilterBy;
        private Sunny.UI.UITextBox txtFilterValue;
        private Sunny.UI.UIComboBox cbStatusFilter;
        private Sunny.UI.UISymbolButton btnAddItem;
        private Sunny.UI.UIDataGridView dgvFoundItems;
        private System.Windows.Forms.ContextMenuStrip cmsFoundItems;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAsClaimedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private Sunny.UI.UILabel lblRecordsText;
        private Sunny.UI.UILabel lblRecordCount;
    }
}