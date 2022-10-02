using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Properties;

namespace WeightGain.UI.AdminForms
{
    public partial class UserAddFormAdmin : Form
    {
        private readonly UserRepository _userRepository;
        private bool _showPassword;
        public User selectedUser;
        public UserAddFormAdmin(UserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        #region Helper Functions
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void UserAddFormAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void UserAddFormAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(dif));
        }

        private void UserAddFormAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var password = txtPassword.Text.Trim();
            if (!string.IsNullOrEmpty(password))
            {
                var score = Helper.CheckPasswordStrenght(password);
                pbStr.Value = 20 * score;
                switch (score)
                {
                    case 0:
                        pbStr.ProgressColor = Color.Red;
                        pbStr.ProgressColor2 = Color.Red;
                        break;
                    case 1:
                        pbStr.ProgressColor = Color.Orange;
                        pbStr.ProgressColor2 = Color.Orange;
                        break;
                    case 2:
                        pbStr.ProgressColor = Color.Blue;
                        pbStr.ProgressColor2 = Color.Blue;
                        break;
                    case 3:
                        pbStr.ProgressColor = Color.DarkBlue;
                        pbStr.ProgressColor2 = Color.DarkBlue;
                        break;
                    case 4:
                        pbStr.ProgressColor = Color.Green;
                        pbStr.ProgressColor2 = Color.Green;
                        break;
                    case 5:
                        pbStr.ProgressColor = Color.DarkGreen;
                        pbStr.ProgressColor2 = Color.DarkGreen;
                        break;
                }
            }
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            txtPassword.PasswordChar = _showPassword ? '\0' : '*';
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var firstName = txtName.Text.Trim();
            var lastName = txtLastname.Text.Trim();
            var email = txtEmail.Text.Trim();
            var telephone = txtPhoneNumber.Text.Trim();
            var password = txtPassword.Text.Trim();
            var birthDate = dtpBirthDate.Value;
            var weight = nudWeight.Value;
            var height = nudHeight.Value;

            if (!Helper.CheckEmptyValues(formRightPanel, new object[] { txtPhoneNumber, txtEmail }))
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

            if (!string.IsNullOrEmpty(email))
            {
                if (!Helper.CheckEmail(email))
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Lütfen mail adresini kontrol edin.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogError.Show();
                    return;
                }
            }

            if (Helper.CheckPasswordStrenght(password) < 3)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Girdiğiniz şifre güvenlik açısından çok zayıf. Lütfen özel karakter, büyük harf girmeyi ve şifre uzunluğunu fazla tutmayı deneyin.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }
            if (weight == 0 || height == 0)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Kilo ve boy değerlerini kontrol edin.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }
            try
            {
                var newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = telephone,
                    BirthDate = birthDate,
                    Password = Helper.GeneratePasswordHash(password),
                    Weight = weight,
                    Height = height,
                    UserType = UserTypeEnum.User
                };
                if (_userRepository.Insert(newUser))
                {
                    var successDialog = new Guna2MessageDialog
                    {
                        Text = "Yeni üye başarıyla eklendi.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    successDialog.Show();
                }
            }
            catch
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Hata oluştu. Girilen değerleri lütfen kontrol edin.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
            }
        }

        private void UserAddFormAdmin_Load(object sender, EventArgs e)
        {
            if (selectedUser == null) return;
            txtName.Text = selectedUser.FirstName;
            txtLastname.Text = selectedUser.LastName;
            txtEmail.Text = selectedUser.Email;
            txtPhoneNumber.Text = selectedUser.PhoneNumber;
            txtPassword.Text = string.Empty;
            dtpBirthDate.Value = selectedUser.BirthDate;
            nudWeight.Value = selectedUser.Weight;
            nudHeight.Value = selectedUser.Height;
        }
    }
}
