using System.Windows.Forms;

namespace ExchangeApp
{
    public partial class AboutForm : Form
    {
        private readonly Panel _oldPanel;
        public AboutForm(Panel oldPanel)
        {
            InitializeComponent();
            _oldPanel = oldPanel;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            (aboutPanel.Parent.Parent as MainForm).SetContentPanel(_oldPanel);
        }
    }
}
