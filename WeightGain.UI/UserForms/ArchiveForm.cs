using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

namespace WeightGain.UI.UserForms
{
    public partial class ArchiveForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly User _logginedUser;

        public ArchiveForm(User logginedUser)
        {
            InitializeComponent();
            _logginedUser = logginedUser;
            _mealTimeRepository = new MealTimeRepository();
            dtpArchiveStartDate.MaxDate = DateTime.Now;
        }

        private void btnGet_Click(object sender, System.EventArgs e)
        {
            var selectedDate = dtpArchiveStartDate.Value;
            var mealTimeList = _mealTimeRepository.GetByDate(selectedDate, _logginedUser.Id);
            dgvDataEntryDays.DataSource = mealTimeList;
        }
    }
}
