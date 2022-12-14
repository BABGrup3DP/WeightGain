using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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
        private bool _showPassword;
        private readonly List<BaseRepository> _repositoryList = new List<BaseRepository>();
        public LoginForm()
        {
            _userRepository = new UserRepository();
            var categoryRepository = new CategoryRepository();
            var productRepository = new ProductRepository();
            var portionRepository = new PortionRepository();
            var exerciseRepository = new ExerciseRepository();
            var mealTimeRepository = new MealTimeRepository();
            InitializeComponent();
            _repositoryList.Add(_userRepository);
            _repositoryList.Add(categoryRepository);
            _repositoryList.Add(productRepository);
            _repositoryList.Add(portionRepository);
            _repositoryList.Add(exerciseRepository);
            _repositoryList.Add(mealTimeRepository);
        }

        #region Helper Functions (Formun üstünden sürüklenmesi)
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
            var registerForm = new RegisterForm(_repositoryList)
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
                    Caption = Resources.ProgramTitle,
                    Style = MessageDialogStyle.Light
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
                        var adminForm = new AdminForm(_repositoryList, findUser)
                        {
                            Owner = this
                        };
                        Hide();
                        adminForm.Show();
                        return;
                    case DATA.UserTypeEnum.Dietitian:
                        MessageBox.Show("Diyetisyen girişi henüz geliştirilmedi.");
                        return;
                    case DATA.UserTypeEnum.User:
                        var userForm = new UserForm(_repositoryList, findUser)
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
                            Caption = Resources.ProgramTitle,
                            Style = MessageDialogStyle.Light
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
                    Style = MessageDialogStyle.Light,
                    Buttons = MessageDialogButtons.YesNo,
                };
                if (messageDialogError.Show() == DialogResult.No) return;
                var registerForm = new RegisterForm(_repositoryList)
                {
                    Owner = this
                };
                registerForm.Show();
                Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
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

            txtEmailPhone.Focus();
            if (!string.IsNullOrEmpty(Settings.Default.emailphone) && !string.IsNullOrEmpty(Settings.Default.password))
            {
                txtEmailPhone.Text = Settings.Default.emailphone;
                txtPassword.Text = Settings.Default.password;
                cbRememberMe.Checked = true;
            }
            ttBtnLogin.SetToolTip(btnLogin, "Giriş yapmak için tıklayın.");
        }

        private void txtPassword_IconRightClick(object sender, EventArgs e)
        {
            _showPassword = !_showPassword;
            txtPassword.PasswordChar = _showPassword ? '\0' : '*';
        }
    }
}
