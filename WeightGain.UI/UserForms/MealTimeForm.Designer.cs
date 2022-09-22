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
            System.Windows.Forms.TabPage tpMealTimes;
            System.Windows.Forms.Button button4;
            System.Windows.Forms.Button button5;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button6;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealTimeForm));
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.tabWizardControl1 = new WeightGain.UI.Extensions.TabWizardControl();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.tpSave = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            tpMealTimes = new System.Windows.Forms.TabPage();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.tabWizardControl1.SuspendLayout();
            tpMealTimes.SuspendLayout();
            this.tpCategory.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.SuspendLayout();
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
            this.btnPrev.Location = new System.Drawing.Point(26, 749);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(419, 62);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(920, 752);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(419, 62);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Öğün Seç";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tabWizardControl1
            // 
            this.tabWizardControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabWizardControl1.Controls.Add(tpMealTimes);
            this.tabWizardControl1.Controls.Add(this.tpCategory);
            this.tabWizardControl1.Controls.Add(this.tpProduct);
            this.tabWizardControl1.Controls.Add(this.tpSave);
            this.tabWizardControl1.Location = new System.Drawing.Point(15, 15);
            this.tabWizardControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabWizardControl1.Name = "tabWizardControl1";
            this.tabWizardControl1.NextButton = this.btnNext;
            this.tabWizardControl1.NextButtonLastText = "Kaydet";
            this.tabWizardControl1.PreviousButton = this.btnPrev;
            this.tabWizardControl1.SelectedIndex = 0;
            this.tabWizardControl1.Size = new System.Drawing.Size(1329, 719);
            this.tabWizardControl1.TabIndex = 0;
            this.tabWizardControl1.Text = null;
            // 
            // tpMealTimes
            // 
            tpMealTimes.CausesValidation = false;
            tpMealTimes.Controls.Add(this.label2);
            tpMealTimes.Controls.Add(this.label1);
            tpMealTimes.Controls.Add(button1);
            tpMealTimes.Controls.Add(this.label13);
            tpMealTimes.Controls.Add(this.label12);
            tpMealTimes.Controls.Add(this.label11);
            tpMealTimes.Controls.Add(this.label10);
            tpMealTimes.Controls.Add(this.label9);
            tpMealTimes.Controls.Add(this.label8);
            tpMealTimes.Controls.Add(button6);
            tpMealTimes.Controls.Add(button3);
            tpMealTimes.Controls.Add(this.label7);
            tpMealTimes.Controls.Add(button2);
            tpMealTimes.Controls.Add(this.label6);
            tpMealTimes.Controls.Add(this.label5);
            tpMealTimes.Controls.Add(this.label4);
            tpMealTimes.Controls.Add(this.label3);
            tpMealTimes.Controls.Add(button5);
            tpMealTimes.Controls.Add(button4);
            tpMealTimes.Location = new System.Drawing.Point(4, 25);
            tpMealTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tpMealTimes.Name = "tpMealTimes";
            tpMealTimes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tpMealTimes.Size = new System.Drawing.Size(1321, 690);
            tpMealTimes.TabIndex = 0;
            tpMealTimes.Text = "Öğün Seç";
            tpMealTimes.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.label14);
            this.tpCategory.Controls.Add(this.comboBox1);
            this.tpCategory.Controls.Add(this.button7);
            this.tpCategory.Location = new System.Drawing.Point(4, 25);
            this.tpCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCategory.Size = new System.Drawing.Size(1321, 690);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Kategori Seç";
            this.tpCategory.UseVisualStyleBackColor = true;
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
            this.tpProduct.Location = new System.Drawing.Point(4, 25);
            this.tpProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Size = new System.Drawing.Size(1321, 690);
            this.tpProduct.TabIndex = 2;
            this.tpProduct.Text = "Ürün Seç";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // tpSave
            // 
            this.tpSave.Location = new System.Drawing.Point(4, 25);
            this.tpSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpSave.Name = "tpSave";
            this.tpSave.Size = new System.Drawing.Size(1321, 690);
            this.tpSave.TabIndex = 3;
            this.tpSave.Text = "Kaydet";
            this.tpSave.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.PaleTurquoise;
            button4.BackgroundImage = global::WeightGain.UI.Properties.Resources.lunch;
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button4.CausesValidation = false;
            button4.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button4.Location = new System.Drawing.Point(334, 334);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(216, 192);
            button4.TabIndex = 6;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.PaleTurquoise;
            button5.BackgroundImage = global::WeightGain.UI.Properties.Resources.lunch;
            button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button5.CausesValidation = false;
            button5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button5.Location = new System.Drawing.Point(627, 95);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(216, 192);
            button5.TabIndex = 7;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(441, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Akşam Yemeği";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(752, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Öğle Yemeği";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(423, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(718, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ekle";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Aquamarine;
            button2.BackgroundImage = global::WeightGain.UI.Properties.Resources.lunch;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.CausesValidation = false;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            button2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button2.Location = new System.Drawing.Point(334, 98);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(216, 192);
            button2.TabIndex = 12;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(457, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "1.Ara Öğün";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Aquamarine;
            button3.BackgroundImage = global::WeightGain.UI.Properties.Resources.lunch;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button3.CausesValidation = false;
            button3.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            button3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button3.Location = new System.Drawing.Point(53, 334);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(216, 192);
            button3.TabIndex = 14;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.Color.Aquamarine;
            button6.BackgroundImage = global::WeightGain.UI.Properties.Resources.lunch;
            button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button6.CausesValidation = false;
            button6.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            button6.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button6.Location = new System.Drawing.Point(627, 336);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(216, 192);
            button6.TabIndex = 15;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = false;
            button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LemonChiffon;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(177, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "1.Ara Öğün";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(752, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "1.Ara Öğün";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(143, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ekle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(718, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ekle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(423, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ekle";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(65, 602);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(579, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "Senin Sağlığın, Senin Kuralların.İlk Öğün Planıyla güne başlayabilirsin..";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(426, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 27);
            this.button7.TabIndex = 0;
            this.button7.Text = "Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.AliceBlue;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(117, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(560, 72);
            this.label14.TabIndex = 4;
            this.label14.Text = "Kategoriden bir seçim ile devam edebilirsin.Tek yapman gereken seçim sonrası Ekle" +
    " butonuna tuşlaman :)";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.PaleTurquoise;
            button1.BackgroundImage = global::WeightGain.UI.Properties.Resources.lunch;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.CausesValidation = false;
            button1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button1.Location = new System.Drawing.Point(53, 98);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(216, 192);
            button1.TabIndex = 22;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(177, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kahvaltı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(143, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ekle";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(901, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label15.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label15.Location = new System.Drawing.Point(901, 68);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(191, 23);
            label15.TabIndex = 1;
            label15.Text = "Öğününe Eklenen Ürünler";
            label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(188, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 308);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = System.Drawing.Color.Transparent;
            label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label16.Location = new System.Drawing.Point(20, 68);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(111, 23);
            label16.TabIndex = 5;
            label16.Text = "Seçili Kategori";
            label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.Location = new System.Drawing.Point(800, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 34);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ekle";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DodgerBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button10.Location = new System.Drawing.Point(188, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(176, 34);
            this.button10.TabIndex = 7;
            this.button10.Text = "Seçimleri Listele";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // MealTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1359, 850);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tabWizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MealTimeForm";
            this.Text = "LunchForm";
            this.Load += new System.EventHandler(this.MealTimeForm_Load);
            this.tabWizardControl1.ResumeLayout(false);
            tpMealTimes.ResumeLayout(false);
            tpMealTimes.PerformLayout();
            this.tpCategory.ResumeLayout(false);
            this.tpProduct.ResumeLayout(false);
            this.tpProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private Extensions.TabWizardControl tabWizardControl1;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListView listView1;
    }
}