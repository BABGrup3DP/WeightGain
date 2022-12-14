namespace WeightGain.UI.UserForms
{
    partial class MainForm
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
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWeight = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHeight = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAge = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBmi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalOfDay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCal1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBmh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAgeText = new System.Windows.Forms.TextBox();
            this.txtWeightText = new System.Windows.Forms.TextBox();
            this.txtHeightText = new System.Windows.Forms.TextBox();
            this.txtBMH = new System.Windows.Forms.TextBox();
            this.txtGetCalory = new System.Windows.Forms.TextBox();
            this.lblDateNow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.leftPanelMenuLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSlogan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cpbCalory = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtCaloryNow = new System.Windows.Forms.TextBox();
            this.lblCal2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelMenuLogo)).BeginInit();
            this.cpbCalory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUser
            // 
            this.pbUser.Image = global::WeightGain.UI.Properties.Resources.femaleUser;
            this.pbUser.Location = new System.Drawing.Point(321, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(191, 201);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = false;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(321, 219);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(191, 55);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Kullanıcı1";
            this.lblUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(319, 313);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(50, 17);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Kilonuz :";
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHeight.Location = new System.Drawing.Point(312, 346);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Boyunuz :";
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(323, 280);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 17);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Yaşınız :";
            // 
            // lblBmi
            // 
            this.lblBmi.BackColor = System.Drawing.Color.Transparent;
            this.lblBmi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBmi.Location = new System.Drawing.Point(237, 378);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(132, 17);
            this.lblBmi.TabIndex = 3;
            this.lblBmi.Text = "Vücut Kitle Endeksiniz :";
            // 
            // lblCalOfDay
            // 
            this.lblCalOfDay.BackColor = System.Drawing.Color.Transparent;
            this.lblCalOfDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalOfDay.Location = new System.Drawing.Point(226, 411);
            this.lblCalOfDay.Name = "lblCalOfDay";
            this.lblCalOfDay.Size = new System.Drawing.Size(143, 17);
            this.lblCalOfDay.TabIndex = 4;
            this.lblCalOfDay.Text = "Günlük Kalori İhtiyacınız :";
            // 
            // lblCal1
            // 
            this.lblCal1.BackColor = System.Drawing.Color.Transparent;
            this.lblCal1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCal1.Location = new System.Drawing.Point(518, 411);
            this.lblCal1.Name = "lblCal1";
            this.lblCal1.Size = new System.Drawing.Size(35, 17);
            this.lblCal1.TabIndex = 5;
            this.lblCal1.Text = "Kalori";
            // 
            // lblBmh
            // 
            this.lblBmh.BackColor = System.Drawing.Color.Transparent;
            this.lblBmh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBmh.Location = new System.Drawing.Point(518, 378);
            this.lblBmh.Name = "lblBmh";
            this.lblBmh.Size = new System.Drawing.Size(31, 17);
            this.lblBmh.TabIndex = 5;
            this.lblBmh.Text = "BMH";
            // 
            // txtAgeText
            // 
            this.txtAgeText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAgeText.Location = new System.Drawing.Point(391, 274);
            this.txtAgeText.Name = "txtAgeText";
            this.txtAgeText.ReadOnly = true;
            this.txtAgeText.Size = new System.Drawing.Size(121, 23);
            this.txtAgeText.TabIndex = 6;
            // 
            // txtWeightText
            // 
            this.txtWeightText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWeightText.Location = new System.Drawing.Point(390, 307);
            this.txtWeightText.Name = "txtWeightText";
            this.txtWeightText.ReadOnly = true;
            this.txtWeightText.Size = new System.Drawing.Size(121, 23);
            this.txtWeightText.TabIndex = 6;
            // 
            // txtHeightText
            // 
            this.txtHeightText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHeightText.Location = new System.Drawing.Point(391, 340);
            this.txtHeightText.Name = "txtHeightText";
            this.txtHeightText.ReadOnly = true;
            this.txtHeightText.Size = new System.Drawing.Size(121, 23);
            this.txtHeightText.TabIndex = 6;
            // 
            // txtBMH
            // 
            this.txtBMH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBMH.Location = new System.Drawing.Point(391, 373);
            this.txtBMH.Name = "txtBMH";
            this.txtBMH.ReadOnly = true;
            this.txtBMH.Size = new System.Drawing.Size(121, 23);
            this.txtBMH.TabIndex = 6;
            // 
            // txtGetCalory
            // 
            this.txtGetCalory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGetCalory.Location = new System.Drawing.Point(391, 406);
            this.txtGetCalory.Name = "txtGetCalory";
            this.txtGetCalory.ReadOnly = true;
            this.txtGetCalory.Size = new System.Drawing.Size(121, 23);
            this.txtGetCalory.TabIndex = 6;
            // 
            // lblDateNow
            // 
            this.lblDateNow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateNow.Location = new System.Drawing.Point(763, 12);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(37, 17);
            this.lblDateNow.TabIndex = 2;
            this.lblDateNow.Text = "Tarih :";
            // 
            // leftPanelMenuLogo
            // 
            this.leftPanelMenuLogo.BackColor = System.Drawing.Color.Transparent;
            this.leftPanelMenuLogo.Image = global::WeightGain.UI.Properties.Resources.WGLogo;
            this.leftPanelMenuLogo.ImageRotate = 0F;
            this.leftPanelMenuLogo.Location = new System.Drawing.Point(4, 12);
            this.leftPanelMenuLogo.Name = "leftPanelMenuLogo";
            this.leftPanelMenuLogo.Size = new System.Drawing.Size(309, 339);
            this.leftPanelMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPanelMenuLogo.TabIndex = 9;
            this.leftPanelMenuLogo.TabStop = false;
            this.leftPanelMenuLogo.UseTransparentBackground = true;
            // 
            // lblSlogan
            // 
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(88, 241);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(155, 27);
            this.lblSlogan.TabIndex = 10;
            this.lblSlogan.Text = "Sağlıkla Kilo Alın";
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // cpbCalory
            // 
            this.cpbCalory.Controls.Add(this.lblPercent);
            this.cpbCalory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cpbCalory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpbCalory.ForeColor = System.Drawing.Color.White;
            this.cpbCalory.Location = new System.Drawing.Point(626, 274);
            this.cpbCalory.Minimum = 0;
            this.cpbCalory.Name = "cpbCalory";
            this.cpbCalory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpbCalory.Size = new System.Drawing.Size(154, 154);
            this.cpbCalory.TabIndex = 11;
            this.cpbCalory.Text = "guna2CircleProgressBar1";
            // 
            // lblPercent
            // 
            this.lblPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPercent.ForeColor = System.Drawing.Color.Black;
            this.lblPercent.Location = new System.Drawing.Point(25, 64);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(103, 21);
            this.lblPercent.TabIndex = 0;
            this.lblPercent.Text = "label1";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCaloryNow
            // 
            this.txtCaloryNow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCaloryNow.Location = new System.Drawing.Point(391, 440);
            this.txtCaloryNow.Name = "txtCaloryNow";
            this.txtCaloryNow.ReadOnly = true;
            this.txtCaloryNow.Size = new System.Drawing.Size(121, 23);
            this.txtCaloryNow.TabIndex = 14;
            // 
            // lblCal2
            // 
            this.lblCal2.BackColor = System.Drawing.Color.Transparent;
            this.lblCal2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCal2.Location = new System.Drawing.Point(518, 445);
            this.lblCal2.Name = "lblCal2";
            this.lblCal2.Size = new System.Drawing.Size(35, 17);
            this.lblCal2.TabIndex = 13;
            this.lblCal2.Text = "Kalori";
            // 
            // lblCalTotal
            // 
            this.lblCalTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblCalTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalTotal.Location = new System.Drawing.Point(255, 445);
            this.lblCalTotal.Name = "lblCalTotal";
            this.lblCalTotal.Size = new System.Drawing.Size(114, 17);
            this.lblCalTotal.TabIndex = 12;
            this.lblCalTotal.Text = "Şuana Kadar Alınan :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(983, 515);
            this.Controls.Add(this.txtCaloryNow);
            this.Controls.Add(this.lblCal2);
            this.Controls.Add(this.lblCalTotal);
            this.Controls.Add(this.cpbCalory);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.leftPanelMenuLogo);
            this.Controls.Add(this.txtGetCalory);
            this.Controls.Add(this.txtBMH);
            this.Controls.Add(this.txtHeightText);
            this.Controls.Add(this.txtWeightText);
            this.Controls.Add(this.txtAgeText);
            this.Controls.Add(this.lblBmh);
            this.Controls.Add(this.lblCal1);
            this.Controls.Add(this.lblCalOfDay);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbUser);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPanelMenuLogo)).EndInit();
            this.cpbCalory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWeight;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeight;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAge;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBmi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalOfDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCal1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBmh;
        private System.Windows.Forms.TextBox txtAgeText;
        private System.Windows.Forms.TextBox txtWeightText;
        private System.Windows.Forms.TextBox txtHeightText;
        private System.Windows.Forms.TextBox txtBMH;
        private System.Windows.Forms.TextBox txtGetCalory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateNow;
        private Guna.UI2.WinForms.Guna2PictureBox leftPanelMenuLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSlogan;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpbCalory;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TextBox txtCaloryNow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCal2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalTotal;
    }
}