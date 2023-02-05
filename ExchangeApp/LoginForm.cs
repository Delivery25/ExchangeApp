using System.Security.Cryptography;

namespace ExchangeApp;
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        //var salt = string.Empty;        
        //var password = HashPassword(passwordTextBox.Text, ref salt);

        if(loginTextBox.Text == Properties.Resources.loginText)
        {
            var result = VerifyHashedPassword(passwordTextBox.Text);
            if (result)
            {
                (loginPanel.Parent.Parent as MainForm).SetContentPanel(new ExchangeForm().exchangePanel);
            }
            else
            {
                MessageBox.Show("Данные для авторизации введены неверно");
            }
        }
        else
        {
            MessageBox.Show("Данные для авторизации введены неверно");
        }
    }

    //https://ru.stackoverflow.com/questions/545944/%D0%9A%D0%B0%D0%BA-%D0%B7%D0%B0%D1%88%D0%B8%D1%84%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D0%BF%D0%B0%D1%80%D0%BE%D0%BB%D0%B8
    public static bool VerifyHashedPassword(string password)
    {
        var result = new byte[31];
        var salt = Convert.FromBase64String(Properties.Resources.saltText);
        using (var bytes = new Rfc2898DeriveBytes(password, salt, 0x3e8))
        {
            result = bytes.GetBytes(0x20);
        }
        byte[] dst = new byte[0x31];
        Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
        Buffer.BlockCopy(result, 0, dst, 0x11, 0x20);
        var textResult = Convert.ToBase64String(dst);
        return Equals(textResult, Properties.Resources.passwordText);
    }

    public string HashPassword(string password, ref string usersalt)
    {
        byte[] salt;
        byte[] buffer2;

        using (var bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
        {
            salt = bytes.Salt;
            buffer2 = bytes.GetBytes(0x20);
        }
        usersalt = Convert.ToBase64String(salt);
        byte[] dst = new byte[0x31];
        Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
        Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
        return Convert.ToBase64String(dst);
    }
}