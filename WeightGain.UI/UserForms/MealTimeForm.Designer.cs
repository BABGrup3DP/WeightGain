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
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.tabWizardControl1 = new WeightGain.UI.Extensions.TabWizardControl();
            this.tpMealTimes = new System.Windows.Forms.TabPage();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.tpSave = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabWizardControl1.SuspendLayout();
            this.tpMealTimes.SuspendLayout();
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
            this.btnPrev.Location = new System.Drawing.Point(21, 599);
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
            this.btnNext.Location = new System.Drawing.Point(736, 602);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(335, 50);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Öğün Seç";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // tabWizardControl1
            // 
            this.tabWizardControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabWizardControl1.Controls.Add(this.tpMealTimes);
            this.tabWizardControl1.Controls.Add(this.tpCategory);
            this.tabWizardControl1.Controls.Add(this.tpProduct);
            this.tabWizardControl1.Controls.Add(this.tpSave);
            this.tabWizardControl1.Location = new System.Drawing.Point(12, 12);
            this.tabWizardControl1.Name = "tabWizardControl1";
            this.tabWizardControl1.NextButton = this.btnNext;
            this.tabWizardControl1.NextButtonLastText = "Kaydet";
            this.tabWizardControl1.PreviousButton = this.btnPrev;
            this.tabWizardControl1.SelectedIndex = 0;
            this.tabWizardControl1.Size = new System.Drawing.Size(1063, 575);
            this.tabWizardControl1.TabIndex = 0;
            this.tabWizardControl1.Text = null;
            // 
            // tpMealTimes
            // 
            this.tpMealTimes.Controls.Add(this.listView1);
            this.tpMealTimes.Location = new System.Drawing.Point(4, 22);
            this.tpMealTimes.Name = "tpMealTimes";
            this.tpMealTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tpMealTimes.Size = new System.Drawing.Size(1055, 549);
            this.tpMealTimes.TabIndex = 0;
            this.tpMealTimes.Text = "Öğün Seç";
            this.tpMealTimes.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(1055, 549);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Kategori Seç";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // tpProduct
            // 
            this.tpProduct.Location = new System.Drawing.Point(4, 22);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Size = new System.Drawing.Size(1055, 549);
            this.tpProduct.TabIndex = 2;
            this.tpProduct.Text = "Ürün Seç";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // tpSave
            // 
            this.tpSave.Location = new System.Drawing.Point(4, 22);
            this.tpSave.Name = "tpSave";
            this.tpSave.Size = new System.Drawing.Size(1055, 549);
            this.tpSave.TabIndex = 3;
            this.tpSave.Text = "Kaydet";
            this.tpSave.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MealTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1087, 664);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tabWizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealTimeForm";
            this.Text = "LunchForm";
            this.Load += new System.EventHandler(this.MealTimeForm_Load);
            this.tabWizardControl1.ResumeLayout(false);
            this.tpMealTimes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private Extensions.TabWizardControl tabWizardControl1;
        private System.Windows.Forms.TabPage tpMealTimes;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpSave;
        private System.Windows.Forms.ListView listView1;
    }
}