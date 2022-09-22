using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
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
        }

        private void ExerciseForm_Load(object sender, EventArgs e)
        {
            cmbExercies.DataSource = _exerciseRepository.GetExercises();
            decimal weight = _logginedUser.Weight;
            lblCalBicycleV.Text= Convert.ToString(weight * (5.6m) * 1);
            lblCalJumpingRopeV.Text= Convert.ToString(weight * (5.8m) * 1);
            lblCalRunV.Text= Convert.ToString(weight * (6.34m) * 1);
            lblCalWalkV.Text= Convert.ToString(weight * (2.1m) * 1);
            lblCalSwimV.Text= Convert.ToString(weight * (9.0m) * 1);

            RefreshDataGridView();
        }

        private void btnCalculateCal_Click(object sender, EventArgs e)
        {
            decimal weight = _logginedUser.Weight;
            decimal parCoefficient=1.1m ;
            switch (cmbExercies.Text) // comboboxta yapılan değişikliği görmüyor
            {
                case "Bicycle":
                    parCoefficient = 5.6m;
                    break;
                case "JumpingRope":
                    parCoefficient = 5.8m;
                    break;
                case "Run":
                    parCoefficient = 6.34m;
                    break;
                case "Walk":
                    parCoefficient = 2.1m;
                    break;
                case "Swim":
                    parCoefficient = 9.0m;
                    break;
            }
            txtExerciseCal.Text = Convert.ToString(weight * parCoefficient * nudExerciseTime.Value/60);

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            var exerciseType = cmbExercies.SelectedValue;
            if (!string.IsNullOrEmpty(txtExerciseCal.Text))
            {
                if (_exerciseRepository.Insert(new Exercise
                {
                    Duration = (byte)nudExerciseTime.Value,
                    ExerciseType = (ExerciseEnum)exerciseType,
                    ExerciseDate = DateTime.Now,
                    User = _logginedUser,
                    UserId = _logginedUser.ID
                }))
                {
                    MessageBox.Show("eklendi");
                }
            }
            RefreshDataGridView();
        }
        public void RefreshDataGridView()
        {
            dgvShowExercise.DataSource = _exerciseRepository.GetAll();
            dgvShowExercise.Columns[0].ReadOnly = true;
            dgvShowExercise.Columns[0].HeaderText = "Egzersiz ID";
            dgvShowExercise.Columns[1].HeaderText = "Egzersiz Tipi";
            dgvShowExercise.Columns[2].HeaderText = "Egzersiz Süresi(dak)";
            dgvShowExercise.Columns[3].HeaderText = "Egzersiz Tarihi";
            dgvShowExercise.Columns[4].HeaderText = "Kullanıcı ID";
        }

        private void btnDeleteExercise_Click(object sender, EventArgs e)
        {
            var selectedCells = dgvShowExercise.SelectedCells;
            if (selectedCells.Count >= 0)
            {
                var selectedCategoryId = selectedCells[0].Value;
                if (_exerciseRepository.Delete((int)selectedCategoryId))
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
                    ExerciseID = (int)exerciseId,
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
