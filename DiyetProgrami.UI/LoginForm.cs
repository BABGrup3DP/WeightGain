using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.UI.Helpers;

namespace WeightGain.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            if (!Helper.CheckPanelEmptyValues(formRightPanel))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }
            var userForm = new AdminForm()
            {
                Owner = this
            };
            Hide();
            userForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmailTelephone.Focus();
        }
    }
}
