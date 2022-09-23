using System;
using System.Windows.Forms;
using WeightGain.DATA;

namespace WeightGain.UI.UserForms
{
    public partial class MainForm : Form
    {
        private readonly User _logginedUser;
        public MainForm(User logginedUser)
        {
            _logginedUser = logginedUser;
            InitializeComponent();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDateNow.Text = "Tarih: " + DateTime.Now.ToString("D");
            decimal weight = _logginedUser.Weight;
            decimal height = _logginedUser.Height;
            byte age = _logginedUser.Age;
            lblUser.Text = _logginedUser.FullName;
            txtAgeText.Text = Convert.ToString(age);
            txtHeightText.Text = Convert.ToString(decimal.Round(height, 2));
            txtWeightText.Text = Convert.ToString(decimal.Round(weight, 2));

            txtBMH.Text = Convert.ToString(decimal.Round(weight / (height * height) * 10000, 2));
            decimal neededCalory = decimal.Round((655.1m + (9.56m * weight) + (1.85m * height) - (4.68m * age)) * 1.1m, 2);
            txtGetCalory.Text = neededCalory.ToString();
        }
    }
}
