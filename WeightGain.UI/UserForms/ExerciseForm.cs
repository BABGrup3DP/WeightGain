using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Extensions;
using WeightGain.UI.Properties;

namespace WeightGain.UI.UserForms
{
    public partial class ExerciseForm : Form
    {
        private readonly ExerciseRepository _exerciseRepository;

        private readonly User _logginedUser;
        public ExerciseForm(List<BaseRepository> baseRepositories, User logginedUser)
        {
            InitializeComponent();
            _logginedUser = logginedUser;
            _exerciseRepository = (ExerciseRepository)baseRepositories.Single(x => x.GetType() == typeof(ExerciseRepository));
            dtpExerciseDate.Value = DateTime.Now;
            dtpExerciseDate.MaxDate = DateTime.Now;
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            var listEnum = _exerciseRepository.GetExercises();
            foreach (var exercise in listEnum)
            {
                if (exercise == ExerciseEnum.Bicycle)
                    cmbExercies.Items.Add("Bisiklet");
                else if (exercise == ExerciseEnum.JumpRope)
                    cmbExercies.Items.Add("İp Atlama");
                else if (exercise == ExerciseEnum.Run)
                    cmbExercies.Items.Add("Koşu");
                else if (exercise == ExerciseEnum.Walk)
                    cmbExercies.Items.Add("Yürüyüş");
                else if (exercise == ExerciseEnum.Swim)
                    cmbExercies.Items.Add("Yüzme");
            }

            cmbExercies.SelectedIndex = 0;
            var weight = _logginedUser.Weight;
            lblCalBicycleV.Text = (weight * 5.6m * 1).ToString("F");
            lblCalJumpingRopeV.Text = (weight * 5.8m * 1).ToString("F");
            lblCalRunV.Text = (weight * 6.34m * 1).ToString("F");
            lblCalWalkV.Text = (weight * 2.1m * 1).ToString("F");
            lblCalSwimV.Text = (weight * 9.0m * 1).ToString("F");

            RefreshDataGridView();
        }

        private void btnCalculateCal_Click(object sender, EventArgs e)
        {
            txtExerciseCal.Text = Helper.CalculateExercise(_logginedUser.Weight, cmbExercies.SelectedIndex, nudExerciseTime.Value).ToString("F");
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            var exerciseType = cmbExercies.SelectedIndex + 1;
            if (exerciseType == 0)
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Egzersiz tipi yanlış seçilmiş.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogSuccess.Show();
                return;
            }
            if (!string.IsNullOrEmpty(txtExerciseCal.Text))
            {
                if (_exerciseRepository.Insert(new Exercise
                {
                    Duration = (int)nudExerciseTime.Value,
                    ExerciseType = (ExerciseEnum)exerciseType,
                    ExerciseDate = dtpExerciseDate.Value.Date,
                    UserId = _logginedUser.Id,
                    TotalCal = Convert.ToDouble(txtExerciseCal.Text)
                }))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Egzersiz başarıyla eklendi.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                    cmbExercies.SelectedIndex = 0;
                    nudExerciseTime.Value = 1;
                    txtExerciseCal.Text = string.Empty;
                }
                else
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Egzersiz eklenirken hata oluştu.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogSuccess.Show();
                }
            }
        }
        public void RefreshDataGridView()
        {
            dgvShowExercise.AutoGenerateColumns = false;
            dgvShowExercise.DataSource = null;
            dgvShowExercise.DataSource = _exerciseRepository.GetByUserId(_logginedUser.Id);
            if (dgvShowExercise.Columns.Count != 0) return;
            dgvShowExercise.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExerciseId",
                HeaderText = "ID",
                Name = "ExerciseId",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvShowExercise.Columns[0].Visible = false;
            dgvShowExercise.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExerciseType",
                HeaderText = "Egzersiz Tipi",
                Name = "ExerciseType",
                Width = 200,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                CellTemplate = new ExerciseTypeEnumTextBoxCell()
            });
            dgvShowExercise.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duration",
                HeaderText = "Toplam Süre (Dakika)",
                Name = "Duration",
                Width = 100,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvShowExercise.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalCal",
                HeaderText = "Toplam Yakılan Kalori",
                Name = "TotalCal",
                Width = 100,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "0.00##" }
            });
            dgvShowExercise.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ExerciseDate",
                HeaderText = "Egzersiz Tarihi",
                Name = "ExersizeDate",
                Width = 100,
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy" }
            });
        }

        private void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvShowExercise.SelectedRows;
            if (selectedRows.Count >= 0)
            {
                var dialogMessage = "";
                foreach (var selectedRow in selectedRows)
                {
                    var selectedExercise = (Exercise)((DataGridViewRow)selectedRow).DataBoundItem;
                    if (selectedExercise == null) continue;
                    if (_exerciseRepository.Delete(selectedExercise.ExerciseId))
                    {
                        dialogMessage += $"{selectedExercise.ExerciseId} başarıyla silindi.\n";
                    }
                    else
                    {
                        dialogMessage += $"{selectedExercise.ExerciseId} silinirken hata oluştu.\n";
                    }
                }
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = dialogMessage,
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Egzersiz seçilmemiş.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
            }
        }
    }
}
