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
        private readonly ProductRepository _productRepository;
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
            _productRepository = new ProductRepository();
            selectedCategories = new List<Category>();
            selectedProducts = new List<Product>();
            _logginedUser = logginedUser;
        }

        private void MealTimeForm_Load(object sender, EventArgs e)
        {
            clbCategories.DataSource = _categoryRepository.GetAll();
            clbCategories.DisplayMember = "Name";
            clbCategories.ValueMember = "CategoryId";

            lbMealTimeProducts.DisplayMember = "ProductName";
            lbMealTimeProducts.ValueMember = "ProductID";
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

        private void RefreshProductList()
        {
            foreach (var selectedCategory in selectedCategories)
            {
                var selectedCategoryId = selectedCategory.CategoryID;
                var selectedCategoryProducts = _productRepository.GetByCategoryId(selectedCategoryId);
                if (selectedCategoryProducts == null) continue;
                var categoryGroup = new ListViewGroup(selectedCategory.Name);
                if (lwProducts.Groups.Contains(categoryGroup)) continue;
                lwProducts.Groups.Add(categoryGroup);
                foreach (var selectedCategoryProduct in selectedCategoryProducts)
                {
                    lwProducts.Items.Add(new ListViewItem(
                        new[] { selectedCategoryProduct.ProductName, selectedCategoryProduct.Calory.ToString("F") }, categoryGroup
                    ));
                }
            }
        }

        private void clbCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lwProducts.Items.Clear();
            var selecedCategory = (Category)((CheckedListBox)sender).SelectedItem;
            if (selectedCategories.Count != 0)
            {
                if (!selectedCategories.Contains(selecedCategory))
                {
                    selectedCategories.Add(selecedCategory);
                }
                else
                {
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        selectedCategories.Remove(selecedCategory);
                    }
                }
            }
            else
            {
                if (e.NewValue == CheckState.Checked)
                {
                    selectedCategories.Add(selecedCategory);
                }
            }
            RefreshProductList();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            if (lwProducts.SelectedItems.Count == 0) return;
            foreach (var products in lwProducts.SelectedItems)
            {
                if (lbMealTimeProducts.Items.Count != 0)
                {
                    if (!lbMealTimeProducts.Items.Contains(products))
                    {
                        lbMealTimeProducts.Items.Add(products);
                    }
                }
                else
                {
                    lbMealTimeProducts.Items.Add(products);
                }
            }
        }
    }
}