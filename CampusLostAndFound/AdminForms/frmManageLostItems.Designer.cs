namespace CampusLostAndFound.AdminForms
{
    partial class frmManageLostItems
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
            this.lblTitle = new Sunny.UI.UILabel();
            this.pbHeaderIcon = new Sunny.UI.UISymbolLabel();
            this.lblFilterBy = new Sunny.UI.UILabel();
            this.cbFilterBy = new Sunny.UI.UIComboBox();
            this.txtFilterValue = new Sunny.UI.UITextBox();
            this.cbStatusFilter = new Sunny.UI.UIComboBox();
            this.btnAddItem = new Sunny.UI.UISymbolButton();
            this.dgvLostItems = new Sunny.UI.UIDataGridView();
            this.cmsLostItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.markAsReturnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToFoundItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsText = new Sunny.UI.UILabel();
            this.lblRecordCount = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostItems)).BeginInit();
            this.cmsLostItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHeaderIcon
            // 
            this.pbHeaderIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pbHeaderIcon.Location = new System.Drawing.Point(445, 12);
            this.pbHeaderIcon.Name = "pbHeaderIcon";
            this.pbHeaderIcon.Size = new System.Drawing.Size(70, 65);
            this.pbHeaderIcon.Style = Sunny.UI.UIStyle.Custom;
            this.pbHeaderIcon.StyleCustomMode = true;
            this.pbHeaderIcon.Symbol = 61736;
            this.pbHeaderIcon.SymbolColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.pbHeaderIcon.SymbolSize = 54;
            this.pbHeaderIcon.TabIndex = 0;
            this.pbHeaderIcon.Text = "";
            this.pbHeaderIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.lblTitle.Location = new System.Drawing.Point(330, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.StyleCustomMode = true;
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Lost Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
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
            this.cbFilterBy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbFilterBy.FillColor = System.Drawing.Color.White;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbFilterBy.ItemHeight = 28;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Item ID",
            "Item Name",
            "Category",
            "Location",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(115, 138);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilterBy.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.cbFilterBy.Size = new System.Drawing.Size(195, 38);
            this.cbFilterBy.Style = Sunny.UI.UIStyle.Custom;
            this.cbFilterBy.StyleCustomMode = true;
            this.cbFilterBy.SymbolSize = 24;
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FillColor = System.Drawing.Color.White;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFilterValue.Location = new System.Drawing.Point(322, 138);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(5);
            this.txtFilterValue.Radius = 10;
            this.txtFilterValue.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
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
            this.cbStatusFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbStatusFilter.FillColor = System.Drawing.Color.White;
            this.cbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbStatusFilter.ItemHeight = 28;
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Open",
            "Claimed",
            "Returned"});
            this.cbStatusFilter.Location = new System.Drawing.Point(322, 138);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusFilter.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbStatusFilter.Radius = 10;
            this.cbStatusFilter.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.cbStatusFilter.Size = new System.Drawing.Size(195, 38);
            this.cbStatusFilter.Style = Sunny.UI.UIStyle.Custom;
            this.cbStatusFilter.StyleCustomMode = true;
            this.cbStatusFilter.SymbolSize = 24;
            this.cbStatusFilter.TabIndex = 5;
            this.cbStatusFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatusFilter.Visible = false;
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.btnAddItem.FillHoverColor = System.Drawing.Color.FromArgb(0, 110, 190);
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.Location = new System.Drawing.Point(790, 135);
            this.btnAddItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Radius = 12;
            this.btnAddItem.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.btnAddItem.Size = new System.Drawing.Size(155, 42);
            this.btnAddItem.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddItem.StyleCustomMode = true;
            this.btnAddItem.Symbol = 61543;
            this.btnAddItem.SymbolSize = 20;
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Lost Item";
            this.btnAddItem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvLostItems
            // 
            this.dgvLostItems.AllowUserToAddRows = false;
            this.dgvLostItems.AllowUserToDeleteRows = false;
            this.dgvLostItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvLostItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLostItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLostItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLostItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvLostItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLostItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(0, 90, 156);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(0, 90, 156);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLostItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLostItems.ColumnHeadersHeight = 42;
            this.dgvLostItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLostItems.ContextMenuStrip = this.cmsLostItems;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLostItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLostItems.EnableHeadersVisualStyles = false;
            this.dgvLostItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvLostItems.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvLostItems.Location = new System.Drawing.Point(25, 192);
            this.dgvLostItems.MultiSelect = false;
            this.dgvLostItems.Name = "dgvLostItems";
            this.dgvLostItems.ReadOnly = true;
            this.dgvLostItems.RowHeadersVisible = false;
            this.dgvLostItems.RowTemplate.Height = 38;
            this.dgvLostItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLostItems.Size = new System.Drawing.Size(920, 420);
            this.dgvLostItems.Style = Sunny.UI.UIStyle.Custom;
            this.dgvLostItems.StyleCustomMode = true;
            this.dgvLostItems.TabIndex = 7;
            // 
            // cmsLostItems
            // 
            this.cmsLostItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmsLostItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.toolStripSeparator1,
            this.markAsReturnedToolStripMenuItem,
            this.moveToFoundItemsToolStripMenuItem});
            this.cmsLostItems.Name = "cmsLostItems";
            this.cmsLostItems.Size = new System.Drawing.Size(215, 100);
            this.cmsLostItems.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLostItems_Opening);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // markAsReturnedToolStripMenuItem
            // 
            this.markAsReturnedToolStripMenuItem.Name = "markAsReturnedToolStripMenuItem";
            this.markAsReturnedToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.markAsReturnedToolStripMenuItem.Text = "Mark as Returned";
            this.markAsReturnedToolStripMenuItem.Click += new System.EventHandler(this.markAsReturnedToolStripMenuItem_Click);
            // 
            // moveToFoundItemsToolStripMenuItem
            // 
            this.moveToFoundItemsToolStripMenuItem.Name = "moveToFoundItemsToolStripMenuItem";
            this.moveToFoundItemsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.moveToFoundItemsToolStripMenuItem.Text = "Move to Found Items";
            this.moveToFoundItemsToolStripMenuItem.Click += new System.EventHandler(this.moveToFoundItemsToolStripMenuItem_Click);
            // 
            // lblRecordsText
            // 
            this.lblRecordsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecordsText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
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
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.lblRecordCount.Location = new System.Drawing.Point(122, 628);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(80, 28);
            this.lblRecordCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblRecordCount.StyleCustomMode = true;
            this.lblRecordCount.TabIndex = 9;
            this.lblRecordCount.Text = "0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmManageLostItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 675);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblRecordsText);
            this.Controls.Add(this.dgvLostItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cbStatusFilter);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbHeaderIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageLostItems";
            this.Text = "Manage Lost Items";
            this.Load += new System.EventHandler(this.frmManageLostItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLostItems)).EndInit();
            this.cmsLostItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UISymbolLabel pbHeaderIcon;
        private Sunny.UI.UILabel lblFilterBy;
        private Sunny.UI.UIComboBox cbFilterBy;
        private Sunny.UI.UITextBox txtFilterValue;
        private Sunny.UI.UIComboBox cbStatusFilter;
        private Sunny.UI.UISymbolButton btnAddItem;
        private Sunny.UI.UIDataGridView dgvLostItems;
        private System.Windows.Forms.ContextMenuStrip cmsLostItems;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem markAsReturnedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToFoundItemsToolStripMenuItem;
        private Sunny.UI.UILabel lblRecordsText;
        private Sunny.UI.UILabel lblRecordCount;
    }
}