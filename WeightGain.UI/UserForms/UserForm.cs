using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.UI.UserForms
{
    public partial class UserForm : Form
    {
        private readonly UserRepository _userRepository;
        private readonly List<BaseRepository> _baseRepositories;
        private readonly User _logginedUser;
        public UserForm(List<BaseRepository> baseRepository, User logginedUser)
        {
            InitializeComponent();
            _baseRepositories = baseRepository;
            _userRepository = (UserRepository)baseRepository.Single(x => x.GetType() == typeof(UserRepository));
            _logginedUser = logginedUser;
        }

        #region Helper Functions
        private bool _dragging;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
        }

        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(dif));
        }

        private void UserForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion
        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner == null) return;
            Owner.Show();
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Close();
        }

        private void btnMealTimes_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new MealTimeForm(_baseRepositories, _logginedUser));
        }

        private void btnExercies_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ExerciseForm(_baseRepositories, _logginedUser));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ReportForm(_baseRepositories, _logginedUser));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ProfileForm(_baseRepositories, _logginedUser));
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

        private void UserForm_Load(object sender, EventArgs e)
        {
            Helper.OpenChildForm(mainPanel, new MainForm(_baseRepositories, _logginedUser));
        }


        private void leftPanelMenuLogo_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(mainPanel, new MainForm(_baseRepositories, _logginedUser));
        }

    }
}
