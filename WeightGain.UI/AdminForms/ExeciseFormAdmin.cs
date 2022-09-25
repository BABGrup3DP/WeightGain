using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
{
    public partial class ExeciseFormAdmin : Form
    {
        private readonly ExerciseRepository _exerciseRepository;
        public ExeciseFormAdmin()
        {
            InitializeComponent();
            _exerciseRepository = new ExerciseRepository();
            cmbExerciseType.DataSource = _exerciseRepository.GetExercises();
        }

        private void RefreshDataGridView()
        {
            dgvExercise.DataSource = _exerciseRepository.GetAll();
            dgvExercise.Columns[0].ReadOnly = true;
            dgvExercise.Columns[0].HeaderText = "ID";

        }
        private void ExeciseFormAdmin_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            var exerciseType = cmbExerciseType.SelectedIndex;
            var exerciseDuration = txtExerciseDuration.Text.Trim();
            if (exerciseType == -1 || string.IsNullOrEmpty(exerciseDuration))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            var exercise = new Exercise
            {
                ExerciseType = (ExerciseEnum)exerciseType,
                Duration = Convert.ToByte(exerciseDuration),
            };
            if (_exerciseRepository.Insert(exercise))
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Egzersiz eklendi.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Egzersiz eklenirken hata oluştu.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            var selectedCells = dgvExercise.SelectedCells;
            if (selectedCells.Count >= 0)
            {
                var selectedExerciseId = selectedCells[0].Value;
                if (_exerciseRepository.Delete((int)selectedExerciseId))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Egzersiz başarıyla silindi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Egzersiz silinirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
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

        private void dgvExercise_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var newExerciseDuration = dgvExercise.Rows[e.RowIndex].Cells[2].Value;
                var newExerciseType = dgvExercise.Rows[e.RowIndex].Cells[1].Value;
                var exerciseId = dgvExercise.Rows[e.RowIndex].Cells[0].Value;
                var exercise = new Exercise
                {
                    ExerciseId = (int)exerciseId,
                    ExerciseType = (ExerciseEnum)newExerciseType,
                    Duration = Convert.ToByte(newExerciseDuration),
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
