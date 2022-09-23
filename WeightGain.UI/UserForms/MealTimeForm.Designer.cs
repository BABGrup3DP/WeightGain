using System;

namespace WeightGain.UI.UserForms
{
    partial class MealTimeForm
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
            System.Windows.Forms.Button btnBreakfast;
            System.Windows.Forms.Button btnThirdSnack;
            System.Windows.Forms.Button btnSecondSnack;
            System.Windows.Forms.Button btnFirstSnack;
            System.Windows.Forms.Button btnLunch;
            System.Windows.Forms.Button btnDinner;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealTimeForm));
            this.tpMealTimes = new System.Windows.Forms.TabPage();
            this.lblAddBreakfast = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAddFirstSnack = new System.Windows.Forms.Label();
            this.lblAddThirdSnack = new System.Windows.Forms.Label();
            this.lblAddSecondSnack = new System.Windows.Forms.Label();
            this.lblThirdSnack = new System.Windows.Forms.Label();
            this.lblSecondSnack = new System.Windows.Forms.Label();
            this.lblFirstSnack = new System.Windows.Forms.Label();
            this.lblAddLunch = new System.Windows.Forms.Label();
            this.lblAddDinner = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.twcMealTimes = new WeightGain.UI.Extensions.TabWizardControl();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tpLastCheck = new System.Windows.Forms.TabPage();
            btnBreakfast = new System.Windows.Forms.Button();
            btnThirdSnack = new System.Windows.Forms.Button();
            btnSecondSnack = new System.Windows.Forms.Button();
            btnFirstSnack = new System.Windows.Forms.Button();
            btnLunch = new System.Windows.Forms.Button();
            btnDinner = new System.Windows.Forms.Button();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.tpMealTimes.SuspendLayout();
            this.twcMealTimes.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBreakfast
            // 
            btnBreakfast.BackColor = System.Drawing.Color.PaleTurquoise;
            btnBreakfast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnBreakfast.CausesValidation = false;
            btnBreakfast.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnBreakfast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBreakfast.Location = new System.Drawing.Point(42, 78);
            btnBreakfast.Margin = new System.Windows.Forms.Padding(2);
            btnBreakfast.Name = "btnBreakfast";
            btnBreakfast.Size = new System.Drawing.Size(173, 154);
            btnBreakfast.TabIndex = 22;
            btnBreakfast.Tag = "breakfast";
            btnBreakfast.Text = "+";
            btnBreakfast.UseVisualStyleBackColor = false;
            btnBreakfast.Click += new System.EventHandler(this.SelectMealTime);
            // 
            // btnThirdSnack
            // 
            btnThirdSnack.BackColor = System.Drawing.Color.Aquamarine;
            btnThirdSnack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnThirdSnack.CausesValidation = false;
            btnThirdSnack.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            btnThirdSnack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            btnThirdSnack.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnThirdSnack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnThirdSnack.Location = new System.Drawing.Point(502, 269);
            btnThirdSnack.Margin = new System.Windows.Forms.Padding(2);
            btnThirdSnack.Name = "btnThirdSnack";
            btnThirdSnack.Size = new System.Drawing.Size(173, 154);
            btnThirdSnack.TabIndex = 15;
            btnThirdSnack.Tag = "thirdsnack";
            btnThirdSnack.Text = "+";
            btnThirdSnack.UseVisualStyleBackColor = false;
            btnThirdSnack.Click += new System.EventHandler(this.SelectMealTime);
            // 
            // btnSecondSnack
            // 
            btnSecondSnack.BackColor = System.Drawing.Color.Aquamarine;
            btnSecondSnack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnSecondSnack.CausesValidation = false;
            btnSecondSnack.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            btnSecondSnack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            btnSecondSnack.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnSecondSnack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSecondSnack.Location = new System.Drawing.Point(42, 267);
            btnSecondSnack.Margin = new System.Windows.Forms.Padding(2);
            btnSecondSnack.Name = "btnSecondSnack";
            btnSecondSnack.Size = new System.Drawing.Size(173, 154);
            btnSecondSnack.TabIndex = 14;
            btnSecondSnack.Tag = "secondsnack";
            btnSecondSnack.Text = "+";
            btnSecondSnack.UseVisualStyleBackColor = false;
            btnSecondSnack.Click += new System.EventHandler(this.SelectMealTime);
            // 
            // btnFirstSnack
            // 
            btnFirstSnack.BackColor = System.Drawing.Color.Aquamarine;
            btnFirstSnack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnFirstSnack.CausesValidation = false;
            btnFirstSnack.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            btnFirstSnack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            btnFirstSnack.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnFirstSnack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFirstSnack.Location = new System.Drawing.Point(267, 78);
            btnFirstSnack.Margin = new System.Windows.Forms.Padding(2);
            btnFirstSnack.Name = "btnFirstSnack";
            btnFirstSnack.Size = new System.Drawing.Size(173, 154);
            btnFirstSnack.TabIndex = 12;
            btnFirstSnack.Tag = "firstsnack";
            btnFirstSnack.Text = "+";
            btnFirstSnack.UseVisualStyleBackColor = false;
            btnFirstSnack.Click += new System.EventHandler(this.SelectMealTime);
            // 
            // btnLunch
            // 
            btnLunch.BackColor = System.Drawing.Color.PaleTurquoise;
            btnLunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnLunch.CausesValidation = false;
            btnLunch.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnLunch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLunch.Location = new System.Drawing.Point(502, 76);
            btnLunch.Margin = new System.Windows.Forms.Padding(2);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new System.Drawing.Size(173, 154);
            btnLunch.TabIndex = 7;
            btnLunch.Tag = "lunch";
            btnLunch.Text = "+";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += new System.EventHandler(this.SelectMealTime);
            // 
            // btnDinner
            // 
            btnDinner.BackColor = System.Drawing.Color.PaleTurquoise;
            btnDinner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnDinner.CausesValidation = false;
            btnDinner.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btnDinner.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDinner.Location = new System.Drawing.Point(267, 267);
            btnDinner.Margin = new System.Windows.Forms.Padding(2);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new System.Drawing.Size(173, 154);
            btnDinner.TabIndex = 6;
            btnDinner.Tag = "dinner";
            btnDinner.Text = "+";
            btnDinner.UseVisualStyleBackColor = false;
            btnDinner.Click += new System.EventHandler(this.SelectMealTime);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label15.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label15.Location = new System.Drawing.Point(721, 54);
            label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(154, 19);
            label15.TabIndex = 1;
            label15.Text = "Öğününe Eklenen Ürünler";
            label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label16.Location = new System.Drawing.Point(16, 54);
            label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(89, 19);
            label16.TabIndex = 5;
            label16.Text = "Seçili Kategori";
            label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpMealTimes
            // 
            this.tpMealTimes.Controls.Add(this.lblAddBreakfast);
            this.tpMealTimes.Controls.Add(this.lblBreakfast);
            this.tpMealTimes.Controls.Add(btnBreakfast);
            this.tpMealTimes.Controls.Add(this.label13);
            this.tpMealTimes.Controls.Add(this.lblAddFirstSnack);
            this.tpMealTimes.Controls.Add(this.lblAddThirdSnack);
            this.tpMealTimes.Controls.Add(this.lblAddSecondSnack);
            this.tpMealTimes.Controls.Add(this.lblThirdSnack);
            this.tpMealTimes.Controls.Add(this.lblSecondSnack);
            this.tpMealTimes.Controls.Add(btnThirdSnack);
            this.tpMealTimes.Controls.Add(btnSecondSnack);
            this.tpMealTimes.Controls.Add(this.lblFirstSnack);
            this.tpMealTimes.Controls.Add(btnFirstSnack);
            this.tpMealTimes.Controls.Add(this.lblAddLunch);
            this.tpMealTimes.Controls.Add(this.lblAddDinner);
            this.tpMealTimes.Controls.Add(this.lblLunch);
            this.tpMealTimes.Controls.Add(this.lblDinner);
            this.tpMealTimes.Controls.Add(btnLunch);
            this.tpMealTimes.Controls.Add(btnDinner);
            this.tpMealTimes.Location = new System.Drawing.Point(4, 22);
            this.tpMealTimes.Name = "tpMealTimes";
            this.tpMealTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tpMealTimes.Size = new System.Drawing.Size(1055, 549);
            this.tpMealTimes.TabIndex = 0;
            this.tpMealTimes.Text = "Öğün Seç";
            this.tpMealTimes.UseVisualStyleBackColor = true;
            // 
            // lblAddBreakfast
            // 
            this.lblAddBreakfast.AutoSize = true;
            this.lblAddBreakfast.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddBreakfast.Location = new System.Drawing.Point(114, 182);
            this.lblAddBreakfast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddBreakfast.Name = "lblAddBreakfast";
            this.lblAddBreakfast.Size = new System.Drawing.Size(32, 13);
            this.lblAddBreakfast.TabIndex = 24;
            this.lblAddBreakfast.Text = "Ekle";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.BackColor = System.Drawing.Color.LightGreen;
            this.lblBreakfast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBreakfast.Location = new System.Drawing.Point(142, 82);
            this.lblBreakfast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(70, 23);
            this.lblBreakfast.TabIndex = 23;
            this.lblBreakfast.Text = "Kahvaltı";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(52, 482);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(464, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Senin Sağlığın, Senin Kuralların. İlk Öğün Planıyla güne başlayabilirsin..";
            // 
            // lblAddFirstSnack
            // 
            this.lblAddFirstSnack.AutoSize = true;
            this.lblAddFirstSnack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddFirstSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddFirstSnack.Location = new System.Drawing.Point(338, 182);
            this.lblAddFirstSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddFirstSnack.Name = "lblAddFirstSnack";
            this.lblAddFirstSnack.Size = new System.Drawing.Size(32, 13);
            this.lblAddFirstSnack.TabIndex = 20;
            this.lblAddFirstSnack.Text = "Ekle";
            // 
            // lblAddThirdSnack
            // 
            this.lblAddThirdSnack.AutoSize = true;
            this.lblAddThirdSnack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddThirdSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddThirdSnack.Location = new System.Drawing.Point(574, 374);
            this.lblAddThirdSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddThirdSnack.Name = "lblAddThirdSnack";
            this.lblAddThirdSnack.Size = new System.Drawing.Size(32, 13);
            this.lblAddThirdSnack.TabIndex = 19;
            this.lblAddThirdSnack.Text = "Ekle";
            // 
            // lblAddSecondSnack
            // 
            this.lblAddSecondSnack.AutoSize = true;
            this.lblAddSecondSnack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddSecondSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddSecondSnack.Location = new System.Drawing.Point(114, 374);
            this.lblAddSecondSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSecondSnack.Name = "lblAddSecondSnack";
            this.lblAddSecondSnack.Size = new System.Drawing.Size(32, 13);
            this.lblAddSecondSnack.TabIndex = 18;
            this.lblAddSecondSnack.Text = "Ekle";
            // 
            // lblThirdSnack
            // 
            this.lblThirdSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblThirdSnack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThirdSnack.Location = new System.Drawing.Point(602, 274);
            this.lblThirdSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThirdSnack.Name = "lblThirdSnack";
            this.lblThirdSnack.Size = new System.Drawing.Size(70, 23);
            this.lblThirdSnack.TabIndex = 17;
            this.lblThirdSnack.Text = "3.Ara Öğün";
            this.lblThirdSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondSnack
            // 
            this.lblSecondSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSecondSnack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondSnack.Location = new System.Drawing.Point(142, 271);
            this.lblSecondSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondSnack.Name = "lblSecondSnack";
            this.lblSecondSnack.Size = new System.Drawing.Size(70, 23);
            this.lblSecondSnack.TabIndex = 16;
            this.lblSecondSnack.Text = "2.Ara Öğün";
            this.lblSecondSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstSnack
            // 
            this.lblFirstSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFirstSnack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstSnack.Location = new System.Drawing.Point(366, 82);
            this.lblFirstSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstSnack.Name = "lblFirstSnack";
            this.lblFirstSnack.Size = new System.Drawing.Size(70, 23);
            this.lblFirstSnack.TabIndex = 13;
            this.lblFirstSnack.Text = "1.Ara Öğün";
            this.lblFirstSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddLunch
            // 
            this.lblAddLunch.AutoSize = true;
            this.lblAddLunch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddLunch.Location = new System.Drawing.Point(574, 182);
            this.lblAddLunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddLunch.Name = "lblAddLunch";
            this.lblAddLunch.Size = new System.Drawing.Size(32, 13);
            this.lblAddLunch.TabIndex = 11;
            this.lblAddLunch.Text = "Ekle";
            // 
            // lblAddDinner
            // 
            this.lblAddDinner.AutoSize = true;
            this.lblAddDinner.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddDinner.Location = new System.Drawing.Point(338, 374);
            this.lblAddDinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddDinner.Name = "lblAddDinner";
            this.lblAddDinner.Size = new System.Drawing.Size(32, 13);
            this.lblAddDinner.TabIndex = 10;
            this.lblAddDinner.Text = "Ekle";
            // 
            // lblLunch
            // 
            this.lblLunch.BackColor = System.Drawing.Color.LightGreen;
            this.lblLunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLunch.Location = new System.Drawing.Point(602, 80);
            this.lblLunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(70, 23);
            this.lblLunch.TabIndex = 9;
            this.lblLunch.Text = "Öğle Yemeği";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDinner
            // 
            this.lblDinner.BackColor = System.Drawing.Color.LightGreen;
            this.lblDinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDinner.Location = new System.Drawing.Point(353, 271);
            this.lblDinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(84, 23);
            this.lblDinner.TabIndex = 8;
            this.lblDinner.Text = "Akşam Yemeği";
            this.lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrev.IconColor = System.Drawing.Color.Black;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(12, 599);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(335, 50);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(736, 599);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(335, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Kategori Seç";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // twcMealTimes
            // 
            this.twcMealTimes.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.twcMealTimes.Controls.Add(this.tpMealTimes);
            this.twcMealTimes.Controls.Add(this.tpCategory);
            this.twcMealTimes.Controls.Add(this.tpProduct);
            this.twcMealTimes.Controls.Add(this.tpLastCheck);
            this.twcMealTimes.Location = new System.Drawing.Point(12, 12);
            this.twcMealTimes.Name = "twcMealTimes";
            this.twcMealTimes.NextButtonLastText = "Kaydet";
            this.twcMealTimes.SelectedIndex = 0;
            this.twcMealTimes.Size = new System.Drawing.Size(1063, 575);
            this.twcMealTimes.TabIndex = 0;
            this.twcMealTimes.Text = null;
            this.twcMealTimes.Selected += new System.Windows.Forms.TabControlEventHandler(this.twcMealTimes_Selected);
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.label14);
            this.tpCategory.Controls.Add(this.cmbCategory);
            this.tpCategory.Controls.Add(this.btnAddCategory);
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(1055, 549);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Kategori Seç";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.AliceBlue;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(94, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(448, 58);
            this.label14.TabIndex = 4;
            this.label14.Text = "Kategoriden bir seçim ile devam edebilirsin.Tek yapman gereken seçim sonrası Ekle" +
    " butonuna tuşlaman :)";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(106, 150);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(182, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AutoSize = true;
            this.btnAddCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategory.Location = new System.Drawing.Point(341, 150);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(169, 23);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.button10);
            this.tpProduct.Controls.Add(label16);
            this.tpProduct.Controls.Add(this.textBox1);
            this.tpProduct.Controls.Add(this.button8);
            this.tpProduct.Controls.Add(this.listView1);
            this.tpProduct.Controls.Add(label15);
            this.tpProduct.Controls.Add(this.listBox1);
            this.tpProduct.Location = new System.Drawing.Point(4, 22);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Size = new System.Drawing.Size(1055, 549);
            this.tpProduct.TabIndex = 2;
            this.tpProduct.Text = "Ürün Seç";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button10.Location = new System.Drawing.Point(150, 54);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 27);
            this.button10.TabIndex = 7;
            this.button10.Text = "Seçimleri Listele";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.Location = new System.Drawing.Point(640, 206);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 27);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ekle";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(150, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 247);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(721, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 238);
            this.listBox1.TabIndex = 0;
            // 
            // tpLastCheck
            // 
            this.tpLastCheck.Location = new System.Drawing.Point(4, 22);
            this.tpLastCheck.Name = "tpLastCheck";
            this.tpLastCheck.Size = new System.Drawing.Size(1055, 549);
            this.tpLastCheck.TabIndex = 3;
            this.tpLastCheck.Text = "Son Kontrol";
            this.tpLastCheck.UseVisualStyleBackColor = true;
            // 
            // MealTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1087, 680);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.twcMealTimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealTimeForm";
            this.Text = "LunchForm";
            this.Load += new System.EventHandler(this.MealTimeForm_Load);
            this.tpMealTimes.ResumeLayout(false);
            this.tpMealTimes.PerformLayout();
            this.twcMealTimes.ResumeLayout(false);
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            this.tpProduct.ResumeLayout(false);
            this.tpProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private Extensions.TabWizardControl twcMealTimes;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpLastCheck;
        private System.Windows.Forms.Label lblThirdSnack;
        private System.Windows.Forms.Label lblSecondSnack;
        private System.Windows.Forms.Label lblFirstSnack;
        private System.Windows.Forms.Label lblAddLunch;
        private System.Windows.Forms.Label lblAddDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAddFirstSnack;
        private System.Windows.Forms.Label lblAddThirdSnack;
        private System.Windows.Forms.Label lblAddSecondSnack;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAddBreakfast;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tpMealTimes;
    }
}