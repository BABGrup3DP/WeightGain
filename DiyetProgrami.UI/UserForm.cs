using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.UI.Helpers;

namespace WeightGain.UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        #region Helper Functions
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void UserForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Show();
                if (e.CloseReason != CloseReason.FormOwnerClosing)
                    Owner.Close();
            }
        }

        private void btnLunchs_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void btnExercies_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            btnLunchs.Enabled = false;
        }
    }
}
