namespace ExchangeApp;

public partial class MainForm : Form
{
    private Panel oldPanel;
    private Control oldForm;

    public MainForm()
    {
        InitializeComponent();
        SetContentPanel(new LoginForm().loginPanel);
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

    private void closeMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void aboutMenuItem_Click(object sender, EventArgs e)
    {
        SetContentPanel(new AboutForm(oldPanel).aboutPanel);
    }
}