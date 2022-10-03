using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;

namespace WeightGain.UI.AdminForms
{
    public partial class AdminMainForm : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();
        private readonly MealTimeRepository _mealTimeRepository = new MealTimeRepository();
        private readonly ExerciseRepository _exerciseRepository = new ExerciseRepository();

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            var totalUsers = _userRepository.GetAll().Count;
            var totalCategories = _categoryRepository.GetAll().Count;
            var totalProducts = _productRepository.GetAll().Count;
            var totalMealTimes = _mealTimeRepository.GetAll().Count;
            var totalExercises = _exerciseRepository.GetAll().Count;
            txtTotalUser.Text = totalUsers.ToString();
            txtTotalCategory.Text = totalCategories.ToString();
            txtTotalProduct.Text = totalProducts.ToString();
            txtTotalMealTime.Text = totalMealTimes.ToString();
            txtTotalExercise.Text = totalExercises.ToString();

            // TODO: iyi durumda ve kötü durumda olan kullanıcılar hesaplanacak.
        }
    }
}
