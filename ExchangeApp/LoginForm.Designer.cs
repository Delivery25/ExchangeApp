namespace ExchangeApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.loginTextBox);
            this.loginPanel.Controls.Add(this.welcomLabel);
            this.loginPanel.Controls.Add(this.loginPictureBox);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(605, 309);
            this.loginPanel.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(269, 167);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 21);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(280, 103);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(54, 21);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Логин";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(467, 234);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(338, 165);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(204, 23);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(338, 103);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(204, 23);
            this.loginTextBox.TabIndex = 2;
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomLabel.Location = new System.Drawing.Point(316, 25);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(226, 32);
            this.welcomLabel.TabIndex = 1;
            this.welcomLabel.Text = "Добро пожаловать";
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginPictureBox.Image = global::ExchangeApp.Properties.Resources.login;
            this.loginPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(228, 309);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 309);
            this.Controls.Add(this.loginPanel);
            this.MinimumSize = new System.Drawing.Size(621, 348);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox loginPictureBox;
        private Label welcomLabel;
        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox loginTextBox;
        private Label passwordLabel;
        private Label loginLabel;
        public Panel loginPanel;
    }
}