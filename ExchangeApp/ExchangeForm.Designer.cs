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
            this.favoritesDataGridView = new System.Windows.Forms.DataGridView();
            this.allDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.percentageDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.exchangePanel.SuspendLayout();
            this.exchangeTabControl.SuspendLayout();
            this.favoritesTabPage.SuspendLayout();
            this.allTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataGridView)).BeginInit();
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
            this.favoritesTabPage.Controls.Add(this.favoritesDataGridView);
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
            this.allTabPage.Controls.Add(this.allDataGridView);
            this.allTabPage.Location = new System.Drawing.Point(4, 24);
            this.allTabPage.Name = "allTabPage";
            this.allTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allTabPage.Size = new System.Drawing.Size(597, 281);
            this.allTabPage.TabIndex = 1;
            this.allTabPage.Text = "Все";
            this.allTabPage.UseVisualStyleBackColor = true;
            // 
            // favoritesDataGridView
            // 
            this.favoritesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favoritesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Course,
            this.image,
            this.percentageDifference,
            this.difference,
            this.delete});
            this.favoritesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favoritesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.favoritesDataGridView.Name = "favoritesDataGridView";
            this.favoritesDataGridView.RowTemplate.Height = 25;
            this.favoritesDataGridView.Size = new System.Drawing.Size(591, 275);
            this.favoritesDataGridView.TabIndex = 0;
            this.favoritesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.favoritesDataGridView_CellContentClick);
            // 
            // allDataGridView
            // 
            this.allDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allDataGridView.Location = new System.Drawing.Point(3, 3);
            this.allDataGridView.Name = "allDataGridView";
            this.allDataGridView.RowTemplate.Height = 25;
            this.allDataGridView.Size = new System.Drawing.Size(591, 275);
            this.allDataGridView.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
            // 
            // Course
            // 
            this.Course.HeaderText = "Курс";
            this.Course.Name = "Course";
            // 
            // image
            // 
            this.image.HeaderText = "";
            this.image.Name = "image";
            this.image.Width = 15;
            // 
            // percentageDifference
            // 
            this.percentageDifference.HeaderText = "Динамика в процентах";
            this.percentageDifference.Name = "percentageDifference";
            // 
            // difference
            // 
            this.difference.HeaderText = "Динамика";
            this.difference.Name = "difference";
            this.difference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Text = "Удалить";
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 309);
            this.Controls.Add(this.exchangePanel);
            this.MinimumSize = new System.Drawing.Size(621, 348);
            //this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.exchangePanel.ResumeLayout(false);
            this.exchangeTabControl.ResumeLayout(false);
            this.favoritesTabPage.ResumeLayout(false);
            this.allTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favoritesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl exchangeTabControl;
        private TabPage favoritesTabPage;
        private TabPage allTabPage;
        public Panel exchangePanel;
        private DataGridView favoritesDataGridView;
        private DataGridView allDataGridView;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn percentageDifference;
        private DataGridViewTextBoxColumn difference;
        private DataGridViewButtonColumn delete;
    }
}