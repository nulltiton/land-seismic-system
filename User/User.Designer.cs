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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formBorderPanel = new System.Windows.Forms.Panel();
            this.backwardsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.userlogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.drop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.formBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // formBorderPanel
            // 
            this.formBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.formBorderPanel.Controls.Add(this.backwardsButton);
            this.formBorderPanel.Controls.Add(this.addButton);
            this.formBorderPanel.Controls.Add(this.formNameLabel);
            this.formBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBorderPanel.ForeColor = System.Drawing.Color.White;
            this.formBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.formBorderPanel.Name = "formBorderPanel";
            this.formBorderPanel.Size = new System.Drawing.Size(1153, 45);
            this.formBorderPanel.TabIndex = 0;
            // 
            // backwardsButton
            // 
            this.backwardsButton.FlatAppearance.BorderSize = 0;
            this.backwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("backwardsButton.Image")));
            this.backwardsButton.Location = new System.Drawing.Point(1107, 10);
            this.backwardsButton.Name = "backwardsButton";
            this.backwardsButton.Size = new System.Drawing.Size(25, 25);
            this.backwardsButton.TabIndex = 2;
            this.backwardsButton.UseVisualStyleBackColor = true;
            this.backwardsButton.Click += new System.EventHandler(this.backwardsBbutton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::LandSeismic.Properties.Resources.plus;
            this.addButton.Location = new System.Drawing.Point(1058, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(25, 25);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Location = new System.Drawing.Point(12, 13);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(135, 18);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Ведущие геологи";
            // 
            // userGrid
            // 
            this.userGrid.AllowUserToAddRows = false;
            this.userGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.userGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userlogin,
            this.userpassword,
            this.usersurname,
            this.userFirstName,
            this.userMiddleName,
            this.userphone,
            this.useraddress,
            this.userposition,
            this.edit,
            this.drop});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.userGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.userGrid.Location = new System.Drawing.Point(0, 45);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGrid.Size = new System.Drawing.Size(1153, 381);
            this.userGrid.TabIndex = 1;
            this.userGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGrid_CellContentClick);
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
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Редактировать";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 120;
            // 
            // drop
            // 
            this.drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop.HeaderText = "";
            this.drop.Name = "drop";
            this.drop.ReadOnly = true;
            this.drop.Text = "Удалить";
            this.drop.UseColumnTextForButtonValue = true;
            this.drop.Width = 90;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 426);
            this.ControlBox = false;
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.formBorderPanel);
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
            this.formBorderPanel.ResumeLayout(false);
            this.formBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBorderPanel;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.Button backwardsButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn useraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userposition;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn drop;
    }
}