using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.UI.Helpers;

namespace WeightGain.UI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
