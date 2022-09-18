namespace WeightGain.UI
{
    partial class ExerciseForm
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
            this.guna2VTrackBar1 = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.SuspendLayout();
            // 
            // guna2VTrackBar1
            // 
            this.guna2VTrackBar1.Location = new System.Drawing.Point(346, 72);
            this.guna2VTrackBar1.Name = "guna2VTrackBar1";
            this.guna2VTrackBar1.Size = new System.Drawing.Size(23, 300);
            this.guna2VTrackBar1.TabIndex = 0;
            this.guna2VTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2VTrackBar1);
            this.Name = "ExerciseForm";
            this.Text = "ExerciseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2VTrackBar guna2VTrackBar1;
    }
}