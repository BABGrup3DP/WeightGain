namespace WeightGain.UI.AdminForms
{
    partial class ReportsFormAdmin
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
            this.lwProducts = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // lwProducts
            // 
            this.lwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.productAmount});
            this.lwProducts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lwProducts.FullRowSelect = true;
            this.lwProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwProducts.HideSelection = false;
            this.lwProducts.Location = new System.Drawing.Point(11, 11);
            this.lwProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lwProducts.Name = "lwProducts";
            this.lwProducts.Size = new System.Drawing.Size(495, 175);
            this.lwProducts.TabIndex = 3;
            this.lwProducts.UseCompatibleStateImageBehavior = false;
            this.lwProducts.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Tag = "1";
            this.productName.Text = "Ürün Adı";
            this.productName.Width = 203;
            // 
            // productAmount
            // 
            this.productAmount.Tag = "2";
            this.productAmount.Text = "Eklenme Sayısı";
            this.productAmount.Width = 124;
            // 
            // ReportsFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 665);
            this.Controls.Add(this.lwProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReportsFormAdmin";
            this.Text = "ReportsFormAdmin";
            this.Load += new System.EventHandler(this.ReportsFormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private System.Windows.Forms.ListView lwProducts;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productAmount;
    }
}