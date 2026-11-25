namespace CampusLostAndFound.AdminForms
{
    partial class frmAddEditUser
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
            this.lblTitle = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lblUserID = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkIsActive = new Sunny.UI.UICheckBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cbRole = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtUsername = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New User";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(35, 70);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(88, 25);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "User ID :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblUserID.Location = new System.Drawing.Point(118, 70);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 25);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "???";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.pictureBox3);
            this.uiPanel1.Controls.Add(this.pictureBox2);
            this.uiPanel1.Controls.Add(this.pictureBox1);
            this.uiPanel1.Controls.Add(this.chkIsActive);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.cbRole);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.txtPassword);
            this.uiPanel1.Controls.Add(this.uiLabel3);
            this.uiPanel1.Controls.Add(this.txtUsername);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(30, 105);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 15;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.uiPanel1.Size = new System.Drawing.Size(560, 260);
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CampusLostAndFound.Properties.Resources.role;
            this.pictureBox3.Location = new System.Drawing.Point(137, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CampusLostAndFound.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(137, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampusLostAndFound.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(137, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(156)))));
            this.chkIsActive.CheckBoxSize = 22;
            this.chkIsActive.Checked = true;
            this.chkIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkIsActive.Location = new System.Drawing.Point(190, 187);
            this.chkIsActive.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(29, 27);
            this.chkIsActive.TabIndex = 7;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(9, 186);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(92, 25);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "Is Active:";
            // 
            // cbRole
            // 
            this.cbRole.DataSource = null;
            this.cbRole.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbRole.FillColor = System.Drawing.Color.White;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbRole.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cbRole.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbRole.Location = new System.Drawing.Point(190, 124);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRole.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbRole.Name = "cbRole";
            this.cbRole.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbRole.Radius = 10;
            this.cbRole.Size = new System.Drawing.Size(310, 36);
            this.cbRole.SymbolSize = 24;
            this.cbRole.TabIndex = 5;
            this.cbRole.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbRole.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(9, 131);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(57, 25);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "Role:";
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(190, 70);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 10;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(310, 36);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(9, 76);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(104, 25);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(190, 16);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsername.Radius = 10;
            this.txtUsername.ShowText = false;
            this.txtUsername.Size = new System.Drawing.Size(310, 36);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsername.Watermark = "example@gmail.com";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(5, 21);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(108, 25);
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "Username:";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(330, 385);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 12;
            this.btnClose.Size = new System.Drawing.Size(120, 42);
            this.btnClose.Symbol = 61453;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(470, 385);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 12;
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.Symbol = 61452;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(620, 460);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lblUserID;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cbRole;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UICheckBox chkIsActive;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UISymbolButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}