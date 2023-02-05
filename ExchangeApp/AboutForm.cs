using System.Windows.Forms;

namespace ExchangeApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            (aboutPanel.Parent.Parent as MainForm).SetContentPanel(new ExchangeForm().exchangePanel);
        }
    }
}
