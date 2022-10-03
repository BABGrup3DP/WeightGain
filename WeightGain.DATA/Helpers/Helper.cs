using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WeightGain.DATA.Helpers
{
    public class Helper
    {

        /// <summary>
        /// İnternet bağlantısını kontrol eder.
        /// </summary>
        /// <param name="description">-</param>
        /// <param name="reservedValue">-</param>
        /// <returns>İnternet bağlantısının durumuna göre true ya da false</returns>
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int description, int reservedValue);
        public static bool CheckInternetConnection()
        {
            return InternetGetConnectedState(out var desc, 0);
        }

        /// <summary>
        /// Programın ilk derlenme zamanında veritabanına ekleme yaparken kaynak dosyalarından byte okuması yapmak için kullanılır.
        /// </summary>
        /// <param name="nameOfFile">Dosyanın adı</param>
        /// <returns>Okunan byte değeri</returns>
        public static byte[] GetImageBytes(string nameOfFile)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream($"WeightGain.DATA.Resources.{nameOfFile}.jpg"))
            {
                if (stream == null) return null;
                var buffer = new byte[stream.Length];
                _ = stream.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        /// <summary>
        /// Panel içerisindeki kontrollerin uygun olup olmadığını kontrol ederi.
        /// </summary>
        /// <param name="pnl">Kontrol edilecek olan panel</param>
        /// <param name="dissmissObj">Kontrol edilmeyecek olan kontroller</param>
        /// <returns>Herhangi bir boş alan var ise false döner.</returns>
        public static bool CheckEmptyValues(Panel pnl, object[] dissmissObj = null)
        {
            foreach (var ctrl in pnl.Controls)
            {
                if (dissmissObj != null && dissmissObj.Contains(ctrl)) continue;
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
        /// Groupbox içerisindeki kontrollerin uygun olup olmadığını kontrol ederi.
        /// </summary>
        /// <param name="groupBox">Kontrol edilecek olan groupbox</param>
        /// <param name="dissmissObj">Kontrol edilmeyecek olan kontroller</param>
        /// <returns>Herhangi bir boş alan var ise false döner.</returns>
        public static bool CheckEmptyValues(Guna2GroupBox groupBox, object[] dissmissObj = null)
        {
            foreach (var ctrl in groupBox.Controls)
            {
                if (dissmissObj != null && dissmissObj.Contains(ctrl)) continue;
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
                pnl.Controls.Clear(); // panel içerisindeki kontrolleri temizler
            childForm.TopLevel = false;
            childForm.AutoScroll = true; // Formun içerisindeki kontrolleri otomatik olarak kaydırma özelliğini aktif eder.
            childForm.FormBorderStyle = FormBorderStyle.None; // Formun kenarlıklarını kaldırır.
            childForm.MaximumSize = pnl.Size; // Formun boyutunu panelin boyutuna göre ayarlar.
            childForm.MinimumSize = pnl.Size; // Formun boyutunu panelin boyutuna göre ayarlar.
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
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript)) //number only //"^\d+$" if you need to match more than one digit.
                score++;
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript)) //both, lower and upper case
                score++;
            if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript)) //^[A-Z]+$
                score++;
            return score;
        }

        /// <summary>
        /// Girilen değerin SHA512 ile şifrelenmiş değerini döndürür.
        /// </summary>
        /// <param name="value">SHA512 ile şifrelenecek değer</param>
        /// <returns>SHA512 base64 ile şifrelenmiş değeri</returns>
        public static string GeneratePasswordHash(string value)
        {
            var uEncode = new UnicodeEncoding();
            var bytVa = uEncode.GetBytes(value);
            var sha = new SHA512Managed();
            var hash = sha.ComputeHash(bytVa);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Girilen değerlere göre egzersizde yakılan kaloriyi hesaplar
        /// </summary>
        /// <param name="userWeight">Kullanıcının kilosu</param>
        /// <param name="selectedExerciseIndex">Seçilen egzersiz türü</param>
        /// <param name="totalExerciseTime">Egzersizde geçirilen toplam süre (saniye)</param>
        /// <returns>Toplam yakılan kalori</returns>
        public static decimal CalculateExercise(decimal userWeight, int selectedExerciseIndex, decimal totalExerciseTime)
        {
            var parCoefficient = 1.1m;
            switch (selectedExerciseIndex)
            {
                case 0:
                    parCoefficient = 5.6m;
                    break;
                case 1:
                    parCoefficient = 5.8m;
                    break;
                case 2:
                    parCoefficient = 6.34m;
                    break;
                case 3:
                    parCoefficient = 2.1m;
                    break;
                case 4:
                    parCoefficient = 9.0m;
                    break;
            }
            return userWeight * parCoefficient * totalExerciseTime / 60;
        }

        /// <summary>
        /// Girilen değerlere göre kullanıcının günlük alması gereken kaloriyi hesaplar
        /// </summary>
        /// <param name="userWeight">Kullanıcının kilosu</param>
        /// <param name="userHeight">Kullanıcının boyu</param>
        /// <param name="userAge">Kullanıcının yaşı</param>
        /// <returns>Günlük alınması gereken kalori miktarı</returns>
        public static decimal CalculateNeededCalory(decimal userWeight, decimal userHeight, int userAge)
        {
            return decimal.Round((655.1m + 9.56m * userWeight + 1.85m * userHeight - 4.68m * userAge) * 1.1m, 2);
        }


    }
}
