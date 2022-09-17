namespace WeightGain.UI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.leftMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.leftPanelMenuLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.leftMenuLunchImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.leftMenuExerciseImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.leftMenuReportImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.leftMenuArchiveImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.leftMenuProfileImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.leftMenuHelpImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.leftMenuLogoutImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblMenuLunchs = new System.Windows.Forms.Label();
            this.lblMenuExercises = new System.Windows.Forms.Label();
            this.lblMenuReports = new System.Windows.Forms.Label();
            this.lblMenuArchives = new System.Windows.Forms.Label();
            this.lblMenuProfile = new System.Windows.Forms.Label();
            this.lblMenuHelp = new System.Windows.Forms.Label();
            this.lblMenuLogout = new System.Windows.Forms.Label();
            this.leftMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelMenuLogo)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuLunchImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuExerciseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuReportImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuArchiveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuHelpImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuLogoutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.leftMenuPanel.Controls.Add(this.lblMenuLogout);
            this.leftMenuPanel.Controls.Add(this.lblMenuHelp);
            this.leftMenuPanel.Controls.Add(this.lblMenuProfile);
            this.leftMenuPanel.Controls.Add(this.lblMenuArchives);
            this.leftMenuPanel.Controls.Add(this.lblMenuReports);
            this.leftMenuPanel.Controls.Add(this.lblMenuExercises);
            this.leftMenuPanel.Controls.Add(this.lblMenuLunchs);
            this.leftMenuPanel.Controls.Add(this.leftMenuLogoutImage);
            this.leftMenuPanel.Controls.Add(this.leftMenuHelpImage);
            this.leftMenuPanel.Controls.Add(this.leftMenuProfileImage);
            this.leftMenuPanel.Controls.Add(this.leftMenuArchiveImage);
            this.leftMenuPanel.Controls.Add(this.leftMenuReportImage);
            this.leftMenuPanel.Controls.Add(this.leftMenuExerciseImage);
            this.leftMenuPanel.Controls.Add(this.leftMenuLunchImage);
            this.leftMenuPanel.Controls.Add(this.leftPanelMenuLogo);
            this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMenuPanel.Name = "leftMenuPanel";
            this.leftMenuPanel.Size = new System.Drawing.Size(233, 727);
            this.leftMenuPanel.TabIndex = 0;
            this.leftMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.leftMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.leftMenuPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // leftPanelMenuLogo
            // 
            this.leftPanelMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftPanelMenuLogo.Image = global::WeightGain.UI.Properties.Resources.WGLogo;
            this.leftPanelMenuLogo.ImageRotate = 0F;
            this.leftPanelMenuLogo.Location = new System.Drawing.Point(3, 3);
            this.leftPanelMenuLogo.Name = "leftPanelMenuLogo";
            this.leftPanelMenuLogo.Size = new System.Drawing.Size(230, 231);
            this.leftPanelMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPanelMenuLogo.TabIndex = 0;
            this.leftPanelMenuLogo.TabStop = false;
            this.leftPanelMenuLogo.UseTransparentBackground = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnClose.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnClose.Location = new System.Drawing.Point(1055, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 32);
            this.btnClose.TabIndex = 6;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(233, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1100, 32);
            this.topPanel.TabIndex = 7;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(233, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 695);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // leftMenuLunchImage
            // 
            this.leftMenuLunchImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuLunchImage.Image = global::WeightGain.UI.Properties.Resources.lunch;
            this.leftMenuLunchImage.ImageRotate = 0F;
            this.leftMenuLunchImage.Location = new System.Drawing.Point(3, 240);
            this.leftMenuLunchImage.Name = "leftMenuLunchImage";
            this.leftMenuLunchImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuLunchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuLunchImage.TabIndex = 1;
            this.leftMenuLunchImage.TabStop = false;
            this.leftMenuLunchImage.UseTransparentBackground = true;
            // 
            // leftMenuExerciseImage
            // 
            this.leftMenuExerciseImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuExerciseImage.Image = global::WeightGain.UI.Properties.Resources.exercise;
            this.leftMenuExerciseImage.ImageRotate = 0F;
            this.leftMenuExerciseImage.Location = new System.Drawing.Point(3, 310);
            this.leftMenuExerciseImage.Name = "leftMenuExerciseImage";
            this.leftMenuExerciseImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuExerciseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuExerciseImage.TabIndex = 2;
            this.leftMenuExerciseImage.TabStop = false;
            this.leftMenuExerciseImage.UseTransparentBackground = true;
            // 
            // leftMenuReportImage
            // 
            this.leftMenuReportImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuReportImage.Image = global::WeightGain.UI.Properties.Resources.reports;
            this.leftMenuReportImage.ImageRotate = 0F;
            this.leftMenuReportImage.Location = new System.Drawing.Point(3, 380);
            this.leftMenuReportImage.Name = "leftMenuReportImage";
            this.leftMenuReportImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuReportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuReportImage.TabIndex = 3;
            this.leftMenuReportImage.TabStop = false;
            this.leftMenuReportImage.UseTransparentBackground = true;
            // 
            // leftMenuArchiveImage
            // 
            this.leftMenuArchiveImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuArchiveImage.Image = global::WeightGain.UI.Properties.Resources.archive;
            this.leftMenuArchiveImage.ImageRotate = 0F;
            this.leftMenuArchiveImage.Location = new System.Drawing.Point(3, 450);
            this.leftMenuArchiveImage.Name = "leftMenuArchiveImage";
            this.leftMenuArchiveImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuArchiveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuArchiveImage.TabIndex = 4;
            this.leftMenuArchiveImage.TabStop = false;
            this.leftMenuArchiveImage.UseTransparentBackground = true;
            // 
            // leftMenuProfileImage
            // 
            this.leftMenuProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuProfileImage.Image = global::WeightGain.UI.Properties.Resources.profile;
            this.leftMenuProfileImage.ImageRotate = 0F;
            this.leftMenuProfileImage.Location = new System.Drawing.Point(3, 520);
            this.leftMenuProfileImage.Name = "leftMenuProfileImage";
            this.leftMenuProfileImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuProfileImage.TabIndex = 5;
            this.leftMenuProfileImage.TabStop = false;
            this.leftMenuProfileImage.UseTransparentBackground = true;
            // 
            // leftMenuHelpImage
            // 
            this.leftMenuHelpImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuHelpImage.Image = global::WeightGain.UI.Properties.Resources.help;
            this.leftMenuHelpImage.ImageRotate = 0F;
            this.leftMenuHelpImage.Location = new System.Drawing.Point(3, 590);
            this.leftMenuHelpImage.Name = "leftMenuHelpImage";
            this.leftMenuHelpImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuHelpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuHelpImage.TabIndex = 6;
            this.leftMenuHelpImage.TabStop = false;
            this.leftMenuHelpImage.UseTransparentBackground = true;
            // 
            // leftMenuLogoutImage
            // 
            this.leftMenuLogoutImage.BackColor = System.Drawing.Color.Transparent;
            this.leftMenuLogoutImage.Image = global::WeightGain.UI.Properties.Resources.logout;
            this.leftMenuLogoutImage.ImageRotate = 0F;
            this.leftMenuLogoutImage.Location = new System.Drawing.Point(3, 660);
            this.leftMenuLogoutImage.Name = "leftMenuLogoutImage";
            this.leftMenuLogoutImage.Size = new System.Drawing.Size(64, 64);
            this.leftMenuLogoutImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftMenuLogoutImage.TabIndex = 7;
            this.leftMenuLogoutImage.TabStop = false;
            this.leftMenuLogoutImage.UseTransparentBackground = true;
            // 
            // lblMenuLunchs
            // 
            this.lblMenuLunchs.AutoSize = true;
            this.lblMenuLunchs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuLunchs.Location = new System.Drawing.Point(73, 260);
            this.lblMenuLunchs.Name = "lblMenuLunchs";
            this.lblMenuLunchs.Size = new System.Drawing.Size(93, 30);
            this.lblMenuLunchs.TabIndex = 8;
            this.lblMenuLunchs.Text = "Öğünler";
            this.lblMenuLunchs.Click += new System.EventHandler(this.lblMenuLunchs_Click);
            // 
            // lblMenuExercises
            // 
            this.lblMenuExercises.AutoSize = true;
            this.lblMenuExercises.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuExercises.Location = new System.Drawing.Point(73, 328);
            this.lblMenuExercises.Name = "lblMenuExercises";
            this.lblMenuExercises.Size = new System.Drawing.Size(136, 30);
            this.lblMenuExercises.TabIndex = 9;
            this.lblMenuExercises.Text = "Antremanlar";
            this.lblMenuExercises.Click += new System.EventHandler(this.lblMenuExercises_Click);
            // 
            // lblMenuReports
            // 
            this.lblMenuReports.AutoSize = true;
            this.lblMenuReports.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuReports.Location = new System.Drawing.Point(73, 398);
            this.lblMenuReports.Name = "lblMenuReports";
            this.lblMenuReports.Size = new System.Drawing.Size(97, 30);
            this.lblMenuReports.TabIndex = 10;
            this.lblMenuReports.Text = "Raporlar";
            this.lblMenuReports.Click += new System.EventHandler(this.lblMenuReports_Click);
            // 
            // lblMenuArchives
            // 
            this.lblMenuArchives.AutoSize = true;
            this.lblMenuArchives.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuArchives.Location = new System.Drawing.Point(73, 470);
            this.lblMenuArchives.Name = "lblMenuArchives";
            this.lblMenuArchives.Size = new System.Drawing.Size(87, 30);
            this.lblMenuArchives.TabIndex = 11;
            this.lblMenuArchives.Text = "Arşivler";
            this.lblMenuArchives.Click += new System.EventHandler(this.lblMenuArchives_Click);
            // 
            // lblMenuProfile
            // 
            this.lblMenuProfile.AutoSize = true;
            this.lblMenuProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuProfile.Location = new System.Drawing.Point(73, 534);
            this.lblMenuProfile.Name = "lblMenuProfile";
            this.lblMenuProfile.Size = new System.Drawing.Size(148, 30);
            this.lblMenuProfile.TabIndex = 12;
            this.lblMenuProfile.Text = "Profil Bilgileri";
            this.lblMenuProfile.Click += new System.EventHandler(this.lblMenuProfile_Click);
            // 
            // lblMenuHelp
            // 
            this.lblMenuHelp.AutoSize = true;
            this.lblMenuHelp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuHelp.Location = new System.Drawing.Point(73, 603);
            this.lblMenuHelp.Name = "lblMenuHelp";
            this.lblMenuHelp.Size = new System.Drawing.Size(81, 30);
            this.lblMenuHelp.TabIndex = 13;
            this.lblMenuHelp.Text = "Yardım";
            this.lblMenuHelp.Click += new System.EventHandler(this.lblMenuHelp_Click);
            // 
            // lblMenuLogout
            // 
            this.lblMenuLogout.AutoSize = true;
            this.lblMenuLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenuLogout.Location = new System.Drawing.Point(73, 673);
            this.lblMenuLogout.Name = "lblMenuLogout";
            this.lblMenuLogout.Size = new System.Drawing.Size(59, 30);
            this.lblMenuLogout.TabIndex = 14;
            this.lblMenuLogout.Text = "Çıkış";
            this.lblMenuLogout.Click += new System.EventHandler(this.lblMenuLogout_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftMenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            this.leftMenuPanel.ResumeLayout(false);
            this.leftMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelMenuLogo)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuLunchImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuExerciseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuReportImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuArchiveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuHelpImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenuLogoutImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Panel leftMenuPanel;
        private Guna.UI2.WinForms.Guna2PictureBox leftPanelMenuLogo;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuLunchImage;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuLogoutImage;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuHelpImage;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuProfileImage;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuArchiveImage;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuReportImage;
        private Guna.UI2.WinForms.Guna2PictureBox leftMenuExerciseImage;
        private System.Windows.Forms.Label lblMenuLunchs;
        private System.Windows.Forms.Label lblMenuLogout;
        private System.Windows.Forms.Label lblMenuHelp;
        private System.Windows.Forms.Label lblMenuProfile;
        private System.Windows.Forms.Label lblMenuArchives;
        private System.Windows.Forms.Label lblMenuReports;
        private System.Windows.Forms.Label lblMenuExercises;
    }
}