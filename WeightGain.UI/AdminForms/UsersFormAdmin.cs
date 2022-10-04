using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Extensions;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
{
    public partial class UsersFormAdmin : Form
    {
        private readonly UserRepository _userRepository;
        public UsersFormAdmin(List<BaseRepository> baseRepository)
        {
            InitializeComponent();
            _userRepository = (UserRepository)baseRepository.Single(x => x.GetType() == typeof(UserRepository));
        }

        private void RefreshDataGridView()
        {
            dgvUsers.AutoGenerateColumns = false;

            dgvUsers.DataSource = _userRepository.GetAll();

            if (dgvUsers.Columns.Count == 0)
            {
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Id",
                    HeaderText = "ID",
                    Name = "Id",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvUsers.Columns[0].Visible = false;
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "FirstName",
                    HeaderText = "Adı",
                    Name = "FirstName",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "LastName",
                    HeaderText = "Soyadı",
                    Name = "LastName",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Email",
                    HeaderText = "Email",
                    Name = "Email",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PhoneNumber",
                    HeaderText = "Telefon",
                    Name = "PhoneNumber",
                    Width = 100,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BirthDate",
                    HeaderText = "Doğum Yılı",
                    Name = "BirhDate",
                    Width = 50,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" },
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Age",
                    HeaderText = "Yaş",
                    Name = "Age",
                    Width = 20,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Weight",
                    HeaderText = "Kilo",
                    Name = "Weight",
                    Width = 40,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F" },
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Height",
                    HeaderText = "Boy",
                    Name = "Height",
                    Width = 40,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F" },
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Bmi",
                    HeaderText = "BMI",
                    Name = "Bmi",
                    Width = 40,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "F" },
                });
                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "UserType",
                    HeaderText = "Kullanıcı Türü",
                    Name = "UserType",
                    Width = 40,
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    CellTemplate = new UserTypeEnumTextBoxCell()
                });
            }
        }

        private void UsersFormAdmin_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            using (var userAddFormAdmin = new UserAddFormAdmin(_userRepository))
            {
                userAddFormAdmin.Owner = this;
                userAddFormAdmin.ShowDialog();
            }
            RefreshDataGridView();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var selectedUsers = dgvUsers.SelectedRows;
            var resultMessage = "";
            if (selectedUsers.Count > 0)
            {
                foreach (var selectedUser in selectedUsers)
                {
                    var user = (User)((DataGridViewRow)selectedUser).DataBoundItem;
                    if (user == null) continue;
                    if (user.UserType == UserTypeEnum.Admin)
                    {
                        resultMessage += $"{user.FullName} kullanıcısı yönetici olduğu için silinemez !\n";
                        continue; // admin kullanıcılar silinemez.
                    }
                    if (_userRepository.Delete(user))
                    {
                        resultMessage += $"{user.FullName} kullanıcısı başarıyla silindi.\n";
                    }
                    else
                    {
                        resultMessage += $"{user.FullName} kullanıcısı silinirken hata oluştu.\n";
                    }
                }
                var messageDialog = new Guna2MessageDialog
                {
                    Text = resultMessage,
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialog.Show();
                RefreshDataGridView();
            }
            else
            {
                MessageDialog.Show("Seçilmiş üye bulunamadı !", Resources.ProgramTitle, MessageDialogButtons.OK, MessageDialogStyle.Light);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            var selectedUsers = dgvUsers.SelectedRows;
            if (selectedUsers.Count > 1)
            {
                var messageDialog = new Guna2MessageDialog
                {
                    Text = "Lütfen sadece bir üye seçin.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialog.Show();
                return;
            }
            using (var userAddFormAdmin = new UserAddFormAdmin(_userRepository))
            {
                userAddFormAdmin.Owner = this;
                userAddFormAdmin.selectedUser = (User)selectedUsers[0].DataBoundItem;
                userAddFormAdmin.ShowDialog();
            }
        }

    }
}
