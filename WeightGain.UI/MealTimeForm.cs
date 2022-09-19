using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

namespace WeightGain.UI
{
    public partial class MealTimeForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly User _logginedUser;
        public MealTimeForm(User logginedUser)
        {
            InitializeComponent();
            _mealTimeRepository = new MealTimeRepository();
            _logginedUser = logginedUser;
        }

        private void MealTimeForm_Load(object sender, EventArgs e)
        {
            var findMealTimes = _mealTimeRepository.GetByUserId(_logginedUser.ID);
            if (findMealTimes.Count != 0)
            {
                guna2DataGridView1.DataSource = findMealTimes;
            }
        }
    }
}
