using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.AdminForms
{
    public partial class AdminMainForm : Form
    {
        private UserRepository _userRepository;
        private CategoryRepository _categoryRepository;
        private ProductRepository _productRepository;
        private PortionRepository _portionRepository;
        private MealTimeRepository _mealTimeRepository;
        private ExerciseRepository _exerciseRepository;

        public AdminMainForm(List<BaseRepository> baseRepository)
        {
            _userRepository = (UserRepository)baseRepository.Single(x => x.GetType() == typeof(UserRepository));
            _categoryRepository = (CategoryRepository)baseRepository.Single(x => x.GetType() == typeof(CategoryRepository));
            _productRepository = (ProductRepository)baseRepository.Single(x => x.GetType() == typeof(ProductRepository));
            _portionRepository = (PortionRepository)baseRepository.Single(x => x.GetType() == typeof(PortionRepository));
            _mealTimeRepository = (MealTimeRepository)baseRepository.Single(x => x.GetType() == typeof(MealTimeRepository));
            _exerciseRepository = (ExerciseRepository)baseRepository.Single(x => x.GetType() == typeof(ExerciseRepository));
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

            var totalUsers = _userRepository.GetAll(true).Count;
            var totalCategories = _categoryRepository.GetAll().Count;
            var totalProducts = _productRepository.GetAll().Count;
            var totalMealTimes = _mealTimeRepository.GetAll().Count;
            var totalExercises = _exerciseRepository.GetAll().Count;
            txtTotalUser.Text = totalUsers.ToString();
            txtTotalCategory.Text = totalCategories.ToString();
            txtTotalProduct.Text = totalProducts.ToString();
            txtTotalMealTime.Text = totalMealTimes.ToString();
            txtTotalExercise.Text = totalExercises.ToString();
            var goodUser = 0;
            foreach (var user in _userRepository.GetAll(true))
            {
                var getUserTotalCalories = _portionRepository.GetByUserId(user.Id).Sum(x => x.Size * x.Product.Calory);
                var getUserTotalExercises = _exerciseRepository.GetByUserId(user.Id).Sum(x => x.TotalCal);
                var getUserTotalNeedCalory = (double)Helper.CalculateNeededCalory(user.Weight, user.Height, user.Age) * (DateTime.Now.Date - user.RegisterDate.Date).TotalDays;
                if (getUserTotalCalories >= getUserTotalNeedCalory + getUserTotalExercises)
                    goodUser++;
            }
            txtTotalGood.Text = goodUser.ToString();
            txtTotalBad.Text = (totalUsers - goodUser).ToString();
        }

        private void bgwContextLoad_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _userRepository = new UserRepository();
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            _portionRepository = new PortionRepository();
            _mealTimeRepository = new MealTimeRepository();
            _exerciseRepository = new ExerciseRepository();
        }

        private void bgwContextLoad_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

        }
    }
}
