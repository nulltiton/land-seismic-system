namespace LandSeismic.GroupType
{
    partial class GroupType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.GroupTypeGrid = new System.Windows.Forms.DataGridView();
            this.IdGroupType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroupType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupTypeGrid)).BeginInit();
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
            this.FormBorderPanel.Size = new System.Drawing.Size(445, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(399, 10);
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
            this.AddButton.Location = new System.Drawing.Point(350, 10);
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
            this.FormNameLabel.Size = new System.Drawing.Size(84, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Тип групп";
            // 
            // GroupTypeGrid
            // 
            this.GroupTypeGrid.AllowUserToAddRows = false;
            this.GroupTypeGrid.AllowUserToDeleteRows = false;
            this.GroupTypeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupTypeGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GroupTypeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupTypeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GroupTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGroupType,
            this.NameGroupType,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupTypeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.GroupTypeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupTypeGrid.Location = new System.Drawing.Point(0, 45);
            this.GroupTypeGrid.Name = "GroupTypeGrid";
            this.GroupTypeGrid.ReadOnly = true;
            this.GroupTypeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GroupTypeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupTypeGrid.Size = new System.Drawing.Size(445, 381);
            this.GroupTypeGrid.TabIndex = 1;
            this.GroupTypeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupTypeGrid_CellContentClick);
            // 
            // IdGroupType
            // 
            this.IdGroupType.DataPropertyName = "id";
            this.IdGroupType.HeaderText = "Id";
            this.IdGroupType.Name = "IdGroupType";
            this.IdGroupType.ReadOnly = true;
            this.IdGroupType.Visible = false;
            // 
            // NameGroupType
            // 
            this.NameGroupType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameGroupType.DataPropertyName = "name";
            this.NameGroupType.HeaderText = "Наименование";
            this.NameGroupType.Name = "NameGroupType";
            this.NameGroupType.ReadOnly = true;
            this.NameGroupType.Width = 178;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 5;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 5;
            // 
            // GroupType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 426);
            this.ControlBox = false;
            this.Controls.Add(this.GroupTypeGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupType";
            this.Load += new System.EventHandler(this.GroupType_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.GroupType_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GroupType_KeyDown);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupTypeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView GroupTypeGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroupType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroupType;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}