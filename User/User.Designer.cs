namespace LandSeismic.User
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.UserGrid = new System.Windows.Forms.DataGridView();
            this.userlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).BeginInit();
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
            this.FormBorderPanel.Size = new System.Drawing.Size(1170, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(1125, 10);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(25, 25);
            this.BackwardsButton.TabIndex = 2;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsBbutton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::LandSeismic.Properties.Resources.plus;
            this.AddButton.Location = new System.Drawing.Point(1076, 10);
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
            this.FormNameLabel.Size = new System.Drawing.Size(110, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Пользователи";
            // 
            // UserGrid
            // 
            this.UserGrid.AllowUserToAddRows = false;
            this.UserGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.UserGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.UserGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.UserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userlogin,
            this.userpassword,
            this.usersurname,
            this.userFirstName,
            this.userMiddleName,
            this.userphone,
            this.useraddress,
            this.userposition,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.UserGrid.Location = new System.Drawing.Point(0, 45);
            this.UserGrid.Name = "UserGrid";
            this.UserGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGrid.Size = new System.Drawing.Size(1170, 381);
            this.UserGrid.TabIndex = 1;
            this.UserGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGrid_CellContentClick);
            // 
            // userlogin
            // 
            this.userlogin.DataPropertyName = "login";
            this.userlogin.HeaderText = "Логин";
            this.userlogin.Name = "userlogin";
            this.userlogin.ReadOnly = true;
            this.userlogin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userlogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userlogin.Width = 60;
            // 
            // userpassword
            // 
            this.userpassword.DataPropertyName = "password";
            this.userpassword.HeaderText = "Пароль";
            this.userpassword.Name = "userpassword";
            this.userpassword.ReadOnly = true;
            this.userpassword.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userpassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userpassword.Visible = false;
            // 
            // usersurname
            // 
            this.usersurname.DataPropertyName = "surname";
            this.usersurname.HeaderText = "Фамилия";
            this.usersurname.Name = "usersurname";
            this.usersurname.ReadOnly = true;
            this.usersurname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usersurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // userFirstName
            // 
            this.userFirstName.DataPropertyName = "firstName";
            this.userFirstName.HeaderText = "Имя";
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            this.userFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userFirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userFirstName.Width = 85;
            // 
            // userMiddleName
            // 
            this.userMiddleName.DataPropertyName = "middleName";
            this.userMiddleName.HeaderText = "Отчество";
            this.userMiddleName.Name = "userMiddleName";
            this.userMiddleName.ReadOnly = true;
            this.userMiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userMiddleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userMiddleName.Width = 125;
            // 
            // userphone
            // 
            this.userphone.DataPropertyName = "phone";
            this.userphone.HeaderText = "Телефон";
            this.userphone.Name = "userphone";
            this.userphone.ReadOnly = true;
            this.userphone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userphone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userphone.Width = 140;
            // 
            // useraddress
            // 
            this.useraddress.DataPropertyName = "address";
            this.useraddress.HeaderText = "Адрес";
            this.useraddress.Name = "useraddress";
            this.useraddress.ReadOnly = true;
            this.useraddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.useraddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.useraddress.Width = 200;
            // 
            // userposition
            // 
            this.userposition.DataPropertyName = "name";
            this.userposition.HeaderText = "Должность";
            this.userposition.Name = "userposition";
            this.userposition.ReadOnly = true;
            this.userposition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userposition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.userposition.Width = 190;
            // 
            // EditButton
            // 
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
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 90;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 426);
            this.ControlBox = false;
            this.Controls.Add(this.UserGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeadGeologist";
            this.Load += new System.EventHandler(this.User_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.User_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User_KeyDown);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView UserGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn useraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userposition;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}