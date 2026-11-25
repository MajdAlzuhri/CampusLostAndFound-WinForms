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
            var cellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            var cellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            var cellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

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

            // pbHeaderIcon
            this.pbHeaderIcon.Location = new System.Drawing.Point(445, 12);
            this.pbHeaderIcon.Name = "pbHeaderIcon";
            this.pbHeaderIcon.Size = new System.Drawing.Size(70, 65);
            this.pbHeaderIcon.Style = Sunny.UI.UIStyle.Custom;
            this.pbHeaderIcon.StyleCustomMode = true;
            this.pbHeaderIcon.Symbol = 61530;
            this.pbHeaderIcon.SymbolColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.pbHeaderIcon.SymbolSize = 54;
            this.pbHeaderIcon.Text = "";

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.lblTitle.Location = new System.Drawing.Point(310, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.StyleCustomMode = true;
            this.lblTitle.Text = "Manage Found Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblFilterBy
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblFilterBy.Location = new System.Drawing.Point(25, 142);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(85, 30);
            this.lblFilterBy.Style = Sunny.UI.UIStyle.Custom;
            this.lblFilterBy.StyleCustomMode = true;
            this.lblFilterBy.Text = "Filter By:";
            this.lblFilterBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // cbFilterBy
            this.cbFilterBy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbFilterBy.FillColor = System.Drawing.Color.White;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbFilterBy.Items.AddRange(new object[] { "None", "Item ID", "Item Name", "Category", "Color", "Location", "Status" });
            this.cbFilterBy.Location = new System.Drawing.Point(115, 138);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.cbFilterBy.Size = new System.Drawing.Size(195, 38);
            this.cbFilterBy.Style = Sunny.UI.UIStyle.Custom;
            this.cbFilterBy.StyleCustomMode = true;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);

            // txtFilterValue
            this.txtFilterValue.FillColor = System.Drawing.Color.White;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFilterValue.Location = new System.Drawing.Point(322, 138);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Radius = 10;
            this.txtFilterValue.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.txtFilterValue.Size = new System.Drawing.Size(230, 38);
            this.txtFilterValue.Style = Sunny.UI.UIStyle.Custom;
            this.txtFilterValue.StyleCustomMode = true;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.Watermark = "Type to search...";
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);

            // cbStatusFilter
            this.cbStatusFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbStatusFilter.FillColor = System.Drawing.Color.White;
            this.cbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbStatusFilter.Items.AddRange(new object[] { "All", "Open", "Claimed", "Returned" });
            this.cbStatusFilter.Location = new System.Drawing.Point(322, 138);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Radius = 10;
            this.cbStatusFilter.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.cbStatusFilter.Size = new System.Drawing.Size(195, 38);
            this.cbStatusFilter.Style = Sunny.UI.UIStyle.Custom;
            this.cbStatusFilter.StyleCustomMode = true;
            this.cbStatusFilter.Visible = false;
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);

            // btnAddItem
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnAddItem.FillHoverColor = System.Drawing.Color.FromArgb(4, 120, 87);
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.Location = new System.Drawing.Point(775, 135);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Radius = 12;
            this.btnAddItem.RectColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnAddItem.Size = new System.Drawing.Size(170, 42);
            this.btnAddItem.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddItem.StyleCustomMode = true;
            this.btnAddItem.Symbol = 61543;
            this.btnAddItem.SymbolSize = 20;
            this.btnAddItem.Text = "Add Found Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            // dgvFoundItems
            this.dgvFoundItems.AllowUserToAddRows = false;
            this.dgvFoundItems.AllowUserToDeleteRows = false;
            this.dgvFoundItems.AllowUserToResizeRows = false;
            cellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvFoundItems.AlternatingRowsDefaultCellStyle = cellStyle1;
            this.dgvFoundItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoundItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoundItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvFoundItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            cellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle2.BackColor = System.Drawing.Color.FromArgb(0, 90, 156);
            cellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            cellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvFoundItems.ColumnHeadersDefaultCellStyle = cellStyle2;
            this.dgvFoundItems.ColumnHeadersHeight = 42;
            this.dgvFoundItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFoundItems.ContextMenuStrip = this.cmsFoundItems;
            cellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cellStyle3.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            cellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            cellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.dgvFoundItems.DefaultCellStyle = cellStyle3;
            this.dgvFoundItems.EnableHeadersVisualStyles = false;
            this.dgvFoundItems.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvFoundItems.Location = new System.Drawing.Point(25, 192);
            this.dgvFoundItems.MultiSelect = false;
            this.dgvFoundItems.Name = "dgvFoundItems";
            this.dgvFoundItems.ReadOnly = true;
            this.dgvFoundItems.RowHeadersVisible = false;
            this.dgvFoundItems.RowTemplate.Height = 38;
            this.dgvFoundItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoundItems.Size = new System.Drawing.Size(920, 420);
            this.dgvFoundItems.Style = Sunny.UI.UIStyle.Custom;
            this.dgvFoundItems.StyleCustomMode = true;

            // cmsFoundItems
            this.cmsFoundItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.editItemToolStripMenuItem, this.markAsClaimedToolStripMenuItem, this.toolStripSeparator1, this.deleteItemToolStripMenuItem
            });
            this.cmsFoundItems.Name = "cmsFoundItems";
            this.cmsFoundItems.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFoundItems_Opening);

            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Text = "Edit Item";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);

            this.markAsClaimedToolStripMenuItem.Name = "markAsClaimedToolStripMenuItem";
            this.markAsClaimedToolStripMenuItem.Text = "Mark as Claimed";
            this.markAsClaimedToolStripMenuItem.Click += new System.EventHandler(this.markAsClaimedToolStripMenuItem_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";

            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);

            // lblRecordsText & lblRecordCount
            this.lblRecordsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecordsText.Location = new System.Drawing.Point(25, 628);
            this.lblRecordsText.Name = "lblRecordsText";
            this.lblRecordsText.Size = new System.Drawing.Size(95, 28);
            this.lblRecordsText.Style = Sunny.UI.UIStyle.Custom;
            this.lblRecordsText.StyleCustomMode = true;
            this.lblRecordsText.Text = "# Records:";

            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.lblRecordCount.Location = new System.Drawing.Point(122, 628);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(80, 28);
            this.lblRecordCount.Style = Sunny.UI.UIStyle.Custom;
            this.lblRecordCount.StyleCustomMode = true;
            this.lblRecordCount.Text = "0";

            // frmManageFoundItems
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