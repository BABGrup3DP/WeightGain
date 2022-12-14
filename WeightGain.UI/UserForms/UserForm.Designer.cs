namespace WeightGain.UI.UserForms
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
            this.btnMealTimes = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnHelp = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMealTimes = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnExercies = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.leftPanelMenuLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.leftMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelMenuLogo)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.leftMenuPanel.Controls.Add(this.btnMealTimes);
            this.leftMenuPanel.Controls.Add(this.btnLogout);
            this.leftMenuPanel.Controls.Add(this.btnHelp);
            this.leftMenuPanel.Controls.Add(this.btnAddMealTimes);
            this.leftMenuPanel.Controls.Add(this.btnProfile);
            this.leftMenuPanel.Controls.Add(this.btnExercies);
            this.leftMenuPanel.Controls.Add(this.btnReports);
            this.leftMenuPanel.Controls.Add(this.leftPanelMenuLogo);
            this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftMenuPanel.Name = "leftMenuPanel";
            this.leftMenuPanel.Size = new System.Drawing.Size(157, 541);
            this.leftMenuPanel.TabIndex = 0;
            this.leftMenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.leftMenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.leftMenuPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // btnMealTimes
            // 
            this.btnMealTimes.Animated = true;
            this.btnMealTimes.AnimatedGIF = true;
            this.btnMealTimes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnMealTimes.BorderRadius = 5;
            this.btnMealTimes.BorderThickness = 1;
            this.btnMealTimes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnMealTimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnMealTimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnMealTimes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnMealTimes.FocusedColor = System.Drawing.Color.Transparent;
            this.btnMealTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMealTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMealTimes.Image = global::WeightGain.UI.Properties.Resources.meals;
            this.btnMealTimes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMealTimes.ImageSize = new System.Drawing.Size(48, 48);
            this.btnMealTimes.Location = new System.Drawing.Point(4, 177);
            this.btnMealTimes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMealTimes.Name = "btnMealTimes";
            this.btnMealTimes.PressedColor = System.Drawing.Color.Transparent;
            this.btnMealTimes.Size = new System.Drawing.Size(149, 57);
            this.btnMealTimes.TabIndex = 7;
            this.btnMealTimes.Text = "Öğünler";
            this.btnMealTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMealTimes.Click += new System.EventHandler(this.btnMealTimes_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.AnimatedGIF = true;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogout.Image = global::WeightGain.UI.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(48, 48);
            this.btnLogout.Location = new System.Drawing.Point(5, 482);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 57);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Çıkış";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Animated = true;
            this.btnHelp.AnimatedGIF = true;
            this.btnHelp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnHelp.BorderRadius = 5;
            this.btnHelp.BorderThickness = 1;
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnHelp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHelp.Image = global::WeightGain.UI.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.ImageSize = new System.Drawing.Size(48, 48);
            this.btnHelp.Location = new System.Drawing.Point(5, 421);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(149, 57);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Yardım";
            this.btnHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAddMealTimes
            // 
            this.btnAddMealTimes.Animated = true;
            this.btnAddMealTimes.AnimatedGIF = true;
            this.btnAddMealTimes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnAddMealTimes.BorderRadius = 5;
            this.btnAddMealTimes.BorderThickness = 1;
            this.btnAddMealTimes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnAddMealTimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnAddMealTimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnAddMealTimes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnAddMealTimes.FocusedColor = System.Drawing.Color.Transparent;
            this.btnAddMealTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMealTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddMealTimes.Image = global::WeightGain.UI.Properties.Resources.lunch;
            this.btnAddMealTimes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddMealTimes.ImageSize = new System.Drawing.Size(48, 48);
            this.btnAddMealTimes.Location = new System.Drawing.Point(4, 116);
            this.btnAddMealTimes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMealTimes.Name = "btnAddMealTimes";
            this.btnAddMealTimes.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddMealTimes.Size = new System.Drawing.Size(149, 57);
            this.btnAddMealTimes.TabIndex = 0;
            this.btnAddMealTimes.Text = "Öğün Ekle";
            this.btnAddMealTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddMealTimes.Click += new System.EventHandler(this.btnAddMealTimes_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.AnimatedGIF = true;
            this.btnProfile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnProfile.BorderRadius = 5;
            this.btnProfile.BorderThickness = 1;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnProfile.Image = global::WeightGain.UI.Properties.Resources.profile;
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.ImageSize = new System.Drawing.Size(48, 48);
            this.btnProfile.Location = new System.Drawing.Point(5, 360);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(149, 57);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profil Bilgileri";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnExercies
            // 
            this.btnExercies.Animated = true;
            this.btnExercies.AnimatedGIF = true;
            this.btnExercies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnExercies.BorderRadius = 5;
            this.btnExercies.BorderThickness = 1;
            this.btnExercies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnExercies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnExercies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnExercies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnExercies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExercies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExercies.Image = global::WeightGain.UI.Properties.Resources.exercise;
            this.btnExercies.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExercies.ImageSize = new System.Drawing.Size(48, 48);
            this.btnExercies.Location = new System.Drawing.Point(5, 238);
            this.btnExercies.Margin = new System.Windows.Forms.Padding(2);
            this.btnExercies.Name = "btnExercies";
            this.btnExercies.Size = new System.Drawing.Size(149, 57);
            this.btnExercies.TabIndex = 1;
            this.btnExercies.Text = "Antrenmanlar";
            this.btnExercies.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExercies.Click += new System.EventHandler(this.btnExercies_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.AnimatedGIF = true;
            this.btnReports.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnReports.BorderRadius = 5;
            this.btnReports.BorderThickness = 1;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(138)))), ((int)(((byte)(205)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnReports.Image = global::WeightGain.UI.Properties.Resources.reports;
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageSize = new System.Drawing.Size(48, 48);
            this.btnReports.Location = new System.Drawing.Point(5, 299);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(149, 57);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Raporlar";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // leftPanelMenuLogo
            // 
            this.leftPanelMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftPanelMenuLogo.Image = global::WeightGain.UI.Properties.Resources.WGLogo;
            this.leftPanelMenuLogo.ImageRotate = 0F;
            this.leftPanelMenuLogo.Location = new System.Drawing.Point(-27, -28);
            this.leftPanelMenuLogo.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanelMenuLogo.Name = "leftPanelMenuLogo";
            this.leftPanelMenuLogo.Size = new System.Drawing.Size(224, 188);
            this.leftPanelMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPanelMenuLogo.TabIndex = 0;
            this.leftPanelMenuLogo.TabStop = false;
            this.leftPanelMenuLogo.UseTransparentBackground = true;
            this.leftPanelMenuLogo.Click += new System.EventHandler(this.leftPanelMenuLogo_Click);
            this.leftPanelMenuLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.leftPanelMenuLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.leftPanelMenuLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.btnClose.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(99)))), ((int)(((byte)(137)))));
            this.btnClose.Location = new System.Drawing.Point(947, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 26);
            this.btnClose.TabIndex = 6;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(157, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(983, 26);
            this.topPanel.TabIndex = 7;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(157, 26);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.MaximumSize = new System.Drawing.Size(983, 515);
            this.mainPanel.MinimumSize = new System.Drawing.Size(983, 515);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(983, 515);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1140, 541);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftMenuPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseUp);
            this.leftMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelMenuLogo)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Panel leftMenuPanel;
        private Guna.UI2.WinForms.Guna2PictureBox leftPanelMenuLogo;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnExercies;
        private Guna.UI2.WinForms.Guna2Button btnAddMealTimes;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnHelp;
        private Guna.UI2.WinForms.Guna2Button btnMealTimes;
    }
}