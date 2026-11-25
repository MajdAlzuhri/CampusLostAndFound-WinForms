namespace CampusLostAndFound.AdminForms
{
    partial class frmAddEditClaim
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
            this.lblClaimIDText = new Sunny.UI.UILabel();
            this.lblClaimID = new Sunny.UI.UILabel();
            this.pnlCard = new Sunny.UI.UIPanel();
            this.lblItemID = new Sunny.UI.UILabel();
            this.txtItemID = new Sunny.UI.UITextBox();
            this.btnFindItem = new Sunny.UI.UISymbolButton();
            this.lblItemPreview = new Sunny.UI.UILabel();
            this.lblClaimantName = new Sunny.UI.UILabel();
            this.txtClaimantName = new Sunny.UI.UITextBox();
            this.lblPhone = new Sunny.UI.UILabel();
            this.txtPhone = new Sunny.UI.UITextBox();
            this.lblStatus = new Sunny.UI.UILabel();
            this.cbClaimStatus = new Sunny.UI.UIComboBox();
            this.lblVerification = new Sunny.UI.UILabel();
            this.txtVerificationResult = new Sunny.UI.UITextBox();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.lblTitle.Location = new System.Drawing.Point(160, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.StyleCustomMode = true;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Claim";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClaimIDText
            // 
            this.lblClaimIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblClaimIDText.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblClaimIDText.Location = new System.Drawing.Point(35, 62);
            this.lblClaimIDText.Name = "lblClaimIDText";
            this.lblClaimIDText.Size = new System.Drawing.Size(85, 28);
            this.lblClaimIDText.Style = Sunny.UI.UIStyle.Custom;
            this.lblClaimIDText.StyleCustomMode = true;
            this.lblClaimIDText.TabIndex = 1;
            this.lblClaimIDText.Text = "Claim ID:";
            this.lblClaimIDText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClaimID
            // 
            this.lblClaimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblClaimID.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.lblClaimID.Location = new System.Drawing.Point(122, 62);
            this.lblClaimID.Name = "lblClaimID";
            this.lblClaimID.Size = new System.Drawing.Size(90, 28);
            this.lblClaimID.Style = Sunny.UI.UIStyle.Custom;
            this.lblClaimID.StyleCustomMode = true;
            this.lblClaimID.TabIndex = 2;
            this.lblClaimID.Text = "???";
            this.lblClaimID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.txtVerificationResult);
            this.pnlCard.Controls.Add(this.lblVerification);
            this.pnlCard.Controls.Add(this.cbClaimStatus);
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Controls.Add(this.txtPhone);
            this.pnlCard.Controls.Add(this.lblPhone);
            this.pnlCard.Controls.Add(this.txtClaimantName);
            this.pnlCard.Controls.Add(this.lblClaimantName);
            this.pnlCard.Controls.Add(this.lblItemPreview);
            this.pnlCard.Controls.Add(this.btnFindItem);
            this.pnlCard.Controls.Add(this.txtItemID);
            this.pnlCard.Controls.Add(this.lblItemID);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCard.Location = new System.Drawing.Point(30, 98);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCard.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Radius = 15;
            this.pnlCard.RectColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.pnlCard.Size = new System.Drawing.Size(620, 390);
            this.pnlCard.Style = Sunny.UI.UIStyle.Custom;
            this.pnlCard.StyleCustomMode = true;
            this.pnlCard.TabIndex = 3;
            this.pnlCard.Text = null;
            // 
            // lblItemID
            // 
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblItemID.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblItemID.Location = new System.Drawing.Point(25, 22);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(130, 30);
            this.lblItemID.Style = Sunny.UI.UIStyle.Custom;
            this.lblItemID.StyleCustomMode = true;
            this.lblItemID.TabIndex = 0;
            this.lblItemID.Text = "Found Item ID:";
            this.lblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemID
            // 
            this.txtItemID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtItemID.Location = new System.Drawing.Point(165, 20);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Padding = new System.Windows.Forms.Padding(5);
            this.txtItemID.Radius = 10;
            this.txtItemID.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.txtItemID.ShowText = false;
            this.txtItemID.Size = new System.Drawing.Size(160, 36);
            this.txtItemID.Style = Sunny.UI.UIStyle.Custom;
            this.txtItemID.StyleCustomMode = true;
            this.txtItemID.TabIndex = 1;
            this.txtItemID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtItemID.Watermark = "Enter Item ID...";
            this.txtItemID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemID_KeyPress);
            // 
            // btnFindItem
            // 
            this.btnFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItem.FillColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.btnFindItem.FillHoverColor = System.Drawing.Color.FromArgb(0, 110, 190);
            this.btnFindItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnFindItem.Location = new System.Drawing.Point(338, 20);
            this.btnFindItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFindItem.Name = "btnFindItem";
            this.btnFindItem.Radius = 10;
            this.btnFindItem.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.btnFindItem.Size = new System.Drawing.Size(115, 36);
            this.btnFindItem.Style = Sunny.UI.UIStyle.Custom;
            this.btnFindItem.StyleCustomMode = true;
            this.btnFindItem.Symbol = 61442;
            this.btnFindItem.SymbolSize = 18;
            this.btnFindItem.TabIndex = 2;
            this.btnFindItem.Text = "Verify Item";
            this.btnFindItem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindItem.Click += new System.EventHandler(this.btnFindItem_Click);
            // 
            // lblItemPreview
            // 
            this.lblItemPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblItemPreview.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblItemPreview.Location = new System.Drawing.Point(165, 62);
            this.lblItemPreview.Name = "lblItemPreview";
            this.lblItemPreview.Size = new System.Drawing.Size(425, 26);
            this.lblItemPreview.Style = Sunny.UI.UIStyle.Custom;
            this.lblItemPreview.StyleCustomMode = true;
            this.lblItemPreview.TabIndex = 3;
            this.lblItemPreview.Text = "Click 'Verify Item' to load item details...";
            this.lblItemPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClaimantName
            // 
            this.lblClaimantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblClaimantName.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblClaimantName.Location = new System.Drawing.Point(25, 102);
            this.lblClaimantName.Name = "lblClaimantName";
            this.lblClaimantName.Size = new System.Drawing.Size(130, 30);
            this.lblClaimantName.Style = Sunny.UI.UIStyle.Custom;
            this.lblClaimantName.StyleCustomMode = true;
            this.lblClaimantName.TabIndex = 4;
            this.lblClaimantName.Text = "Claimant Name:";
            this.lblClaimantName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClaimantName
            // 
            this.txtClaimantName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClaimantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtClaimantName.Location = new System.Drawing.Point(165, 100);
            this.txtClaimantName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClaimantName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtClaimantName.Name = "txtClaimantName";
            this.txtClaimantName.Padding = new System.Windows.Forms.Padding(5);
            this.txtClaimantName.Radius = 10;
            this.txtClaimantName.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.txtClaimantName.ShowText = false;
            this.txtClaimantName.Size = new System.Drawing.Size(425, 36);
            this.txtClaimantName.Style = Sunny.UI.UIStyle.Custom;
            this.txtClaimantName.StyleCustomMode = true;
            this.txtClaimantName.TabIndex = 5;
            this.txtClaimantName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtClaimantName.Watermark = "Student full name...";
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblPhone.Location = new System.Drawing.Point(25, 152);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(130, 30);
            this.lblPhone.Style = Sunny.UI.UIStyle.Custom;
            this.lblPhone.StyleCustomMode = true;
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Number:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtPhone.Location = new System.Drawing.Point(165, 150);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhone.Radius = 10;
            this.txtPhone.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.txtPhone.ShowText = false;
            this.txtPhone.Size = new System.Drawing.Size(210, 36);
            this.txtPhone.Style = Sunny.UI.UIStyle.Custom;
            this.txtPhone.StyleCustomMode = true;
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPhone.Watermark = "03XXXXXXXXX";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblStatus.Location = new System.Drawing.Point(385, 152);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 30);
            this.lblStatus.Style = Sunny.UI.UIStyle.Custom;
            this.lblStatus.StyleCustomMode = true;
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbClaimStatus
            // 
            this.cbClaimStatus.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbClaimStatus.FillColor = System.Drawing.Color.White;
            this.cbClaimStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbClaimStatus.ItemHeight = 26;
            this.cbClaimStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.cbClaimStatus.Location = new System.Drawing.Point(450, 150);
            this.cbClaimStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbClaimStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbClaimStatus.Name = "cbClaimStatus";
            this.cbClaimStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbClaimStatus.Radius = 10;
            this.cbClaimStatus.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.cbClaimStatus.Size = new System.Drawing.Size(140, 36);
            this.cbClaimStatus.Style = Sunny.UI.UIStyle.Custom;
            this.cbClaimStatus.StyleCustomMode = true;
            this.cbClaimStatus.SymbolSize = 24;
            this.cbClaimStatus.TabIndex = 9;
            this.cbClaimStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVerification
            // 
            this.lblVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblVerification.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblVerification.Location = new System.Drawing.Point(25, 205);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(135, 45);
            this.lblVerification.Style = Sunny.UI.UIStyle.Custom;
            this.lblVerification.StyleCustomMode = true;
            this.lblVerification.TabIndex = 10;
            this.lblVerification.Text = "Verification\r\nNotes:";
            this.lblVerification.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtVerificationResult
            // 
            this.txtVerificationResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerificationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtVerificationResult.Location = new System.Drawing.Point(165, 205);
            this.txtVerificationResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVerificationResult.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtVerificationResult.Multiline = true;
            this.txtVerificationResult.Name = "txtVerificationResult";
            this.txtVerificationResult.Padding = new System.Windows.Forms.Padding(5);
            this.txtVerificationResult.Radius = 10;
            this.txtVerificationResult.RectColor = System.Drawing.Color.FromArgb(0, 90, 156);
            this.txtVerificationResult.ShowText = false;
            this.txtVerificationResult.Size = new System.Drawing.Size(425, 155);
            this.txtVerificationResult.Style = Sunny.UI.UIStyle.Custom;
            this.txtVerificationResult.StyleCustomMode = true;
            this.txtVerificationResult.TabIndex = 11;
            this.txtVerificationResult.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtVerificationResult.Watermark = "Student ID card number, serial number, or proof of ownership...";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnClose.FillHoverColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(390, 505);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 12;
            this.btnClose.RectColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnClose.Size = new System.Drawing.Size(120, 42);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.StyleCustomMode = true;
            this.btnClose.Symbol = 61453;
            this.btnClose.SymbolSize = 20;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(530, 505);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 12;
            this.btnSave.RectColor = System.Drawing.Color.FromArgb(16, 185, 129);
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
            // frmAddEditClaim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(680, 565);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblClaimID);
            this.Controls.Add(this.lblClaimIDText);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditClaim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Claim";
            this.Load += new System.EventHandler(this.frmAddEditClaim_Load);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblClaimIDText;
        private Sunny.UI.UILabel lblClaimID;
        private Sunny.UI.UIPanel pnlCard;
        private Sunny.UI.UILabel lblItemID;
        private Sunny.UI.UITextBox txtItemID;
        private Sunny.UI.UISymbolButton btnFindItem;
        private Sunny.UI.UILabel lblItemPreview;
        private Sunny.UI.UILabel lblClaimantName;
        private Sunny.UI.UITextBox txtClaimantName;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UILabel lblStatus;
        private Sunny.UI.UIComboBox cbClaimStatus;
        private Sunny.UI.UILabel lblVerification;
        private Sunny.UI.UITextBox txtVerificationResult;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UISymbolButton btnSave;
    }
}