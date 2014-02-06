namespace Competition
{
    partial class frmMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gControls = new System.Windows.Forms.GroupBox();
            this.gRentals = new System.Windows.Forms.GroupBox();
            this.gRTenure = new System.Windows.Forms.GroupBox();
            this.btnRRefresh = new System.Windows.Forms.Button();
            this.btnRSave = new System.Windows.Forms.Button();
            this.dtREnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtRStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRReceivable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRCumulative = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRMonthly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRLotNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRTenant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gTenants = new System.Windows.Forms.GroupBox();
            this.gECTenants = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTContact_Email = new System.Windows.Forms.TextBox();
            this.lblLandLine = new System.Windows.Forms.Label();
            this.txtTContact_Landline = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTRemarks = new System.Windows.Forms.TextBox();
            this.lblTRemarks = new System.Windows.Forms.Label();
            this.txtTContact_Mobile = new System.Windows.Forms.TextBox();
            this.lblTContact = new System.Windows.Forms.Label();
            this.lblTAddress = new System.Windows.Forms.Label();
            this.txtTAddress = new System.Windows.Forms.TextBox();
            this.txtTLotNo = new System.Windows.Forms.TextBox();
            this.lblTLotNO = new System.Windows.Forms.Label();
            this.txtTCompanyName = new System.Windows.Forms.TextBox();
            this.lblTCompanyName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbTenants = new System.Windows.Forms.ComboBox();
            this.lblDuePayments = new System.Windows.Forms.Label();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnTenants = new System.Windows.Forms.Button();
            this.cMain = new System.Windows.Forms.MonthCalendar();
            this.gOptions = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbSTenant = new System.Windows.Forms.ComboBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gControls.SuspendLayout();
            this.gRentals.SuspendLayout();
            this.gRTenure.SuspendLayout();
            this.gTenants.SuspendLayout();
            this.gECTenants.SuspendLayout();
            this.gOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gControls, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gOptions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 471);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gControls
            // 
            this.gControls.Controls.Add(this.cbSTenant);
            this.gControls.Controls.Add(this.btnExport);
            this.gControls.Controls.Add(this.gTenants);
            this.gControls.Controls.Add(this.lblDuePayments);
            this.gControls.Controls.Add(this.btnRentals);
            this.gControls.Controls.Add(this.btnTenants);
            this.gControls.Controls.Add(this.cMain);
            this.gControls.Controls.Add(this.gRentals);
            this.gControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControls.Location = new System.Drawing.Point(3, 47);
            this.gControls.Name = "gControls";
            this.gControls.Size = new System.Drawing.Size(829, 367);
            this.gControls.TabIndex = 2;
            this.gControls.TabStop = false;
            this.gControls.Text = "Controls";
            // 
            // gRentals
            // 
            this.gRentals.Controls.Add(this.gRTenure);
            this.gRentals.Controls.Add(this.lblRLotNo);
            this.gRentals.Controls.Add(this.label3);
            this.gRentals.Controls.Add(this.lblRAddress);
            this.gRentals.Controls.Add(this.label2);
            this.gRentals.Controls.Add(this.cbRTenant);
            this.gRentals.Controls.Add(this.label1);
            this.gRentals.Location = new System.Drawing.Point(118, 19);
            this.gRentals.Name = "gRentals";
            this.gRentals.Size = new System.Drawing.Size(441, 342);
            this.gRentals.TabIndex = 5;
            this.gRentals.TabStop = false;
            this.gRentals.Text = "Rentals";
            this.gRentals.Visible = false;
            // 
            // gRTenure
            // 
            this.gRTenure.Controls.Add(this.btnRRefresh);
            this.gRTenure.Controls.Add(this.btnRSave);
            this.gRTenure.Controls.Add(this.dtREnd);
            this.gRTenure.Controls.Add(this.label8);
            this.gRTenure.Controls.Add(this.dtRStart);
            this.gRTenure.Controls.Add(this.label7);
            this.gRTenure.Controls.Add(this.lblRReceivable);
            this.gRTenure.Controls.Add(this.label6);
            this.gRTenure.Controls.Add(this.txtRCumulative);
            this.gRTenure.Controls.Add(this.label5);
            this.gRTenure.Controls.Add(this.txtRMonthly);
            this.gRTenure.Controls.Add(this.label4);
            this.gRTenure.Location = new System.Drawing.Point(15, 111);
            this.gRTenure.Name = "gRTenure";
            this.gRTenure.Size = new System.Drawing.Size(414, 219);
            this.gRTenure.TabIndex = 6;
            this.gRTenure.TabStop = false;
            this.gRTenure.Text = "Tenure Details";
            // 
            // btnRRefresh
            // 
            this.btnRRefresh.Location = new System.Drawing.Point(215, 153);
            this.btnRRefresh.Name = "btnRRefresh";
            this.btnRRefresh.Size = new System.Drawing.Size(94, 23);
            this.btnRRefresh.TabIndex = 11;
            this.btnRRefresh.Text = "Refresh";
            this.btnRRefresh.UseVisualStyleBackColor = true;
            this.btnRRefresh.Click += new System.EventHandler(this.btnRRefresh_Click);
            // 
            // btnRSave
            // 
            this.btnRSave.Location = new System.Drawing.Point(109, 153);
            this.btnRSave.Name = "btnRSave";
            this.btnRSave.Size = new System.Drawing.Size(100, 23);
            this.btnRSave.TabIndex = 10;
            this.btnRSave.Text = "Save Changes";
            this.btnRSave.UseVisualStyleBackColor = true;
            this.btnRSave.Click += new System.EventHandler(this.btnRSave_Click);
            // 
            // dtREnd
            // 
            this.dtREnd.Location = new System.Drawing.Point(109, 127);
            this.dtREnd.Name = "dtREnd";
            this.dtREnd.Size = new System.Drawing.Size(200, 20);
            this.dtREnd.TabIndex = 9;
            this.dtREnd.ValueChanged += new System.EventHandler(this.dt_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tenure End:";
            // 
            // dtRStart
            // 
            this.dtRStart.Location = new System.Drawing.Point(109, 101);
            this.dtRStart.Name = "dtRStart";
            this.dtRStart.Size = new System.Drawing.Size(200, 20);
            this.dtRStart.TabIndex = 7;
            this.dtRStart.ValueChanged += new System.EventHandler(this.dt_Changed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tenure Start:";
            // 
            // lblRReceivable
            // 
            this.lblRReceivable.AutoSize = true;
            this.lblRReceivable.Location = new System.Drawing.Point(106, 78);
            this.lblRReceivable.Name = "lblRReceivable";
            this.lblRReceivable.Size = new System.Drawing.Size(16, 13);
            this.lblRReceivable.TabIndex = 5;
            this.lblRReceivable.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rental Receivable:";
            // 
            // txtRCumulative
            // 
            this.txtRCumulative.Location = new System.Drawing.Point(109, 49);
            this.txtRCumulative.Name = "txtRCumulative";
            this.txtRCumulative.Size = new System.Drawing.Size(200, 20);
            this.txtRCumulative.TabIndex = 3;
            this.txtRCumulative.TextChanged += new System.EventHandler(this.txtR_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cumulative Rental:";
            // 
            // txtRMonthly
            // 
            this.txtRMonthly.Location = new System.Drawing.Point(109, 23);
            this.txtRMonthly.Name = "txtRMonthly";
            this.txtRMonthly.Size = new System.Drawing.Size(200, 20);
            this.txtRMonthly.TabIndex = 1;
            this.txtRMonthly.TextChanged += new System.EventHandler(this.txtR_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monthly Rental:";
            // 
            // lblRLotNo
            // 
            this.lblRLotNo.AutoSize = true;
            this.lblRLotNo.Location = new System.Drawing.Point(121, 85);
            this.lblRLotNo.Name = "lblRLotNo";
            this.lblRLotNo.Size = new System.Drawing.Size(16, 13);
            this.lblRLotNo.TabIndex = 5;
            this.lblRLotNo.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lot No:";
            // 
            // lblRAddress
            // 
            this.lblRAddress.AutoSize = true;
            this.lblRAddress.Location = new System.Drawing.Point(121, 59);
            this.lblRAddress.Name = "lblRAddress";
            this.lblRAddress.Size = new System.Drawing.Size(16, 13);
            this.lblRAddress.TabIndex = 3;
            this.lblRAddress.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // cbRTenant
            // 
            this.cbRTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRTenant.FormattingEnabled = true;
            this.cbRTenant.Location = new System.Drawing.Point(124, 19);
            this.cbRTenant.Name = "cbRTenant";
            this.cbRTenant.Size = new System.Drawing.Size(200, 21);
            this.cbRTenant.TabIndex = 1;
            this.cbRTenant.SelectedIndexChanged += new System.EventHandler(this.cbR_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Tenant:";
            // 
            // gTenants
            // 
            this.gTenants.Controls.Add(this.gECTenants);
            this.gTenants.Controls.Add(this.btnAdd);
            this.gTenants.Controls.Add(this.btnRemove);
            this.gTenants.Controls.Add(this.btnEdit);
            this.gTenants.Controls.Add(this.cbTenants);
            this.gTenants.Location = new System.Drawing.Point(118, 19);
            this.gTenants.Name = "gTenants";
            this.gTenants.Size = new System.Drawing.Size(441, 342);
            this.gTenants.TabIndex = 5;
            this.gTenants.TabStop = false;
            this.gTenants.Text = "Tenants";
            this.gTenants.Visible = false;
            // 
            // gECTenants
            // 
            this.gECTenants.Controls.Add(this.lblEmail);
            this.gECTenants.Controls.Add(this.txtTContact_Email);
            this.gECTenants.Controls.Add(this.lblLandLine);
            this.gECTenants.Controls.Add(this.txtTContact_Landline);
            this.gECTenants.Controls.Add(this.lblMobile);
            this.gECTenants.Controls.Add(this.btnSaveChanges);
            this.gECTenants.Controls.Add(this.btnSave);
            this.gECTenants.Controls.Add(this.txtTRemarks);
            this.gECTenants.Controls.Add(this.lblTRemarks);
            this.gECTenants.Controls.Add(this.txtTContact_Mobile);
            this.gECTenants.Controls.Add(this.lblTContact);
            this.gECTenants.Controls.Add(this.lblTAddress);
            this.gECTenants.Controls.Add(this.txtTAddress);
            this.gECTenants.Controls.Add(this.txtTLotNo);
            this.gECTenants.Controls.Add(this.lblTLotNO);
            this.gECTenants.Controls.Add(this.txtTCompanyName);
            this.gECTenants.Controls.Add(this.lblTCompanyName);
            this.gECTenants.Location = new System.Drawing.Point(6, 46);
            this.gECTenants.Name = "gECTenants";
            this.gECTenants.Size = new System.Drawing.Size(429, 290);
            this.gECTenants.TabIndex = 4;
            this.gECTenants.TabStop = false;
            this.gECTenants.Text = "Add Tenant";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(113, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtTContact_Email
            // 
            this.txtTContact_Email.Location = new System.Drawing.Point(154, 143);
            this.txtTContact_Email.Name = "txtTContact_Email";
            this.txtTContact_Email.Size = new System.Drawing.Size(269, 20);
            this.txtTContact_Email.TabIndex = 10;
            // 
            // lblLandLine
            // 
            this.lblLandLine.AutoSize = true;
            this.lblLandLine.Location = new System.Drawing.Point(98, 120);
            this.lblLandLine.Name = "lblLandLine";
            this.lblLandLine.Size = new System.Drawing.Size(50, 13);
            this.lblLandLine.TabIndex = 15;
            this.lblLandLine.Text = "Landline:";
            // 
            // txtTContact_Landline
            // 
            this.txtTContact_Landline.Location = new System.Drawing.Point(154, 117);
            this.txtTContact_Landline.Name = "txtTContact_Landline";
            this.txtTContact_Landline.Size = new System.Drawing.Size(269, 20);
            this.txtTContact_Landline.TabIndex = 9;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(107, 94);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 13;
            this.lblMobile.Text = "Mobile:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(178, 195);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(245, 23);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTRemarks
            // 
            this.txtTRemarks.Location = new System.Drawing.Point(97, 169);
            this.txtTRemarks.Name = "txtTRemarks";
            this.txtTRemarks.Size = new System.Drawing.Size(326, 20);
            this.txtTRemarks.TabIndex = 11;
            // 
            // lblTRemarks
            // 
            this.lblTRemarks.AutoSize = true;
            this.lblTRemarks.Location = new System.Drawing.Point(38, 172);
            this.lblTRemarks.Name = "lblTRemarks";
            this.lblTRemarks.Size = new System.Drawing.Size(52, 13);
            this.lblTRemarks.TabIndex = 9;
            this.lblTRemarks.Text = "Remarks:";
            // 
            // txtTContact_Mobile
            // 
            this.txtTContact_Mobile.Location = new System.Drawing.Point(154, 91);
            this.txtTContact_Mobile.Name = "txtTContact_Mobile";
            this.txtTContact_Mobile.Size = new System.Drawing.Size(269, 20);
            this.txtTContact_Mobile.TabIndex = 8;
            // 
            // lblTContact
            // 
            this.lblTContact.AutoSize = true;
            this.lblTContact.Location = new System.Drawing.Point(44, 94);
            this.lblTContact.Name = "lblTContact";
            this.lblTContact.Size = new System.Drawing.Size(47, 13);
            this.lblTContact.TabIndex = 6;
            this.lblTContact.Text = "Contact:";
            // 
            // lblTAddress
            // 
            this.lblTAddress.AutoSize = true;
            this.lblTAddress.Location = new System.Drawing.Point(11, 68);
            this.lblTAddress.Name = "lblTAddress";
            this.lblTAddress.Size = new System.Drawing.Size(80, 13);
            this.lblTAddress.TabIndex = 5;
            this.lblTAddress.Text = "Property Name:";
            // 
            // txtTAddress
            // 
            this.txtTAddress.Location = new System.Drawing.Point(97, 65);
            this.txtTAddress.Name = "txtTAddress";
            this.txtTAddress.Size = new System.Drawing.Size(326, 20);
            this.txtTAddress.TabIndex = 4;
            // 
            // txtTLotNo
            // 
            this.txtTLotNo.Location = new System.Drawing.Point(97, 39);
            this.txtTLotNo.Name = "txtTLotNo";
            this.txtTLotNo.Size = new System.Drawing.Size(326, 20);
            this.txtTLotNo.TabIndex = 3;
            // 
            // lblTLotNO
            // 
            this.lblTLotNO.AutoSize = true;
            this.lblTLotNO.Location = new System.Drawing.Point(49, 42);
            this.lblTLotNO.Name = "lblTLotNO";
            this.lblTLotNO.Size = new System.Drawing.Size(42, 13);
            this.lblTLotNO.TabIndex = 2;
            this.lblTLotNO.Text = "Lot No:";
            // 
            // txtTCompanyName
            // 
            this.txtTCompanyName.Location = new System.Drawing.Point(97, 13);
            this.txtTCompanyName.Name = "txtTCompanyName";
            this.txtTCompanyName.Size = new System.Drawing.Size(326, 20);
            this.txtTCompanyName.TabIndex = 1;
            // 
            // lblTCompanyName
            // 
            this.lblTCompanyName.AutoSize = true;
            this.lblTCompanyName.Location = new System.Drawing.Point(6, 16);
            this.lblTCompanyName.Name = "lblTCompanyName";
            this.lblTCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblTCompanyName.TabIndex = 0;
            this.lblTCompanyName.Text = "Company Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(295, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Tenant";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(214, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(133, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbTenants
            // 
            this.cbTenants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenants.FormattingEnabled = true;
            this.cbTenants.Location = new System.Drawing.Point(6, 19);
            this.cbTenants.Name = "cbTenants";
            this.cbTenants.Size = new System.Drawing.Size(121, 21);
            this.cbTenants.TabIndex = 0;
            // 
            // lblDuePayments
            // 
            this.lblDuePayments.AutoSize = true;
            this.lblDuePayments.Location = new System.Drawing.Point(568, 196);
            this.lblDuePayments.Name = "lblDuePayments";
            this.lblDuePayments.Size = new System.Drawing.Size(85, 13);
            this.lblDuePayments.TabIndex = 4;
            this.lblDuePayments.Text = "0 due payments.";
            // 
            // btnRentals
            // 
            this.btnRentals.Location = new System.Drawing.Point(9, 54);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(103, 23);
            this.btnRentals.TabIndex = 3;
            this.btnRentals.Text = "View Rentals";
            this.btnRentals.UseVisualStyleBackColor = true;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnTenants
            // 
            this.btnTenants.Location = new System.Drawing.Point(9, 25);
            this.btnTenants.Name = "btnTenants";
            this.btnTenants.Size = new System.Drawing.Size(103, 23);
            this.btnTenants.TabIndex = 2;
            this.btnTenants.Text = "Tenants";
            this.btnTenants.UseVisualStyleBackColor = true;
            this.btnTenants.Click += new System.EventHandler(this.btnTenants_Click);
            // 
            // cMain
            // 
            this.cMain.Location = new System.Drawing.Point(571, 25);
            this.cMain.Name = "cMain";
            this.cMain.TabIndex = 1;
            // 
            // gOptions
            // 
            this.gOptions.Controls.Add(this.btnAbout);
            this.gOptions.Controls.Add(this.btnLogout);
            this.gOptions.Controls.Add(this.btnSettings);
            this.gOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gOptions.Location = new System.Drawing.Point(3, 420);
            this.gOptions.Name = "gOptions";
            this.gOptions.Size = new System.Drawing.Size(829, 48);
            this.gOptions.TabIndex = 3;
            this.gOptions.TabStop = false;
            this.gOptions.Text = "Options";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(648, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(9, 16);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 38);
            this.panel1.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(9, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(9, 83);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(103, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Tenants";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbSTenant
            // 
            this.cbSTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTenant.FormattingEnabled = true;
            this.cbSTenant.Location = new System.Drawing.Point(9, 112);
            this.cbSTenant.Name = "cbSTenant";
            this.cbSTenant.Size = new System.Drawing.Size(103, 21);
            this.cbSTenant.TabIndex = 6;
            this.cbSTenant.Visible = false;
            this.cbSTenant.SelectedIndexChanged += new System.EventHandler(this.cbSTenant_SelectedIndexChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(729, 16);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(835, 510);
            this.MinimumSize = new System.Drawing.Size(835, 510);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClose);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gControls.ResumeLayout(false);
            this.gControls.PerformLayout();
            this.gRentals.ResumeLayout(false);
            this.gRentals.PerformLayout();
            this.gRTenure.ResumeLayout(false);
            this.gRTenure.PerformLayout();
            this.gTenants.ResumeLayout(false);
            this.gECTenants.ResumeLayout(false);
            this.gECTenants.PerformLayout();
            this.gOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gControls;
        private System.Windows.Forms.GroupBox gOptions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblDuePayments;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnTenants;
        private System.Windows.Forms.MonthCalendar cMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gTenants;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbTenants;
        private System.Windows.Forms.GroupBox gECTenants;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTRemarks;
        private System.Windows.Forms.Label lblTRemarks;
        private System.Windows.Forms.TextBox txtTContact_Mobile;
        private System.Windows.Forms.Label lblTContact;
        private System.Windows.Forms.Label lblTAddress;
        private System.Windows.Forms.TextBox txtTAddress;
        private System.Windows.Forms.TextBox txtTLotNo;
        private System.Windows.Forms.Label lblTLotNO;
        private System.Windows.Forms.TextBox txtTCompanyName;
        private System.Windows.Forms.Label lblTCompanyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTContact_Email;
        private System.Windows.Forms.Label lblLandLine;
        private System.Windows.Forms.TextBox txtTContact_Landline;
        private System.Windows.Forms.GroupBox gRentals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRTenant;
        private System.Windows.Forms.GroupBox gRTenure;
        private System.Windows.Forms.Label lblRLotNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtREnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtRStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRReceivable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRCumulative;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRMonthly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRSave;
        private System.Windows.Forms.Button btnRRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbSTenant;
        private System.Windows.Forms.Button btnAbout;

    }
}