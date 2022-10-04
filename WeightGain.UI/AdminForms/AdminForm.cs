﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;
using WeightGain.UI.UserForms;

namespace WeightGain.UI.AdminForms
{
    public partial class AdminForm : Form
    {
        public readonly UserRepository _userRepository;
        private readonly List<BaseRepository> _baseRepositories;
        private readonly User _logginedUser;
        public AdminForm(List<BaseRepository> baseRepository, User logginedUser)
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

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new UsersFormAdmin(_userRepository));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            //Helper.OpenChildForm(mainPanel, new ReportForm());
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            //Helper.OpenChildForm(mainPanel, new ReportForm(_logginedUser));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ProfileForm(_userRepository, _logginedUser));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Helper.OpenChildForm(mainPanel, new AdminMainForm(_baseRepositories));
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new CategoriesAdminForm());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Helper.ChangeButtonEnableMenu(leftMenuPanel, sender as Guna2Button);
            Helper.OpenChildForm(mainPanel, new ProductsFormAdmin());
        }

        private void leftPanelMenuLogo_Click(object sender, EventArgs e)
        {
            Helper.OpenChildForm(mainPanel, new AdminMainForm(_baseRepositories));
        }
    }
}
