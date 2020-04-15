namespace LandSeismic.InventoryList
{
    partial class InventoryList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.InventoryListGrid = new System.Windows.Forms.DataGridView();
            this.ResourceGrid = new System.Windows.Forms.DataGridView();
            this.IdListResourceInList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResourceResourceList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameResourceInList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountResourceInList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddInventoryListButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.DocumentButton = new System.Windows.Forms.Button();
            this.InventoryListSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.IdInventoryList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSquadInventoryList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginGeologistInventoryList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameInventoryList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateInventoryList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBorderPanel
            // 
            this.FormBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderPanel.Controls.Add(this.AddInventoryListButton);
            this.FormBorderPanel.Controls.Add(this.BackwardsButton);
            this.FormBorderPanel.Controls.Add(this.DocumentButton);
            this.FormBorderPanel.Controls.Add(this.FormNameLabel);
            this.FormBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderPanel.ForeColor = System.Drawing.Color.White;
            this.FormBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderPanel.Name = "FormBorderPanel";
            this.FormBorderPanel.Size = new System.Drawing.Size(874, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(347, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Перечень материально-технических ресурсов";
            // 
            // InventoryListGrid
            // 
            this.InventoryListGrid.AllowUserToAddRows = false;
            this.InventoryListGrid.AllowUserToDeleteRows = false;
            this.InventoryListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryListGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.InventoryListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryListGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInventoryList,
            this.IdSquadInventoryList,
            this.LoginGeologistInventoryList,
            this.FullNameInventoryList,
            this.CreationDateInventoryList,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryListGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.InventoryListGrid.Location = new System.Drawing.Point(0, 45);
            this.InventoryListGrid.Name = "InventoryListGrid";
            this.InventoryListGrid.ReadOnly = true;
            this.InventoryListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.InventoryListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryListGrid.Size = new System.Drawing.Size(694, 359);
            this.InventoryListGrid.TabIndex = 1;
            this.InventoryListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryListGrid_CellContentClick);
            // 
            // ResourceGrid
            // 
            this.ResourceGrid.AllowUserToAddRows = false;
            this.ResourceGrid.AllowUserToDeleteRows = false;
            this.ResourceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResourceGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ResourceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResourceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ResourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdListResourceInList,
            this.IdResourceResourceList,
            this.NameResourceInList,
            this.AmountResourceInList,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResourceGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.ResourceGrid.Location = new System.Drawing.Point(0, 404);
            this.ResourceGrid.Name = "ResourceGrid";
            this.ResourceGrid.ReadOnly = true;
            this.ResourceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ResourceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResourceGrid.Size = new System.Drawing.Size(694, 359);
            this.ResourceGrid.TabIndex = 2;
            // 
            // IdListResourceInList
            // 
            this.IdListResourceInList.DataPropertyName = "idList";
            this.IdListResourceInList.HeaderText = "IdList";
            this.IdListResourceInList.Name = "IdListResourceInList";
            this.IdListResourceInList.ReadOnly = true;
            this.IdListResourceInList.Visible = false;
            // 
            // IdResourceResourceList
            // 
            this.IdResourceResourceList.DataPropertyName = "idResource";
            this.IdResourceResourceList.HeaderText = "IdResource";
            this.IdResourceResourceList.Name = "IdResourceResourceList";
            this.IdResourceResourceList.ReadOnly = true;
            this.IdResourceResourceList.Visible = false;
            // 
            // NameResourceInList
            // 
            this.NameResourceInList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameResourceInList.DataPropertyName = "name";
            this.NameResourceInList.HeaderText = "Ресурс";
            this.NameResourceInList.Name = "NameResourceInList";
            this.NameResourceInList.ReadOnly = true;
            this.NameResourceInList.Width = 300;
            // 
            // AmountResourceInList
            // 
            this.AmountResourceInList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AmountResourceInList.DataPropertyName = "amount";
            this.AmountResourceInList.HeaderText = "Количество";
            this.AmountResourceInList.Name = "AmountResourceInList";
            this.AmountResourceInList.ReadOnly = true;
            this.AmountResourceInList.Width = 119;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Редактировать";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 130;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Text = "Удалить";
            this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn2.Width = 85;
            // 
            // AddInventoryListButton
            // 
            this.AddInventoryListButton.FlatAppearance.BorderSize = 0;
            this.AddInventoryListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInventoryListButton.Image = global::LandSeismic.Properties.Resources.plus;
            this.AddInventoryListButton.Location = new System.Drawing.Point(728, 10);
            this.AddInventoryListButton.Name = "AddInventoryListButton";
            this.AddInventoryListButton.Size = new System.Drawing.Size(25, 25);
            this.AddInventoryListButton.TabIndex = 3;
            this.AddInventoryListButton.UseVisualStyleBackColor = true;
            this.AddInventoryListButton.Click += new System.EventHandler(this.AddInventoryListButton_Click);
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(826, 10);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(25, 25);
            this.BackwardsButton.TabIndex = 2;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // DocumentButton
            // 
            this.DocumentButton.FlatAppearance.BorderSize = 0;
            this.DocumentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentButton.Image = global::LandSeismic.Properties.Resources.document;
            this.DocumentButton.Location = new System.Drawing.Point(777, 10);
            this.DocumentButton.Name = "DocumentButton";
            this.DocumentButton.Size = new System.Drawing.Size(25, 25);
            this.DocumentButton.TabIndex = 1;
            this.DocumentButton.UseVisualStyleBackColor = true;
            this.DocumentButton.Click += new System.EventHandler(this.DocumentButton_Click);
            // 
            // IdInventoryList
            // 
            this.IdInventoryList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdInventoryList.DataPropertyName = "id";
            this.IdInventoryList.HeaderText = "ID";
            this.IdInventoryList.Name = "IdInventoryList";
            this.IdInventoryList.ReadOnly = true;
            this.IdInventoryList.Width = 50;
            // 
            // IdSquadInventoryList
            // 
            this.IdSquadInventoryList.DataPropertyName = "idSquad";
            this.IdSquadInventoryList.HeaderText = "Отряд";
            this.IdSquadInventoryList.Name = "IdSquadInventoryList";
            this.IdSquadInventoryList.ReadOnly = true;
            // 
            // LoginGeologistInventoryList
            // 
            this.LoginGeologistInventoryList.DataPropertyName = "logingeologist";
            this.LoginGeologistInventoryList.HeaderText = "LoginGeologist";
            this.LoginGeologistInventoryList.Name = "LoginGeologistInventoryList";
            this.LoginGeologistInventoryList.ReadOnly = true;
            this.LoginGeologistInventoryList.Visible = false;
            // 
            // FullNameInventoryList
            // 
            this.FullNameInventoryList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullNameInventoryList.DataPropertyName = "fullName";
            this.FullNameInventoryList.HeaderText = "ФИО геолога";
            this.FullNameInventoryList.Name = "FullNameInventoryList";
            this.FullNameInventoryList.ReadOnly = true;
            this.FullNameInventoryList.Width = 230;
            // 
            // CreationDateInventoryList
            // 
            this.CreationDateInventoryList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreationDateInventoryList.DataPropertyName = "creationDate";
            this.CreationDateInventoryList.HeaderText = "Дата создания";
            this.CreationDateInventoryList.Name = "CreationDateInventoryList";
            this.CreationDateInventoryList.ReadOnly = true;
            this.CreationDateInventoryList.Width = 140;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 130;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 85;
            // 
            // InventoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 763);
            this.ControlBox = false;
            this.Controls.Add(this.ResourceGrid);
            this.Controls.Add(this.InventoryListGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryList";
            this.Load += new System.EventHandler(this.InventoryList_Load);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResourceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView InventoryListGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button DocumentButton;
        private System.Windows.Forms.DataGridView ResourceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdListResourceInList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResourceResourceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameResourceInList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountResourceInList;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Button AddInventoryListButton;
        private System.Windows.Forms.SaveFileDialog InventoryListSaveDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInventoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSquadInventoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginGeologistInventoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameInventoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateInventoryList;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}