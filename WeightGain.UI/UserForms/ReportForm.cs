﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.UserForms
{
    public partial class ReportForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly ExerciseRepository _exerciseRepository;
        private readonly User _logginedUser;

        public ReportForm(List<BaseRepository> baseRepositories, User logginedUser)
        {
            InitializeComponent();
            _logginedUser = logginedUser;
            _mealTimeRepository = (MealTimeRepository)baseRepositories.Single(x => x.GetType() == typeof(MealTimeRepository));
            _exerciseRepository = (ExerciseRepository)baseRepositories.Single(x => x.GetType() == typeof(MealTimeRepository));
            dtpArchiveStartDate.Value = DateTime.Now;
            dtpArchiveStartDate.MaxDate = DateTime.Now;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpArchiveStartDate.Value.Date;
            var selectedToDate = cmbDateTo.SelectedIndex;
            List<MealTime> mealTimes;

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
            switch (selectedToDate)
            {
                case 0: // Günlük
                    mealTimes = _mealTimeRepository.GetByDate(selectedDate, _logginedUser.Id);
                    if (mealTimes != null)
                    {
                        foreach (var mealTime in mealTimes)
                        {
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

                        lblMorning.Text = string.Join(", ", breakfastMeals);
                        lblFirstSnack.Text = string.Join(", ", firstSnackMeals);
                        lblAfternoon.Text = string.Join(", ", lunchMeals);
                        lblSecondSnack.Text = string.Join(", ", secondSnackMeals);
                        lblEvening.Text = string.Join(", ", dinnerMeals);
                        lblThirdSnack.Text = string.Join(", ", lastSnackMeals);
                    }
                    else
                    {
                        txtBreakFast.Text = "";
                        txtFirstSnack.Text = "";
                        txtLunch.Text = "";
                        txtSecondSnack.Text = "";
                        txtDinner.Text = "";
                        txtThirdSnack.Text = "";
                        txtTotalCalory.Text = "";

                        lblMorning.Text = "Öğünde Yenilen Besinler";
                        lblFirstSnack.Text = "Öğünde Yenilen Besinler";
                        lblAfternoon.Text = "Öğünde Yenilen Besinler";
                        lblSecondSnack.Text = "Öğünde Yenilen Besinler";
                        lblEvening.Text = "Öğünde Yenilen Besinler";
                        lblThirdSnack.Text = "Öğünde Yenilen Besinler";
                    }
                    var weight = _logginedUser.Weight;
                    var height = _logginedUser.Height;
                    var age = _logginedUser.Age;
                    var neededCalory = Helper.CalculateNeededCalory(weight, height, age);

                    var dailyExercises = _exerciseRepository.GetByDate(selectedDate, _logginedUser.Id);
                    if (dailyExercises != null)
                    {
                        foreach (var dailyExercise in dailyExercises)
                        {
                            neededCalory += (decimal)dailyExercise.TotalCal;
                        }
                    }
                    txtTotalNeedCalory.Text = neededCalory.ToString();
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
