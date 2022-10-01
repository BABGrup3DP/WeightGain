using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
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
            dgvCategories.Columns[0].ReadOnly = true;
            dgvCategories.Columns[0].HeaderText = "ID";
            dgvCategories.Columns[1].HeaderText = "Kategori Adı";
            dgvCategories.Columns[2].HeaderText = "Kategori Açıklaması";
        }


        private void CategoriesAdminForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var categoryName = txtCategoryName.Text.Trim();
            var categoryDesc = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(categoryName)||string.IsNullOrEmpty(categoryDesc))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            var category = new Category
            {
                Name = categoryName,
                Description = categoryDesc,
            };
            if (_categoryRepository.Insert(category))
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Kategori eklendi.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Kategori eklenirken hata oluştu.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            var selectedCells = dgvCategories.SelectedCells;
            if (selectedCells.Count >= 0)
            {
                var selectedCategoryId = selectedCells[0].Value;
                if (_categoryRepository.Delete((int)selectedCategoryId))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Kategori başarıyla silindi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Kategori silinirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Kategori seçilmemiş.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void dgvCategories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return;
            var newDescription = dgvCategories.Rows[e.RowIndex].Cells[2].Value;
            var newcategoryName = dgvCategories.Rows[e.RowIndex].Cells[1].Value;
            var categoryId = dgvCategories.Rows[e.RowIndex].Cells[0].Value;
            var category = new Category
            {
                CategoryId = (int)categoryId,
                Name=(string)newcategoryName,
                Description = newDescription == null ? "" : newDescription.ToString()
            };
            if (_categoryRepository.Update(category))
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Kategori başarıyla düzenlendi.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Kategori düzenlenirken hata oluştu.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }
    }
}
