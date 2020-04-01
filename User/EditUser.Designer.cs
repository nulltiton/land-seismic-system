namespace LandSeismic.User
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.MiddleNamePanel = new System.Windows.Forms.Panel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNamePanel = new System.Windows.Forms.Panel();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnamePanel = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordUnderlinePanel = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginUnderlinePanel = new System.Windows.Forms.Panel();
            this.FormBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorderPanel
            // 
            this.FormBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderPanel.Controls.Add(this.SaveButton);
            this.FormBorderPanel.Controls.Add(this.BackwardsButton);
            this.FormBorderPanel.Controls.Add(this.FormNameLabel);
            this.FormBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderPanel.ForeColor = System.Drawing.Color.White;
            this.FormBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderPanel.Name = "FormBorderPanel";
            this.FormBorderPanel.Size = new System.Drawing.Size(263, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Image = global::LandSeismic.Properties.Resources.save;
            this.SaveButton.Location = new System.Drawing.Point(172, 10);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(25, 25);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(220, 10);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(25, 25);
            this.BackwardsButton.TabIndex = 9;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(128, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Редактирование";
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMaskedTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(31, 427);
            this.PhoneMaskedTextBox.Mask = "8 (000) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(204, 19);
            this.PhoneMaskedTextBox.TabIndex = 5;
            this.PhoneMaskedTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PhoneMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneMaskedTextBox_KeyPress);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionComboBox.ForeColor = System.Drawing.Color.Gray;
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PositionComboBox.Location = new System.Drawing.Point(27, 554);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(204, 26);
            this.PositionComboBox.TabIndex = 7;
            this.PositionComboBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.ForeColor = System.Drawing.Color.Gray;
            this.PositionLabel.Location = new System.Drawing.Point(28, 533);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(88, 18);
            this.PositionLabel.TabIndex = 52;
            this.PositionLabel.Text = "Должность";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextBox.ForeColor = System.Drawing.Color.Gray;
            this.AddressTextBox.Location = new System.Drawing.Point(31, 492);
            this.AddressTextBox.MaxLength = 40;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(200, 19);
            this.AddressTextBox.TabIndex = 6;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.ForeColor = System.Drawing.Color.Gray;
            this.AddressLabel.Location = new System.Drawing.Point(28, 471);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 18);
            this.AddressLabel.TabIndex = 51;
            this.AddressLabel.Text = "Адрес";
            // 
            // AddressPanel
            // 
            this.AddressPanel.BackColor = System.Drawing.Color.LightGray;
            this.AddressPanel.Location = new System.Drawing.Point(31, 513);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(200, 1);
            this.AddressPanel.TabIndex = 50;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.ForeColor = System.Drawing.Color.Gray;
            this.PhoneLabel.Location = new System.Drawing.Point(28, 403);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(73, 18);
            this.PhoneLabel.TabIndex = 49;
            this.PhoneLabel.Text = "Телефон";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiddleNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.MiddleNameTextBox.Location = new System.Drawing.Point(31, 358);
            this.MiddleNameTextBox.MaxLength = 20;
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.MiddleNameTextBox.TabIndex = 4;
            this.MiddleNameTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.MiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.MiddleNameLabel.Location = new System.Drawing.Point(28, 337);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(76, 18);
            this.MiddleNameLabel.TabIndex = 48;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // MiddleNamePanel
            // 
            this.MiddleNamePanel.BackColor = System.Drawing.Color.LightGray;
            this.MiddleNamePanel.Location = new System.Drawing.Point(31, 378);
            this.MiddleNamePanel.Name = "MiddleNamePanel";
            this.MiddleNamePanel.Size = new System.Drawing.Size(200, 1);
            this.MiddleNamePanel.TabIndex = 47;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameLabel.Location = new System.Drawing.Point(28, 268);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(39, 18);
            this.FirstNameLabel.TabIndex = 46;
            this.FirstNameLabel.Text = "Имя";
            // 
            // FirstNamePanel
            // 
            this.FirstNamePanel.BackColor = System.Drawing.Color.LightGray;
            this.FirstNamePanel.Location = new System.Drawing.Point(31, 315);
            this.FirstNamePanel.Name = "FirstNamePanel";
            this.FirstNamePanel.Size = new System.Drawing.Size(200, 1);
            this.FirstNamePanel.TabIndex = 45;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.FirstNameTextBox.Location = new System.Drawing.Point(31, 294);
            this.FirstNameTextBox.MaxLength = 20;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.FirstNameTextBox.TabIndex = 3;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.FirstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SurnameTextBox.Location = new System.Drawing.Point(31, 227);
            this.SurnameTextBox.MaxLength = 20;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(200, 19);
            this.SurnameTextBox.TabIndex = 2;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.ForeColor = System.Drawing.Color.Gray;
            this.SurnameLabel.Location = new System.Drawing.Point(28, 202);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(75, 18);
            this.SurnameLabel.TabIndex = 44;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SurnamePanel
            // 
            this.SurnamePanel.BackColor = System.Drawing.Color.LightGray;
            this.SurnamePanel.Location = new System.Drawing.Point(31, 248);
            this.SurnamePanel.Name = "SurnamePanel";
            this.SurnamePanel.Size = new System.Drawing.Size(200, 1);
            this.SurnamePanel.TabIndex = 43;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.PasswordLabel.Location = new System.Drawing.Point(28, 135);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(62, 18);
            this.PasswordLabel.TabIndex = 42;
            this.PasswordLabel.Text = "Пароль";
            // 
            // PasswordUnderlinePanel
            // 
            this.PasswordUnderlinePanel.BackColor = System.Drawing.Color.LightGray;
            this.PasswordUnderlinePanel.Location = new System.Drawing.Point(31, 182);
            this.PasswordUnderlinePanel.Name = "PasswordUnderlinePanel";
            this.PasswordUnderlinePanel.Size = new System.Drawing.Size(200, 1);
            this.PasswordUnderlinePanel.TabIndex = 41;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(31, 161);
            this.PasswordTextBox.MaxLength = 32;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 19);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginTextBox.Location = new System.Drawing.Point(31, 94);
            this.LoginTextBox.MaxLength = 10;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(200, 19);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.ForeColor = System.Drawing.Color.Gray;
            this.LoginLabel.Location = new System.Drawing.Point(28, 69);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(52, 18);
            this.LoginLabel.TabIndex = 40;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginUnderlinePanel
            // 
            this.LoginUnderlinePanel.BackColor = System.Drawing.Color.LightGray;
            this.LoginUnderlinePanel.Location = new System.Drawing.Point(31, 115);
            this.LoginUnderlinePanel.Name = "LoginUnderlinePanel";
            this.LoginUnderlinePanel.Size = new System.Drawing.Size(200, 1);
            this.LoginUnderlinePanel.TabIndex = 39;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 602);
            this.ControlBox = false;
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.PositionComboBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressPanel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.MiddleNamePanel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNamePanel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnamePanel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordUnderlinePanel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginUnderlinePanel);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Panel MiddleNamePanel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Panel FirstNamePanel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Panel SurnamePanel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel PasswordUnderlinePanel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Panel LoginUnderlinePanel;
    }
}