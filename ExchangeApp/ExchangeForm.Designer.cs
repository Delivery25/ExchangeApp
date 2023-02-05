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
            this.allTabPage = new System.Windows.Forms.TabPage();
            this.favoritesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameValute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.exchangePanel.SuspendLayout();
            this.exchangeTabControl.SuspendLayout();
            this.favoritesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // exchangePanel
            // 
            this.exchangePanel.Controls.Add(this.exchangeTabControl);
            this.exchangePanel.Controls.Add(this.statusStrip);
            this.exchangePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangePanel.Location = new System.Drawing.Point(0, 0);
            this.exchangePanel.Name = "exchangePanel";
            this.exchangePanel.Size = new System.Drawing.Size(605, 309);
            this.exchangePanel.TabIndex = 0;
            // 
            // exchangeTabControl
            // 
            this.exchangeTabControl.Controls.Add(this.allTabPage);
            this.exchangeTabControl.Controls.Add(this.favoritesTabPage);
            this.exchangeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exchangeTabControl.Location = new System.Drawing.Point(0, 0);
            this.exchangeTabControl.Name = "exchangeTabControl";
            this.exchangeTabControl.SelectedIndex = 0;
            this.exchangeTabControl.Size = new System.Drawing.Size(605, 287);
            this.exchangeTabControl.TabIndex = 0;
            this.exchangeTabControl.SelectedIndexChanged += new System.EventHandler(this.exchangeTabControl_SelectedIndexChanged);
            // 
            // allTabPage
            // 
            this.allTabPage.Location = new System.Drawing.Point(4, 24);
            this.allTabPage.Name = "allTabPage";
            this.allTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allTabPage.Size = new System.Drawing.Size(597, 259);
            this.allTabPage.TabIndex = 1;
            this.allTabPage.Text = "Все";
            this.allTabPage.UseVisualStyleBackColor = true;
            // 
            // favoritesTabPage
            // 
            this.favoritesTabPage.Controls.Add(this.dataGridView);
            this.favoritesTabPage.Location = new System.Drawing.Point(4, 24);
            this.favoritesTabPage.Name = "favoritesTabPage";
            this.favoritesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favoritesTabPage.Size = new System.Drawing.Size(597, 214);
            this.favoritesTabPage.TabIndex = 0;
            this.favoritesTabPage.Text = "Избранные";
            this.favoritesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.NameValute,
            this.Count,
            this.Сourse,
            this.Button});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(591, 208);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.Frozen = true;
            this.Code.HeaderText = "Код валюты";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 75;
            // 
            // NameValute
            // 
            this.NameValute.DataPropertyName = "Name";
            this.NameValute.Frozen = true;
            this.NameValute.HeaderText = "Название";
            this.NameValute.Name = "NameValute";
            this.NameValute.ReadOnly = true;
            this.NameValute.Width = 285;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Nominal";
            this.Count.Frozen = true;
            this.Count.HeaderText = "Кол-во";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 50;
            // 
            // Сourse
            // 
            this.Сourse.DataPropertyName = "Сourse";
            this.Сourse.Frozen = true;
            this.Сourse.HeaderText = "Курс";
            this.Сourse.Name = "Сourse";
            this.Сourse.ReadOnly = true;
            this.Сourse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Сourse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Button
            // 
            this.Button.HeaderText = "";
            this.Button.Name = "Button";
            this.Button.ReadOnly = true;
            this.Button.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Button.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Button.Text = "❌";
            this.Button.UseColumnTextForButtonValue = true;
            this.Button.Width = 20;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 287);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(605, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "fgggggggg";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
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
            this.exchangePanel.PerformLayout();
            this.exchangeTabControl.ResumeLayout(false);
            this.favoritesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl exchangeTabControl;
        public Panel exchangePanel;
        public DataGridView dataGridView;
        public TabPage favoritesTabPage;
        public TabPage allTabPage;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn NameValute;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Сourse;
        private DataGridViewButtonColumn Button;
        public StatusStrip statusStrip;
        public ToolStripStatusLabel StatusLabel;
    }
}