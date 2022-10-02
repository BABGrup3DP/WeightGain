using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
{
    public partial class ProductsFormAdmin : Form
    {
        private readonly ProductRepository _productRepository;
        private List<ProductWithCategory> _productWithCategories;

        public ProductsFormAdmin()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            var categoryRepository = new CategoryRepository();
            cmbProductCategory.DataSource = categoryRepository.GetAll();
            cmbProductCategory.DisplayMember = "Name";
            cmbProductCategory.ValueMember = "CategoryId";
        }

        public void RefreshDataGridView()
        {
            _productWithCategories = new List<ProductWithCategory>();
            var products = _productRepository.GetAll();
            foreach (var product in products)
            {
                var productWithCategory = new ProductWithCategory
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Scale = product.Scale,
                    Calory = product.Calory,
                    Picture = product.Picture,
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category.Name
                };
                _productWithCategories.Add(productWithCategory);
            }
            dgvProducts.AutoGenerateColumns = false;
            if (dgvProducts.DataSource != null)
                dgvProducts.DataSource = null;
            dgvProducts.DataSource = _productWithCategories;
            if (dgvProducts.Columns.Count == 0)
            {
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductID",
                    HeaderText = "ID",
                    Name = "ProductID",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvProducts.Columns[0].Visible = false;
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductName",
                    HeaderText = "Ürün Adı",
                    Name = "ProductName",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,

                });
                dgvProducts.Columns.Add(new DataGridViewImageColumn
                {
                    DataPropertyName = "Picture",
                    HeaderText = "Resim",
                    Name = "Picture",
                    Width = 200,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Scale",
                    HeaderText = "Ölçü",
                    Name = "Scale",
                    Width = 50,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Calory",
                    HeaderText = "Kalori",
                    Name = "Calory",
                    Width = 50,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F" }

                });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CategoryId",
                    HeaderText = "Kategori Id",
                    Name = "CategoryId",
                    Visible = false
                });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "CategoryName",
                    HeaderText = "Kategori",
                    Name = "CategoryName",
                    Width = 100,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
            }
        }

        private void ProductsFormAdmin_Load(object sender, EventArgs e)
        {

            RefreshDataGridView();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var productName = txtProductName.Text.Trim();
            var productScale = txtProductScale.Text.Trim();
            var productCalory = txtProductCalory.Text.Trim();
            var productImage = txtProductImage.Text.Trim();
            var productCategory = (Category)cmbProductCategory.SelectedItem;
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productCalory) || string.IsNullOrEmpty(productScale) || productCategory == null || string.IsNullOrEmpty(productImage))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }
            var product = new Product
            {
                ProductName = productName,
                Scale = productScale,
                Calory = Convert.ToDouble(productCalory),
                Picture = File.ReadAllBytes(productImage),
                Category = productCategory,
            };
            if (_productRepository.Insert(product))
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Ürün eklendi.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogSuccess.Show();
                txtProductName.Text = string.Empty;
                txtProductScale.Text = string.Empty;
                txtProductCalory.Text = string.Empty;
                txtProductImage.Text = string.Empty;
                cmbProductCategory.SelectedItem = 0;
                pbProduct.Image = null;

            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Ürün eklenirken hata oluştu.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
            }
            RefreshDataGridView();
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is ProductWithCategory editedProduct)
            {
                var product = new Product
                {
                    ProductId = editedProduct.ProductId,
                    ProductName = editedProduct.ProductName,
                    Scale = editedProduct.Scale,
                    Calory = editedProduct.Calory,
                    CategoryId = editedProduct.CategoryId,
                    Picture = editedProduct.Picture,
                };
                if (_productRepository.Update(product))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Ürün başarıyla düzenlendi.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogSuccess.Show();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Ürün düzenlenirken hata oluştu.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogError.Show();
                }
                RefreshDataGridView();
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
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Ürün silinirken hata oluştu.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogError.Show();
                }
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Ürün seçilmemiş.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
            }

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            ofdProductImage.Filter = "";

            var codecs = ImageCodecInfo.GetImageEncoders();
            var sep = string.Empty;

            foreach (var c in codecs)
            {
                var codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                ofdProductImage.Filter =
                    $"{ofdProductImage.Filter}{sep}{codecName} ({c.FilenameExtension})|{c.FilenameExtension}";
                sep = "|";
            }
            ofdProductImage.Filter = $"{ofdProductImage.Filter}{sep}All Files (*.*)|*.*";

            var result = ofdProductImage.ShowDialog();

            if (result != DialogResult.OK) return;
            var filename = ofdProductImage.FileName;
            txtProductImage.Text = filename;
            pbProduct.Image = Image.FromFile(filename);
        }
    }
}
