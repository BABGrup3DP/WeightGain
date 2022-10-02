using System.Windows.Forms;

namespace WeightGain.UI.UserForms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnnedir_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Günlük kilo artış ve azalımını takip etmek için tasarlanmış masaüstü bir yazılım programıdır");
        }

        private void btnuyelik_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("weightgain.com üzerinden Üye ol seçeneğine tıklayarak üye olabilirsin");
        }

        private void btnucret_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Evet,WeightGain ücretsiz bir uygulamadır.Web sitesi üzerinden ücretsiz olarak yararlabilirsin");

        }

        private void btnyassiniri_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("WeightGain uygulamasını 19-24 yaş aralığında vücut kitle endeksi 18.5 altında olan herkes kullanabilir");
        }

        private void btnhesaplama_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Kalori hesaplama için kişinin vücut ölçüleri gereklidir.Vücut bilgilerinizi ilgili bölümden girebilirsiniz.WeightGain kişiye en uygun diyet listesini sunarken kişisel bilgilerini ve hedeflerini göz önüne alır");
        }

        private void btnsecim_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Kullanıcı ana sayfasından öğünlere girerek karşınıza çıkan öğünlerden uygun olanı seçtiğinizde karşınıza çıkan kategorilere göre ürün seçimi yapabilirsiniz");
        }

        private void btnbilgigoruntuleme_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Günlük kalori bilgilerinizi kullanıcı ana sayfası üzerinden yada detaylı olarak 'Raporlar' bölümünden görüntüleyebilirsiniz.");
        }

        private void btnantremangirisi_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Kullanıcı ana sayfası üzerinden 'Antremanlar' Bölümüne giriş yaparak, günlük egsersiz bilgi girişi ile kalori hesaplaması yapabilirsiniz.");
        }

        private void btnsonuculasim_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(" 'Raporlar' bölümünden geçmiş verilerinize ulaşabilirsiniz.");

        }

        private void btnuyelikiptali_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(" Dilediğiniz zaman Profil sayfasından üyelik iptalinizi gerçekleştirebilirsiniz.");
        }
    }
}


