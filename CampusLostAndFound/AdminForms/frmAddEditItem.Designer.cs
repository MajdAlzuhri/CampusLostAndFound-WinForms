namespace CampusLostAndFound.AdminForms
{
    partial class frmAddEditItem
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
            this.lblTitle = new Sunny.UI.UILabel();
            this.lblItemIDText = new Sunny.UI.UILabel();
            this.lblItemID = new Sunny.UI.UILabel();
            this.pnlCard = new Sunny.UI.UIPanel();
            this.txtDescription = new Sunny.UI.UITextBox();
            this.lblDescription = new Sunny.UI.UILabel();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.lblStatus = new Sunny.UI.UILabel();
            this.txtLocation = new Sunny.UI.UITextBox();
            this.lblLocation = new Sunny.UI.UILabel();
            this.dtpItemDate = new Sunny.UI.UIDatePicker();
            this.lblDate = new Sunny.UI.UILabel();
            this.txtColor = new Sunny.UI.UITextBox();
            this.lblColor = new Sunny.UI.UILabel();
            this.cbCategory = new Sunny.UI.UIComboBox();
            this.lblCategory = new Sunny.UI.UILabel();
            this.txtItemName = new Sunny.UI.UITextBox();
            this.lblItemName = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.lblTitle.Location = new System.Drawing.Point(160, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.StyleCustomMode = true;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Lost Item";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemIDText
            // 
            this.lblItemIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemIDText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblItemIDText.Location = new System.Drawing.Point(35, 62);
            this.lblItemIDText.Name = "lblItemIDText";
            this.lblItemIDText.Size = new System.Drawing.Size(75, 28);
            this.lblItemIDText.Style = Sunny.UI.UIStyle.Custom;
            this.lblItemIDText.StyleCustomMode = true;
            this.lblItemIDText.TabIndex = 1;
            this.lblItemIDText.Text = "Item ID:";
            this.lblItemIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemID
            // 
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblItemID.Location = new System.Drawing.Point(115, 62);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(90, 28);
            this.lblItemID.Style = Sunny.UI.UIStyle.Custom;
            this.lblItemID.StyleCustomMode = true;
            this.lblItemID.TabIndex = 2;
            this.lblItemID.Text = "???";
            this.lblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.txtDescription);
            this.pnlCard.Controls.Add(this.lblDescription);
            this.pnlCard.Controls.Add(this.cbStatus);
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Controls.Add(this.txtLocation);
            this.pnlCard.Controls.Add(this.lblLocation);
            this.pnlCard.Controls.Add(this.dtpItemDate);
            this.pnlCard.Controls.Add(this.lblDate);
            this.pnlCard.Controls.Add(this.txtColor);
            this.pnlCard.Controls.Add(this.lblColor);
            this.pnlCard.Controls.Add(this.cbCategory);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Controls.Add(this.txtItemName);
            this.pnlCard.Controls.Add(this.lblItemName);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCard.Location = new System.Drawing.Point(30, 98);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Radius = 15;
            this.pnlCard.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.pnlCard.Size = new System.Drawing.Size(620, 385);
            this.pnlCard.Style = Sunny.UI.UIStyle.Custom;
            this.pnlCard.StyleCustomMode = true;
            this.pnlCard.TabIndex = 3;
            this.pnlCard.Text = null;
            this.pnlCard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtDescription.Location = new System.Drawing.Point(145, 222);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(5);
            this.txtDescription.Radius = 10;
            this.txtDescription.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.txtDescription.ShowText = false;
            this.txtDescription.Size = new System.Drawing.Size(445, 135);
            this.txtDescription.Style = Sunny.UI.UIStyle.Custom;
            this.txtDescription.StyleCustomMode = true;
            this.txtDescription.TabIndex = 13;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtDescription.Watermark = "Additional details, unique marks, brand, or student contact info...";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblDescription.Location = new System.Drawing.Point(25, 222);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(110, 30);
            this.lblDescription.Style = Sunny.UI.UIStyle.Custom;
            this.lblDescription.StyleCustomMode = true;
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = null;
            this.cbStatus.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.White;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbStatus.ItemHeight = 26;
            this.cbStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbStatus.Items.AddRange(new object[] {
            "Open",
            "Claimed",
            "Returned"});
            this.cbStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbStatus.Location = new System.Drawing.Point(440, 120);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatus.Radius = 10;
            this.cbStatus.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.cbStatus.Size = new System.Drawing.Size(150, 36);
            this.cbStatus.Style = Sunny.UI.UIStyle.Custom;
            this.cbStatus.StyleCustomMode = true;
            this.cbStatus.SymbolSize = 24;
            this.cbStatus.TabIndex = 9;
            this.cbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatus.Watermark = "";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblStatus.Location = new System.Drawing.Point(375, 122);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 30);
            this.lblStatus.Style = Sunny.UI.UIStyle.Custom;
            this.lblStatus.StyleCustomMode = true;
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocation
            // 
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtLocation.Location = new System.Drawing.Point(145, 170);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocation.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Padding = new System.Windows.Forms.Padding(5);
            this.txtLocation.Radius = 10;
            this.txtLocation.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.txtLocation.ShowText = false;
            this.txtLocation.Size = new System.Drawing.Size(445, 36);
            this.txtLocation.Style = Sunny.UI.UIStyle.Custom;
            this.txtLocation.StyleCustomMode = true;
            this.txtLocation.TabIndex = 11;
            this.txtLocation.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLocation.Watermark = "e.g., Library 2nd Floor, Engineering Cafeteria...";
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblLocation.Location = new System.Drawing.Point(25, 172);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(110, 30);
            this.lblLocation.Style = Sunny.UI.UIStyle.Custom;
            this.lblLocation.StyleCustomMode = true;
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpItemDate
            // 
            this.dtpItemDate.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dtpItemDate.FillColor = System.Drawing.Color.White;
            this.dtpItemDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.dtpItemDate.Location = new System.Drawing.Point(145, 120);
            this.dtpItemDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpItemDate.MaxLength = 10;
            this.dtpItemDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpItemDate.Name = "dtpItemDate";
            this.dtpItemDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpItemDate.Radius = 10;
            this.dtpItemDate.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.dtpItemDate.Size = new System.Drawing.Size(210, 36);
            this.dtpItemDate.Style = Sunny.UI.UIStyle.Custom;
            this.dtpItemDate.StyleCustomMode = true;
            this.dtpItemDate.SymbolDropDown = 61555;
            this.dtpItemDate.SymbolNormal = 61555;
            this.dtpItemDate.SymbolSize = 24;
            this.dtpItemDate.TabIndex = 7;
            this.dtpItemDate.Text = "2026-11-20";
            this.dtpItemDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpItemDate.Value = new System.DateTime(2026, 11, 20, 0, 0, 0, 0);
            this.dtpItemDate.Watermark = "";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblDate.Location = new System.Drawing.Point(25, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 30);
            this.lblDate.Style = Sunny.UI.UIStyle.Custom;
            this.lblDate.StyleCustomMode = true;
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtColor
            // 
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtColor.Location = new System.Drawing.Point(440, 70);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtColor.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtColor.Name = "txtColor";
            this.txtColor.Padding = new System.Windows.Forms.Padding(5);
            this.txtColor.Radius = 10;
            this.txtColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.txtColor.ShowText = false;
            this.txtColor.Size = new System.Drawing.Size(150, 36);
            this.txtColor.Style = Sunny.UI.UIStyle.Custom;
            this.txtColor.StyleCustomMode = true;
            this.txtColor.TabIndex = 5;
            this.txtColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtColor.Watermark = "Black, Blue...";
            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblColor.Location = new System.Drawing.Point(375, 72);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 30);
            this.lblColor.Style = Sunny.UI.UIStyle.Custom;
            this.lblColor.StyleCustomMode = true;
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCategory
            // 
            this.cbCategory.DataSource = null;
            this.cbCategory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbCategory.FillColor = System.Drawing.Color.White;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbCategory.ItemHeight = 26;
            this.cbCategory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbCategory.Items.AddRange(new object[] {
            "Electronics",
            "Documents & IDs",
            "Keys & Cards",
            "Bags & Wallets",
            "Books & Stationery",
            "Accessories & Clothing",
            "Other"});
            this.cbCategory.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbCategory.Location = new System.Drawing.Point(145, 70);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCategory.Radius = 10;
            this.cbCategory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.cbCategory.Size = new System.Drawing.Size(210, 36);
            this.cbCategory.Style = Sunny.UI.UIStyle.Custom;
            this.cbCategory.StyleCustomMode = true;
            this.cbCategory.SymbolSize = 24;
            this.cbCategory.TabIndex = 3;
            this.cbCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCategory.Watermark = "";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblCategory.Location = new System.Drawing.Point(25, 72);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(110, 30);
            this.lblCategory.Style = Sunny.UI.UIStyle.Custom;
            this.lblCategory.StyleCustomMode = true;
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemName
            // 
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtItemName.Location = new System.Drawing.Point(145, 20);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Padding = new System.Windows.Forms.Padding(5);
            this.txtItemName.Radius = 10;
            this.txtItemName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.txtItemName.ShowText = false;
            this.txtItemName.Size = new System.Drawing.Size(445, 36);
            this.txtItemName.Style = Sunny.UI.UIStyle.Custom;
            this.txtItemName.StyleCustomMode = true;
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtItemName.Watermark = "e.g., Black Dell Laptop, Student ID Card...";
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.lblItemName.Location = new System.Drawing.Point(25, 22);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(110, 30);
            this.lblItemName.Style = Sunny.UI.UIStyle.Custom;
            this.lblItemName.StyleCustomMode = true;
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClose.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(390, 502);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 12;
            this.btnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClose.Size = new System.Drawing.Size(120, 42);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.StyleCustomMode = true;
            this.btnClose.Symbol = 61453;
            this.btnClose.SymbolSize = 20;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(530, 502);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 12;
            this.btnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.Style = Sunny.UI.UIStyle.Custom;
            this.btnSave.StyleCustomMode = true;
            this.btnSave.Symbol = 61452;
            this.btnSave.SymbolSize = 20;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(680, 565);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblItemIDText);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Item";
            this.Load += new System.EventHandler(this.frmAddEditItem_Load);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblItemIDText;
        private Sunny.UI.UILabel lblItemID;
        private Sunny.UI.UIPanel pnlCard;
        private Sunny.UI.UILabel lblItemName;
        private Sunny.UI.UITextBox txtItemName;
        private Sunny.UI.UILabel lblCategory;
        private Sunny.UI.UIComboBox cbCategory;
        private Sunny.UI.UILabel lblColor;
        private Sunny.UI.UITextBox txtColor;
        private Sunny.UI.UILabel lblDate;
        private Sunny.UI.UIDatePicker dtpItemDate;
        private Sunny.UI.UILabel lblLocation;
        private Sunny.UI.UITextBox txtLocation;
        private Sunny.UI.UILabel lblStatus;
        private Sunny.UI.UIComboBox cbStatus;
        private Sunny.UI.UILabel lblDescription;
        private Sunny.UI.UITextBox txtDescription;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UISymbolButton btnSave;
    }
}