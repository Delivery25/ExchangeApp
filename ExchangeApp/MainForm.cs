using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeApp
{
    public partial class MainForm : Form
    {
        private Panel oldPanel;
        private Control oldForm;

        public MainForm()
        {
            InitializeComponent();
            SetContentPanel(new LoginForm().loginPanel);
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetContentPanel(new AboutForm().aboutPanel);
        }

        public void SetContentPanel(Panel panel)
        {
            if (oldPanel != null)
            {
                oldPanel.Parent = oldForm;
            }
            oldPanel = panel;
            oldForm = panel.Parent;
            panel.Parent = mainPanel;
        }
    }
}
