namespace WeightGain.UI.AdminForms
{
    partial class AdminMainForm
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
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtTotalUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalMealTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalExercise = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalGood = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalBad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalUser = new System.Windows.Forms.Label();
            this.lblTotalCategory = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.lblTotalMealTimes = new System.Windows.Forms.Label();
            this.lblTotalExercises = new System.Windows.Forms.Label();
            this.lblTotalGood = new System.Windows.Forms.Label();
            this.lblTotalBad = new System.Windows.Forms.Label();
            this.gbStats = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.bgwContextLoad = new System.ComponentModel.BackgroundWorker();
            this.gbStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // txtTotalUser
            // 
            this.txtTotalUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalUser.DefaultText = "";
            this.txtTotalUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalUser.Location = new System.Drawing.Point(188, 60);
            this.txtTotalUser.Name = "txtTotalUser";
            this.txtTotalUser.PasswordChar = '\0';
            this.txtTotalUser.PlaceholderText = "";
            this.txtTotalUser.ReadOnly = true;
            this.txtTotalUser.SelectedText = "";
            this.txtTotalUser.Size = new System.Drawing.Size(215, 23);
            this.txtTotalUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalUser.TabIndex = 0;
            // 
            // txtTotalCategory
            // 
            this.txtTotalCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalCategory.DefaultText = "";
            this.txtTotalCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalCategory.Location = new System.Drawing.Point(188, 101);
            this.txtTotalCategory.Name = "txtTotalCategory";
            this.txtTotalCategory.PasswordChar = '\0';
            this.txtTotalCategory.PlaceholderText = "";
            this.txtTotalCategory.ReadOnly = true;
            this.txtTotalCategory.SelectedText = "";
            this.txtTotalCategory.Size = new System.Drawing.Size(215, 23);
            this.txtTotalCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalCategory.TabIndex = 1;
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalProduct.DefaultText = "";
            this.txtTotalProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalProduct.Location = new System.Drawing.Point(188, 143);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.PasswordChar = '\0';
            this.txtTotalProduct.PlaceholderText = "";
            this.txtTotalProduct.ReadOnly = true;
            this.txtTotalProduct.SelectedText = "";
            this.txtTotalProduct.Size = new System.Drawing.Size(215, 23);
            this.txtTotalProduct.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalProduct.TabIndex = 1;
            // 
            // txtTotalMealTime
            // 
            this.txtTotalMealTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalMealTime.DefaultText = "";
            this.txtTotalMealTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalMealTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalMealTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalMealTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalMealTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalMealTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalMealTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalMealTime.Location = new System.Drawing.Point(188, 185);
            this.txtTotalMealTime.Name = "txtTotalMealTime";
            this.txtTotalMealTime.PasswordChar = '\0';
            this.txtTotalMealTime.PlaceholderText = "";
            this.txtTotalMealTime.ReadOnly = true;
            this.txtTotalMealTime.SelectedText = "";
            this.txtTotalMealTime.Size = new System.Drawing.Size(215, 23);
            this.txtTotalMealTime.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalMealTime.TabIndex = 1;
            // 
            // txtTotalExercise
            // 
            this.txtTotalExercise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalExercise.DefaultText = "";
            this.txtTotalExercise.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalExercise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalExercise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalExercise.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalExercise.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalExercise.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalExercise.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalExercise.Location = new System.Drawing.Point(188, 227);
            this.txtTotalExercise.Name = "txtTotalExercise";
            this.txtTotalExercise.PasswordChar = '\0';
            this.txtTotalExercise.PlaceholderText = "";
            this.txtTotalExercise.ReadOnly = true;
            this.txtTotalExercise.SelectedText = "";
            this.txtTotalExercise.Size = new System.Drawing.Size(215, 23);
            this.txtTotalExercise.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalExercise.TabIndex = 1;
            // 
            // txtTotalGood
            // 
            this.txtTotalGood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalGood.DefaultText = "";
            this.txtTotalGood.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalGood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalGood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalGood.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalGood.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalGood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalGood.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalGood.Location = new System.Drawing.Point(188, 269);
            this.txtTotalGood.Name = "txtTotalGood";
            this.txtTotalGood.PasswordChar = '\0';
            this.txtTotalGood.PlaceholderText = "";
            this.txtTotalGood.ReadOnly = true;
            this.txtTotalGood.SelectedText = "";
            this.txtTotalGood.Size = new System.Drawing.Size(215, 23);
            this.txtTotalGood.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalGood.TabIndex = 1;
            // 
            // txtTotalBad
            // 
            this.txtTotalBad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalBad.DefaultText = "";
            this.txtTotalBad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalBad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalBad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalBad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalBad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalBad.Location = new System.Drawing.Point(188, 311);
            this.txtTotalBad.Name = "txtTotalBad";
            this.txtTotalBad.PasswordChar = '\0';
            this.txtTotalBad.PlaceholderText = "";
            this.txtTotalBad.ReadOnly = true;
            this.txtTotalBad.SelectedText = "";
            this.txtTotalBad.Size = new System.Drawing.Size(215, 23);
            this.txtTotalBad.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotalBad.TabIndex = 1;
            // 
            // lblTotalUser
            // 
            this.lblTotalUser.AutoSize = true;
            this.lblTotalUser.Location = new System.Drawing.Point(16, 62);
            this.lblTotalUser.Name = "lblTotalUser";
            this.lblTotalUser.Size = new System.Drawing.Size(129, 21);
            this.lblTotalUser.TabIndex = 2;
            this.lblTotalUser.Text = "Toplam Kullanıcı: ";
            // 
            // lblTotalCategory
            // 
            this.lblTotalCategory.AutoSize = true;
            this.lblTotalCategory.Location = new System.Drawing.Point(16, 103);
            this.lblTotalCategory.Name = "lblTotalCategory";
            this.lblTotalCategory.Size = new System.Drawing.Size(129, 21);
            this.lblTotalCategory.TabIndex = 3;
            this.lblTotalCategory.Text = "Toplam Kategori: ";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Location = new System.Drawing.Point(16, 145);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(102, 21);
            this.lblTotalProduct.TabIndex = 3;
            this.lblTotalProduct.Text = "Toplam Ürün:";
            // 
            // lblTotalMealTimes
            // 
            this.lblTotalMealTimes.AutoSize = true;
            this.lblTotalMealTimes.Location = new System.Drawing.Point(16, 187);
            this.lblTotalMealTimes.Name = "lblTotalMealTimes";
            this.lblTotalMealTimes.Size = new System.Drawing.Size(110, 21);
            this.lblTotalMealTimes.TabIndex = 3;
            this.lblTotalMealTimes.Text = "Toplam Öğün: ";
            // 
            // lblTotalExercises
            // 
            this.lblTotalExercises.AutoSize = true;
            this.lblTotalExercises.Location = new System.Drawing.Point(16, 229);
            this.lblTotalExercises.Name = "lblTotalExercises";
            this.lblTotalExercises.Size = new System.Drawing.Size(123, 21);
            this.lblTotalExercises.TabIndex = 3;
            this.lblTotalExercises.Text = "Toplam Egzersiz:";
            // 
            // lblTotalGood
            // 
            this.lblTotalGood.AutoSize = true;
            this.lblTotalGood.Location = new System.Drawing.Point(16, 271);
            this.lblTotalGood.Name = "lblTotalGood";
            this.lblTotalGood.Size = new System.Drawing.Size(150, 21);
            this.lblTotalGood.TabIndex = 3;
            this.lblTotalGood.Text = "Toplam İyi Gidenler: ";
            // 
            // lblTotalBad
            // 
            this.lblTotalBad.AutoSize = true;
            this.lblTotalBad.Location = new System.Drawing.Point(16, 313);
            this.lblTotalBad.Name = "lblTotalBad";
            this.lblTotalBad.Size = new System.Drawing.Size(166, 21);
            this.lblTotalBad.TabIndex = 3;
            this.lblTotalBad.Text = "Toplam Kötü Gidenler: ";
            // 
            // gbStats
            // 
            this.gbStats.BackColor = System.Drawing.Color.Transparent;
            this.gbStats.Controls.Add(this.lblNote);
            this.gbStats.Controls.Add(this.txtTotalBad);
            this.gbStats.Controls.Add(this.lblTotalBad);
            this.gbStats.Controls.Add(this.txtTotalUser);
            this.gbStats.Controls.Add(this.lblTotalGood);
            this.gbStats.Controls.Add(this.txtTotalCategory);
            this.gbStats.Controls.Add(this.lblTotalExercises);
            this.gbStats.Controls.Add(this.txtTotalProduct);
            this.gbStats.Controls.Add(this.lblTotalMealTimes);
            this.gbStats.Controls.Add(this.txtTotalMealTime);
            this.gbStats.Controls.Add(this.lblTotalProduct);
            this.gbStats.Controls.Add(this.txtTotalExercise);
            this.gbStats.Controls.Add(this.lblTotalCategory);
            this.gbStats.Controls.Add(this.txtTotalGood);
            this.gbStats.Controls.Add(this.lblTotalUser);
            this.gbStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbStats.Location = new System.Drawing.Point(12, 12);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(446, 400);
            this.gbStats.TabIndex = 4;
            this.gbStats.Text = "Weight Gain İstatistikler";
            this.gbStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNote.Location = new System.Drawing.Point(16, 353);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(427, 35);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Kullanıcılar ile alakalı hesaplar yapılırken sadece düz kullanıcılar dikkate alın" +
    "mıştır.";
            // 
            // bgwContextLoad
            // 
            this.bgwContextLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwContextLoad_DoWork);
            this.bgwContextLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwContextLoad_RunWorkerCompleted);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 665);
            this.Controls.Add(this.gbStats);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalGood;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalExercise;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalMealTime;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalUser;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalBad;
        private System.Windows.Forms.Label lblTotalBad;
        private System.Windows.Forms.Label lblTotalGood;
        private System.Windows.Forms.Label lblTotalExercises;
        private System.Windows.Forms.Label lblTotalMealTimes;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblTotalCategory;
        private System.Windows.Forms.Label lblTotalUser;
        private Guna.UI2.WinForms.Guna2GroupBox gbStats;
        private System.Windows.Forms.Label lblNote;
        private System.ComponentModel.BackgroundWorker bgwContextLoad;
    }
}