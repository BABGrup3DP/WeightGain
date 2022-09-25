using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Extensions;

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
                    lwProducts.Items.Add(new ListViewItem(new[] { selectedCategoryProduct.ProductName, selectedCategoryProduct.Calory.ToString("F") })
                    {
                        Tag = selectedCategoryProduct.ProductID,
                        Group = categoryGroup
                    });
                }
            }
        }

        private void RefreshSelectedProductList()
        {
            dgvSelectedProducts.AutoGenerateColumns = false;
            dgvSelectedProducts.DataSource = null;
            dgvSelectedProducts.DataSource = selectedProducts;
            //dgvSelectedProducts.Update();
            //dgvSelectedProducts.Refresh();
            if (dgvSelectedProducts.Columns.Count == 0)
            {
                dgvSelectedProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductID",
                    HeaderText = "ID",
                    Name = "ProductID",
                    ReadOnly = true,
                });
                dgvSelectedProducts.Columns[0].Visible = false;
                dgvSelectedProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductName",
                    HeaderText = "Ürün Adı",
                    Name = "ProductName",
                    Width = 200,
                    ReadOnly = true
                });
                dgvSelectedProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Scale",
                    HeaderText = "Ölçü",
                    Name = "Scale",
                    Width = 100,
                    ReadOnly = true
                });
                dgvSelectedProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Calory",
                    HeaderText = "Kalori",
                    Name = "Calory",
                    Width = 100,
                    ReadOnly = true
                });
                dgvSelectedProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Serving",
                    HeaderText = "Porsiyon",
                    Name = "Serving",
                    Width = 50,
                });
            }
            foreach (DataGridViewRow row in dgvSelectedProducts.Rows)
            {
                if (row.Cells[4].Value == null)
                    row.Cells[4].Value = 1;
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
                var product = _productRepository.GetById(((ListViewItem)products).Tag);
                if (selectedProducts.Count == 0)
                {

                    selectedProducts.Add(product);
                }
                else
                {
                    if (!selectedProducts.Contains(product))
                    {
                        selectedProducts.Add(product);
                    }
                }
            }

            RefreshSelectedProductList();
        }

        private void dgvSelectedProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= CheckServing_KeyPress;
            if (dgvSelectedProducts.CurrentCell.ColumnIndex != 4) return;
            if (e.Control is TextBox tb)
            {
                tb.KeyPress += CheckServing_KeyPress;
            }
        }
        private static void CheckServing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dgvSelectedProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double totalCal = 0;
            foreach (DataGridViewRow row in ((DataGridView)sender).Rows)
            {
                if (row.Cells[4].Value == null) continue;
                totalCal += Convert.ToDouble(row.Cells[3].Value) * Convert.ToDouble(row.Cells[4].Value);
            }
            txtTotalCal.Text = totalCal.ToString("0.##");
        }
    }
}