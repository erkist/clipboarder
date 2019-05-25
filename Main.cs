using System;
using System.Windows.Forms;

namespace Erkist.Clipboarder
{
    public partial class Main : Form
    {
        private GlobalHotkeys hotkeys = new GlobalHotkeys();
        private Provider provider = new Provider();

        public Main()
        {
            InitializeComponent();

            hotkeys.KeyPressed += new EventHandler<KeyPressedEventArgs>(GlobalHotkeyPressed);
            hotkeys.RegisterHotKey(Clipboarder.ModifierKeys.Control | Clipboarder.ModifierKeys.Shift, Keys.C);

            provider.Initialize();
            NextData();
        }

        internal void GlobalHotkeyPressed(object sender, KeyPressedEventArgs eventArgs)
        {
            NextData();
        }

        private void NextData()
        {
            string nextData = provider.NextData();
            Clipboard.SetText(nextData);
            ClipboardText.Text = nextData;
            HumanFriendlyText.Text = provider.DescribeData();
        }
    }
}
