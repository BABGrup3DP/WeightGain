using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

namespace WeightGain.UI.UserForms
{
    public partial class MealTimeForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly User _logginedUser;
        private MealTimeEnum selectedMealTime = MealTimeEnum.Sabah_Kahvaltısı;
        private List<Category> selectedCategories;
        private List<Product> selectedProducts;
        public MealTimeForm(User logginedUser)
        {
            InitializeComponent();
            twcMealTimes.NextButton = btnNext;
            twcMealTimes.PreviousButton = btnPrev;
            _mealTimeRepository = new MealTimeRepository();
            _categoryRepository = new CategoryRepository();
            selectedCategories = new List<Category>();
            selectedProducts = new List<Product>();
            _logginedUser = logginedUser;
        }

        private void MealTimeForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = _categoryRepository.GetAll();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void SelectMealTime(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "breakfast":
                    selectedMealTime = MealTimeEnum.Sabah_Kahvaltısı;
                    break;
                case "firstsnack":
                    selectedMealTime = MealTimeEnum.Birinci_Ara_öğün;
                    break;
                case "lunch":
                    selectedMealTime = MealTimeEnum.Öğle_Yemeği;
                    break;
                case "secondsnack":
                    selectedMealTime = MealTimeEnum.İkinci_Ara_Öğün;
                    break;
                case "dinner":
                    selectedMealTime = MealTimeEnum.Akşam_Yemeği;
                    break;
                case "thirdsnack":
                    selectedMealTime = MealTimeEnum.Üçüncü_Ara_Öğün;
                    break;
            }
        }

        private void twcMealTimes_Selected(object sender, TabControlEventArgs e)
        {
            var selectedIndex = twcMealTimes.SelectedIndex;
            switch (selectedIndex - 1)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
