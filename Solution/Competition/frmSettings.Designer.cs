namespace Competition
{
    partial class frmSettings
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
            this.gSettings = new System.Windows.Forms.TabControl();
            this.tGeneral = new System.Windows.Forms.TabPage();
            this.txtT1PasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnT1_Save = new System.Windows.Forms.Button();
            this.txtT1Password = new System.Windows.Forms.TextBox();
            this.txtT1Email = new System.Windows.Forms.TextBox();
            this.txtT1PhoneNo = new System.Windows.Forms.TextBox();
            this.txtT1HouseNo = new System.Windows.Forms.TextBox();
            this.txtT1Address = new System.Windows.Forms.TextBox();
            this.txtT1IC = new System.Windows.Forms.TextBox();
            this.txtT1Username = new System.Windows.Forms.TextBox();
            this.lblT1Password = new System.Windows.Forms.Label();
            this.lblT1Email = new System.Windows.Forms.Label();
            this.lblT1PhoneNo = new System.Windows.Forms.Label();
            this.lblT1HouseNo = new System.Windows.Forms.Label();
            this.lblT1Address = new System.Windows.Forms.Label();
            this.lblT1IC = new System.Windows.Forms.Label();
            this.lblT1Username = new System.Windows.Forms.Label();
            this.tAdmin = new System.Windows.Forms.TabPage();
            this.btnT2Remove = new System.Windows.Forms.Button();
            this.lblT2Users = new System.Windows.Forms.Label();
            this.cbT2Users = new System.Windows.Forms.ComboBox();
            this.gSettings.SuspendLayout();
            this.tGeneral.SuspendLayout();
            this.tAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gSettings
            // 
            this.gSettings.Controls.Add(this.tGeneral);
            this.gSettings.Controls.Add(this.tAdmin);
            this.gSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSettings.Location = new System.Drawing.Point(0, 0);
            this.gSettings.Name = "gSettings";
            this.gSettings.SelectedIndex = 0;
            this.gSettings.Size = new System.Drawing.Size(489, 436);
            this.gSettings.TabIndex = 0;
            this.gSettings.SelectedIndexChanged += new System.EventHandler(this.gChange);
            // 
            // tGeneral
            // 
            this.tGeneral.Controls.Add(this.txtT1PasswordConfirm);
            this.tGeneral.Controls.Add(this.btnT1_Save);
            this.tGeneral.Controls.Add(this.txtT1Password);
            this.tGeneral.Controls.Add(this.txtT1Email);
            this.tGeneral.Controls.Add(this.txtT1PhoneNo);
            this.tGeneral.Controls.Add(this.txtT1HouseNo);
            this.tGeneral.Controls.Add(this.txtT1Address);
            this.tGeneral.Controls.Add(this.txtT1IC);
            this.tGeneral.Controls.Add(this.txtT1Username);
            this.tGeneral.Controls.Add(this.lblT1Password);
            this.tGeneral.Controls.Add(this.lblT1Email);
            this.tGeneral.Controls.Add(this.lblT1PhoneNo);
            this.tGeneral.Controls.Add(this.lblT1HouseNo);
            this.tGeneral.Controls.Add(this.lblT1Address);
            this.tGeneral.Controls.Add(this.lblT1IC);
            this.tGeneral.Controls.Add(this.lblT1Username);
            this.tGeneral.Location = new System.Drawing.Point(4, 22);
            this.tGeneral.Name = "tGeneral";
            this.tGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tGeneral.Size = new System.Drawing.Size(481, 410);
            this.tGeneral.TabIndex = 0;
            this.tGeneral.Text = "General";
            this.tGeneral.UseVisualStyleBackColor = true;
            // 
            // txtT1PasswordConfirm
            // 
            this.txtT1PasswordConfirm.Location = new System.Drawing.Point(266, 165);
            this.txtT1PasswordConfirm.Name = "txtT1PasswordConfirm";
            this.txtT1PasswordConfirm.PasswordChar = '*';
            this.txtT1PasswordConfirm.Size = new System.Drawing.Size(170, 20);
            this.txtT1PasswordConfirm.TabIndex = 30;
            this.txtT1PasswordConfirm.UseSystemPasswordChar = true;
            // 
            // btnT1_Save
            // 
            this.btnT1_Save.Location = new System.Drawing.Point(86, 191);
            this.btnT1_Save.Name = "btnT1_Save";
            this.btnT1_Save.Size = new System.Drawing.Size(170, 23);
            this.btnT1_Save.TabIndex = 31;
            this.btnT1_Save.Text = "Save";
            this.btnT1_Save.UseVisualStyleBackColor = true;
            this.btnT1_Save.Click += new System.EventHandler(this.btnT1_Save_Click);
            // 
            // txtT1Password
            // 
            this.txtT1Password.Location = new System.Drawing.Point(86, 165);
            this.txtT1Password.Name = "txtT1Password";
            this.txtT1Password.PasswordChar = '*';
            this.txtT1Password.Size = new System.Drawing.Size(170, 20);
            this.txtT1Password.TabIndex = 29;
            this.txtT1Password.UseSystemPasswordChar = true;
            // 
            // txtT1Email
            // 
            this.txtT1Email.Location = new System.Drawing.Point(86, 139);
            this.txtT1Email.Name = "txtT1Email";
            this.txtT1Email.Size = new System.Drawing.Size(350, 20);
            this.txtT1Email.TabIndex = 28;
            // 
            // txtT1PhoneNo
            // 
            this.txtT1PhoneNo.Location = new System.Drawing.Point(86, 113);
            this.txtT1PhoneNo.Name = "txtT1PhoneNo";
            this.txtT1PhoneNo.Size = new System.Drawing.Size(350, 20);
            this.txtT1PhoneNo.TabIndex = 27;
            // 
            // txtT1HouseNo
            // 
            this.txtT1HouseNo.Location = new System.Drawing.Point(86, 87);
            this.txtT1HouseNo.Name = "txtT1HouseNo";
            this.txtT1HouseNo.Size = new System.Drawing.Size(350, 20);
            this.txtT1HouseNo.TabIndex = 26;
            // 
            // txtT1Address
            // 
            this.txtT1Address.Location = new System.Drawing.Point(86, 61);
            this.txtT1Address.Name = "txtT1Address";
            this.txtT1Address.Size = new System.Drawing.Size(350, 20);
            this.txtT1Address.TabIndex = 25;
            // 
            // txtT1IC
            // 
            this.txtT1IC.Location = new System.Drawing.Point(86, 35);
            this.txtT1IC.Name = "txtT1IC";
            this.txtT1IC.Size = new System.Drawing.Size(350, 20);
            this.txtT1IC.TabIndex = 24;
            // 
            // txtT1Username
            // 
            this.txtT1Username.Location = new System.Drawing.Point(86, 9);
            this.txtT1Username.Name = "txtT1Username";
            this.txtT1Username.Size = new System.Drawing.Size(350, 20);
            this.txtT1Username.TabIndex = 23;
            this.txtT1Username.Leave += new System.EventHandler(this.checkExist);
            // 
            // lblT1Password
            // 
            this.lblT1Password.AutoSize = true;
            this.lblT1Password.Location = new System.Drawing.Point(8, 168);
            this.lblT1Password.Name = "lblT1Password";
            this.lblT1Password.Size = new System.Drawing.Size(56, 13);
            this.lblT1Password.TabIndex = 22;
            this.lblT1Password.Text = "Password:";
            // 
            // lblT1Email
            // 
            this.lblT1Email.AutoSize = true;
            this.lblT1Email.Location = new System.Drawing.Point(8, 142);
            this.lblT1Email.Name = "lblT1Email";
            this.lblT1Email.Size = new System.Drawing.Size(35, 13);
            this.lblT1Email.TabIndex = 21;
            this.lblT1Email.Text = "Email:";
            // 
            // lblT1PhoneNo
            // 
            this.lblT1PhoneNo.AutoSize = true;
            this.lblT1PhoneNo.Location = new System.Drawing.Point(8, 116);
            this.lblT1PhoneNo.Name = "lblT1PhoneNo";
            this.lblT1PhoneNo.Size = new System.Drawing.Size(58, 13);
            this.lblT1PhoneNo.TabIndex = 20;
            this.lblT1PhoneNo.Text = "Phone No:";
            // 
            // lblT1HouseNo
            // 
            this.lblT1HouseNo.AutoSize = true;
            this.lblT1HouseNo.Location = new System.Drawing.Point(8, 90);
            this.lblT1HouseNo.Name = "lblT1HouseNo";
            this.lblT1HouseNo.Size = new System.Drawing.Size(58, 13);
            this.lblT1HouseNo.TabIndex = 19;
            this.lblT1HouseNo.Text = "House No:";
            // 
            // lblT1Address
            // 
            this.lblT1Address.AutoSize = true;
            this.lblT1Address.Location = new System.Drawing.Point(8, 64);
            this.lblT1Address.Name = "lblT1Address";
            this.lblT1Address.Size = new System.Drawing.Size(79, 13);
            this.lblT1Address.TabIndex = 18;
            this.lblT1Address.Text = "Home Address:";
            // 
            // lblT1IC
            // 
            this.lblT1IC.AutoSize = true;
            this.lblT1IC.Location = new System.Drawing.Point(8, 38);
            this.lblT1IC.Name = "lblT1IC";
            this.lblT1IC.Size = new System.Drawing.Size(37, 13);
            this.lblT1IC.TabIndex = 17;
            this.lblT1IC.Text = "IC No:";
            // 
            // lblT1Username
            // 
            this.lblT1Username.AutoSize = true;
            this.lblT1Username.Location = new System.Drawing.Point(8, 12);
            this.lblT1Username.Name = "lblT1Username";
            this.lblT1Username.Size = new System.Drawing.Size(58, 13);
            this.lblT1Username.TabIndex = 16;
            this.lblT1Username.Text = "Username:";
            // 
            // tAdmin
            // 
            this.tAdmin.Controls.Add(this.btnT2Remove);
            this.tAdmin.Controls.Add(this.lblT2Users);
            this.tAdmin.Controls.Add(this.cbT2Users);
            this.tAdmin.Location = new System.Drawing.Point(4, 22);
            this.tAdmin.Name = "tAdmin";
            this.tAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tAdmin.Size = new System.Drawing.Size(481, 410);
            this.tAdmin.TabIndex = 1;
            this.tAdmin.Text = "Administration";
            this.tAdmin.UseVisualStyleBackColor = true;
            // 
            // btnT2Remove
            // 
            this.btnT2Remove.Location = new System.Drawing.Point(46, 33);
            this.btnT2Remove.Name = "btnT2Remove";
            this.btnT2Remove.Size = new System.Drawing.Size(121, 23);
            this.btnT2Remove.TabIndex = 2;
            this.btnT2Remove.Text = "Remove User";
            this.btnT2Remove.UseVisualStyleBackColor = true;
            this.btnT2Remove.Click += new System.EventHandler(this.btnT2Remove_Click);
            // 
            // lblT2Users
            // 
            this.lblT2Users.AutoSize = true;
            this.lblT2Users.Location = new System.Drawing.Point(6, 9);
            this.lblT2Users.Name = "lblT2Users";
            this.lblT2Users.Size = new System.Drawing.Size(34, 13);
            this.lblT2Users.TabIndex = 1;
            this.lblT2Users.Text = "Users";
            // 
            // cbT2Users
            // 
            this.cbT2Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbT2Users.FormattingEnabled = true;
            this.cbT2Users.Location = new System.Drawing.Point(46, 6);
            this.cbT2Users.Name = "cbT2Users";
            this.cbT2Users.Size = new System.Drawing.Size(427, 21);
            this.cbT2Users.TabIndex = 0;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 436);
            this.Controls.Add(this.gSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(505, 475);
            this.MinimumSize = new System.Drawing.Size(505, 475);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClose);
            this.gSettings.ResumeLayout(false);
            this.tGeneral.ResumeLayout(false);
            this.tGeneral.PerformLayout();
            this.tAdmin.ResumeLayout(false);
            this.tAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl gSettings;
        private System.Windows.Forms.TabPage tGeneral;
        private System.Windows.Forms.TabPage tAdmin;
        private System.Windows.Forms.TextBox txtT1PasswordConfirm;
        private System.Windows.Forms.Button btnT1_Save;
        private System.Windows.Forms.TextBox txtT1Password;
        private System.Windows.Forms.TextBox txtT1Email;
        private System.Windows.Forms.TextBox txtT1PhoneNo;
        private System.Windows.Forms.TextBox txtT1HouseNo;
        private System.Windows.Forms.TextBox txtT1Address;
        private System.Windows.Forms.TextBox txtT1IC;
        private System.Windows.Forms.TextBox txtT1Username;
        private System.Windows.Forms.Label lblT1Password;
        private System.Windows.Forms.Label lblT1Email;
        private System.Windows.Forms.Label lblT1PhoneNo;
        private System.Windows.Forms.Label lblT1HouseNo;
        private System.Windows.Forms.Label lblT1Address;
        private System.Windows.Forms.Label lblT1IC;
        private System.Windows.Forms.Label lblT1Username;
        private System.Windows.Forms.Button btnT2Remove;
        private System.Windows.Forms.Label lblT2Users;
        private System.Windows.Forms.ComboBox cbT2Users;
    }
}