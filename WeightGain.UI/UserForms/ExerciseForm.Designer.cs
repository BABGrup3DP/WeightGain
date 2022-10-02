using System;

namespace WeightGain.UI.UserForms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblExersiceDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExerciseType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbExercies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblExerciseTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtExerciseCal = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCalculateCal = new Guna.UI2.WinForms.Guna2Button();
            this.gbCalory = new Guna.UI2.WinForms.Guna2GroupBox();
            this.nudExerciseTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnAddExercise = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gpExercise = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblCalBicycle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalSwim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalBicycleV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalSwimV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalWalk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExerciseBic = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalWalkV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalRun = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExerciseSwim = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalRunV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalJumpingRope = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExerciseWalk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalJumpingRopeV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExerciseRun = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblExerciseJumpRope = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCalHour = new System.Windows.Forms.Label();
            this.lblExercises = new System.Windows.Forms.Label();
            this.dtpExerciseDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvShowExercise = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDeleteExercise = new Guna.UI2.WinForms.Guna2Button();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gbCalory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExerciseTime)).BeginInit();
            this.gpExercise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowExercise)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExersiceDate
            // 
            this.lblExersiceDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExersiceDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExersiceDate.Location = new System.Drawing.Point(300, 9);
            this.lblExersiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblExersiceDate.Name = "lblExersiceDate";
            this.lblExersiceDate.Size = new System.Drawing.Size(37, 17);
            this.lblExersiceDate.TabIndex = 0;
            this.lblExersiceDate.Text = "Tarih :";
            // 
            // lblExerciseType
            // 
            this.lblExerciseType.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseType.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseType.Location = new System.Drawing.Point(11, 52);
            this.lblExerciseType.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseType.Name = "lblExerciseType";
            this.lblExerciseType.Size = new System.Drawing.Size(96, 17);
            this.lblExerciseType.TabIndex = 0;
            this.lblExerciseType.Text = "Yapılan Egzersiz : ";
            // 
            // cmbExercies
            // 
            this.cmbExercies.BackColor = System.Drawing.Color.Transparent;
            this.cmbExercies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExercies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExercies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbExercies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbExercies.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbExercies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbExercies.ItemHeight = 30;
            this.cmbExercies.Location = new System.Drawing.Point(111, 42);
            this.cmbExercies.Margin = new System.Windows.Forms.Padding(2);
            this.cmbExercies.Name = "cmbExercies";
            this.cmbExercies.Size = new System.Drawing.Size(187, 36);
            this.cmbExercies.TabIndex = 2;
            // 
            // lblExerciseTime
            // 
            this.lblExerciseTime.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseTime.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseTime.Location = new System.Drawing.Point(12, 86);
            this.lblExerciseTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseTime.Name = "lblExerciseTime";
            this.lblExerciseTime.Size = new System.Drawing.Size(91, 17);
            this.lblExerciseTime.TabIndex = 0;
            this.lblExerciseTime.Text = "Egzersiz Süresi : ";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(302, 86);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(39, 17);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "dakika";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 144);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(83, 17);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = "Yakılan Kalori :";
            // 
            // txtExerciseCal
            // 
            this.txtExerciseCal.Location = new System.Drawing.Point(111, 140);
            this.txtExerciseCal.Margin = new System.Windows.Forms.Padding(2);
            this.txtExerciseCal.Multiline = true;
            this.txtExerciseCal.Name = "txtExerciseCal";
            this.txtExerciseCal.ReadOnly = true;
            this.txtExerciseCal.Size = new System.Drawing.Size(187, 27);
            this.txtExerciseCal.TabIndex = 3;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(302, 150);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(34, 17);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.Text = "kalori";
            // 
            // btnCalculateCal
            // 
            this.btnCalculateCal.Animated = true;
            this.btnCalculateCal.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculateCal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateCal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateCal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculateCal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculateCal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculateCal.ForeColor = System.Drawing.Color.White;
            this.btnCalculateCal.Location = new System.Drawing.Point(112, 107);
            this.btnCalculateCal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculateCal.Name = "btnCalculateCal";
            this.btnCalculateCal.Size = new System.Drawing.Size(186, 31);
            this.btnCalculateCal.TabIndex = 4;
            this.btnCalculateCal.Text = "Hesapla";
            this.btnCalculateCal.Click += new System.EventHandler(this.btnCalculateCal_Click);
            // 
            // gbCalory
            // 
            this.gbCalory.Controls.Add(this.nudExerciseTime);
            this.gbCalory.Controls.Add(this.btnAddExercise);
            this.gbCalory.Controls.Add(this.btnCalculateCal);
            this.gbCalory.Controls.Add(this.lblExerciseType);
            this.gbCalory.Controls.Add(this.txtExerciseCal);
            this.gbCalory.Controls.Add(this.lblExerciseTime);
            this.gbCalory.Controls.Add(this.guna2HtmlLabel5);
            this.gbCalory.Controls.Add(this.cmbExercies);
            this.gbCalory.Controls.Add(this.guna2HtmlLabel4);
            this.gbCalory.Controls.Add(this.guna2HtmlLabel6);
            this.gbCalory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbCalory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbCalory.Location = new System.Drawing.Point(72, 34);
            this.gbCalory.Margin = new System.Windows.Forms.Padding(2);
            this.gbCalory.Name = "gbCalory";
            this.gbCalory.Size = new System.Drawing.Size(360, 207);
            this.gbCalory.TabIndex = 5;
            this.gbCalory.Text = "Egzersize Göre Kalori Hesaplama";
            // 
            // nudExerciseTime
            // 
            this.nudExerciseTime.BackColor = System.Drawing.Color.Transparent;
            this.nudExerciseTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudExerciseTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudExerciseTime.Location = new System.Drawing.Point(111, 80);
            this.nudExerciseTime.Margin = new System.Windows.Forms.Padding(2);
            this.nudExerciseTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudExerciseTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExerciseTime.Name = "nudExerciseTime";
            this.nudExerciseTime.Size = new System.Drawing.Size(187, 26);
            this.nudExerciseTime.TabIndex = 6;
            this.nudExerciseTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Animated = true;
            this.btnAddExercise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddExercise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddExercise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddExercise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddExercise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddExercise.ForeColor = System.Drawing.Color.White;
            this.btnAddExercise.Location = new System.Drawing.Point(111, 171);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(187, 31);
            this.btnAddExercise.TabIndex = 5;
            this.btnAddExercise.Text = "Ekle";
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.AutoSize = false;
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(74, 411);
            this.guna2HtmlLabel22.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(360, 32);
            this.guna2HtmlLabel22.TabIndex = 0;
            this.guna2HtmlLabel22.Text = "Kaybedilen Kaloriyi Günlük Alınması\r\n Gereken Değere Ekle\r\n";
            // 
            // gpExercise
            // 
            this.gpExercise.Controls.Add(this.lblTable);
            this.gpExercise.Controls.Add(this.lblCalBicycle);
            this.gpExercise.Controls.Add(this.lblCalSwim);
            this.gpExercise.Controls.Add(this.lblCalBicycleV);
            this.gpExercise.Controls.Add(this.lblCalSwimV);
            this.gpExercise.Controls.Add(this.lblCalWalk);
            this.gpExercise.Controls.Add(this.lblExerciseBic);
            this.gpExercise.Controls.Add(this.lblCalWalkV);
            this.gpExercise.Controls.Add(this.lblCalRun);
            this.gpExercise.Controls.Add(this.lblExerciseSwim);
            this.gpExercise.Controls.Add(this.lblCalRunV);
            this.gpExercise.Controls.Add(this.lblCalJumpingRope);
            this.gpExercise.Controls.Add(this.lblExerciseWalk);
            this.gpExercise.Controls.Add(this.lblCalJumpingRopeV);
            this.gpExercise.Controls.Add(this.lblExerciseRun);
            this.gpExercise.Controls.Add(this.lblExerciseJumpRope);
            this.gpExercise.Controls.Add(this.lblCalHour);
            this.gpExercise.Controls.Add(this.lblExercises);
            this.gpExercise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gpExercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gpExercise.Location = new System.Drawing.Point(436, 34);
            this.gpExercise.Margin = new System.Windows.Forms.Padding(2);
            this.gpExercise.Name = "gpExercise";
            this.gpExercise.Size = new System.Drawing.Size(380, 207);
            this.gpExercise.TabIndex = 6;
            this.gpExercise.Text = "Egzersiz Bilgileri";
            // 
            // lblTable
            // 
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTable.Location = new System.Drawing.Point(63, 39);
            this.lblTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(256, 36);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "Egzersizlerin 1 saatte kaybettirdiği kalori mitarları tablosu (girdiğiniz kilo, b" +
    "oy ve yaş bilgisine göre değişiklik gösterebilir)";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCalBicycle
            // 
            this.lblCalBicycle.BackColor = System.Drawing.Color.Transparent;
            this.lblCalBicycle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalBicycle.ForeColor = System.Drawing.Color.Black;
            this.lblCalBicycle.Location = new System.Drawing.Point(293, 96);
            this.lblCalBicycle.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalBicycle.Name = "lblCalBicycle";
            this.lblCalBicycle.Size = new System.Drawing.Size(34, 17);
            this.lblCalBicycle.TabIndex = 1;
            this.lblCalBicycle.Text = "kalori";
            // 
            // lblCalSwim
            // 
            this.lblCalSwim.BackColor = System.Drawing.Color.Transparent;
            this.lblCalSwim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalSwim.ForeColor = System.Drawing.Color.Black;
            this.lblCalSwim.Location = new System.Drawing.Point(293, 169);
            this.lblCalSwim.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalSwim.Name = "lblCalSwim";
            this.lblCalSwim.Size = new System.Drawing.Size(34, 17);
            this.lblCalSwim.TabIndex = 1;
            this.lblCalSwim.Text = "kalori";
            // 
            // lblCalBicycleV
            // 
            this.lblCalBicycleV.BackColor = System.Drawing.Color.Transparent;
            this.lblCalBicycleV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalBicycleV.ForeColor = System.Drawing.Color.Black;
            this.lblCalBicycleV.Location = new System.Drawing.Point(228, 96);
            this.lblCalBicycleV.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalBicycleV.Name = "lblCalBicycleV";
            this.lblCalBicycleV.Size = new System.Drawing.Size(27, 17);
            this.lblCalBicycleV.TabIndex = 1;
            this.lblCalBicycleV.Text = "........";
            // 
            // lblCalSwimV
            // 
            this.lblCalSwimV.BackColor = System.Drawing.Color.Transparent;
            this.lblCalSwimV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalSwimV.ForeColor = System.Drawing.Color.Black;
            this.lblCalSwimV.Location = new System.Drawing.Point(228, 169);
            this.lblCalSwimV.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalSwimV.Name = "lblCalSwimV";
            this.lblCalSwimV.Size = new System.Drawing.Size(27, 17);
            this.lblCalSwimV.TabIndex = 1;
            this.lblCalSwimV.Text = "........";
            // 
            // lblCalWalk
            // 
            this.lblCalWalk.BackColor = System.Drawing.Color.Transparent;
            this.lblCalWalk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalWalk.ForeColor = System.Drawing.Color.Black;
            this.lblCalWalk.Location = new System.Drawing.Point(293, 151);
            this.lblCalWalk.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalWalk.Name = "lblCalWalk";
            this.lblCalWalk.Size = new System.Drawing.Size(34, 17);
            this.lblCalWalk.TabIndex = 1;
            this.lblCalWalk.Text = "kalori";
            // 
            // lblExerciseBic
            // 
            this.lblExerciseBic.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseBic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseBic.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseBic.Location = new System.Drawing.Point(66, 96);
            this.lblExerciseBic.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseBic.Name = "lblExerciseBic";
            this.lblExerciseBic.Size = new System.Drawing.Size(44, 17);
            this.lblExerciseBic.TabIndex = 1;
            this.lblExerciseBic.Text = "Bisiklet";
            // 
            // lblCalWalkV
            // 
            this.lblCalWalkV.BackColor = System.Drawing.Color.Transparent;
            this.lblCalWalkV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalWalkV.ForeColor = System.Drawing.Color.Black;
            this.lblCalWalkV.Location = new System.Drawing.Point(228, 151);
            this.lblCalWalkV.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalWalkV.Name = "lblCalWalkV";
            this.lblCalWalkV.Size = new System.Drawing.Size(27, 17);
            this.lblCalWalkV.TabIndex = 1;
            this.lblCalWalkV.Text = "........";
            // 
            // lblCalRun
            // 
            this.lblCalRun.BackColor = System.Drawing.Color.Transparent;
            this.lblCalRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalRun.ForeColor = System.Drawing.Color.Black;
            this.lblCalRun.Location = new System.Drawing.Point(293, 133);
            this.lblCalRun.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalRun.Name = "lblCalRun";
            this.lblCalRun.Size = new System.Drawing.Size(34, 17);
            this.lblCalRun.TabIndex = 1;
            this.lblCalRun.Text = "kalori";
            // 
            // lblExerciseSwim
            // 
            this.lblExerciseSwim.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseSwim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseSwim.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseSwim.Location = new System.Drawing.Point(66, 169);
            this.lblExerciseSwim.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseSwim.Name = "lblExerciseSwim";
            this.lblExerciseSwim.Size = new System.Drawing.Size(41, 17);
            this.lblExerciseSwim.TabIndex = 1;
            this.lblExerciseSwim.Text = "Yüzme";
            // 
            // lblCalRunV
            // 
            this.lblCalRunV.BackColor = System.Drawing.Color.Transparent;
            this.lblCalRunV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalRunV.ForeColor = System.Drawing.Color.Black;
            this.lblCalRunV.Location = new System.Drawing.Point(228, 133);
            this.lblCalRunV.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalRunV.Name = "lblCalRunV";
            this.lblCalRunV.Size = new System.Drawing.Size(27, 17);
            this.lblCalRunV.TabIndex = 1;
            this.lblCalRunV.Text = "........";
            // 
            // lblCalJumpingRope
            // 
            this.lblCalJumpingRope.BackColor = System.Drawing.Color.Transparent;
            this.lblCalJumpingRope.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalJumpingRope.ForeColor = System.Drawing.Color.Black;
            this.lblCalJumpingRope.Location = new System.Drawing.Point(293, 114);
            this.lblCalJumpingRope.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalJumpingRope.Name = "lblCalJumpingRope";
            this.lblCalJumpingRope.Size = new System.Drawing.Size(34, 17);
            this.lblCalJumpingRope.TabIndex = 1;
            this.lblCalJumpingRope.Text = "kalori";
            // 
            // lblExerciseWalk
            // 
            this.lblExerciseWalk.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseWalk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseWalk.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseWalk.Location = new System.Drawing.Point(65, 151);
            this.lblExerciseWalk.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseWalk.Name = "lblExerciseWalk";
            this.lblExerciseWalk.Size = new System.Drawing.Size(47, 17);
            this.lblExerciseWalk.TabIndex = 1;
            this.lblExerciseWalk.Text = "Yürüyüş";
            // 
            // lblCalJumpingRopeV
            // 
            this.lblCalJumpingRopeV.BackColor = System.Drawing.Color.Transparent;
            this.lblCalJumpingRopeV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalJumpingRopeV.ForeColor = System.Drawing.Color.Black;
            this.lblCalJumpingRopeV.Location = new System.Drawing.Point(228, 114);
            this.lblCalJumpingRopeV.Margin = new System.Windows.Forms.Padding(2);
            this.lblCalJumpingRopeV.Name = "lblCalJumpingRopeV";
            this.lblCalJumpingRopeV.Size = new System.Drawing.Size(27, 17);
            this.lblCalJumpingRopeV.TabIndex = 1;
            this.lblCalJumpingRopeV.Text = "........";
            // 
            // lblExerciseRun
            // 
            this.lblExerciseRun.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseRun.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseRun.Location = new System.Drawing.Point(66, 133);
            this.lblExerciseRun.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseRun.Name = "lblExerciseRun";
            this.lblExerciseRun.Size = new System.Drawing.Size(40, 17);
            this.lblExerciseRun.TabIndex = 1;
            this.lblExerciseRun.Text = "Koşma";
            // 
            // lblExerciseJumpRope
            // 
            this.lblExerciseJumpRope.BackColor = System.Drawing.Color.Transparent;
            this.lblExerciseJumpRope.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExerciseJumpRope.ForeColor = System.Drawing.Color.Black;
            this.lblExerciseJumpRope.Location = new System.Drawing.Point(65, 114);
            this.lblExerciseJumpRope.Margin = new System.Windows.Forms.Padding(2);
            this.lblExerciseJumpRope.Name = "lblExerciseJumpRope";
            this.lblExerciseJumpRope.Size = new System.Drawing.Size(56, 17);
            this.lblExerciseJumpRope.TabIndex = 1;
            this.lblExerciseJumpRope.Text = "İp Atlama";
            // 
            // lblCalHour
            // 
            this.lblCalHour.AutoSize = true;
            this.lblCalHour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCalHour.ForeColor = System.Drawing.Color.Black;
            this.lblCalHour.Location = new System.Drawing.Point(225, 80);
            this.lblCalHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalHour.Name = "lblCalHour";
            this.lblCalHour.Size = new System.Drawing.Size(104, 15);
            this.lblCalHour.TabIndex = 0;
            this.lblCalHour.Text = "Yakılan Kalori / Sa";
            // 
            // lblExercises
            // 
            this.lblExercises.AutoSize = true;
            this.lblExercises.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExercises.ForeColor = System.Drawing.Color.Black;
            this.lblExercises.Location = new System.Drawing.Point(63, 80);
            this.lblExercises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExercises.Name = "lblExercises";
            this.lblExercises.Size = new System.Drawing.Size(73, 15);
            this.lblExercises.TabIndex = 0;
            this.lblExercises.Text = "Egzersizler :";
            // 
            // dtpExerciseDate
            // 
            this.dtpExerciseDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpExerciseDate.BorderRadius = 6;
            this.dtpExerciseDate.Checked = true;
            this.dtpExerciseDate.FillColor = System.Drawing.Color.White;
            this.dtpExerciseDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExerciseDate.ForeColor = System.Drawing.Color.Black;
            this.dtpExerciseDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpExerciseDate.Location = new System.Drawing.Point(345, 4);
            this.dtpExerciseDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExerciseDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExerciseDate.Name = "dtpExerciseDate";
            this.dtpExerciseDate.Size = new System.Drawing.Size(263, 26);
            this.dtpExerciseDate.TabIndex = 5;
            // 
            // dgvShowExercise
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvShowExercise.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowExercise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowExercise.ColumnHeadersHeight = 55;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowExercise.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowExercise.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowExercise.Location = new System.Drawing.Point(74, 245);
            this.dgvShowExercise.Margin = new System.Windows.Forms.Padding(2);
            this.dgvShowExercise.Name = "dgvShowExercise";
            this.dgvShowExercise.RowHeadersVisible = false;
            this.dgvShowExercise.Size = new System.Drawing.Size(744, 161);
            this.dgvShowExercise.TabIndex = 7;
            this.dgvShowExercise.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowExercise.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShowExercise.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShowExercise.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShowExercise.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShowExercise.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowExercise.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowExercise.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvShowExercise.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShowExercise.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvShowExercise.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowExercise.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowExercise.ThemeStyle.HeaderStyle.Height = 55;
            this.dgvShowExercise.ThemeStyle.ReadOnly = false;
            this.dgvShowExercise.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowExercise.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShowExercise.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvShowExercise.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowExercise.ThemeStyle.RowsStyle.Height = 22;
            this.dgvShowExercise.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowExercise.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowExercise.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowExercise_CellEndEdit);
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteExercise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteExercise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteExercise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteExercise.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteExercise.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExercise.Location = new System.Drawing.Point(438, 410);
            this.btnDeleteExercise.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(378, 33);
            this.btnDeleteExercise.TabIndex = 8;
            this.btnDeleteExercise.Text = "Seçilenleri Sil";
            this.btnDeleteExercise.Click += new System.EventHandler(this.btnDeleteExercise_Click);
            // 
            // formElipse
            // 
            this.formElipse.TargetControl = this;
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(860, 454);
            this.Controls.Add(this.btnDeleteExercise);
            this.Controls.Add(this.dgvShowExercise);
            this.Controls.Add(this.dtpExerciseDate);
            this.Controls.Add(this.gpExercise);
            this.Controls.Add(this.gbCalory);
            this.Controls.Add(this.lblExersiceDate);
            this.Controls.Add(this.guna2HtmlLabel22);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExerciseForm";
            this.Text = "ExerciseForm";
            this.Load += new System.EventHandler(this.ExerciseForm_Load);
            this.gbCalory.ResumeLayout(false);
            this.gbCalory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExerciseTime)).EndInit();
            this.gpExercise.ResumeLayout(false);
            this.gpExercise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowExercise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblExersiceDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbExercies;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.TextBox txtExerciseCal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnCalculateCal;
        private Guna.UI2.WinForms.Guna2GroupBox gbCalory;
        private Guna.UI2.WinForms.Guna2GroupBox gpExercise;
        private System.Windows.Forms.Label lblCalHour;
        private System.Windows.Forms.Label lblExercises;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseJumpRope;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseBic;
        private Guna.UI2.WinForms.Guna2Button btnAddExercise;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalBicycle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalSwim;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalBicycleV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalSwimV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalWalk;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalWalkV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalRun;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseSwim;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalRunV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalJumpingRope;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseWalk;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCalJumpingRopeV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblExerciseRun;
        private System.Windows.Forms.Label lblTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudExerciseTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExerciseDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowExercise;
        private Guna.UI2.WinForms.Guna2Button btnDeleteExercise;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
    }
}