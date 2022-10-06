using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WeightGain.UI.Properties;

namespace WeightGain.UI.CustomForms
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            lblCaption.Text = $"{Resources.ProgramTitle} - {title}";
            lblMessage.Text = message;
            SetFormSize();
        }

        private void SetFormSize()
        {
            var width = lblMessage.Width;
            var height = panelTop.Height + lblMessage.Height + panelBottom.Height;
            Size = new Size(width, height);
        }
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
