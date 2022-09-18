namespace WeightGain.UI
{
    partial class ProfileForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nupHeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nupWeight = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblName.Location = new System.Drawing.Point(6, 14);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Adınız: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblLastName.Location = new System.Drawing.Point(6, 60);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(120, 30);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Soyadınız: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblEmail.Location = new System.Drawing.Point(6, 106);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(159, 30);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Mail Adresiniz:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblTelephone.Location = new System.Drawing.Point(6, 152);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(205, 30);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Telefon Numaranız:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblBirthDate.Location = new System.Drawing.Point(6, 199);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(181, 30);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Doğum Tarihiniz:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblWeight.Location = new System.Drawing.Point(6, 244);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(94, 30);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Kilonuz:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblHeight.Location = new System.Drawing.Point(6, 290);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(105, 30);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Boyunuz:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(235, 14);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(412, 30);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(235, 60);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(412, 30);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(235, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(412, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.DefaultText = "";
            this.txtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.txtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.Location = new System.Drawing.Point(235, 152);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.Size = new System.Drawing.Size(412, 30);
            this.txtTelephone.TabIndex = 3;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
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
            this.dtpBirthDate.Location = new System.Drawing.Point(235, 198);
            this.dtpBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(412, 36);
            this.dtpBirthDate.TabIndex = 4;
            this.dtpBirthDate.Value = new System.DateTime(2022, 9, 15, 11, 44, 50, 634);
            // 
            // nupHeight
            // 
            this.nupHeight.BackColor = System.Drawing.Color.Transparent;
            this.nupHeight.BorderRadius = 6;
            this.nupHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupHeight.DecimalPlaces = 1;
            this.nupHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.nupHeight.Location = new System.Drawing.Point(235, 290);
            this.nupHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupHeight.Name = "nupHeight";
            this.nupHeight.Size = new System.Drawing.Size(156, 36);
            this.nupHeight.TabIndex = 6;
            // 
            // nupWeight
            // 
            this.nupWeight.BackColor = System.Drawing.Color.Transparent;
            this.nupWeight.BorderRadius = 6;
            this.nupWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupWeight.DecimalPlaces = 2;
            this.nupWeight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(116)))), ((int)(((byte)(196)))));
            this.nupWeight.Location = new System.Drawing.Point(235, 244);
            this.nupWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupWeight.Name = "nupWeight";
            this.nupWeight.Size = new System.Drawing.Size(156, 36);
            this.nupWeight.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(235, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(412, 53);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Kayıt Et";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(235, 336);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(412, 30);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lblPassword.Location = new System.Drawing.Point(6, 336);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 30);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Şifreniz:";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.DefaultText = "";
            this.txtPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(118)))), ((int)(((byte)(195)))));
            this.txtPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword2.Location = new System.Drawing.Point(235, 382);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '\0';
            this.txtPassword2.PlaceholderText = "";
            this.txtPassword2.SelectedText = "";
            this.txtPassword2.Size = new System.Drawing.Size(412, 30);
            this.txtPassword2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(6, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tekrar Şifreniz: ";
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.lblBirthDate);
            this.pnlProfile.Controls.Add(this.btnSave);
            this.pnlProfile.Controls.Add(this.txtPassword2);
            this.pnlProfile.Controls.Add(this.lblName);
            this.pnlProfile.Controls.Add(this.label2);
            this.pnlProfile.Controls.Add(this.lblLastName);
            this.pnlProfile.Controls.Add(this.txtPassword);
            this.pnlProfile.Controls.Add(this.lblEmail);
            this.pnlProfile.Controls.Add(this.lblPassword);
            this.pnlProfile.Controls.Add(this.lblTelephone);
            this.pnlProfile.Controls.Add(this.lblWeight);
            this.pnlProfile.Controls.Add(this.nupHeight);
            this.pnlProfile.Controls.Add(this.lblHeight);
            this.pnlProfile.Controls.Add(this.nupWeight);
            this.pnlProfile.Controls.Add(this.txtFirstName);
            this.pnlProfile.Controls.Add(this.dtpBirthDate);
            this.pnlProfile.Controls.Add(this.txtLastName);
            this.pnlProfile.Controls.Add(this.txtTelephone);
            this.pnlProfile.Controls.Add(this.txtEmail);
            this.pnlProfile.Location = new System.Drawing.Point(12, 12);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(678, 514);
            this.pnlProfile.TabIndex = 17;
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 547);
            this.Controls.Add(this.pnlProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWeight)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephone;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupHeight;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupWeight;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2Panel pnlProfile;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
    }
}