using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

namespace WeightGain.UI.UserForms
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

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
