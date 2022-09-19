using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;

namespace WeightGain.UI
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

        private void ProductsFormAdmin_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _productRepository.GetAll();
            //dgvProducts.Columns[0].HeaderText = "ID";
            //dgvProducts.Columns[1].HeaderText = "Kategori Adı";
            //dgvProducts.Columns[2].HeaderText = "Ürün Adı";
            //dgvProducts.Columns[3].HeaderText = "Ölçüsü";
            //dgvProducts.Columns[4].HeaderText = "Kalori Değeri";

            // TODO : düzeltilecek
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var productName = txtProductName.Text.Trim();
        }
    }
}
