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
            this.tpCategoryAndProduct = new System.Windows.Forms.TabPage();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.txtTotalCal = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSelectedProducts = new System.Windows.Forms.DataGridView();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.lwProducts = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCalory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            btnBreakfast = new System.Windows.Forms.Button();
            btnThirdSnack = new System.Windows.Forms.Button();
            btnSecondSnack = new System.Windows.Forms.Button();
            btnFirstSnack = new System.Windows.Forms.Button();
            btnLunch = new System.Windows.Forms.Button();
            btnDinner = new System.Windows.Forms.Button();
            this.tpMealTimes.SuspendLayout();
            this.twcMealTimes.SuspendLayout();
            this.tpCategoryAndProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedProducts)).BeginInit();
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
            this.twcMealTimes.Controls.Add(this.tpCategoryAndProduct);
            this.twcMealTimes.Location = new System.Drawing.Point(12, 12);
            this.twcMealTimes.Name = "twcMealTimes";
            this.twcMealTimes.NextButtonLastText = "Kaydet";
            this.twcMealTimes.SelectedIndex = 0;
            this.twcMealTimes.Size = new System.Drawing.Size(1063, 575);
            this.twcMealTimes.TabIndex = 0;
            this.twcMealTimes.Text = null;
            this.twcMealTimes.Selected += new System.Windows.Forms.TabControlEventHandler(this.twcMealTimes_Selected);
            // 
            // tpCategoryAndProduct
            // 
            this.tpCategoryAndProduct.Controls.Add(this.lblTotalCal);
            this.tpCategoryAndProduct.Controls.Add(this.txtTotalCal);
            this.tpCategoryAndProduct.Controls.Add(this.dgvSelectedProducts);
            this.tpCategoryAndProduct.Controls.Add(this.clbCategories);
            this.tpCategoryAndProduct.Controls.Add(this.btnAddProducts);
            this.tpCategoryAndProduct.Controls.Add(this.lwProducts);
            this.tpCategoryAndProduct.Location = new System.Drawing.Point(4, 22);
            this.tpCategoryAndProduct.Name = "tpCategoryAndProduct";
            this.tpCategoryAndProduct.Size = new System.Drawing.Size(1055, 549);
            this.tpCategoryAndProduct.TabIndex = 2;
            this.tpCategoryAndProduct.Text = "Kategori ve Ürün Seç";
            this.tpCategoryAndProduct.UseVisualStyleBackColor = true;
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Location = new System.Drawing.Point(592, 436);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(111, 13);
            this.lblTotalCal.TabIndex = 11;
            this.lblTotalCal.Text = "Toplam Kalori Miktarı: ";
            // 
            // txtTotalCal
            // 
            this.txtTotalCal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalCal.DefaultText = "";
            this.txtTotalCal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalCal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalCal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalCal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalCal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalCal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalCal.Location = new System.Drawing.Point(852, 427);
            this.txtTotalCal.Name = "txtTotalCal";
            this.txtTotalCal.PasswordChar = '\0';
            this.txtTotalCal.PlaceholderText = "";
            this.txtTotalCal.ReadOnly = true;
            this.txtTotalCal.SelectedText = "";
            this.txtTotalCal.Size = new System.Drawing.Size(200, 36);
            this.txtTotalCal.TabIndex = 10;
            // 
            // dgvSelectedProducts
            // 
            this.dgvSelectedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedProducts.Location = new System.Drawing.Point(595, 13);
            this.dgvSelectedProducts.Name = "dgvSelectedProducts";
            this.dgvSelectedProducts.Size = new System.Drawing.Size(457, 409);
            this.dgvSelectedProducts.TabIndex = 9;
            this.dgvSelectedProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedProducts_CellEndEdit);
            this.dgvSelectedProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSelectedProducts_EditingControlShowing);
            // 
            // clbCategories
            // 
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Location = new System.Drawing.Point(3, 13);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(228, 409);
            this.clbCategories.TabIndex = 8;
            this.clbCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategories_ItemCheck);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProducts.Image")));
            this.btnAddProducts.Location = new System.Drawing.Point(236, 427);
            this.btnAddProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(354, 96);
            this.btnAddProducts.TabIndex = 3;
            this.btnAddProducts.Text = "Ekle";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // lwProducts
            // 
            this.lwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.productCalory});
            this.lwProducts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lwProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwProducts.HideSelection = false;
            this.lwProducts.Location = new System.Drawing.Point(236, 13);
            this.lwProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lwProducts.Name = "lwProducts";
            this.lwProducts.Size = new System.Drawing.Size(354, 409);
            this.lwProducts.TabIndex = 2;
            this.lwProducts.UseCompatibleStateImageBehavior = false;
            this.lwProducts.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Text = "Ürün Adı";
            this.productName.Width = 181;
            // 
            // productCalory
            // 
            this.productCalory.Text = "Kalori Değeri";
            this.productCalory.Width = 124;
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
            this.tpCategoryAndProduct.ResumeLayout(false);
            this.tpCategoryAndProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private Extensions.TabWizardControl twcMealTimes;
        private System.Windows.Forms.TabPage tpCategoryAndProduct;
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
        private System.Windows.Forms.Label lblAddBreakfast;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.ListView lwProducts;
        private System.Windows.Forms.TabPage tpMealTimes;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productCalory;
        private System.Windows.Forms.DataGridView dgvSelectedProducts;
        private System.Windows.Forms.Label lblTotalCal;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalCal;
    }
}