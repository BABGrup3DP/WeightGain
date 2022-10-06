using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace WeightGain.UI.UserForms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private Guna2MessageDialog _messageDialog;
        private void HelpForm_Load(object sender, System.EventArgs e)
        {
            _messageDialog = new Guna2MessageDialog
            {
                Icon = MessageDialogIcon.Information,
                Caption = "Bilgilendirme",
                Buttons = MessageDialogButtons.OK,
                Style = MessageDialogStyle.Light,
            };
        }

        private void btnNedir_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Nedir?";
            _messageDialog.Text = "Günlük kilo artış ve azalımını takip etmek için tasarlanmış\nmasaüstü bir yazılım programıdır.";
            _messageDialog.Show();
        }

        private void btnUyelik_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Üyelik";
            _messageDialog.Text = "Üyelik işlemleri için kayıt ol butonuna tıklayarak kayıt olabilirsiniz.Kayıt olurken kullanıcı adı, e-posta ve\nşifre bilgilerinizi girerek üyelik işlemini tamamlayabilirsiniz.\nÜyelik oluşturulduktan sonra giriş yapabilirsiniz";
            _messageDialog.Show();
        }

        private void btnUcret_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Ücret";
            _messageDialog.Text = "Evet, WeightGain ücretsiz bir uygulamadır.\nWeb sitesi üzerinden ücretsiz olarak yararlabilirsin.";
            _messageDialog.Show();
        }

        private void btnYasSiniri_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Yaş Sınırı";
            _messageDialog.Text = "WeightGain uygulamasını 19-24 yaş aralığında vücut kitle\nendeksi 18.5 altında olan kadın kullanıcılar kullanabilir.";
            _messageDialog.Show();
        }

        private void btnHesaplama_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Hesaplama";
            _messageDialog.Text = "Kalori hesaplama için kişinin vücut ölçüleri gereklidir.\nVücut bilgilerinizi ilgili bölümden girebilirsiniz.\nWeightGain kişiye en uygun diyet listesini sunarken kişisel bilgilerini \nve hedeflerini göz önüne alır.";
            _messageDialog.Show();
        }

        private void btnSecim_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Öğün ve Ürün Seçimi";
            _messageDialog.Text = "Kullanıcı ana sayfasından öğünlere girerek karşınıza çıkan öğünlerden uygun olanı \nseçtiğinizde karşınıza çıkan kategorilere göre ürün seçimi yapabilirsiniz.";
            _messageDialog.Show();
        }

        private void btnBilgiGoruntuleme_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Bilgi Görüntüleme";
            _messageDialog.Text = "Günlük kalori bilgilerinizi kullanıcı ana sayfası üzerinden yada detaylı olarak  \n'Raporlar' bölümünden görüntüleyebilirsiniz.";
            _messageDialog.Show();
        }

        private void btnAntremanGirisi_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Antreman Girişi";
            _messageDialog.Text = "Kullanıcı ana sayfası üzerinden 'Antremanlar' Bölümüne giriş yaparak, \ngünlük egsersiz bilgi girişi ile kalori hesaplaması yapabilirsiniz.";
            _messageDialog.Show();
        }

        private void btnSonucUlasim_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Sonuç Ulaşım";
            _messageDialog.Text = "'Raporlar' bölümünden geçmiş verilerinize ulaşabilirsiniz.";
            _messageDialog.Show();
        }
        
        private void btnUyelikIptali_Click(object sender, System.EventArgs e)
        {
            _messageDialog.Caption = "Üyelik İptali";
            _messageDialog.Text = "Dilediğiniz zaman Profil sayfasından üyelik iptalinizi \ngerçekleştirebilirsiniz.";
            _messageDialog.Show();
        }
    }
}


