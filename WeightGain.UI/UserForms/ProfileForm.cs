using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Properties;

namespace WeightGain.UI.UserForms
{
    public partial class ProfileForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly User _logginedUser;
        private bool _showPassword;
        private bool _showPassword2;


        public ProfileForm(UserRepository userRepository, User logginedUser)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _logginedUser = logginedUser;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updatingUser = _logginedUser;
            if (!Helper.CheckEmptyValues(pnlProfile, new object[] { txtPassword, txtPassword2 }))
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
            var userName = txtFirstName.Text.Trim();
            var lastName = txtLastName.Text.Trim();
            updatingUser.FirstName = userName;
            updatingUser.LastName = lastName;

            var password = txtPassword.Text.Trim();
            var password2 = txtPassword2.Text.Trim();

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(password2))
            {
                if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Şifreler uyuşmuyor.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogError.Show();
                    return;
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
                updatingUser.Password = Helper.GeneratePasswordHash(password);
            }

            var email = txtEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email) && !Helper.CheckEmail(email))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Email adresinizi kontrol edin.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }
            var telephone = txtPhone.Text.Trim();
            if (telephone.Length != 11)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Telefon numarası 11 haneli olmalıdır.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }
            var weight = nudWeight.Value;
            var height = nudHeight.Value;
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
            updatingUser.Email = email;
            updatingUser.PhoneNumber = telephone;
            updatingUser.BirthDate = dtpBirthDate.Value;
            updatingUser.Weight = weight;
            updatingUser.Height = height;
            _userRepository.Update(updatingUser);
            var messageDialog = new Guna2MessageDialog
            {
                Text = "Bilgileriniz başarıyla güncellendi.",
                Caption = Resources.ProgramTitle,
                Style = MessageDialogStyle.Light
            };
            messageDialog.Show();


        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _logginedUser.FirstName;
            txtLastName.Text = _logginedUser.LastName;
            txtEmail.Text = _logginedUser.Email;
            txtPhone.Text = _logginedUser.PhoneNumber;
            dtpBirthDate.Value = _logginedUser.BirthDate;
            nudWeight.Value = _logginedUser.Weight;
            nudHeight.Value = _logginedUser.Height;
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

        private void txtPassword2_IconRightClick(object sender, EventArgs e)
        {
            _showPassword2 = !_showPassword2;
            txtPassword2.PasswordChar = _showPassword2 ? '\0' : '*';
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var messageDialog = new Guna2MessageDialog
            {
                Icon = MessageDialogIcon.Warning,
                Caption = "Dikkat",
                Buttons = MessageDialogButtons.YesNo,
                Text = "Hesabınızı silmek istediğinize emin misiniz? Bu işlem geri alınamaz.",
                Style = MessageDialogStyle.Light
            };
            if (messageDialog.Show() == DialogResult.OK)
            {
                if (_userRepository.Delete(_logginedUser))
                {
                    var messageDialogSuccess = new Guna2MessageDialog
                    {
                        Text = "Hesabınız başarıyla silindi. Program şimdi kapatılacak.",
                        Buttons = MessageDialogButtons.OK,
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogSuccess.Style = MessageDialogStyle.Light;
                    Environment.Exit(0);
                }
                else
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Hesabınız silinirken hata oluştu.",
                        Buttons = MessageDialogButtons.OK,
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    messageDialogError.Show();
                }
            }
            else
            {
                var messageDialogSuccess = new Guna2MessageDialog
                {
                    Text = "Hesap silme işlemi iptal edildi.",
                    Buttons = MessageDialogButtons.OK,
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogSuccess.Show();
            }
        }
    }
}
