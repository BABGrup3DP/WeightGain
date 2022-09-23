using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.UserForms
{
    public partial class ProfileForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly User _logginedUser;
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
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            updatingUser.FirstName = txtFirstName.Text.Trim();
            updatingUser.LastName = txtLastName.Text.Trim();

            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()) && !string.IsNullOrEmpty(txtPassword2.Text))
            {
                if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Şifreler uyuşmuyor.",
                        Caption = Properties.Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                    return;
                }
                if (Helper.CheckPasswordStrenght(txtPassword.Text.Trim()) < 3)
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Girdiğiniz şifre güvenlik açısından çok zayıf. Lütfen özel karakter, büyük harf girmeyi ve şifre uzunluğunu fazla tutmayı deneyin.",
                        Caption = Properties.Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                    return;
                }
                updatingUser.Password = Helper.GeneratePasswordHash(txtPassword.Text.Trim());
            }

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !Helper.CheckEmail(txtEmail.Text.Trim()))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Email adresinizi kontrol edin.",
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            updatingUser.Email = txtEmail.Text.Trim();
            updatingUser.PhoneNumber = txtPhone.Text.Trim();
            updatingUser.BirthDate = dtpBirthDate.Value;
            updatingUser.Weight = nudWeight.Value;
            updatingUser.Height = nudHeight.Value;
            _userRepository.Update(updatingUser);
            var messageDialog = new Guna2MessageDialog
            {
                Text = "Bilgileriniz başarıyla güncellendi.",
                Caption = Properties.Resources.ProgramTitle
            };
            messageDialog.Show();


        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'D') && (e.KeyChar < 'a' || e.KeyChar > 'd') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'D') && (e.KeyChar < 'a' || e.KeyChar > 'd') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
