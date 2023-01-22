namespace ExchangeApp
{
    partial class ExchangeForm
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
            this.exchangePanel = new System.Windows.Forms.Panel();
            this.exchangeTabControl = new System.Windows.Forms.TabControl();
            this.favoritesTabPage = new System.Windows.Forms.TabPage();
            this.allTabPage = new System.Windows.Forms.TabPage();
            this.exchangePanel.SuspendLayout();
            this.exchangeTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // exchangePanel
            // 
            this.exchangePanel.Controls.Add(this.exchangeTabControl);
            this.exchangePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangePanel.Location = new System.Drawing.Point(0, 0);
            this.exchangePanel.Name = "exchangePanel";
            this.exchangePanel.Size = new System.Drawing.Size(605, 309);
            this.exchangePanel.TabIndex = 0;
            // 
            // exchangeTabControl
            // 
            this.exchangeTabControl.Controls.Add(this.favoritesTabPage);
            this.exchangeTabControl.Controls.Add(this.allTabPage);
            this.exchangeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangeTabControl.Location = new System.Drawing.Point(0, 0);
            this.exchangeTabControl.Name = "exchangeTabControl";
            this.exchangeTabControl.SelectedIndex = 0;
            this.exchangeTabControl.Size = new System.Drawing.Size(605, 309);
            this.exchangeTabControl.TabIndex = 0;
            // 
            // favoritesTabPage
            // 
            this.favoritesTabPage.Location = new System.Drawing.Point(4, 24);
            this.favoritesTabPage.Name = "favoritesTabPage";
            this.favoritesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favoritesTabPage.Size = new System.Drawing.Size(597, 281);
            this.favoritesTabPage.TabIndex = 0;
            this.favoritesTabPage.Text = "Избранные";
            this.favoritesTabPage.UseVisualStyleBackColor = true;
            // 
            // allTabPage
            // 
            this.allTabPage.Location = new System.Drawing.Point(4, 24);
            this.allTabPage.Name = "allTabPage";
            this.allTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allTabPage.Size = new System.Drawing.Size(597, 281);
            this.allTabPage.TabIndex = 1;
            this.allTabPage.Text = "Все";
            this.allTabPage.UseVisualStyleBackColor = true;
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 309);
            this.Controls.Add(this.exchangePanel);
            this.MinimumSize = new System.Drawing.Size(621, 348);
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.exchangePanel.ResumeLayout(false);
            this.exchangeTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl exchangeTabControl;
        private TabPage favoritesTabPage;
        private TabPage allTabPage;
        public Panel exchangePanel;
    }
}