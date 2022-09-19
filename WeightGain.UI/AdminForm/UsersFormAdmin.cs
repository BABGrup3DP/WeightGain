using System;
using System.Linq;
using System.Windows.Forms;
using WeightGain.DAL.Repositories;

namespace WeightGain.UI
{
    public partial class UsersFormAdmin : Form
    {
        public readonly UserRepository _userRepository;
        public UsersFormAdmin(UserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = _userRepository.GetAll();
            dgvUsers.Columns[0].HeaderText = "ID";
            dgvUsers.Columns[1].HeaderText = "Ad Soyad";
            dgvUsers.Columns[2].HeaderText = "Kilo";
            dgvUsers.Columns[3].HeaderText = "Boy";
            dgvUsers.Columns[4].HeaderText = "Yaş";

        }
    }
}
