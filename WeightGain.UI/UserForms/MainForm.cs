using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;
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
            lblDateToday.Text = DateTime.Now.ToString();
            decimal weight = _logginedUser.Weight;
            decimal height = _logginedUser.Height;
            byte age= _logginedUser.Age;
            lblUser.Text = _logginedUser.FullName;
            txtAgeText.Text = Convert.ToString(age);
            txtHeightText.Text = Convert.ToString(height);
            txtWeightText.Text = Convert.ToString(weight);

            txtBMH.Text =Convert.ToString( weight / (height * height) * 10000) ;
            double neededCalory = (655.1+(9.56 *(double)weight)+(1.85*(double)height)-(4.68*age))*1.1;
            txtGetCalory.Text = neededCalory.ToString();
        }
    }
}
