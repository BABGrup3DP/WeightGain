using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

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

        public static void ChangeButtonEnableMenu(Panel pnl, Guna2Button selectedBtn)
        {
            foreach (var ctrl in pnl.Controls)
            {
                if (ctrl is Guna2Button)
                {
                    if (ctrl == selectedBtn)
                        selectedBtn.Enabled = false;
                    else
                        selectedBtn.Enabled = true;
                }
            }
        }
    }
}
