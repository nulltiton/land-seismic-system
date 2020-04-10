﻿namespace LandSeismic.Squad
{
    partial class Squad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Squad));
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.GroupGrid = new System.Windows.Forms.DataGridView();
            this.IdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSquadGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGroupTypeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroupTypeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SquadGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SquadFilterPanel = new System.Windows.Forms.Panel();
            this.FilterByPositionComboBox = new System.Windows.Forms.ComboBox();
            this.AddSquadButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquadGrid)).BeginInit();
            this.SquadFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorderPanel
            // 
            this.FormBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderPanel.Controls.Add(this.BackwardsButton);
            this.FormBorderPanel.Controls.Add(this.FormNameLabel);
            this.FormBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderPanel.ForeColor = System.Drawing.Color.White;
            this.FormBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderPanel.Name = "FormBorderPanel";
            this.FormBorderPanel.Size = new System.Drawing.Size(1177, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(55, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Отряд";
            // 
            // GroupGrid
            // 
            this.GroupGrid.AllowUserToAddRows = false;
            this.GroupGrid.AllowUserToDeleteRows = false;
            this.GroupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GroupGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGroup,
            this.IdSquadGroup,
            this.IdGroupTypeGroup,
            this.NameGroupTypeGroup,
            this.MemberButton,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.GroupGrid.Location = new System.Drawing.Point(0, 390);
            this.GroupGrid.Name = "GroupGrid";
            this.GroupGrid.ReadOnly = true;
            this.GroupGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GroupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupGrid.Size = new System.Drawing.Size(978, 345);
            this.GroupGrid.TabIndex = 1;
            this.GroupGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupGrid_CellContentClick);
            // 
            // IdGroup
            // 
            this.IdGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdGroup.DataPropertyName = "id";
            this.IdGroup.HeaderText = "id";
            this.IdGroup.Name = "IdGroup";
            this.IdGroup.ReadOnly = true;
            this.IdGroup.Visible = false;
            this.IdGroup.Width = 60;
            // 
            // IdSquadGroup
            // 
            this.IdSquadGroup.DataPropertyName = "idSquad";
            this.IdSquadGroup.HeaderText = "IdSquad";
            this.IdSquadGroup.Name = "IdSquadGroup";
            this.IdSquadGroup.ReadOnly = true;
            this.IdSquadGroup.Visible = false;
            // 
            // IdGroupTypeGroup
            // 
            this.IdGroupTypeGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdGroupTypeGroup.DataPropertyName = "IdGroupType";
            this.IdGroupTypeGroup.HeaderText = "IdGroupType";
            this.IdGroupTypeGroup.Name = "IdGroupTypeGroup";
            this.IdGroupTypeGroup.ReadOnly = true;
            this.IdGroupTypeGroup.Visible = false;
            // 
            // NameGroupTypeGroup
            // 
            this.NameGroupTypeGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameGroupTypeGroup.DataPropertyName = "Name";
            this.NameGroupTypeGroup.HeaderText = "Тип группы";
            this.NameGroupTypeGroup.Name = "NameGroupTypeGroup";
            this.NameGroupTypeGroup.ReadOnly = true;
            this.NameGroupTypeGroup.Width = 535;
            // 
            // MemberButton
            // 
            this.MemberButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberButton.DefaultCellStyle = dataGridViewCellStyle6;
            this.MemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberButton.HeaderText = "";
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.ReadOnly = true;
            this.MemberButton.Text = "Список участников";
            this.MemberButton.UseColumnTextForButtonValue = true;
            this.MemberButton.Width = 170;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle7;
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
            // SquadGrid
            // 
            this.SquadGrid.AllowUserToAddRows = false;
            this.SquadGrid.AllowUserToDeleteRows = false;
            this.SquadGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SquadGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SquadGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SquadGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SquadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SquadGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SquadGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.SquadGrid.Location = new System.Drawing.Point(0, 45);
            this.SquadGrid.Name = "SquadGrid";
            this.SquadGrid.ReadOnly = true;
            this.SquadGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SquadGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SquadGrid.Size = new System.Drawing.Size(978, 345);
            this.SquadGrid.TabIndex = 2;
            this.SquadGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SquadGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "loginSquadLeader";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин начальника сейсмотряда";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fullName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО начальника";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idLocality";
            this.dataGridViewTextBoxColumn4.HeaderText = "Участок";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "departureDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата выхода";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "returnDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата возвращения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "actualReturnDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Фактическое возвращение";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle9;
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
            // SquadFilterPanel
            // 
            this.SquadFilterPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.SquadFilterPanel.Controls.Add(this.AddGroupButton);
            this.SquadFilterPanel.Controls.Add(this.FilterByPositionComboBox);
            this.SquadFilterPanel.Controls.Add(this.AddSquadButton);
            this.SquadFilterPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SquadFilterPanel.Location = new System.Drawing.Point(977, 45);
            this.SquadFilterPanel.Name = "SquadFilterPanel";
            this.SquadFilterPanel.Size = new System.Drawing.Size(200, 690);
            this.SquadFilterPanel.TabIndex = 3;
            // 
            // FilterByPositionComboBox
            // 
            this.FilterByPositionComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterByPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByPositionComboBox.ForeColor = System.Drawing.Color.Black;
            this.FilterByPositionComboBox.FormattingEnabled = true;
            this.FilterByPositionComboBox.Location = new System.Drawing.Point(0, 30);
            this.FilterByPositionComboBox.Name = "FilterByPositionComboBox";
            this.FilterByPositionComboBox.Size = new System.Drawing.Size(200, 26);
            this.FilterByPositionComboBox.TabIndex = 1;
            // 
            // AddSquadButton
            // 
            this.AddSquadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddSquadButton.Location = new System.Drawing.Point(0, 0);
            this.AddSquadButton.Name = "AddSquadButton";
            this.AddSquadButton.Size = new System.Drawing.Size(200, 30);
            this.AddSquadButton.TabIndex = 0;
            this.AddSquadButton.Text = "Добавить";
            this.AddSquadButton.UseVisualStyleBackColor = true;
            this.AddSquadButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(1131, 10);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(25, 25);
            this.BackwardsButton.TabIndex = 2;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(0, 345);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(200, 30);
            this.AddGroupButton.TabIndex = 2;
            this.AddGroupButton.Text = "Добавить";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // Squad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 735);
            this.ControlBox = false;
            this.Controls.Add(this.SquadFilterPanel);
            this.Controls.Add(this.SquadGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Controls.Add(this.GroupGrid);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Squad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Squad";
            this.Load += new System.EventHandler(this.Squad_Load);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquadGrid)).EndInit();
            this.SquadFilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView GroupGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.DataGridView SquadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.Panel SquadFilterPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSquadGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroupTypeGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroupTypeGroup;
        private System.Windows.Forms.DataGridViewButtonColumn MemberButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.Button AddSquadButton;
        private System.Windows.Forms.ComboBox FilterByPositionComboBox;
        private System.Windows.Forms.Button AddGroupButton;
    }
}