using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI
{
    public partial class RegisterForm : Form
    {
        private readonly UserRepository _userRepository;
        public RegisterForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        #region Helper Functions
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(dif));
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
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
            if ((e.KeyChar < 'A' || e.KeyChar > 'D') && (e.KeyChar < 'a' || e.KeyChar > 'd') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'D') && (e.KeyChar < 'a' || e.KeyChar > 'd') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                    Caption = Properties.Resources.ProgramTitle
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
                        Caption = Properties.Resources.ProgramTitle
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
                    Caption = Properties.Resources.ProgramTitle
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
                };
                if (_userRepository.Insert(newUser))
                {
                    var successDialog = new Guna2MessageDialog
                    {
                        Text = "Başarıyla kayıt oldunuz. Artık giriş yapabilirsiniz.",
                        Caption = Properties.Resources.ProgramTitle
                    };
                    successDialog.Show();
                }
            }
            catch
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Hata oluştu. Girilen değerleri lütfen kontrol edin.",
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
