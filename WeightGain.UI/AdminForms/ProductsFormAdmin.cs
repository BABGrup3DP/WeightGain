using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
{
    public partial class ProductsFormAdmin : Form
    {
        public readonly ProductRepository _productRepository;
        public readonly CategoryRepository _categoryRepository;

        public ProductsFormAdmin()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            cmbProductCategory.DataSource = _categoryRepository.GetAll();
            cmbProductCategory.DisplayMember = "Name";
            cmbProductCategory.ValueMember = "CategoryId";
        }

        public void RefreshDataGridView()
        {
            dgvProducts.DataSource = _productRepository.GetAll();
        }

        private void ProductsFormAdmin_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productRepository.GetAll();
            dgvProducts.Columns[0].HeaderText = "ID";
            dgvProducts.Columns[0].ReadOnly = true;
            dgvProducts.Columns[1].HeaderText = "Ürün Adı";
            dgvProducts.Columns[2].HeaderText = "Ölçüsü";
            dgvProducts.Columns[3].HeaderText = "Kalori Değeri";
            //dgvProducts.Columns[4].HeaderText = "Kategori ID";
            //dgvProducts.Columns[4].ReadOnly= true;
            //dgvProducts.Columns[5].HeaderText = "Kategori Adı";

            RefreshDataGridView();
            // TODO : düzeltilecek
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var productName = txtProductName.Text.Trim();
            var productScale = txtProductScale.Text.Trim();
            var productCalory = txtProductCalory.Text.Trim();
            var productCategory = (Category)cmbProductCategory.SelectedItem;
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productCalory) || string.IsNullOrEmpty(productScale) || productCategory == null)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            var product = new Product
            {
                ProductName = productName,
                Scale = productScale,
                Calory = Convert.ToDouble(productCalory),

                Category = (Category)productCategory,
            };
            if (_productRepository.Insert(product))
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Ürün eklendi.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Ürün eklenirken hata oluştu.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var newCategory = dgvProducts.Rows[e.RowIndex].Cells[5].Value;
                var newCategoryId = dgvProducts.Rows[e.RowIndex].Cells[4].Value;
                var newCalory = dgvProducts.Rows[e.RowIndex].Cells[3].Value;
                var newScale = dgvProducts.Rows[e.RowIndex].Cells[2].Value;
                var newProductName = dgvProducts.Rows[e.RowIndex].Cells[1].Value;
                var productId = dgvProducts.Rows[e.RowIndex].Cells[0].Value;
                var product = new Product
                {
                    ProductId = (int)productId,
                    ProductName = (string)newProductName,
                    Scale = (string)newScale,
                    Calory = (double)newCalory,
                    CategoryId = (int)newCategoryId,
                    Category = (Category)newCategory,

                };
                if (_productRepository.Update(product))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Ürün başarıyla düzenlendi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Ürün düzenlenirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedCells = dgvProducts.SelectedCells;
            if (selectedCells.Count >= 0)
            {
                var selectedProductId = selectedCells[0].Value;
                if (_productRepository.Delete((int)selectedProductId))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Ürün başarıyla silindi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Ürün silinirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Ürün seçilmemiş.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }
    }
}
