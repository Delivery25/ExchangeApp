namespace ExchangeApp
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.aboutPictureBox = new System.Windows.Forms.PictureBox();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.closeButton);
            this.aboutPanel.Controls.Add(this.headerLabel);
            this.aboutPanel.Controls.Add(this.infoLabel);
            this.aboutPanel.Controls.Add(this.aboutPictureBox);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPanel.Location = new System.Drawing.Point(0, 0);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(605, 309);
            this.aboutPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(493, 250);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(331, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(163, 32);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "О программе";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLabel.Location = new System.Drawing.Point(285, 84);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(273, 189);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Приложение разработано с целью \r\nинформирования пользователей об \r\nактуальном кур" +
    "се валют\r\n\r\nПриложение разработала\r\nДудникова Диана\r\nПКГХ\r\n2023\r\n\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutPictureBox
            // 
            this.aboutPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.aboutPictureBox.Image = global::ExchangeApp.Properties.Resources.about;
            this.aboutPictureBox.Location = new System.Drawing.Point(0, 0);
            this.aboutPictureBox.Name = "aboutPictureBox";
            this.aboutPictureBox.Size = new System.Drawing.Size(228, 309);
            this.aboutPictureBox.TabIndex = 0;
            this.aboutPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 309);
            this.Controls.Add(this.aboutPanel);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox aboutPictureBox;
        private Label infoLabel;
        private Label headerLabel;
        public Panel aboutPanel;
        private Button closeButton;
    }
}