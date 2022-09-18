using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WeightGain.UI.Helpers
{
    public class Helper
    {
        /// <summary>
        /// Panel içerisindeki kontrollerin uygun olup olmadığını kontrol ederi.
        /// </summary>
        /// <param name="pnl">Kontrol edilecek olan panel</param>
        /// <returns>Herhangi bir boş alan var ise false döner.</returns>
        public static bool CheckPanelEmptyValues(Panel pnl)
        {
            foreach (var ctrl in pnl.Controls)
            {
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
        /// 
        /// </summary>
        /// <param name="pnl"></param>
        /// <param name="childForm"></param>
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
    }
}
