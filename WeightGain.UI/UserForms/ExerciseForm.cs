using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

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

        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            if (Helper.CheckEmptyValues(gpExercise))
            {

            }
        }
    }
}
