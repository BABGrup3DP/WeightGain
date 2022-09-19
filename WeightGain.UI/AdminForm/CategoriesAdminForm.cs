using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;

namespace WeightGain.UI
{
    public partial class CategoriesAdminForm : Form
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoriesAdminForm()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }

        public void RefreshDataGridView()
        {
            dgvCategories.DataSource = _categoryRepository.GetAll();
        }


        private void CategoriesAdminForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
