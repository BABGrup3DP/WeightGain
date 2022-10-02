using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

namespace WeightGain.UI.UserForms
{
    public partial class ReportForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly User _logginedUser;

        public ReportForm(User logginedUser)
        {
            InitializeComponent();
            _logginedUser = logginedUser;
            _mealTimeRepository = new MealTimeRepository();
            dtpArchiveStartDate.MaxDate = DateTime.Now;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpArchiveStartDate.Value;
            var selectedToDate = cmbDateTo.SelectedIndex;
            List<MealTime> mealTimes;
            switch (selectedToDate)
            {
                case 0:
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, _logginedUser.Id);
                    break;
                case 1:
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddDays(7), _logginedUser.Id);
                    break;
                case 2:
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddMonths(1), _logginedUser.Id);
                    break;
                case 3:
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddYears(1), _logginedUser.Id);
                    break;
                default:
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Tarih aralığı seçmek zorundasınız.",
                        Caption = Properties.Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                    return;
            }
            dgvDataEntryDays.DataSource = mealTimes;

        }
    }
}
