using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void lblMenuLunchs_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuExercises_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuReports_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuArchives_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuProfile_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuHelp_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
