using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.UserForms
{
    public partial class MainForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly ExerciseRepository _exerciseRepository;
        private readonly User _logginedUser;
        public MainForm(List<BaseRepository> baseRepository, User logginedUser)
        {
            _logginedUser = logginedUser;
            _mealTimeRepository = (MealTimeRepository)baseRepository.Single(x => x.GetType() == typeof(MealTimeRepository));
            _exerciseRepository = (ExerciseRepository)baseRepository.Single(x => x.GetType() == typeof(ExerciseRepository));
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDateNow.Text = "Tarih: " + DateTime.Now.ToString("D");
            var weight = _logginedUser.Weight;
            var height = _logginedUser.Height;
            var age = _logginedUser.Age;
            lblUser.Text = _logginedUser.FullName;
            txtAgeText.Text = Convert.ToString(age);
            txtHeightText.Text = Convert.ToString(decimal.Round(height, 2));
            txtWeightText.Text = Convert.ToString(decimal.Round(weight, 2));

            txtBMH.Text = Convert.ToString(Math.Round(_logginedUser.Bmi, 2));
            var neededCalory = Helper.CalculateNeededCalory(weight, height, age);
            txtGetCalory.Text = neededCalory.ToString();
            var dailyMealTimes = _mealTimeRepository.GetByDate(DateTime.Now.Date, _logginedUser.Id);
            var totalCalory = 0m;
            if (dailyMealTimes != null)
            {
                foreach (var dailyMealTime in dailyMealTimes)
                {
                    if (dailyMealTime.Products == null) continue;
                    totalCalory +=
                        (decimal)dailyMealTime.Products.Sum(x => x.ProductPortions.Sum(y => y.Product.Calory * y.Size));
                }
            }

            var dailyExercises = _exerciseRepository.GetByDate(DateTime.Now.Date, _logginedUser.Id);
            if (dailyExercises != null)
            {
                foreach (var dailyExercise in dailyExercises)
                {
                    totalCalory -= (decimal)dailyExercise.TotalCal;
                }
            }
            cpbCalory.Maximum = (int)neededCalory;
            cpbCalory.Value = (int)Math.Round(totalCalory, 0);
            lblPercent.Text = $"{Math.Round(totalCalory / neededCalory * 100, 2)}%";
            txtCaloryNow.Text = Convert.ToString(decimal.Round(totalCalory, 2));
        }
    }
}
