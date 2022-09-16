﻿namespace WeightGain.UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.formRightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbFemale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.nupHeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nupWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtTelephoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainFormLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblAlready = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // formRightPanel
            // 
            this.formRightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.formRightPanel.BorderRadius = 15;
            this.formRightPanel.Controls.Add(this.lblTerms);
            this.formRightPanel.Controls.Add(this.lblGender);
            this.formRightPanel.Controls.Add(this.cbFemale);
            this.formRightPanel.Controls.Add(this.cbMale);
            this.formRightPanel.Controls.Add(this.btnSignUp);
            this.formRightPanel.Controls.Add(this.txtPassword);
            this.formRightPanel.Controls.Add(this.lblHeight);
            this.formRightPanel.Controls.Add(this.lblWeight);
            this.formRightPanel.Controls.Add(this.nupHeight);
            this.formRightPanel.Controls.Add(this.nupWeight);
            this.formRightPanel.Controls.Add(this.txtTelephoneNumber);
            this.formRightPanel.Controls.Add(this.txtEmail);
            this.formRightPanel.Controls.Add(this.dtpBirthDate);
            this.formRightPanel.Controls.Add(this.txtSurname);
            this.formRightPanel.Controls.Add(this.lblSignUp);
            this.formRightPanel.Controls.Add(this.txtName);
            this.formRightPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.formRightPanel.Location = new System.Drawing.Point(518, 13);
            this.formRightPanel.Name = "formRightPanel";
            this.formRightPanel.Size = new System.Drawing.Size(311, 504);
            this.formRightPanel.TabIndex = 0;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.BackColor = System.Drawing.Color.Transparent;
            this.lblTerms.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblTerms.Location = new System.Drawing.Point(24, 479);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(264, 24);
            this.lblTerms.TabIndex = 13;
            this.lblTerms.Text = "Üye olduğunuz zaman kullanım koşullarını kabul etmiş \r\nsayılırsınız.";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.lblGender.Location = new System.Drawing.Point(22, 315);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 21);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Cinsiyetiniz";
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.cbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFemale.CheckedState.BorderRadius = 0;
            this.cbFemale.CheckedState.BorderThickness = 0;
            this.cbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.cbFemale.Location = new System.Drawing.Point(215, 314);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(73, 25);
            this.cbFemale.TabIndex = 7;
            this.cbFemale.Text = "Kadın";
            this.cbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cbFemale.UncheckedState.BorderRadius = 0;
            this.cbFemale.UncheckedState.BorderThickness = 0;
            this.cbFemale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cbFemale.UseVisualStyleBackColor = false;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.cbFemale_CheckedChanged);
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.cbMale.Checked = true;
            this.cbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMale.CheckedState.BorderRadius = 0;
            this.cbMale.CheckedState.BorderThickness = 0;
            this.cbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.cbMale.Location = new System.Drawing.Point(127, 314);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(71, 25);
            this.cbMale.TabIndex = 6;
            this.cbMale.Text = "Erkek";
            this.cbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cbMale.UncheckedState.BorderRadius = 0;
            this.cbMale.UncheckedState.BorderThickness = 0;
            this.cbMale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cbMale.UseVisualStyleBackColor = false;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Animated = true;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.btnSignUp.BorderRadius = 6;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.Location = new System.Drawing.Point(26, 431);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(262, 45);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 6;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(26, 221);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtPassword.PlaceholderText = "Şifreniz";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(262, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.lblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.lblHeight.Location = new System.Drawing.Point(22, 394);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(77, 21);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Boyunuz";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.lblWeight.Location = new System.Drawing.Point(22, 355);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(68, 21);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Kilonuz";
            // 
            // nupHeight
            // 
            this.nupHeight.BackColor = System.Drawing.Color.Transparent;
            this.nupHeight.BorderRadius = 6;
            this.nupHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupHeight.DecimalPlaces = 1;
            this.nupHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.nupHeight.Location = new System.Drawing.Point(127, 389);
            this.nupHeight.Name = "nupHeight";
            this.nupHeight.Size = new System.Drawing.Size(156, 36);
            this.nupHeight.TabIndex = 9;
            // 
            // nupWeight
            // 
            this.nupWeight.BackColor = System.Drawing.Color.Transparent;
            this.nupWeight.BorderRadius = 6;
            this.nupWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupWeight.DecimalPlaces = 2;
            this.nupWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.nupWeight.Location = new System.Drawing.Point(127, 347);
            this.nupWeight.Name = "nupWeight";
            this.nupWeight.Size = new System.Drawing.Size(156, 36);
            this.nupWeight.TabIndex = 8;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Animated = true;
            this.txtTelephoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtTelephoneNumber.BorderRadius = 6;
            this.txtTelephoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephoneNumber.DefaultText = "";
            this.txtTelephoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelephoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtTelephoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephoneNumber.Location = new System.Drawing.Point(26, 179);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.PasswordChar = '\0';
            this.txtTelephoneNumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtTelephoneNumber.PlaceholderText = "Telefon Numaranız";
            this.txtTelephoneNumber.SelectedText = "";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(262, 36);
            this.txtTelephoneNumber.TabIndex = 3;
            this.txtTelephoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephoneNumber_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(26, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtEmail.PlaceholderText = "Mail Adresiniz";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(262, 36);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpBirthDate.BorderRadius = 6;
            this.dtpBirthDate.Checked = true;
            this.dtpBirthDate.FillColor = System.Drawing.Color.White;
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.ForeColor = System.Drawing.Color.Black;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthDate.Location = new System.Drawing.Point(26, 263);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(262, 36);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2022, 9, 15, 11, 44, 50, 634);
            // 
            // txtSurname
            // 
            this.txtSurname.Animated = true;
            this.txtSurname.BackColor = System.Drawing.Color.Transparent;
            this.txtSurname.BorderRadius = 6;
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.DefaultText = "";
            this.txtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSurname.Location = new System.Drawing.Point(26, 95);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtSurname.PlaceholderText = "Soyadınız";
            this.txtSurname.SelectedText = "";
            this.txtSurname.Size = new System.Drawing.Size(262, 36);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.lblSignUp.Location = new System.Drawing.Point(113, 13);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(78, 30);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Üye Ol";
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 6;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(26, 53);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtName.PlaceholderText = "Adınız";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(262, 36);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // mainFormLogo
            // 
            this.mainFormLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainFormLogo.Image")));
            this.mainFormLogo.ImageRotate = 0F;
            this.mainFormLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("mainFormLogo.InitialImage")));
            this.mainFormLogo.Location = new System.Drawing.Point(12, 57);
            this.mainFormLogo.Name = "mainFormLogo";
            this.mainFormLogo.Size = new System.Drawing.Size(500, 342);
            this.mainFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainFormLogo.TabIndex = 1;
            this.mainFormLogo.TabStop = false;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblSlogan.Location = new System.Drawing.Point(170, 33);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(186, 21);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Buraya slogan gelebilir";
            // 
            // lblAlready
            // 
            this.lblAlready.AutoSize = true;
            this.lblAlready.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblAlready.Location = new System.Drawing.Point(117, 496);
            this.lblAlready.Name = "lblAlready";
            this.lblAlready.Size = new System.Drawing.Size(193, 21);
            this.lblAlready.TabIndex = 3;
            this.lblAlready.Text = "Zaten üyeliğiniz var mı?";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.lblLogin.Location = new System.Drawing.Point(316, 496);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(95, 21);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Giriş yapın.";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.btnClose.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(841, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblAlready);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.mainFormLogo);
            this.Controls.Add(this.formRightPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(3200, 1680);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyet Programı";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.formRightPanel.ResumeLayout(false);
            this.formRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Panel formRightPanel;
        private Guna.UI2.WinForms.Guna2PictureBox mainFormLogo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAlready;
        private System.Windows.Forms.Label lblSlogan;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label lblSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephoneNumber;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupHeight;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2CheckBox cbFemale;
        private Guna.UI2.WinForms.Guna2CheckBox cbMale;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTerms;
    }
}
