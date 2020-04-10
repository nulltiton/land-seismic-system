namespace LandSeismic.Locality
{
    partial class Locality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locality));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.LocalityGrid = new System.Windows.Forms.DataGridView();
            this.IdLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLocalityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLocalityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSeismicExplorationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSeismocExplorationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatitudeLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongitudeLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginGeologistLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameGeologist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginLeadGeologist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameLeadGeologist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginSquadLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SquadLeaderFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsabilityLocality = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalityGrid)).BeginInit();
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
            this.BackwardsButton.Location = new System.Drawing.Point(1324, 10);
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
            this.AddButton.Location = new System.Drawing.Point(1275, 10);
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
            this.FormNameLabel.Size = new System.Drawing.Size(77, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Название";
            // 
            // LocalityGrid
            // 
            this.LocalityGrid.AllowUserToAddRows = false;
            this.LocalityGrid.AllowUserToDeleteRows = false;
            this.LocalityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalityGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.LocalityGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalityGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LocalityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLocality,
            this.IdLocalityType,
            this.NameLocalityType,
            this.IdSeismicExplorationType,
            this.NameSeismocExplorationType,
            this.SizeLocality,
            this.LatitudeLocality,
            this.LongitudeLocality,
            this.LoginGeologistLocality,
            this.FullNameGeologist,
            this.LoginLeadGeologist,
            this.FullNameLeadGeologist,
            this.LoginSquadLeader,
            this.SquadLeaderFullName,
            this.UsabilityLocality,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalityGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocalityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalityGrid.Location = new System.Drawing.Point(0, 45);
            this.LocalityGrid.Name = "LocalityGrid";
            this.LocalityGrid.ReadOnly = true;
            this.LocalityGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LocalityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalityGrid.Size = new System.Drawing.Size(1370, 381);
            this.LocalityGrid.TabIndex = 1;
            this.LocalityGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocalityGrid_CellContentClick);
            // 
            // IdLocality
            // 
            this.IdLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdLocality.DataPropertyName = "id";
            this.IdLocality.HeaderText = "ID";
            this.IdLocality.Name = "IdLocality";
            this.IdLocality.ReadOnly = true;
            this.IdLocality.Width = 30;
            // 
            // IdLocalityType
            // 
            this.IdLocalityType.DataPropertyName = "idLocalityType";
            this.IdLocalityType.HeaderText = "IdLocalityType";
            this.IdLocalityType.Name = "IdLocalityType";
            this.IdLocalityType.ReadOnly = true;
            this.IdLocalityType.Visible = false;
            // 
            // NameLocalityType
            // 
            this.NameLocalityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameLocalityType.DataPropertyName = "name";
            this.NameLocalityType.HeaderText = "Тип местности";
            this.NameLocalityType.Name = "NameLocalityType";
            this.NameLocalityType.ReadOnly = true;
            this.NameLocalityType.Width = 150;
            // 
            // IdSeismicExplorationType
            // 
            this.IdSeismicExplorationType.DataPropertyName = "idSeismicExplorationType";
            this.IdSeismicExplorationType.HeaderText = "IdSeismicExplorationType";
            this.IdSeismicExplorationType.Name = "IdSeismicExplorationType";
            this.IdSeismicExplorationType.ReadOnly = true;
            this.IdSeismicExplorationType.Visible = false;
            // 
            // NameSeismocExplorationType
            // 
            this.NameSeismocExplorationType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameSeismocExplorationType.DataPropertyName = "name1";
            this.NameSeismocExplorationType.HeaderText = "Тип разведки";
            this.NameSeismocExplorationType.Name = "NameSeismocExplorationType";
            this.NameSeismocExplorationType.ReadOnly = true;
            this.NameSeismocExplorationType.Width = 78;
            // 
            // SizeLocality
            // 
            this.SizeLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeLocality.DataPropertyName = "size";
            this.SizeLocality.HeaderText = "Размер";
            this.SizeLocality.Name = "SizeLocality";
            this.SizeLocality.ReadOnly = true;
            this.SizeLocality.Width = 65;
            // 
            // LatitudeLocality
            // 
            this.LatitudeLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LatitudeLocality.DataPropertyName = "latitude";
            this.LatitudeLocality.HeaderText = "Широта";
            this.LatitudeLocality.Name = "LatitudeLocality";
            this.LatitudeLocality.ReadOnly = true;
            this.LatitudeLocality.Width = 92;
            // 
            // LongitudeLocality
            // 
            this.LongitudeLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LongitudeLocality.DataPropertyName = "Longitude";
            this.LongitudeLocality.HeaderText = "Долгота";
            this.LongitudeLocality.Name = "LongitudeLocality";
            this.LongitudeLocality.ReadOnly = true;
            this.LongitudeLocality.Width = 92;
            // 
            // LoginGeologistLocality
            // 
            this.LoginGeologistLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LoginGeologistLocality.DataPropertyName = "logingeologist";
            this.LoginGeologistLocality.HeaderText = "Логин геолога";
            this.LoginGeologistLocality.Name = "LoginGeologistLocality";
            this.LoginGeologistLocality.ReadOnly = true;
            this.LoginGeologistLocality.Visible = false;
            // 
            // FullNameGeologist
            // 
            this.FullNameGeologist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullNameGeologist.DataPropertyName = "geologistfullname";
            this.FullNameGeologist.HeaderText = "ФИО геолога";
            this.FullNameGeologist.Name = "FullNameGeologist";
            this.FullNameGeologist.ReadOnly = true;
            this.FullNameGeologist.Visible = false;
            this.FullNameGeologist.Width = 320;
            // 
            // LoginLeadGeologist
            // 
            this.LoginLeadGeologist.DataPropertyName = "loginleadgeologist";
            this.LoginLeadGeologist.HeaderText = "Логин ведущего геолога";
            this.LoginLeadGeologist.Name = "LoginLeadGeologist";
            this.LoginLeadGeologist.ReadOnly = true;
            this.LoginLeadGeologist.Visible = false;
            // 
            // FullNameLeadGeologist
            // 
            this.FullNameLeadGeologist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullNameLeadGeologist.DataPropertyName = "leadgeologistfullname";
            this.FullNameLeadGeologist.HeaderText = "ФИО ведущего геолога";
            this.FullNameLeadGeologist.Name = "FullNameLeadGeologist";
            this.FullNameLeadGeologist.ReadOnly = true;
            this.FullNameLeadGeologist.Width = 250;
            // 
            // LoginSquadLeader
            // 
            this.LoginSquadLeader.DataPropertyName = "loginsquadleader";
            this.LoginSquadLeader.HeaderText = "Логин начальника отряда";
            this.LoginSquadLeader.Name = "LoginSquadLeader";
            this.LoginSquadLeader.ReadOnly = true;
            this.LoginSquadLeader.Visible = false;
            // 
            // SquadLeaderFullName
            // 
            this.SquadLeaderFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SquadLeaderFullName.DataPropertyName = "squadLeaderFullName";
            this.SquadLeaderFullName.HeaderText = "ФИО начальника отряда";
            this.SquadLeaderFullName.Name = "SquadLeaderFullName";
            this.SquadLeaderFullName.ReadOnly = true;
            this.SquadLeaderFullName.Width = 250;
            // 
            // UsabilityLocality
            // 
            this.UsabilityLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UsabilityLocality.DataPropertyName = "usability";
            this.UsabilityLocality.HeaderText = "Полезность";
            this.UsabilityLocality.Name = "UsabilityLocality";
            this.UsabilityLocality.ReadOnly = true;
            this.UsabilityLocality.Width = 96;
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
            // Locality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 426);
            this.ControlBox = false;
            this.Controls.Add(this.LocalityGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Locality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locality";
            this.Load += new System.EventHandler(this.Locality_Load);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView LocalityGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocalityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLocalityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSeismicExplorationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSeismocExplorationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatitudeLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongitudeLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginGeologistLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameGeologist;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginLeadGeologist;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameLeadGeologist;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginSquadLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn SquadLeaderFullName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UsabilityLocality;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}