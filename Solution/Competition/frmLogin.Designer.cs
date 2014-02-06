namespace Competition
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
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gNewUser = new System.Windows.Forms.GroupBox();
            this.txtNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtNewPhoneNo = new System.Windows.Forms.TextBox();
            this.txtNewHouseNo = new System.Windows.Forms.TextBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtNewIC = new System.Windows.Forms.TextBox();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.lblNewPhoneNo = new System.Windows.Forms.Label();
            this.lblNewHouseNo = new System.Windows.Forms.Label();
            this.lblNewAddress = new System.Windows.Forms.Label();
            this.lblNewIC = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.PanelLogin.SuspendLayout();
            this.gNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.btnCreateUser);
            this.PanelLogin.Controls.Add(this.btnLogin);
            this.PanelLogin.Controls.Add(this.lblHeader);
            this.PanelLogin.Controls.Add(this.txtPassword);
            this.PanelLogin.Controls.Add(this.txtUserName);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Location = new System.Drawing.Point(14, 14);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(5);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(460, 160);
            this.PanelLogin.TabIndex = 8;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(321, 120);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(113, 23);
            this.btnCreateUser.TabIndex = 14;
            this.btnCreateUser.Text = "Create New User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(84, 120);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(231, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(18, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(153, 25);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Please sign in:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(350, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(84, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(350, 20);
            this.txtUserName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // gNewUser
            // 
            this.gNewUser.Controls.Add(this.txtNewPasswordConfirm);
            this.gNewUser.Controls.Add(this.btnCancel);
            this.gNewUser.Controls.Add(this.btnConfirm);
            this.gNewUser.Controls.Add(this.txtNewPassword);
            this.gNewUser.Controls.Add(this.txtNewEmail);
            this.gNewUser.Controls.Add(this.txtNewPhoneNo);
            this.gNewUser.Controls.Add(this.txtNewHouseNo);
            this.gNewUser.Controls.Add(this.txtNewAddress);
            this.gNewUser.Controls.Add(this.txtNewIC);
            this.gNewUser.Controls.Add(this.txtNewUsername);
            this.gNewUser.Controls.Add(this.lblNewPassword);
            this.gNewUser.Controls.Add(this.lblNewEmail);
            this.gNewUser.Controls.Add(this.lblNewPhoneNo);
            this.gNewUser.Controls.Add(this.lblNewHouseNo);
            this.gNewUser.Controls.Add(this.lblNewAddress);
            this.gNewUser.Controls.Add(this.lblNewIC);
            this.gNewUser.Controls.Add(this.lblNewUsername);
            this.gNewUser.Enabled = false;
            this.gNewUser.Location = new System.Drawing.Point(14, 182);
            this.gNewUser.Name = "gNewUser";
            this.gNewUser.Size = new System.Drawing.Size(460, 245);
            this.gNewUser.TabIndex = 9;
            this.gNewUser.TabStop = false;
            this.gNewUser.Text = "Create a New User";
            this.gNewUser.Visible = false;
            // 
            // txtNewPasswordConfirm
            // 
            this.txtNewPasswordConfirm.Location = new System.Drawing.Point(264, 183);
            this.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
            this.txtNewPasswordConfirm.PasswordChar = '*';
            this.txtNewPasswordConfirm.Size = new System.Drawing.Size(170, 20);
            this.txtNewPasswordConfirm.TabIndex = 14;
            this.txtNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(84, 209);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(231, 23);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "Create User";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(84, 183);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(170, 20);
            this.txtNewPassword.TabIndex = 13;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(84, 157);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(350, 20);
            this.txtNewEmail.TabIndex = 12;
            // 
            // txtNewPhoneNo
            // 
            this.txtNewPhoneNo.Location = new System.Drawing.Point(84, 131);
            this.txtNewPhoneNo.Name = "txtNewPhoneNo";
            this.txtNewPhoneNo.Size = new System.Drawing.Size(350, 20);
            this.txtNewPhoneNo.TabIndex = 11;
            // 
            // txtNewHouseNo
            // 
            this.txtNewHouseNo.Location = new System.Drawing.Point(84, 105);
            this.txtNewHouseNo.Name = "txtNewHouseNo";
            this.txtNewHouseNo.Size = new System.Drawing.Size(350, 20);
            this.txtNewHouseNo.TabIndex = 10;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(84, 79);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(350, 20);
            this.txtNewAddress.TabIndex = 9;
            // 
            // txtNewIC
            // 
            this.txtNewIC.Location = new System.Drawing.Point(84, 53);
            this.txtNewIC.Name = "txtNewIC";
            this.txtNewIC.Size = new System.Drawing.Size(350, 20);
            this.txtNewIC.TabIndex = 8;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(84, 27);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(350, 20);
            this.txtNewUsername.TabIndex = 7;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(6, 186);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(56, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Password:";
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Location = new System.Drawing.Point(6, 160);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(35, 13);
            this.lblNewEmail.TabIndex = 5;
            this.lblNewEmail.Text = "Email:";
            // 
            // lblNewPhoneNo
            // 
            this.lblNewPhoneNo.AutoSize = true;
            this.lblNewPhoneNo.Location = new System.Drawing.Point(6, 134);
            this.lblNewPhoneNo.Name = "lblNewPhoneNo";
            this.lblNewPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblNewPhoneNo.TabIndex = 4;
            this.lblNewPhoneNo.Text = "Phone No:";
            // 
            // lblNewHouseNo
            // 
            this.lblNewHouseNo.AutoSize = true;
            this.lblNewHouseNo.Location = new System.Drawing.Point(6, 108);
            this.lblNewHouseNo.Name = "lblNewHouseNo";
            this.lblNewHouseNo.Size = new System.Drawing.Size(58, 13);
            this.lblNewHouseNo.TabIndex = 3;
            this.lblNewHouseNo.Text = "House No:";
            // 
            // lblNewAddress
            // 
            this.lblNewAddress.AutoSize = true;
            this.lblNewAddress.Location = new System.Drawing.Point(6, 82);
            this.lblNewAddress.Name = "lblNewAddress";
            this.lblNewAddress.Size = new System.Drawing.Size(79, 13);
            this.lblNewAddress.TabIndex = 2;
            this.lblNewAddress.Text = "Home Address:";
            // 
            // lblNewIC
            // 
            this.lblNewIC.AutoSize = true;
            this.lblNewIC.Location = new System.Drawing.Point(6, 56);
            this.lblNewIC.Name = "lblNewIC";
            this.lblNewIC.Size = new System.Drawing.Size(37, 13);
            this.lblNewIC.TabIndex = 1;
            this.lblNewIC.Text = "IC No:";
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(6, 30);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(58, 13);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Text = "Username:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 181);
            this.Controls.Add(this.gNewUser);
            this.Controls.Add(this.PanelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 475);
            this.MinimumSize = new System.Drawing.Size(505, 220);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competition - Login Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exitALL);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.gNewUser.ResumeLayout(false);
            this.gNewUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gNewUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtNewPhoneNo;
        private System.Windows.Forms.TextBox txtNewHouseNo;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtNewIC;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.Label lblNewPhoneNo;
        private System.Windows.Forms.Label lblNewHouseNo;
        private System.Windows.Forms.Label lblNewAddress;
        private System.Windows.Forms.Label lblNewIC;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewPasswordConfirm;

    }
}

