using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeightGain.UI.Helpers
{
    public class Helper
    {
        /// <summary>
        /// Panel içerisindeki kontrollerin uygun olup olmadığını kontrol ederi.
        /// </summary>
        /// <param name="pnl">Kontrol edilecek olan panel</param>
        /// <param name="dissmissObj">Kontrol edilmeyecek olan kontroller</param>
        /// <returns>Herhangi bir boş alan var ise false döner.</returns>
        public static bool CheckPanelEmptyValues(Panel pnl, object[] dissmissObj = null)
        {
            foreach (var ctrl in pnl.Controls)
            {
                if (dissmissObj == null || !dissmissObj.Contains(ctrl)) continue;
                var ctrlName = ctrl.GetType().Name;
                if (ctrlName.Contains("TextBox"))
                {
                    if (ctrl is Guna2TextBox textBox && string.IsNullOrEmpty(textBox.Text.Trim()))
                        return false;
                }
                else if (ctrlName.Contains("DateTimePicker"))
                {
                    if (ctrl is Guna2DateTimePicker dateTimePicker && dateTimePicker.Value >= DateTime.Today)
                        return false;
                }
                else if (ctrlName.Contains("NumericUpDown"))
                {
                    if (ctrl is Guna2NumericUpDown numericUpDown && numericUpDown.Value < 0)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Panel içerisindeki butonların bulunduğu menüye göre akif ve pasif durumunu ayarlar
        /// </summary>
        /// <param name="pnl">Butonların bulunduğu panel</param>
        /// <param name="pressedBtn">Tıklanan buton</param>
        public static void ChangeButtonEnableMenu(Panel pnl, Guna2Button pressedBtn)
        {
            foreach (var ctrl in pnl.Controls)
            {
                if (!(ctrl is Guna2Button button)) continue;
                button.Enabled = button != pressedBtn;
                button.ImageAlign = button.Enabled ? HorizontalAlignment.Left : HorizontalAlignment.Right;
            }
        }

        /// <summary>
        /// Panel içerisinde form açmaya yarayan metot
        /// </summary>
        /// <param name="pnl">İçerisinde form açılacak olan panel</param>
        /// <param name="childForm">Gösterilecek olan form</param>
        public static void OpenChildForm(Panel pnl, Form childForm)
        {
            if (pnl.Controls.Count > 0) // Eğer önceden form eklendiyse
                pnl.Controls.RemoveAt(0); // formu içerisinden kaldır
            childForm.TopLevel = false;
            childForm.AutoScroll = true; // Formun içerisindeki kontrolleri otomatik olarak kaydırma özelliğini aktif eder.
            childForm.FormBorderStyle = FormBorderStyle.None; // Formun kenarlıklarını kaldırır.
            pnl.Controls.Add(childForm); // Formu panel içerisine ekle
            childForm.Show(); // Formu göster
        }

        /// <summary>
        /// Girilen verinin email olup olmadığını kontrol eder
        /// </summary>
        /// <param name="email">Girilen değer</param>
        /// <returns>Doğru ya da yanlış</returns>
        public static bool CheckEmail(string email)
        {
            var mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
            return string.IsNullOrEmpty(email) || mRegxExpression.IsMatch(email);
        }

        /// <summary>
        /// Girilen şifrenin zorluk derecesini verir.
        /// </summary>
        /// <param name="password">Girilen şifre</param>
        /// <returns>0-5 arasında zorluğa göre tam sayı döndürür</returns>
        /// ref : https://social.msdn.microsoft.com/Forums/en-US/5e3f27d2-49af-410a-85a2-3c47e3f77fb1/how-to-check-for-password-strength?forum=csharpgeneral
        public static int CheckPasswordStrenght(string password)
        {
            var score = 1;
            if (password.Length < 1)
                return 0;
            if (password.Length < 4)
                return 1;
            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))   //number only //"^\d+$" if you need to match more than one digit.
                score++;
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //both, lower and upper case
                score++;
            if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
                score++;
            return score;
        }

        /// <summary>
        /// Girilen değerin MD5 ile şifrelenmiş değerini döndürür.
        /// </summary>
        /// <param name="value">MD5 ile şifrelenecek değer</param>
        /// <returns>MD5 hash değeri</returns>
        public string GenerateMd5(string value)
        {
            var md5Hasher = MD5.Create();
            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            return BitConverter.ToString(data);
        }
    }
}
