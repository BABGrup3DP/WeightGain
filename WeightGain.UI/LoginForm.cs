using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA.Helpers;
using WeightGain.UI.AdminForms;
using WeightGain.UI.Properties;
using WeightGain.UI.UserForms;

namespace WeightGain.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository;
        private bool showPassword = false;
        public LoginForm()
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

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm()
            {
                Owner = this
            };
            Hide();
            registerForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckEmptyValues(formRightPanel))
            {
                var messageDialog = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Resources.ProgramTitle
                };
                messageDialog.Show();
                return;
            }

            var emailOrPhone = txtEmailPhone.Text.Trim();
            var password = txtPassword.Text.Trim();
            var findUser = _userRepository.CheckLogin(emailOrPhone, Helper.GeneratePasswordHash(password));
            if (findUser != null)
            {
                if (cbRememberMe.Checked)
                {
                    Settings.Default.emailphone = emailOrPhone;
                    Settings.Default.password = password;
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.emailphone = string.Empty;
                    Settings.Default.password = string.Empty;
                    Settings.Default.Save();
                }
                switch (findUser.UserType)
                {
                    case DATA.UserTypeEnum.Admin:
                        var adminForm = new AdminForm(_userRepository, findUser)
                        {
                            Owner = this
                        };
                        Hide();
                        adminForm.Show();
                        return;
                    case DATA.UserTypeEnum.ProjectManager:
                        MessageBox.Show("Proje yöneticisi girişi yapıldı.");
                        return;
                    case DATA.UserTypeEnum.Dietitian:
                        MessageBox.Show("Diyetisyen girişi yapıldı.");
                        return;
                    case DATA.UserTypeEnum.User:
                        var userForm = new UserForm(_userRepository, findUser)
                        {
                            Owner = this
                        };
                        Hide();
                        userForm.Show();
                        break;
                    default:
                        var messageDialogError = new Guna2MessageDialog
                        {
                            Text = "Bir hata oluştu. ",
                            Caption = Resources.ProgramTitle
                        };
                        messageDialogError.Show();
                        break;
                }
            }
            else
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Girilen bilgilere göre bir kullanıcı bulunamadı. Şimdi üye olmak ister misin?",
                    Caption = Resources.ProgramTitle,
                    Buttons = MessageDialogButtons.YesNo,
                };
                if (messageDialogError.Show() == DialogResult.No) return;
                var registerForm = new RegisterForm()
                {
                    Owner = this
                };
                registerForm.Show();
                Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmailPhone.Focus();
            if (!string.IsNullOrEmpty(Settings.Default.emailphone) && !string.IsNullOrEmpty(Settings.Default.password))
            {
                txtEmailPhone.Text = Settings.Default.emailphone;
                txtPassword.Text = Settings.Default.password;
                cbRememberMe.Checked = true;
            }
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            txtPassword.PasswordChar = showPassword ? '\0' : '*';
        }

        private void lblSlogan_Click(object sender, EventArgs e)
        {

        }
    }
}
