using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

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
        }

        private void btnCalculateCal_Click(object sender, EventArgs e)
        {
            txtExerciseCal.Text = Convert.ToString(1 * nudExerciseTime.Value);

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtExerciseCal.Text))
            {
                if(_exerciseRepository.Insert(new Exercise
                {
                    Duration = (byte)nudExerciseTime.Value,
                    ExerciseType = ExerciseEnum.Bicycle,
                    ExerciseDate = DateTime.Now,
                    User = _logginedUser,
                    UserId = _logginedUser.ID
                }))
                {
                    MessageBox.Show("eklendi");
                }
            }
        }
    }
}
