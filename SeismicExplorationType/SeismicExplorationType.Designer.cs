namespace LandSeismic.SeismicExplorationType
{
    partial class SeismicExplorationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeismicExplorationType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.SeismicExplorationTypeGrid = new System.Windows.Forms.DataGridView();
            this.IdSeismicExploration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeismicExmplorationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DropButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeismicExplorationTypeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBorderPanel
            // 
            this.FormBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderPanel.Controls.Add(this.BackwardsButton);
            this.FormBorderPanel.Controls.Add(this.AddButton);
            this.FormBorderPanel.Controls.Add(this.FormNameLabel);
            this.FormBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderPanel.ForeColor = System.Drawing.Color.White;
            this.FormBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderPanel.Name = "FormBorderPanel";
            this.FormBorderPanel.Size = new System.Drawing.Size(387, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(344, 10);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(25, 25);
            this.BackwardsButton.TabIndex = 2;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::LandSeismic.Properties.Resources.plus;
            this.AddButton.Location = new System.Drawing.Point(295, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(25, 25);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(157, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Тип сейсморазведки";
            // 
            // SeismicExplorationTypeGrid
            // 
            this.SeismicExplorationTypeGrid.AllowUserToAddRows = false;
            this.SeismicExplorationTypeGrid.AllowUserToDeleteRows = false;
            this.SeismicExplorationTypeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeismicExplorationTypeGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SeismicExplorationTypeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SeismicExplorationTypeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SeismicExplorationTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeismicExplorationTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSeismicExploration,
            this.SeismicExmplorationName,
            this.EditButton,
            this.DropButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SeismicExplorationTypeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SeismicExplorationTypeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeismicExplorationTypeGrid.Location = new System.Drawing.Point(0, 45);
            this.SeismicExplorationTypeGrid.Name = "SeismicExplorationTypeGrid";
            this.SeismicExplorationTypeGrid.ReadOnly = true;
            this.SeismicExplorationTypeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SeismicExplorationTypeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SeismicExplorationTypeGrid.Size = new System.Drawing.Size(387, 381);
            this.SeismicExplorationTypeGrid.TabIndex = 1;
            this.SeismicExplorationTypeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeismicExplorationTypeGrid_CellContentClick);
            // 
            // IdSeismicExploration
            // 
            this.IdSeismicExploration.DataPropertyName = "id";
            this.IdSeismicExploration.HeaderText = "ID";
            this.IdSeismicExploration.Name = "IdSeismicExploration";
            this.IdSeismicExploration.ReadOnly = true;
            this.IdSeismicExploration.Visible = false;
            // 
            // SeismicExmplorationName
            // 
            this.SeismicExmplorationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SeismicExmplorationName.DataPropertyName = "name";
            this.SeismicExmplorationName.HeaderText = "Наименование";
            this.SeismicExmplorationName.Name = "SeismicExmplorationName";
            this.SeismicExmplorationName.ReadOnly = true;
            this.SeismicExmplorationName.Width = 120;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 5;
            // 
            // DropButton
            // 
            this.DropButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DropButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropButton.HeaderText = "";
            this.DropButton.Name = "DropButton";
            this.DropButton.ReadOnly = true;
            this.DropButton.Text = "Удалить";
            this.DropButton.UseColumnTextForButtonValue = true;
            this.DropButton.Width = 5;
            // 
            // SeismicExplorationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 426);
            this.ControlBox = false;
            this.Controls.Add(this.SeismicExplorationTypeGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeismicExplorationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeismicExplorationType";
            this.Load += new System.EventHandler(this.SeismicExplorationType_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SeismicExplorationType_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SeismicExplorationType_KeyDown);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeismicExplorationTypeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView SeismicExplorationTypeGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeismicExplorationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeismicExploration;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeismicExmplorationName;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DropButton;
    }
}