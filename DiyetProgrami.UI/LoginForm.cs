using DiyetProgrami.UI.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiyetProgrami.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Helper Functions
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckPanelEmptyValues(formRightPanel))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın !", Properties.Resources.ProgramTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
