using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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
        public ExerciseForm(User logginedUser)
        {
            InitializeComponent();
            _logginedUser = logginedUser;
            _exerciseRepository = new ExerciseRepository();
            dtpExerciseDate.MaxDate = DateTime.Now;
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            List<ExerciseEnum> listEnum = _exerciseRepository.GetExercises();
            foreach (ExerciseEnum exercise in listEnum)
            {
                switch (exercise)
                {
                    case ExerciseEnum.Bicycle:
                        cmbExercies.Items.Add("Bisiklet");
                        break;
                    case ExerciseEnum.JumpRope:
                        cmbExercies.Items.Add("İp Atlama");
                        break;
                    case ExerciseEnum.Run:
                        cmbExercies.Items.Add("Koşu");
                        break;
                    case ExerciseEnum.Walk:
                        cmbExercies.Items.Add("Yürüyüş");
                        break;
                    case ExerciseEnum.Swim:
                        cmbExercies.Items.Add("Yüzme");
                        break;
                }
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
            decimal weight = _logginedUser.Weight;
            decimal parCoefficient = 1.1m;
            switch (cmbExercies.SelectedIndex)
            {
                case 0:
                    parCoefficient = 5.6m;
                    break;
                case 1:
                    parCoefficient = 5.8m;
                    break;
                case 2:
                    parCoefficient = 6.34m;
                    break;
                case 3:
                    parCoefficient = 2.1m;
                    break;
                case 4:
                    parCoefficient = 9.0m;
                    break;
            }
            txtExerciseCal.Text = (weight * parCoefficient * nudExerciseTime.Value / 60).ToString("F");
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            var exerciseType = cmbExercies.SelectedIndex + 1;
            if (exerciseType == 0)
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Egzersiz tipi yanlış seçilmiş.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                return;
            }
            if (!string.IsNullOrEmpty(txtExerciseCal.Text))
            {
                if (_exerciseRepository.Insert(new Exercise
                {
                    Duration = (byte)nudExerciseTime.Value,
                    ExerciseType = (ExerciseEnum)exerciseType,
                    ExerciseDate = DateTime.Now,
                    UserId = _logginedUser.Id
                }))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Egzersiz başarıyla eklendi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Egzersiz eklenirken hata oluştu.",
                        Caption = Resources.ProgramTitle
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
            if (dgvShowExercise.Columns.Count == 0)
            {
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
                    HeaderText = "Toplam Süre",
                    Name = "Duration",
                    Width = 100,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvShowExercise.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ExerciseDate",
                    HeaderText = "Egsersiz Tarihi",
                    Name = "ExersizeDate",
                    Width = 100,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
            }
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
                    if (selectedExercise != null)
                    {
                        if (_exerciseRepository.Delete(selectedExercise.ExerciseId))
                        {
                            dialogMessage += $"{selectedExercise.ExerciseId} başarıyla silindi.\n";
                        }
                        else
                        {
                            dialogMessage += $"{selectedExercise.ExerciseId} silinirken hata oluştu.\n";
                        }
                    }
                }
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = dialogMessage,
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Egzersiz seçilmemiş.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void dgvShowExercise_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var userId = dgvShowExercise.Rows[e.RowIndex].Cells[4].Value;
                var newExerciseDate = dgvShowExercise.Rows[e.RowIndex].Cells[3].Value;
                var newExerciseDuration = dgvShowExercise.Rows[e.RowIndex].Cells[2].Value;
                var newExerciseType = dgvShowExercise.Rows[e.RowIndex].Cells[1].Value;
                var exerciseId = dgvShowExercise.Rows[e.RowIndex].Cells[0].Value;
                var exercise = new Exercise
                {
                    ExerciseId = (int)exerciseId,
                    ExerciseType = (ExerciseEnum)newExerciseType,
                    Duration = (byte)newExerciseDuration,
                    ExerciseDate = (DateTime)newExerciseDate,
                    UserId = (int)userId
                };

                if (_exerciseRepository.Update(exercise))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Egzersiz başarıyla düzenlendi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Egzersiz düzenlenirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
            }
        }

    }
}
