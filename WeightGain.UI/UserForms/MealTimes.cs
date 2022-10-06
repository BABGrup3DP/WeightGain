using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Extensions;
using WeightGain.UI.Properties;

namespace WeightGain.UI.UserForms
{
    public partial class MealTimes : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly User _logginedUser;
        private readonly List<ProductWithPortion> _productWithPortions;

        public MealTimes(List<BaseRepository> baseRepositories, User logginedUser)
        {
            InitializeComponent();
            _mealTimeRepository = (MealTimeRepository)baseRepositories.First(x => x.GetType() == typeof(MealTimeRepository));
            _logginedUser = logginedUser;
            _productWithPortions = new List<ProductWithPortion>();
        }

        private void MealTimes_Load(object sender, EventArgs e)
        {

            RefreshDataGridView();
            dgvMealTimes.DataSource = _productWithPortions.OrderBy(x => x.MealTimeDate).ToList();
        }

        private void RefreshDataGridView()
        {
            _productWithPortions?.Clear();
            var mealTimes = _mealTimeRepository.GetAllByUserId(_logginedUser.Id);
            foreach (var mealTime in mealTimes)
            {
                if (mealTime.Products != null)
                {
                    foreach (var product in mealTime.Products)
                    {
                        var productWithPortion = new ProductWithPortion
                        {
                            ProductName = product.ProductName,
                            ProductId = product.ProductId,
                            Calory = product.Calory,
                            Scale = product.Scale,
                            MealTime = mealTime.MealTimeType,
                            MealTimeDate = mealTime.MealTimeDate,
                        };
                        var findPortion = product.ProductPortions.First(x => x.MealTimeId == mealTime.MealTimeId);
                        productWithPortion.MealTimeId = findPortion.MealTimeId;
                        productWithPortion.Size = findPortion.Size;
                        _productWithPortions.Add(productWithPortion);
                    }
                }
            }

            dgvMealTimes.AutoGenerateColumns = false;
            dgvMealTimes.DataSource = null;
            dgvMealTimes.DataSource = _productWithPortions;

            if (dgvMealTimes.Columns.Count == 0)
            {
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductID",
                    HeaderText = "ID",
                    Name = "ProductID",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvMealTimes.Columns[0].Visible = false;
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MealTimeId",
                    HeaderText = "MealTimeId",
                    Name = "MealTimeId",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvMealTimes.Columns[1].Visible = false;
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MealTime",
                    HeaderText = "Öğün Adı",
                    Name = "MealTime",
                    Width = 200,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    CellTemplate = new MealTimeEnumTextBoxCell(),
                    Tag = "MealTime"
                });
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MealTimeDate",
                    HeaderText = "Tarih",
                    Name = "MealTimeDate",
                    Width = 100,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle() { Format = "dd.MM.yyyy" },
                });
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductName",
                    HeaderText = "Ürün Adı",
                    Name = "ProductName",
                    Width = 200,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Scale",
                    HeaderText = "Ölçü",
                    Name = "Scale",
                    Width = 100,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Calory",
                    HeaderText = "Kalori",
                    Name = "Calory",
                    Width = 100,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F" }
                });
                dgvMealTimes.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Size",
                    HeaderText = "Porsiyon",
                    Name = "Size",
                    Width = 50,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F" }
                });

            }
            //dgvSelectedProducts_CellEndEdit(dgvSelectedProducts, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMealTimes.SelectedRows.Count != 0)
            {
                foreach (var row in dgvMealTimes.SelectedRows)
                {
                    var productWithPortion = (ProductWithPortion)((DataGridViewRow)row).DataBoundItem;
                    if (productWithPortion != null)
                        _mealTimeRepository.Delete(productWithPortion.MealTimeId);
                }
                RefreshDataGridView();
            }
            else
            {
                var messageDialog = new Guna2MessageDialog
                {
                    Text = "Hiçbir ürün seçilmemiş.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialog.Show();
            }
        }
    }
}
