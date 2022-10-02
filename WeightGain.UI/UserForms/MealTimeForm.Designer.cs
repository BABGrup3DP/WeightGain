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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpMealTimes = new System.Windows.Forms.TabPage();
            this.lblAddBreakfast = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
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
            this.dgvSelectedProducts = new System.Windows.Forms.DataGridView();
            this.cmsProducts = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpCatAndProduct = new System.Windows.Forms.TableLayoutPanel();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.lwProducts = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCalory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.txtTotalCal = new Guna.UI2.WinForms.Guna2TextBox();
            this.pTop = new System.Windows.Forms.Panel();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSelectDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpMealTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lwImageList = new System.Windows.Forms.ImageList(this.components);
            this.tlpTabs = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
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
            this.cmsProducts.SuspendLayout();
            this.tlpCatAndProduct.SuspendLayout();
            this.pTop.SuspendLayout();
            this.tlpTabs.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBreakfast
            // 
            btnBreakfast.BackColor = System.Drawing.Color.PaleTurquoise;
            btnBreakfast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnBreakfast.CausesValidation = false;
            btnBreakfast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBreakfast.Location = new System.Drawing.Point(30, 15);
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
            btnThirdSnack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnThirdSnack.Location = new System.Drawing.Point(670, 204);
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
            btnSecondSnack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSecondSnack.Location = new System.Drawing.Point(30, 204);
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
            btnFirstSnack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFirstSnack.Location = new System.Drawing.Point(350, 15);
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
            btnLunch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLunch.Location = new System.Drawing.Point(670, 11);
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
            btnDinner.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDinner.Location = new System.Drawing.Point(350, 204);
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
            this.tpMealTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.tpMealTimes.Controls.Add(this.lblAddBreakfast);
            this.tpMealTimes.Controls.Add(this.lblBreakfast);
            this.tpMealTimes.Controls.Add(btnBreakfast);
            this.tpMealTimes.Controls.Add(this.lblStart);
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
            this.tpMealTimes.Location = new System.Drawing.Point(4, 29);
            this.tpMealTimes.Name = "tpMealTimes";
            this.tpMealTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tpMealTimes.Size = new System.Drawing.Size(975, 482);
            this.tpMealTimes.TabIndex = 0;
            this.tpMealTimes.Text = "Öğün Seç";
            // 
            // lblAddBreakfast
            // 
            this.lblAddBreakfast.AutoSize = true;
            this.lblAddBreakfast.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddBreakfast.Location = new System.Drawing.Point(102, 119);
            this.lblAddBreakfast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddBreakfast.Name = "lblAddBreakfast";
            this.lblAddBreakfast.Size = new System.Drawing.Size(38, 16);
            this.lblAddBreakfast.TabIndex = 24;
            this.lblAddBreakfast.Text = "Ekle";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.BackColor = System.Drawing.Color.LightGreen;
            this.lblBreakfast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBreakfast.Location = new System.Drawing.Point(30, 15);
            this.lblBreakfast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(173, 23);
            this.lblBreakfast.TabIndex = 23;
            this.lblBreakfast.Text = "Kahvaltı";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStart.Location = new System.Drawing.Point(46, 378);
            this.lblStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(979, 41);
            this.lblStart.TabIndex = 21;
            this.lblStart.Text = "Senin Sağlığın, Senin Kuralların. İlk Öğün Planıyla güne başlayabilirsin..";
            // 
            // lblAddFirstSnack
            // 
            this.lblAddFirstSnack.AutoSize = true;
            this.lblAddFirstSnack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddFirstSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddFirstSnack.Location = new System.Drawing.Point(421, 119);
            this.lblAddFirstSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddFirstSnack.Name = "lblAddFirstSnack";
            this.lblAddFirstSnack.Size = new System.Drawing.Size(38, 16);
            this.lblAddFirstSnack.TabIndex = 20;
            this.lblAddFirstSnack.Text = "Ekle";
            // 
            // lblAddThirdSnack
            // 
            this.lblAddThirdSnack.AutoSize = true;
            this.lblAddThirdSnack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddThirdSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddThirdSnack.Location = new System.Drawing.Point(742, 309);
            this.lblAddThirdSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddThirdSnack.Name = "lblAddThirdSnack";
            this.lblAddThirdSnack.Size = new System.Drawing.Size(38, 16);
            this.lblAddThirdSnack.TabIndex = 19;
            this.lblAddThirdSnack.Text = "Ekle";
            // 
            // lblAddSecondSnack
            // 
            this.lblAddSecondSnack.AutoSize = true;
            this.lblAddSecondSnack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddSecondSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddSecondSnack.Location = new System.Drawing.Point(102, 311);
            this.lblAddSecondSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddSecondSnack.Name = "lblAddSecondSnack";
            this.lblAddSecondSnack.Size = new System.Drawing.Size(38, 16);
            this.lblAddSecondSnack.TabIndex = 18;
            this.lblAddSecondSnack.Text = "Ekle";
            // 
            // lblThirdSnack
            // 
            this.lblThirdSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblThirdSnack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThirdSnack.Location = new System.Drawing.Point(670, 202);
            this.lblThirdSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThirdSnack.Name = "lblThirdSnack";
            this.lblThirdSnack.Size = new System.Drawing.Size(173, 23);
            this.lblThirdSnack.TabIndex = 17;
            this.lblThirdSnack.Text = "3.Ara Öğün";
            this.lblThirdSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondSnack
            // 
            this.lblSecondSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblSecondSnack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondSnack.Location = new System.Drawing.Point(30, 204);
            this.lblSecondSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecondSnack.Name = "lblSecondSnack";
            this.lblSecondSnack.Size = new System.Drawing.Size(173, 23);
            this.lblSecondSnack.TabIndex = 16;
            this.lblSecondSnack.Text = "2.Ara Öğün";
            this.lblSecondSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstSnack
            // 
            this.lblFirstSnack.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblFirstSnack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstSnack.Location = new System.Drawing.Point(350, 15);
            this.lblFirstSnack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstSnack.Name = "lblFirstSnack";
            this.lblFirstSnack.Size = new System.Drawing.Size(173, 23);
            this.lblFirstSnack.TabIndex = 13;
            this.lblFirstSnack.Text = "1.Ara Öğün";
            this.lblFirstSnack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddLunch
            // 
            this.lblAddLunch.AutoSize = true;
            this.lblAddLunch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddLunch.Location = new System.Drawing.Point(742, 117);
            this.lblAddLunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddLunch.Name = "lblAddLunch";
            this.lblAddLunch.Size = new System.Drawing.Size(38, 16);
            this.lblAddLunch.TabIndex = 11;
            this.lblAddLunch.Text = "Ekle";
            // 
            // lblAddDinner
            // 
            this.lblAddDinner.AutoSize = true;
            this.lblAddDinner.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblAddDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddDinner.Location = new System.Drawing.Point(421, 311);
            this.lblAddDinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddDinner.Name = "lblAddDinner";
            this.lblAddDinner.Size = new System.Drawing.Size(38, 16);
            this.lblAddDinner.TabIndex = 10;
            this.lblAddDinner.Text = "Ekle";
            // 
            // lblLunch
            // 
            this.lblLunch.BackColor = System.Drawing.Color.LightGreen;
            this.lblLunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLunch.Location = new System.Drawing.Point(670, 13);
            this.lblLunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(173, 23);
            this.lblLunch.TabIndex = 9;
            this.lblLunch.Text = "Öğle Yemeği";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDinner
            // 
            this.lblDinner.BackColor = System.Drawing.Color.LightGreen;
            this.lblDinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDinner.Location = new System.Drawing.Point(350, 204);
            this.lblDinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(173, 23);
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
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrev.Enabled = false;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrev.IconColor = System.Drawing.Color.Black;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(485, 64);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(494, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(486, 64);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Kategori Seç";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // twcMealTimes
            // 
            this.twcMealTimes.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.twcMealTimes.Controls.Add(this.tpMealTimes);
            this.twcMealTimes.Controls.Add(this.tpCategoryAndProduct);
            this.twcMealTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twcMealTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.twcMealTimes.Location = new System.Drawing.Point(3, 3);
            this.twcMealTimes.Name = "twcMealTimes";
            this.twcMealTimes.NextButtonLastText = "Kaydet";
            this.twcMealTimes.SelectedIndex = 0;
            this.twcMealTimes.Size = new System.Drawing.Size(983, 515);
            this.twcMealTimes.TabIndex = 0;
            this.twcMealTimes.Text = null;
            // 
            // tpCategoryAndProduct
            // 
            this.tpCategoryAndProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.tpCategoryAndProduct.Controls.Add(this.dgvSelectedProducts);
            this.tpCategoryAndProduct.Controls.Add(this.tlpCatAndProduct);
            this.tpCategoryAndProduct.Controls.Add(this.btnAdd);
            this.tpCategoryAndProduct.Controls.Add(this.lblTotalCal);
            this.tpCategoryAndProduct.Controls.Add(this.txtTotalCal);
            this.tpCategoryAndProduct.Controls.Add(this.pTop);
            this.tpCategoryAndProduct.Location = new System.Drawing.Point(4, 29);
            this.tpCategoryAndProduct.Name = "tpCategoryAndProduct";
            this.tpCategoryAndProduct.Size = new System.Drawing.Size(975, 482);
            this.tpCategoryAndProduct.TabIndex = 2;
            this.tpCategoryAndProduct.Text = "Kategori ve Ürün Seç";
            // 
            // dgvSelectedProducts
            // 
            this.dgvSelectedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSelectedProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvSelectedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedProducts.ContextMenuStrip = this.cmsProducts;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectedProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedProducts.Location = new System.Drawing.Point(5, 227);
            this.dgvSelectedProducts.Name = "dgvSelectedProducts";
            this.dgvSelectedProducts.RowHeadersWidth = 51;
            this.dgvSelectedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedProducts.Size = new System.Drawing.Size(791, 191);
            this.dgvSelectedProducts.TabIndex = 9;
            this.dgvSelectedProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedProducts_CellEndEdit);
            this.dgvSelectedProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSelectedProducts_EditingControlShowing);
            // 
            // cmsProducts
            // 
            this.cmsProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.cmsProducts.Name = "cmsProducts";
            this.cmsProducts.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsProducts.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsProducts.RenderStyle.ColorTable = null;
            this.cmsProducts.RenderStyle.RoundedEdges = true;
            this.cmsProducts.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsProducts.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsProducts.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsProducts.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsProducts.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsProducts.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tlpCatAndProduct
            // 
            this.tlpCatAndProduct.ColumnCount = 2;
            this.tlpCatAndProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.82051F));
            this.tlpCatAndProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.17949F));
            this.tlpCatAndProduct.Controls.Add(this.clbCategories, 0, 0);
            this.tlpCatAndProduct.Controls.Add(this.lwProducts, 1, 0);
            this.tlpCatAndProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCatAndProduct.Location = new System.Drawing.Point(0, 46);
            this.tlpCatAndProduct.Name = "tlpCatAndProduct";
            this.tlpCatAndProduct.RowCount = 1;
            this.tlpCatAndProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCatAndProduct.Size = new System.Drawing.Size(975, 179);
            this.tlpCatAndProduct.TabIndex = 14;
            // 
            // clbCategories
            // 
            this.clbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Location = new System.Drawing.Point(3, 3);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(470, 173);
            this.clbCategories.TabIndex = 8;
            this.clbCategories.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCategories_ItemCheck);
            // 
            // lwProducts
            // 
            this.lwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.productCalory});
            this.lwProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwProducts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lwProducts.FullRowSelect = true;
            this.lwProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwProducts.HideSelection = false;
            this.lwProducts.Location = new System.Drawing.Point(478, 2);
            this.lwProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lwProducts.Name = "lwProducts";
            this.lwProducts.Size = new System.Drawing.Size(495, 175);
            this.lwProducts.TabIndex = 2;
            this.lwProducts.UseCompatibleStateImageBehavior = false;
            this.lwProducts.View = System.Windows.Forms.View.Details;
            this.lwProducts.SelectedIndexChanged += new System.EventHandler(this.lwProducts_SelectedIndexChanged);
            this.lwProducts.SizeChanged += new System.EventHandler(this.lwProducts_SizeChanged);
            // 
            // productName
            // 
            this.productName.Tag = "1";
            this.productName.Text = "Ürün Adı";
            this.productName.Width = 203;
            // 
            // productCalory
            // 
            this.productCalory.Tag = "2";
            this.productCalory.Text = "Kalori Değeri";
            this.productCalory.Width = 124;
            // 
            // btnAdd
            // 
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(802, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "SEÇİLENLERİ EKLE";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Location = new System.Drawing.Point(820, 275);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(164, 20);
            this.lblTotalCal.TabIndex = 11;
            this.lblTotalCal.Text = "Toplam Kalori Miktarı:";
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
            this.txtTotalCal.Location = new System.Drawing.Point(802, 293);
            this.txtTotalCal.Name = "txtTotalCal";
            this.txtTotalCal.PasswordChar = '\0';
            this.txtTotalCal.PlaceholderText = "";
            this.txtTotalCal.ReadOnly = true;
            this.txtTotalCal.SelectedText = "";
            this.txtTotalCal.Size = new System.Drawing.Size(162, 36);
            this.txtTotalCal.TabIndex = 10;
            // 
            // pTop
            // 
            this.pTop.AutoSize = true;
            this.pTop.Controls.Add(this.txtDescription);
            this.pTop.Controls.Add(this.lblDescription);
            this.pTop.Controls.Add(this.lblSelectDate);
            this.pTop.Controls.Add(this.dtpMealTime);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(975, 46);
            this.pTop.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(409, 7);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(555, 36);
            this.txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(329, 14);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 27);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Açıklama :";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectDate.Location = new System.Drawing.Point(5, 14);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(93, 27);
            this.lblSelectDate.TabIndex = 13;
            this.lblSelectDate.Text = "Tarih Seç :";
            // 
            // dtpMealTime
            // 
            this.dtpMealTime.Checked = true;
            this.dtpMealTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpMealTime.ForeColor = System.Drawing.Color.Black;
            this.dtpMealTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpMealTime.Location = new System.Drawing.Point(85, 7);
            this.dtpMealTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpMealTime.Name = "dtpMealTime";
            this.dtpMealTime.Size = new System.Drawing.Size(238, 36);
            this.dtpMealTime.TabIndex = 12;
            // 
            // lwImageList
            // 
            this.lwImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.lwImageList.ImageSize = new System.Drawing.Size(50, 50);
            this.lwImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tlpTabs
            // 
            this.tlpTabs.AutoSize = true;
            this.tlpTabs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTabs.BackColor = System.Drawing.Color.Transparent;
            this.tlpTabs.ColumnCount = 1;
            this.tlpTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTabs.Controls.Add(this.twcMealTimes, 0, 0);
            this.tlpTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTabs.Location = new System.Drawing.Point(0, 0);
            this.tlpTabs.Name = "tlpTabs";
            this.tlpTabs.RowCount = 1;
            this.tlpTabs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTabs.Size = new System.Drawing.Size(983, 445);
            this.tlpTabs.TabIndex = 3;
            // 
            // tlpButtons
            // 
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.BackColor = System.Drawing.Color.Transparent;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnPrev, 0, 0);
            this.tlpButtons.Controls.Add(this.btnNext, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtons.Location = new System.Drawing.Point(0, 445);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(983, 70);
            this.tlpButtons.TabIndex = 4;
            // 
            // MealTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 515);
            this.Controls.Add(this.tlpTabs);
            this.Controls.Add(this.tlpButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
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
            this.cmsProducts.ResumeLayout(false);
            this.tlpCatAndProduct.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.tlpTabs.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblAddFirstSnack;
        private System.Windows.Forms.Label lblAddThirdSnack;
        private System.Windows.Forms.Label lblAddSecondSnack;
        private System.Windows.Forms.Label lblAddBreakfast;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.ListView lwProducts;
        private System.Windows.Forms.TabPage tpMealTimes;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productCalory;
        private System.Windows.Forms.DataGridView dgvSelectedProducts;
        private System.Windows.Forms.Label lblTotalCal;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalCal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpMealTime;
        private System.Windows.Forms.ImageList lwImageList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsProducts;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.TableLayoutPanel tlpTabs;
        private System.Windows.Forms.TableLayoutPanel tlpCatAndProduct;
        private System.Windows.Forms.Panel pTop;
        private FontAwesome.Sharp.IconButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
    }
}