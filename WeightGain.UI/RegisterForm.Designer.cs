using System;

namespace WeightGain.UI
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
            this.cbAgree = new System.Windows.Forms.CheckBox();
            this.btnRead = new Guna.UI2.WinForms.Guna2Button();
            this.pbStr = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbFemale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbMale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.nudHeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainFormLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblAlready = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
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
            this.formRightPanel.Controls.Add(this.cbAgree);
            this.formRightPanel.Controls.Add(this.btnRead);
            this.formRightPanel.Controls.Add(this.pbStr);
            this.formRightPanel.Controls.Add(this.lblTerms);
            this.formRightPanel.Controls.Add(this.lblGender);
            this.formRightPanel.Controls.Add(this.cbFemale);
            this.formRightPanel.Controls.Add(this.cbMale);
            this.formRightPanel.Controls.Add(this.btnSignUp);
            this.formRightPanel.Controls.Add(this.txtPassword);
            this.formRightPanel.Controls.Add(this.lblHeight);
            this.formRightPanel.Controls.Add(this.lblWeight);
            this.formRightPanel.Controls.Add(this.nudHeight);
            this.formRightPanel.Controls.Add(this.nudWeight);
            this.formRightPanel.Controls.Add(this.txtPhoneNumber);
            this.formRightPanel.Controls.Add(this.txtEmail);
            this.formRightPanel.Controls.Add(this.dtpBirthDate);
            this.formRightPanel.Controls.Add(this.txtLastname);
            this.formRightPanel.Controls.Add(this.lblSignUp);
            this.formRightPanel.Controls.Add(this.txtName);
            this.formRightPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.formRightPanel.Location = new System.Drawing.Point(518, 13);
            this.formRightPanel.Name = "formRightPanel";
            this.formRightPanel.Size = new System.Drawing.Size(311, 567);
            this.formRightPanel.TabIndex = 0;
            // 
            // cbAgree
            // 
            this.cbAgree.AutoSize = true;
            this.cbAgree.BackColor = System.Drawing.Color.Transparent;
            this.cbAgree.Enabled = false;
            this.cbAgree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAgree.ForeColor = System.Drawing.Color.White;
            this.cbAgree.Location = new System.Drawing.Point(94, 516);
            this.cbAgree.Name = "cbAgree";
            this.cbAgree.Size = new System.Drawing.Size(125, 21);
            this.cbAgree.TabIndex = 23;
            this.cbAgree.Text = "Kabul Ediyorum";
            this.cbAgree.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            this.btnRead.Animated = true;
            this.btnRead.BackColor = System.Drawing.Color.Transparent;
            this.btnRead.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.btnRead.BorderRadius = 6;
            this.btnRead.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRead.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRead.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRead.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.btnRead.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(28, 466);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(262, 47);
            this.btnRead.TabIndex = 22;
            this.btnRead.Text = "KVKK Metni okumak için tıklayınız";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // pbStr
            // 
            this.pbStr.Location = new System.Drawing.Point(28, 253);
            this.pbStr.Name = "pbStr";
            this.pbStr.Size = new System.Drawing.Size(260, 11);
            this.pbStr.TabIndex = 14;
            this.pbStr.Text = "guna2ProgressBar1";
            this.pbStr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.BackColor = System.Drawing.Color.Transparent;
            this.lblTerms.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lblTerms.Location = new System.Drawing.Point(24, 540);
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
            this.lblGender.Location = new System.Drawing.Point(22, 308);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 21);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Cinsiyetiniz";
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.cbFemale.Checked = true;
            this.cbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFemale.CheckedState.BorderRadius = 0;
            this.cbFemale.CheckedState.BorderThickness = 0;
            this.cbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFemale.Enabled = false;
            this.cbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.cbFemale.Location = new System.Drawing.Point(215, 307);
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
            this.cbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMale.CheckedState.BorderRadius = 0;
            this.cbMale.CheckedState.BorderThickness = 0;
            this.cbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMale.Enabled = false;
            this.cbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.cbMale.Location = new System.Drawing.Point(127, 307);
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
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignUp.Location = new System.Drawing.Point(26, 417);
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
            this.txtPassword.IconRight = global::WeightGain.UI.Properties.Resources.showpass;
            this.txtPassword.Location = new System.Drawing.Point(26, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtPassword.PlaceholderText = "Şifreniz";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(262, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.IconRightClick += new System.EventHandler(this.txtPassword_IconRightClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.lblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.lblHeight.Location = new System.Drawing.Point(22, 380);
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
            this.lblWeight.Location = new System.Drawing.Point(22, 341);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(68, 21);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Kilonuz";
            // 
            // nudHeight
            // 
            this.nudHeight.BackColor = System.Drawing.Color.Transparent;
            this.nudHeight.BorderRadius = 6;
            this.nudHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHeight.DecimalPlaces = 1;
            this.nudHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.nudHeight.Location = new System.Drawing.Point(127, 375);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(156, 36);
            this.nudHeight.TabIndex = 9;
            // 
            // nudWeight
            // 
            this.nudWeight.BackColor = System.Drawing.Color.Transparent;
            this.nudWeight.BorderRadius = 6;
            this.nudWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudWeight.DecimalPlaces = 2;
            this.nudWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.nudWeight.Location = new System.Drawing.Point(127, 333);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(156, 36);
            this.nudWeight.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Animated = true;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNumber.BorderRadius = 6;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(26, 170);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtPhoneNumber.PlaceholderText = "Telefon Numaranız";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(262, 36);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephoneNumber_KeyPress);
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
            this.txtEmail.Location = new System.Drawing.Point(26, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtEmail.PlaceholderText = "Mail Adresiniz";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(262, 36);
            this.txtEmail.TabIndex = 2;
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
            this.dtpBirthDate.Location = new System.Drawing.Point(26, 267);
            this.dtpBirthDate.MaxDate = new System.DateTime(2022, 9, 23, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(262, 36);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2022, 9, 23, 0, 0, 0, 0);
            // 
            // txtLastname
            // 
            this.txtLastname.Animated = true;
            this.txtLastname.BackColor = System.Drawing.Color.Transparent;
            this.txtLastname.BorderRadius = 6;
            this.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastname.DefaultText = "";
            this.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastname.Location = new System.Drawing.Point(26, 86);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.txtLastname.PlaceholderText = "Soyadınız";
            this.txtLastname.SelectedText = "";
            this.txtLastname.Size = new System.Drawing.Size(262, 36);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.lblSignUp.Location = new System.Drawing.Point(113, 10);
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
            this.txtName.Location = new System.Drawing.Point(26, 44);
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
            this.ClientSize = new System.Drawing.Size(841, 592);
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
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            this.formRightPanel.ResumeLayout(false);
            this.formRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txtLastname;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHeight;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2CheckBox cbFemale;
        private Guna.UI2.WinForms.Guna2CheckBox cbMale;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblTerms;
        private Guna.UI2.WinForms.Guna2ProgressBar pbStr;
        private Guna.UI2.WinForms.Guna2Button btnRead;
        private System.Windows.Forms.CheckBox cbAgree;
    }
}

