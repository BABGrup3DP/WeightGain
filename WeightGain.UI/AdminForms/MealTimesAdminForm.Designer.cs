namespace WeightGain.UI.AdminForms
{
    partial class MealTimesAdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dgvMealTimes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddMealTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteMealTime = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMealTimeDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbMealTimeType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMealTimeDesc = new System.Windows.Forms.Label();
            this.lblMealTimeType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealTimes)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // dgvMealTimes
            // 
            this.dgvMealTimes.AllowUserToAddRows = false;
            this.dgvMealTimes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMealTimes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMealTimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMealTimes.ColumnHeadersHeight = 20;
            this.dgvMealTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMealTimes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMealTimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMealTimes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvMealTimes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMealTimes.Location = new System.Drawing.Point(0, 0);
            this.dgvMealTimes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMealTimes.MultiSelect = false;
            this.dgvMealTimes.Name = "dgvMealTimes";
            this.dgvMealTimes.RowHeadersVisible = false;
            this.dgvMealTimes.Size = new System.Drawing.Size(1044, 314);
            this.dgvMealTimes.TabIndex = 0;
            this.dgvMealTimes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMealTimes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMealTimes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMealTimes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMealTimes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMealTimes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMealTimes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMealTimes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMealTimes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMealTimes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvMealTimes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMealTimes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMealTimes.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvMealTimes.ThemeStyle.ReadOnly = false;
            this.dgvMealTimes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMealTimes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMealTimes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvMealTimes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMealTimes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMealTimes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMealTimes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMealTimes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealTimes_CellEndEdit);
            // 
            // btnAddMealTime
            // 
            this.btnAddMealTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMealTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMealTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMealTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMealTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMealTime.ForeColor = System.Drawing.Color.White;
            this.btnAddMealTime.Location = new System.Drawing.Point(144, 76);
            this.btnAddMealTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMealTime.Name = "btnAddMealTime";
            this.btnAddMealTime.Size = new System.Drawing.Size(326, 59);
            this.btnAddMealTime.TabIndex = 1;
            this.btnAddMealTime.Text = "Ögün Ekle";
            this.btnAddMealTime.Click += new System.EventHandler(this.btnAddMealTime_Click);
            // 
            // btnDeleteMealTime
            // 
            this.btnDeleteMealTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMealTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMealTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMealTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMealTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMealTime.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMealTime.Location = new System.Drawing.Point(498, 321);
            this.btnDeleteMealTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMealTime.Name = "btnDeleteMealTime";
            this.btnDeleteMealTime.Size = new System.Drawing.Size(293, 59);
            this.btnDeleteMealTime.TabIndex = 2;
            this.btnDeleteMealTime.Text = "Ögün Sil";
            this.btnDeleteMealTime.Click += new System.EventHandler(this.btnDeleteMealTime_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtMealTimeDesc);
            this.guna2Panel1.Controls.Add(this.cmbMealTimeType);
            this.guna2Panel1.Controls.Add(this.lblMealTimeDesc);
            this.guna2Panel1.Controls.Add(this.lblMealTimeType);
            this.guna2Panel1.Controls.Add(this.btnAddMealTime);
            this.guna2Panel1.Location = new System.Drawing.Point(16, 321);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(474, 139);
            this.guna2Panel1.TabIndex = 4;
            // 
            // txtMealTimeDesc
            // 
            this.txtMealTimeDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMealTimeDesc.DefaultText = "";
            this.txtMealTimeDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMealTimeDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMealTimeDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMealTimeDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMealTimeDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMealTimeDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMealTimeDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMealTimeDesc.Location = new System.Drawing.Point(144, 42);
            this.txtMealTimeDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMealTimeDesc.Name = "txtMealTimeDesc";
            this.txtMealTimeDesc.PasswordChar = '\0';
            this.txtMealTimeDesc.PlaceholderText = "";
            this.txtMealTimeDesc.SelectedText = "";
            this.txtMealTimeDesc.Size = new System.Drawing.Size(326, 29);
            this.txtMealTimeDesc.TabIndex = 5;
            // 
            // cmbMealTimeType
            // 
            this.cmbMealTimeType.BackColor = System.Drawing.Color.Transparent;
            this.cmbMealTimeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMealTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealTimeType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMealTimeType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMealTimeType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMealTimeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMealTimeType.ItemHeight = 30;
            this.cmbMealTimeType.Location = new System.Drawing.Point(144, 2);
            this.cmbMealTimeType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMealTimeType.Name = "cmbMealTimeType";
            this.cmbMealTimeType.Size = new System.Drawing.Size(326, 36);
            this.cmbMealTimeType.TabIndex = 4;
            // 
            // lblMealTimeDesc
            // 
            this.lblMealTimeDesc.AutoSize = true;
            this.lblMealTimeDesc.Location = new System.Drawing.Point(4, 48);
            this.lblMealTimeDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMealTimeDesc.Name = "lblMealTimeDesc";
            this.lblMealTimeDesc.Size = new System.Drawing.Size(120, 17);
            this.lblMealTimeDesc.TabIndex = 3;
            this.lblMealTimeDesc.Text = "Öğün Açıklaması: ";
            // 
            // lblMealTimeType
            // 
            this.lblMealTimeType.AutoSize = true;
            this.lblMealTimeType.Location = new System.Drawing.Point(4, 12);
            this.lblMealTimeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMealTimeType.Name = "lblMealTimeType";
            this.lblMealTimeType.Size = new System.Drawing.Size(75, 17);
            this.lblMealTimeType.TabIndex = 2;
            this.lblMealTimeType.Text = "Öğün Adı: ";
            // 
            // MealTimesAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 681);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnDeleteMealTime);
            this.Controls.Add(this.dgvMealTimes);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MealTimesAdminForm";
            this.Text = "MealTimesAdmin";
            this.Load += new System.EventHandler(this.MealTimesAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealTimes)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMealTimes;
        private Guna.UI2.WinForms.Guna2Button btnAddMealTime;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMealTime;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMealTimeType;
        private System.Windows.Forms.Label lblMealTimeDesc;
        private System.Windows.Forms.Label lblMealTimeType;
        private Guna.UI2.WinForms.Guna2TextBox txtMealTimeDesc;
    }
}