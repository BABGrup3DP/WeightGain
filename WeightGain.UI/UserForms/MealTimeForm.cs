﻿using System;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
using WeightGain.DATA;

namespace WeightGain.UI.UserForms
{
    public partial class MealTimeForm : Form
    {
        private readonly MealTimeRepository _mealTimeRepository;
        private readonly User _logginedUser;
        public MealTimeForm(User logginedUser)
        {
            InitializeComponent();
            _mealTimeRepository = new MealTimeRepository();
            _logginedUser = logginedUser;
        }

        private void MealTimeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
