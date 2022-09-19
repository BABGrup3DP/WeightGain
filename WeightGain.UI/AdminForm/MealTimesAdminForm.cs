using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Properties;

namespace WeightGain.UI
{
    public partial class MealTimesAdminForm : Form
    {
        private readonly User _logginedUser;
        private readonly MealTimeRepository _mealTimeRepository;
        public MealTimesAdminForm(User logginedUser)
        {
            InitializeComponent();
            _logginedUser = logginedUser;
            _mealTimeRepository = new MealTimeRepository();
            cmbMealTimeType.DataSource = _mealTimeRepository.GetMealTimes();
        }

        private void MealTimesAdminForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAddMealTime_Click(object sender, EventArgs e)
        {
            var mealTimeType = cmbMealTimeType.SelectedIndex;
            var mealTimeDesc = txtMealTimeDesc.Text.Trim();
            if (mealTimeType == -1 || string.IsNullOrEmpty(mealTimeDesc))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            var mealTime = new MealTime
            {
                MealTimeType = (MealTimeEnum)mealTimeType,
                MealTimeDescription = mealTimeDesc
            };
            if (_mealTimeRepository.Insert(mealTime))
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Öğün eklendi.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogSuccess.Show();
                RefreshDataGridView();
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Öğün eklenirken hata oluştu.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void btnDeleteMealTime_Click(object sender, EventArgs e)
        {
            var selectedCells = dgvMealTimes.SelectedCells;
            if (selectedCells.Count >= 0)
            {
                var selectedMealTimeId = selectedCells[0].Value;
                if (_mealTimeRepository.Delete((int)selectedMealTimeId))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Öğün başarıyla silindi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Öğün silinirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Öğün seçilmemiş.",
                    Caption = Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void btnEditMealTime_Click(object sender, EventArgs e)
        {

        }

        private void RefreshDataGridView()
        {
            dgvMealTimes.DataSource = _mealTimeRepository.GetAll();
            dgvMealTimes.Columns[0].ReadOnly = true;
            dgvMealTimes.Columns[0].HeaderText = "ID";
            dgvMealTimes.Columns[1].ReadOnly = true;
            dgvMealTimes.Columns[1].HeaderText = "Öğün Adı";
            dgvMealTimes.Columns[2].HeaderText = "Öğün Açıklaması";

        }

        private void dgvMealTimes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var newDescription = dgvMealTimes.Rows[e.RowIndex].Cells[2].Value;
                var mealTimeType = dgvMealTimes.Rows[e.RowIndex].Cells[1].Value;
                var mealTimeId = dgvMealTimes.Rows[e.RowIndex].Cells[0].Value;
                var mealTime = new MealTime
                {
                    MealTimeId = (int)mealTimeId,
                    MealTimeType = (MealTimeEnum)mealTimeType,
                    MealTimeDescription = newDescription.ToString()
                };
                if (_mealTimeRepository.Update(mealTime))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Öğün başarıyla düzenlendi.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogSuccess.Show();
                    RefreshDataGridView();
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Öğün düzenlenirken hata oluştu.",
                        Caption = Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                }
            }
        }
    }
}
