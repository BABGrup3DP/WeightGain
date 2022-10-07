using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.AdminForms
{
    public partial class ArchiveFormAdmin : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly ExerciseRepository _exerciseRepository;
        private readonly UserRepository _userRepository;

        private List<MealTime> _mealTimeList;
        private User selectedUser;

        public ArchiveFormAdmin(List<BaseRepository> baseRepositories)
        {
            InitializeComponent();
            _mealTimeRepository = (MealTimeRepository)baseRepositories.Single(x => x.GetType() == typeof(MealTimeRepository));
            _exerciseRepository = (ExerciseRepository)baseRepositories.Single(x => x.GetType() == typeof(ExerciseRepository));
            _userRepository = (UserRepository)baseRepositories.Single(x => x.GetType() == typeof(UserRepository));
            dtpArchiveStartDate.Value = DateTime.Now;
            dtpArchiveStartDate.MaxDate = DateTime.Now;
        }

        private void LbDataEnrtyDays()
        {
            if (_mealTimeList != null)
            {
                lbDataEntryDays.Items.Clear();
                foreach (var item in _mealTimeList.Select(x => x.MealTimeDate))
                {
                    if (!lbDataEntryDays.Items.Contains(item))
                    {
                        lbDataEntryDays.Items.Add(item);
                    }
                }
            }
            else
            {
                Helper.EmptyGroupBox(gbReport);
                lbDataEntryDays.Items.Clear();
            }
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            selectedUser = (User)cmbUsers.SelectedItem;
            if (selectedUser == null)
            {
                var errorMessage = new Guna2MessageDialog
                {
                    Text = "Lütfen bir kullanıcı seçin.",
                    Caption = Properties.Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                errorMessage.Show();
                return;
            }
            var selectedDate = dtpArchiveStartDate.Value.Date;
            var selectedToDate = cmbDateTo.SelectedIndex;

            switch (selectedToDate)
            {
                case 0: // Günlük
                    _mealTimeList = _mealTimeRepository.GetByDate(selectedDate, selectedUser.Id);
                    FillTheBlanks(selectedDate);
                    break;
                case 1: // Haftalık
                    _mealTimeList = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddDays(7), selectedUser.Id);
                    break;
                case 2: // Aylık
                    _mealTimeList = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddMonths(1), selectedUser.Id);
                    break;
                case 3: // Yıllık
                    _mealTimeList = _mealTimeRepository.GetByDate(selectedDate, selectedDate.AddYears(1), selectedUser.Id);
                    break;
                default:
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Tarih aralığı seçmek zorundasınız.",
                        Caption = Properties.Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogError.Show();
                    return;
            }
            LbDataEnrtyDays();
        }

        private void FillTheBlanks(DateTime selectedDate)
        {
            Helper.EmptyGroupBox(gbReport);
            var breakfastMeals = new List<string>();
            var firstSnackMeals = new List<string>();
            var lunchMeals = new List<string>();
            var secondSnackMeals = new List<string>();
            var dinnerMeals = new List<string>();
            var lastSnackMeals = new List<string>();

            var breakfastCalory = 0m;
            var firstSnackCalory = 0m;
            var lunchCalory = 0m;
            var secondSnackCalory = 0m;
            var dinnerCalory = 0m;
            var lastSnackCalory = 0m;
            if (_mealTimeList != null)
            {
                foreach (var mealTime in _mealTimeList)
                {
                    if (mealTime.MealTimeDate != selectedDate) continue;
                    var products = mealTime.Products;
                    switch (mealTime.MealTimeType)
                    {
                        case MealTimeEnum.Breakfast:
                            breakfastMeals.AddRange(products.Select(x => x.ProductName));
                            breakfastCalory += (decimal)mealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                            break;
                        case MealTimeEnum.FirstSnack:
                            firstSnackMeals.AddRange(products.Select(x => x.ProductName));
                            firstSnackCalory += (decimal)mealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                            break;
                        case MealTimeEnum.Lunch:
                            lunchMeals.AddRange(products.Select(x => x.ProductName));
                            lunchCalory += (decimal)mealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                            break;
                        case MealTimeEnum.SecondSnack:
                            secondSnackMeals.AddRange(products.Select(x => x.ProductName));
                            secondSnackCalory += (decimal)mealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                            break;
                        case MealTimeEnum.Dinner:
                            dinnerMeals.AddRange(products.Select(x => x.ProductName));
                            dinnerCalory += (decimal)mealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                            break;
                        case MealTimeEnum.LastSnack:
                            lastSnackMeals.AddRange(products.Select(x => x.ProductName));
                            lastSnackCalory += (decimal)mealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                            break;
                    }
                }
                txtBreakFast.Text = breakfastCalory.ToString();
                txtFirstSnack.Text = firstSnackCalory.ToString();
                txtLunch.Text = lunchCalory.ToString();
                txtSecondSnack.Text = secondSnackCalory.ToString();
                txtDinner.Text = dinnerCalory.ToString();
                txtThirdSnack.Text = lastSnackCalory.ToString();
                var totalDailyCalory = breakfastCalory + firstSnackCalory + lunchCalory + secondSnackCalory + dinnerCalory + lastSnackCalory;
                txtTotalCalory.Text = totalDailyCalory.ToString();

                txtAllBreakfast.Text = string.Join(", ", breakfastMeals);
                txtAllFirstSnack.Text = string.Join(", ", firstSnackMeals);
                txtAllLunch.Text = string.Join(", ", lunchMeals);
                txtAllSecondSnack.Text = string.Join(", ", secondSnackMeals);
                txtAllDinner.Text = string.Join(", ", dinnerMeals);
                txtAllLastSnack.Text = string.Join(", ", lastSnackMeals);
            }
            else
            {
                var errorMessage = new Guna2MessageDialog
                {
                    Text = "Belirtilen tarih aralığına ait hiçbir veri bulunamadı.",
                    Caption = Properties.Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                errorMessage.Show();
                lbDataEntryDays.Items.Clear();
            }
            var weight = selectedUser.Weight;
            var height = selectedUser.Height;
            var age = selectedUser.Age;
            var neededCalory = Helper.CalculateNeededCalory(weight, height, age);

            var dailyExercises = _exerciseRepository.GetByDate(selectedDate, selectedUser.Id);
            if (dailyExercises != null)
            {
                foreach (var dailyExercise in dailyExercises)
                {
                    neededCalory += (decimal)dailyExercise.TotalCal;
                }
            }
            txtTotalNeedCalory.Text = neededCalory.ToString();
        }

        private void lbDataEntryDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lbDataEntryDays.SelectedItem;
            if (selectedItem != null)
            {
                var selectedDate = (DateTime)selectedItem;
                FillTheBlanks(selectedDate.Date);
            }
        }

        private void ArchiveFormAdmin_Load(object sender, EventArgs e)
        {
            cmbUsers.Items.AddRange(_userRepository.GetAll(true).ToArray());
            cmbUsers.DisplayMember = "FullName";
            cmbUsers.ValueMember = "Id";
        }
    }
}
