namespace CampusLostAndFound
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new Sunny.UI.UITextBox();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.btnLogin = new Sunny.UI.UIButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(789, 201);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsername.Radius = 20;
            this.txtUsername.ShowText = false;
            this.txtUsername.Size = new System.Drawing.Size(306, 53);
            this.txtUsername.Style = Sunny.UI.UIStyle.Custom;
            this.txtUsername.Symbol = 62141;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtUsername.Watermark = "Username";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPassword.Location = new System.Drawing.Point(789, 278);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 20;
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(306, 53);
            this.txtPassword.Style = Sunny.UI.UIStyle.Custom;
            this.txtPassword.Symbol = 61475;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPassword.Watermark = "Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.FillHoverColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(880, 380);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 20;
            this.btnLogin.Size = new System.Drawing.Size(130, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(71, 226);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(360, 44);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "Campus Lost && Found";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(75, 278);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(442, 20);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "Reuniting students with their belongings easily && securely.";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Navy;
            this.uiLabel3.Location = new System.Drawing.Point(810, 9);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(233, 36);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Welcome Back!";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.uiLabel4.Location = new System.Drawing.Point(825, 45);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(193, 22);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "Sign in to your account";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::CampusLostAndFound.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Campus Lost & Found - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UIButton btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
    }
}

