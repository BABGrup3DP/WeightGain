using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
{
    public partial class UsersFormAdmin : Form
    {
        private readonly UserRepository _userRepository;
        public UsersFormAdmin(UserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void RefreshDataGridView()
        {
            dgvUsers.DataSource = _userRepository.GetAll();
            dgvUsers.AutoGenerateColumns = true;
            

            
            dgvUsers.Columns["FullName"].DisplayIndex = dgvUsers.Columns.Count - 1;
            dgvUsers.Columns["FullName"].Visible = false;

            dgvUsers.Columns["Password"].DisplayIndex = dgvUsers.Columns.Count - 2;
            dgvUsers.Columns["Password"].Visible = false;

            dgvUsers.Columns["ID"].DisplayIndex = 0;

            dgvUsers.Columns["FirstName"].DisplayIndex = 1;
            dgvUsers.Columns["FirstName"].HeaderText = "AD";

            dgvUsers.Columns["LastName"].DisplayIndex = 2;
            dgvUsers.Columns["LastName"].HeaderText = "SOYAD";

            dgvUsers.Columns["BirthDate"].DisplayIndex = 3;
            dgvUsers.Columns["BirthDate"].HeaderText = "DOĞUM TARİHİ";

            dgvUsers.Columns["Age"].DisplayIndex = 4;
            dgvUsers.Columns["Age"].HeaderText = "YAŞ";

            dgvUsers.Columns["Height"].DisplayIndex = 5;
            dgvUsers.Columns["Height"].HeaderText = "KİLO";

            dgvUsers.Columns["Weight"].DisplayIndex = 6;
            dgvUsers.Columns["Weight"].HeaderText = "BOY";

            dgvUsers.Columns["Bmi"].DisplayIndex = 7;
            dgvUsers.Columns["Bmi"].HeaderText = "BMI";

            dgvUsers.Columns["Email"].DisplayIndex = 8;
            dgvUsers.Columns["Email"].HeaderText = "EMAİL";

            dgvUsers.Columns["PhoneNumber"].DisplayIndex = 9;
            dgvUsers.Columns["PhoneNumber"].HeaderText = "TELEFON";

            dgvUsers.Columns["UserType"].DisplayIndex = 10;
            dgvUsers.Columns["UserType"].HeaderText = "ÜYELİK TİPİ";
            dgvUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvUsers.AutoGenerateColumns = false;
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
                    var user = ((DataGridViewRow)selectedUser).DataBoundItem as User;
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
                    Caption = Resources.ProgramTitle
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

        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
