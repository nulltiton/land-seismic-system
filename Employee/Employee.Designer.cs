namespace LandSeismic.Employee
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterByPositionButton = new System.Windows.Forms.Button();
            this.FilterCancellationButton = new System.Windows.Forms.Button();
            this.FilterByPositionComboBox = new System.Windows.Forms.ComboBox();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.FilterPanel.SuspendLayout();
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
            this.FormBorderPanel.Size = new System.Drawing.Size(1370, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(1340, 10);
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
            this.AddButton.Location = new System.Drawing.Point(1291, 10);
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
            this.FormNameLabel.Size = new System.Drawing.Size(97, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Сотрудники";
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.AllowUserToAddRows = false;
            this.EmployeeGrid.AllowUserToDeleteRows = false;
            this.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.EmployeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeSurname,
            this.EmployeeFirstName,
            this.EmployeeMiddleName,
            this.EmployeePhone,
            this.EmployeeAddress,
            this.EmployeeContactPhone,
            this.EmployeePosition,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.EmployeeGrid.Location = new System.Drawing.Point(0, 45);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGrid.Size = new System.Drawing.Size(1188, 381);
            this.EmployeeGrid.TabIndex = 1;
            this.EmployeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGrid_CellContentClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeId.DataPropertyName = "id";
            this.EmployeeId.Frozen = true;
            this.EmployeeId.HeaderText = "Идентификатор";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            this.EmployeeId.Width = 151;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeSurname.DataPropertyName = "surname";
            this.EmployeeSurname.Frozen = true;
            this.EmployeeSurname.HeaderText = "Фамилия";
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.ReadOnly = true;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeFirstName.DataPropertyName = "firstname";
            this.EmployeeFirstName.Frozen = true;
            this.EmployeeFirstName.HeaderText = "Имя";
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.ReadOnly = true;
            this.EmployeeFirstName.Width = 85;
            // 
            // EmployeeMiddleName
            // 
            this.EmployeeMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeMiddleName.DataPropertyName = "middlename";
            this.EmployeeMiddleName.Frozen = true;
            this.EmployeeMiddleName.HeaderText = "Отчество";
            this.EmployeeMiddleName.Name = "EmployeeMiddleName";
            this.EmployeeMiddleName.ReadOnly = true;
            this.EmployeeMiddleName.Width = 125;
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeePhone.DataPropertyName = "phone";
            this.EmployeePhone.Frozen = true;
            this.EmployeePhone.HeaderText = "Телефон";
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.ReadOnly = true;
            this.EmployeePhone.Width = 140;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeAddress.DataPropertyName = "address";
            this.EmployeeAddress.Frozen = true;
            this.EmployeeAddress.HeaderText = "Адрес";
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.ReadOnly = true;
            this.EmployeeAddress.Width = 200;
            // 
            // EmployeeContactPhone
            // 
            this.EmployeeContactPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeeContactPhone.DataPropertyName = "contactPhone";
            this.EmployeeContactPhone.HeaderText = "Контактный телефон";
            this.EmployeeContactPhone.Name = "EmployeeContactPhone";
            this.EmployeeContactPhone.ReadOnly = true;
            this.EmployeeContactPhone.Width = 140;
            // 
            // EmployeePosition
            // 
            this.EmployeePosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmployeePosition.DataPropertyName = "name";
            this.EmployeePosition.HeaderText = "Должность";
            this.EmployeePosition.Name = "EmployeePosition";
            this.EmployeePosition.ReadOnly = true;
            this.EmployeePosition.Width = 130;
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
            this.EditButton.Width = 120;
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
            this.DeleteButton.Width = 90;
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.FilterPanel.Controls.Add(this.FilterByPositionButton);
            this.FilterPanel.Controls.Add(this.FilterCancellationButton);
            this.FilterPanel.Controls.Add(this.FilterByPositionComboBox);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilterPanel.Location = new System.Drawing.Point(1170, 45);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(200, 381);
            this.FilterPanel.TabIndex = 2;
            // 
            // FilterByPositionButton
            // 
            this.FilterByPositionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterByPositionButton.Location = new System.Drawing.Point(0, 26);
            this.FilterByPositionButton.Name = "FilterByPositionButton";
            this.FilterByPositionButton.Size = new System.Drawing.Size(200, 30);
            this.FilterByPositionButton.TabIndex = 2;
            this.FilterByPositionButton.Text = "Фильтровать";
            this.FilterByPositionButton.UseVisualStyleBackColor = true;
            this.FilterByPositionButton.Click += new System.EventHandler(this.FilterByPositionButton_Click);
            // 
            // FilterCancellationButton
            // 
            this.FilterCancellationButton.Location = new System.Drawing.Point(0, 56);
            this.FilterCancellationButton.Name = "FilterCancellationButton";
            this.FilterCancellationButton.Size = new System.Drawing.Size(200, 30);
            this.FilterCancellationButton.TabIndex = 1;
            this.FilterCancellationButton.Text = "Отмена";
            this.FilterCancellationButton.UseVisualStyleBackColor = true;
            this.FilterCancellationButton.Click += new System.EventHandler(this.FilterCancellationButton_Click);
            // 
            // FilterByPositionComboBox
            // 
            this.FilterByPositionComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterByPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByPositionComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterByPositionComboBox.FormattingEnabled = true;
            this.FilterByPositionComboBox.Location = new System.Drawing.Point(0, 0);
            this.FilterByPositionComboBox.Name = "FilterByPositionComboBox";
            this.FilterByPositionComboBox.Size = new System.Drawing.Size(200, 26);
            this.FilterByPositionComboBox.TabIndex = 0;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 426);
            this.ControlBox = false;
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Employee_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Employee_KeyDown);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.FilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePosition;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.ComboBox FilterByPositionComboBox;
        private System.Windows.Forms.Button FilterCancellationButton;
        private System.Windows.Forms.Button FilterByPositionButton;
    }
}