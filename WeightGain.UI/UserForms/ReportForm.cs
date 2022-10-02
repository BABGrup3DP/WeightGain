using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
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
            dtpArchiveStartDate.Value = DateTime.Now;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpArchiveStartDate.Value;
            var selectedToDate = cmbDateTo.SelectedIndex;
            List<MealTime> mealTimes;

            var breakfastMeals = new List<string>();
            var firstSnackMeals = new List<string>();
            var lunchMeals = new List<string>();
            var secondSnackMeals = new List<string>();
            var dinnerMeals = new List<string>();
            var lastSnackMeals = new List<string>();
            switch (selectedToDate)
            {
                case 0: // Günlük
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, _logginedUser.Id);
                    foreach (var mealTime in mealTimes)
                    {
                        var products = mealTime.Products;
                        switch (mealTime.MealTimeType)
                        {
                            case MealTimeEnum.Breakfast:
                                breakfastMeals.AddRange(products.Select(x => x.ProductName));
                                break;
                            case MealTimeEnum.FirstSnack:
                                firstSnackMeals.AddRange(products.Select(x => x.ProductName));
                                break;
                            case MealTimeEnum.Lunch:
                                lunchMeals.AddRange(products.Select(x => x.ProductName));
                                break;
                            case MealTimeEnum.SecondSnack:
                                secondSnackMeals.AddRange(products.Select(x => x.ProductName));
                                break;
                            case MealTimeEnum.Dinner:
                                dinnerMeals.AddRange(products.Select(x => x.ProductName));
                                break;
                            case MealTimeEnum.LastSnack:
                                lastSnackMeals.AddRange(products.Select(x => x.ProductName));
                                break;
                        }
                    }
                    lblMorning.Text = string.Join(", ", breakfastMeals);
                    lblFirstSnack.Text = string.Join(", ", firstSnackMeals);
                    lblAfternoon.Text = string.Join(", ", lunchMeals);
                    lblSecondSnack.Text = string.Join(", ", secondSnackMeals);
                    lblEvening.Text = string.Join(", ", dinnerMeals);
                    lblThirdSnack.Text = string.Join(", ", lastSnackMeals);
                    break;
                case 1: // Haftalık
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddDays(7), _logginedUser.Id);
                    break;
                case 2: // Aylık
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddMonths(1), _logginedUser.Id);
                    break;
                case 3: // Yıllık
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
