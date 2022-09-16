using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace DiyetProgrami.UI.Helpers
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
                    var textBox = ctrl as Guna2TextBox;
                    if (string.IsNullOrEmpty(textBox.Text.Trim()))
                        return false;
                }
                else if (ctrlName.Contains("DateTimePicker"))
                {
                    var dateTimePicker = ctrl as Guna2DateTimePicker;
                    if (dateTimePicker.Value >= DateTime.Today)
                        return false;
                }
                else if (ctrlName.Contains("NumericUpDown"))
                {
                    var numericUpDown = ctrl as Guna2NumericUpDown;
                    if (numericUpDown.Value < 0)
                        return false;
                }
            }
            return false;
        }

    }
}
