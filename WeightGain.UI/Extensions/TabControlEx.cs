using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

// ref => https://github.com/piksel/TabWizardControl
namespace WeightGain.UI.Extensions
{
    public class TabWizardControl : TabControl
    {
        [DefaultValue(true), Category("Design")]
        public bool HideTabs { get; set; } = true;

        [DefaultValue(false), Category("Design")]
        public bool HideTabsInDesign { get; set; } = false;

        public new TabAlignment Alignment { get; set; } = TabAlignment.Bottom;

        public override string Text { get; set; }

        public string NextButtonLastText { get; set; }

        public event EventHandler PageChanged;

        private void OnPageChanged() => PageChanged?.Invoke(this, EventArgs.Empty);

        public event EventHandler LastButtonClicked;
        private void OnLastButtonClicked() => LastButtonClicked?.Invoke(this, EventArgs.Empty);

        private IconButton _nextButton;

        [Category("Buttons")]
        public IconButton NextButton
        {
            get => _nextButton;
            set
            {
                _nextButton = value;
                _nextButton.Enabled = true;
                _nextButton.Click += NextButton_Click;
            }
        }


        private IconButton _prevButton;

        [Category("Buttons")]
        public IconButton PreviousButton
        {
            get => _prevButton;
            set
            {
                _prevButton = value;
                _prevButton.Enabled = false;
                _prevButton.Click += PrevButton_Click;
            }
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == TabPages.Count - 1)
            {
                OnLastButtonClicked();
                return;
            }

            if (_nextPage.ContainsKey(SelectedTab))
                SelectedTab = _nextPage[SelectedTab]();
            else
                SelectedIndex++;

            if (_pageDisplay.ContainsKey(SelectedTab))
                _pageDisplay[SelectedTab](false);

            UpdateState();
            OnPageChanged();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (_prevPage.ContainsKey(SelectedTab))
                SelectedTab = _prevPage[SelectedTab]();
            else if (SelectedIndex > 0)
                SelectedIndex--;

            if (_pageDisplay.ContainsKey(SelectedTab))
                _pageDisplay[SelectedTab](true);

            UpdateState();
            OnPageChanged();

        }

        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 &&
                ((HideTabsInDesign && DesignMode) ||
                (HideTabs && !DesignMode)))
            {
                m.Result = (IntPtr)1;
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private readonly Dictionary<TabPage, Func<TabPage>> _nextPage = new Dictionary<TabPage, Func<TabPage>>();
        private readonly Dictionary<TabPage, Func<TabPage>> _prevPage = new Dictionary<TabPage, Func<TabPage>>();

        public void NextFunction(TabPage page, Func<TabPage> func)
        {
            if (_nextPage.ContainsKey(page))
                _nextPage[page] = func;
            else
                _nextPage.Add(page, func);
        }

        public void NextFunction(TabPage page, Func<bool> func)
        {
            NextFunction(page, () => func() ? TabPages[TabPages.IndexOf(page) + 1] : null);
        }

        public void NextFunction(TabPage current, TabPage next)
        {
            NextFunction(current, () => next);
        }

        public void PreviousFunction(TabPage page, Func<TabPage> func)
        {
            if (_prevPage.ContainsKey(page))
                _prevPage[page] = func;
            else
                _prevPage.Add(page, func);
        }

        public void PreviousFunction(TabPage page, Func<bool> func)
        {
            PreviousFunction(page, () => func() ? TabPages[TabPages.IndexOf(page) - 1] : null);
        }

        public void PreviousFunction(TabPage current, TabPage previous)
        {
            PreviousFunction(current, () => previous);
        }

        readonly Dictionary<TabPage, Action<bool>> _pageDisplay = new Dictionary<TabPage, Action<bool>>();

        public void PageDisplayed(TabPage page, Action<bool> func)
        {
            if (_pageDisplay.ContainsKey(page))
                _pageDisplay[page] = func;
            else
                _pageDisplay.Add(page, func);
        }

        public void UpdateState()
        {
            if (NextButton != null)
            {
                if (_nextPage.ContainsKey(SelectedTab))
                {
                    NextButton.Enabled = _nextPage[SelectedTab]() != null;
                }
                if (SelectedIndex == TabCount - 1 && !string.IsNullOrEmpty(NextButtonLastText))
                {
                    NextButton.Text = NextButtonLastText;
                    NextButton.IconChar = IconChar.Save;
                }
                else
                {
                    NextButton.Text = TabPages[SelectedIndex + 1].Text;
                    NextButton.IconChar = IconChar.Forward;
                }
            }
            if (PreviousButton != null)
            {
                if (SelectedIndex > 0)
                {
                    PreviousButton.Enabled = true;
                    PreviousButton.IconChar = IconChar.Backward;
                    PreviousButton.Text = TabPages[SelectedIndex - 1].Text;
                }
                else
                {
                    PreviousButton.Enabled = false;
                    PreviousButton.IconChar = IconChar.None;
                    PreviousButton.Text = "";
                }
            }
            Text = SelectedTab.Text;
        }
    }
}
