using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.Properties;

namespace WeightGain.UI
{
    public partial class RegisterForm : Form
    {
        private readonly UserRepository _userRepository;
        private bool _showPassword;
        public RegisterForm(List<BaseRepository> repositories)
        {
            InitializeComponent();
            _userRepository = (UserRepository)repositories.Single(x => x.GetType() == typeof(UserRepository));
        }

        #region Helper Functions (Formun üstünden sürüklenmesi)
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(dif));
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            cbFemale.Checked = !cbMale.Checked;
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            cbMale.Checked = !cbFemale.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Hide();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner == null) return;
            Owner.Show();
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!cbAgree.Checked)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "KVKK koşullarını okuyup kabul etmeniz gerekmektedir.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }
            var firstName = txtName.Text.Trim();
            var lastName = txtLastname.Text.Trim();
            var email = txtEmail.Text.Trim();
            var telephone = txtPhoneNumber.Text.Trim();
            var password = txtPassword.Text.Trim();
            var birthDate = dtpBirthDate.Value;
            var age = DateTime.Now.Year - birthDate.Year;
            var weight = nudWeight.Value;
            var height = nudHeight.Value;



            if (!Helper.CheckEmptyValues(formRightPanel, new object[] { txtPhoneNumber }))
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
                        Text = "Lütfen mail adresinizi kontrol edin.",
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
            if (!string.IsNullOrEmpty(telephone) && telephone.Length != 11)
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
            var bMi = Math.Round(weight / (height / 100 * (height / 100)), 2);

            if (bMi > 18.5m)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Vücut kitle indeksiniz:" + bMi + " olarak hesaplanmıştır.\n 18.5'ten büyük olduğu için bu program size uygun değildir.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
                };
                messageDialogError.Show();
                return;
            }

            if (age < 19 || age > 24)
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Üzgünüm. Program 19-24 yaş arası için uygundur.",
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
                        Text = "Başarıyla kayıt oldunuz. Artık giriş yapabilirsiniz.",
                        Caption = Resources.ProgramTitle,
                        Style = MessageDialogStyle.Light
                    };
                    successDialog.Show();
                    Owner?.Show();
                    Hide();
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            lblSlogan.Text = Resources.ProgramSlogan;
            if (!Helper.CheckInternetConnection())
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "İnternete bağlanılamıyor. Programı kullanmak için internete bağlı olmalısınız.",
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light,
                    Buttons = MessageDialogButtons.OK,
                };
                if (messageDialogError.Show() == DialogResult.OK)
                    Close();
            }
            txtName.Focus();
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            cbAgree.Checked = MessageBox.Show("Kişisel verileriniz üyelik başvurunuz sırasında ve / veya sonrasında yazılı ve / veya sözlü olarak ve / veya elektronik ortamda tarafımıza iletmiş olduğunuz, sağlık bilgileri de dahil olmak üzere (ad, soyad, kimlik bilgileri, doğum tarihi, cep telefonu numarası, e-posta,  vb.) özel nitelikli kişisel verilerinizi de içeren her türlü bilgi ve belgeyi ifade etmekte olup, bu veriler üyelerimizin rızaları ve mevzuat hükümleri uyarınca WeightGain tarafından fiziki ve dijital ortamda işlenmekte ve saklanmaktadır. Kabul ediyor musunuz?", Resources.ProgramTitle, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
