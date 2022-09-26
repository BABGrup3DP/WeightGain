using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Properties;

namespace WeightGain.UI.UserForms
{
    public partial class MealTimeForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        private readonly PortionRepository _portionRepository;
        private readonly User _logginedUser;
        private MealTimeEnum _selectedMealTime = MealTimeEnum.Sabah_Kahvaltısı;
        private readonly List<Category> _selectedCategories;
        private readonly List<ProductWithPortion> _productWithPortions;

        public MealTimeForm(User logginedUser)
        {
            InitializeComponent();
            twcMealTimes.NextButton = btnNext;
            twcMealTimes.PreviousButton = btnPrev;
            _mealTimeRepository = new MealTimeRepository();
            _categoryRepository = new CategoryRepository();
            _productRepository = new ProductRepository();
            _portionRepository = new PortionRepository();
            _selectedCategories = new List<Category>();
            _productWithPortions = new List<ProductWithPortion>();
            _logginedUser = logginedUser;
        }

        private void MealTimeForm_Load(object sender, EventArgs e)
        {
            clbCategories.DataSource = _categoryRepository.GetAll();
            clbCategories.DisplayMember = "Name";
            clbCategories.ValueMember = "CategoryId";
            twcMealTimes.LastButtonClicked += TwcMealTimes_LastButtonClicked;
        }


        private void TwcMealTimes_LastButtonClicked(object sender, EventArgs e)
        {
            if (_productWithPortions.Count == 0)
            {
                var messageDialog = new Guna2MessageDialog
                {
                    Text = "Lütfen en az bir ürün seçin.",
                    Caption = Resources.ProgramTitle
                };
                messageDialog.Show();
                return;
            }

            var mealTimeDate = dtpMealTime.Value;
            var newMealTime = new MealTime
            {
                MealTimeType = _selectedMealTime,
                MealTimeDescription = "",
                MealTimeDate = mealTimeDate,
                UserId = _logginedUser.Id,
            };


            if (_mealTimeRepository.Insert(newMealTime) && _mealTimeRepository.AddProductsToMealTime(newMealTime, _productWithPortions))
            {
                var messageDialog = new Guna2MessageDialog
                {
                    Text = "Öğün başarıyla eklendi.",
                    Caption = Resources.ProgramTitle
                };
                messageDialog.Show();
            }
            else
            {
                var messageDialog = new Guna2MessageDialog
                {
                    Text = "Öğün eklenirken hata oluştu.",
                    Caption = Resources.ProgramTitle
                };
                messageDialog.Show();
            }
        }

        private void SelectMealTime(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "breakfast":
                    _selectedMealTime = MealTimeEnum.Sabah_Kahvaltısı;
                    break;
                case "firstsnack":
                    _selectedMealTime = MealTimeEnum.Birinci_Ara_öğün;
                    break;
                case "lunch":
                    _selectedMealTime = MealTimeEnum.Öğle_Yemeği;
                    break;
                case "secondsnack":
                    _selectedMealTime = MealTimeEnum.İkinci_Ara_Öğün;
                    break;
                case "dinner":
                    _selectedMealTime = MealTimeEnum.Akşam_Yemeği;
                    break;
                case "thirdsnack":
                    _selectedMealTime = MealTimeEnum.Üçüncü_Ara_Öğün;
                    break;
            }
        }

        private void RefreshProductList()
        {
            foreach (var selectedCategory in _selectedCategories)
            {
                var selectedCategoryId = selectedCategory.CategoryId;
                var selectedCategoryProducts = _productRepository.GetByCategoryId(selectedCategoryId);
                if (selectedCategoryProducts == null) continue;
                var categoryGroup = new ListViewGroup(selectedCategory.Name);
                if (lwProducts.Groups.Contains(categoryGroup)) continue;
                lwProducts.Groups.Add(categoryGroup);
                foreach (var selectedCategoryProduct in selectedCategoryProducts)
                {
                    var memStream = new MemoryStream(selectedCategoryProduct.Picture);
                    lwImageList.Images.Add(Image.FromStream(memStream));
                    var lastId = lwImageList.Images.Count - 1;
                    var item = new ListViewItem(new[]
                    {
                        selectedCategoryProduct.ProductName,
                        selectedCategoryProduct.Calory.ToString("F")
                    }, lastId)
                    {
                        Tag = selectedCategoryProduct.ProductId,
                        Group = categoryGroup
                    };
                    lwProducts.Items.Add(item);
                }
            }
            lwProducts.SmallImageList = lwImageList;
        }

        private void RefreshSelectedProductList()
        {
            dgvSelectedProducts.AutoGenerateColumns = false;
            dgvSelectedProducts.DataSource = null;
            dgvSelectedProducts.DataSource = _productWithPortions;

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
                    DataPropertyName = "Size",
                    HeaderText = "Porsiyon",
                    Name = "Size",
                    Width = 50,
                });
            }

            foreach (DataGridViewRow row in dgvSelectedProducts.Rows)
            {
                if (row.Cells[4].Value == null)
                    row.Cells[4].Value = 1;
            }
            dgvSelectedProducts_CellEndEdit(dgvSelectedProducts, null);
        }

        private void clbCategories_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            lwProducts.Items.Clear();
            var selecedCategory = (Category)((CheckedListBox)sender).SelectedItem;
            if (_selectedCategories.Count != 0)
            {
                if (!_selectedCategories.Contains(selecedCategory))
                {
                    _selectedCategories.Add(selecedCategory);
                }
                else
                {
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        _selectedCategories.Remove(selecedCategory);
                    }
                }
            }
            else
            {
                if (e.NewValue == CheckState.Checked)
                {
                    _selectedCategories.Add(selecedCategory);
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
                var productWithPortion = new ProductWithPortion()
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Scale = product.Scale,
                    Calory = product.Calory,
                    Size = 1
                };
                if (_productWithPortions.Count == 0)
                {
                    _productWithPortions.Add(productWithPortion);
                }
                else
                {
                    if (!_productWithPortions.Contains(productWithPortion))
                        _productWithPortions.Add(productWithPortion);
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