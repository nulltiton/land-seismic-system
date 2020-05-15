namespace LandSeismic.SquadMember
{
    partial class SqaudMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqaudMember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.SquadMemberGrid = new System.Windows.Forms.DataGridView();
            this.IdSquadMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGroupSquadMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmployeeSquadMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameSquadMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPositionSquadMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePositionSquadMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquadMemberGrid)).BeginInit();
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
            this.FormBorderPanel.Size = new System.Drawing.Size(874, 45);
            this.FormBorderPanel.TabIndex = 0;
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
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::LandSeismic.Properties.Resources.plus;
            this.AddButton.Location = new System.Drawing.Point(777, 10);
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
            this.FormNameLabel.Size = new System.Drawing.Size(88, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Участники";
            // 
            // SquadMemberGrid
            // 
            this.SquadMemberGrid.AllowUserToAddRows = false;
            this.SquadMemberGrid.AllowUserToDeleteRows = false;
            this.SquadMemberGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SquadMemberGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SquadMemberGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SquadMemberGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SquadMemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SquadMemberGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSquadMember,
            this.IdGroupSquadMember,
            this.IdEmployeeSquadMember,
            this.FullNameSquadMember,
            this.IdPositionSquadMember,
            this.NamePositionSquadMember,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SquadMemberGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.SquadMemberGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.SquadMemberGrid.Location = new System.Drawing.Point(0, 45);
            this.SquadMemberGrid.Name = "SquadMemberGrid";
            this.SquadMemberGrid.ReadOnly = true;
            this.SquadMemberGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SquadMemberGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SquadMemberGrid.Size = new System.Drawing.Size(723, 381);
            this.SquadMemberGrid.TabIndex = 1;
            this.SquadMemberGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SquadMemberGrid_CellContentClick);
            // 
            // IdSquadMember
            // 
            this.IdSquadMember.DataPropertyName = "id";
            this.IdSquadMember.HeaderText = "Id";
            this.IdSquadMember.Name = "IdSquadMember";
            this.IdSquadMember.ReadOnly = true;
            this.IdSquadMember.Visible = false;
            // 
            // IdGroupSquadMember
            // 
            this.IdGroupSquadMember.DataPropertyName = "idgroup";
            this.IdGroupSquadMember.HeaderText = "IdGroup";
            this.IdGroupSquadMember.Name = "IdGroupSquadMember";
            this.IdGroupSquadMember.ReadOnly = true;
            this.IdGroupSquadMember.Visible = false;
            // 
            // IdEmployeeSquadMember
            // 
            this.IdEmployeeSquadMember.DataPropertyName = "idemployee";
            this.IdEmployeeSquadMember.HeaderText = "IdEmployee";
            this.IdEmployeeSquadMember.Name = "IdEmployeeSquadMember";
            this.IdEmployeeSquadMember.ReadOnly = true;
            this.IdEmployeeSquadMember.Visible = false;
            // 
            // FullNameSquadMember
            // 
            this.FullNameSquadMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullNameSquadMember.DataPropertyName = "fullname";
            this.FullNameSquadMember.HeaderText = "ФИО участника";
            this.FullNameSquadMember.Name = "FullNameSquadMember";
            this.FullNameSquadMember.ReadOnly = true;
            this.FullNameSquadMember.Width = 320;
            // 
            // IdPositionSquadMember
            // 
            this.IdPositionSquadMember.DataPropertyName = "idposition";
            this.IdPositionSquadMember.HeaderText = "IdPosition";
            this.IdPositionSquadMember.Name = "IdPositionSquadMember";
            this.IdPositionSquadMember.ReadOnly = true;
            this.IdPositionSquadMember.Visible = false;
            // 
            // NamePositionSquadMember
            // 
            this.NamePositionSquadMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NamePositionSquadMember.DataPropertyName = "name";
            this.NamePositionSquadMember.HeaderText = "Должность";
            this.NamePositionSquadMember.Name = "NamePositionSquadMember";
            this.NamePositionSquadMember.ReadOnly = true;
            this.NamePositionSquadMember.Width = 130;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle3;
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
            // SqaudMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 426);
            this.ControlBox = false;
            this.Controls.Add(this.SquadMemberGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqaudMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqaudMember";
            this.Load += new System.EventHandler(this.SqaudMember_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SqaudMember_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqaudMember_KeyDown);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SquadMemberGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView SquadMemberGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSquadMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroupSquadMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployeeSquadMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameSquadMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPositionSquadMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePositionSquadMember;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}