using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using WeightGain.UI.Helpers;

namespace WeightGain.UI
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Helper.CheckPanelEmptyValues(pnlProfile, new object[] { txtPassword, txtPassword2 }))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Lütfen boş alan bırakmayın.",
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()) || !string.IsNullOrEmpty(txtPassword2.Text))
            {
                if (txtPassword.Text.Trim() != txtPassword2.Text.Trim())
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Şifreler uyuşmuyor.",
                        Caption = Properties.Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                    return;
                }
                if (Helper.CheckPasswordStrenght(txtPassword.Text.Trim()) < 3)
                {
                    var messageDialogError = new Guna2MessageDialog
                    {
                        Text = "Girdiğiniz şifre güvenlik açısından çok zayıf. Lütfen özel karakter, büyük harf girmeyi ve şifre uzunluğunu fazla tutmayı deneyin.",
                        Caption = Properties.Resources.ProgramTitle
                    };
                    messageDialogError.Show();
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtTelephone.Text.Trim()))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Email veya telefon numarası girmek zorunludur.",
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
                return;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !Helper.CheckEmail(txtEmail.Text.Trim()))
            {
                var messageDialogError = new Guna2MessageDialog
                {
                    Text = "Email adresinizi kontrol edin.",
                    Caption = Properties.Resources.ProgramTitle
                };
                messageDialogError.Show();
            }

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'D') && (e.KeyChar < 'a' || e.KeyChar > 'd') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'D') && (e.KeyChar < 'a' || e.KeyChar > 'd') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                e.Handled = true;
        }
    }
}
