using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeightGain.UI.Helpers;

namespace WeightGain.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        #region Helper Functions
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(dif));
        }

        private void AdminForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner == null) return;
            Owner.Show();
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Close();
        }

        private void btnMealTimes_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new MealTimeForm());
        }

        private void btnExercies_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ExerciseForm());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ReportForm());
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ArchiveForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ProfileForm());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new HelpForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnMealTimes.PerformClick();
        }
    }
}
