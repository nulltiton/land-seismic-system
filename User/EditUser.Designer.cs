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
            this.formBorderPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.backwardsBbutton = new System.Windows.Forms.Button();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressPanel = new System.Windows.Forms.Panel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.moddleNamePanel = new System.Windows.Forms.Panel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNamePanel = new System.Windows.Forms.Panel();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnamePanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordUnderlinePanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginUnderlinePanel = new System.Windows.Forms.Panel();
            this.formBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBorderPanel
            // 
            this.formBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.formBorderPanel.Controls.Add(this.saveButton);
            this.formBorderPanel.Controls.Add(this.backwardsBbutton);
            this.formBorderPanel.Controls.Add(this.formNameLabel);
            this.formBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBorderPanel.ForeColor = System.Drawing.Color.White;
            this.formBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.formBorderPanel.Name = "formBorderPanel";
            this.formBorderPanel.Size = new System.Drawing.Size(263, 45);
            this.formBorderPanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Image = global::LandSeismic.Properties.Resources.save;
            this.saveButton.Location = new System.Drawing.Point(172, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(25, 25);
            this.saveButton.TabIndex = 4;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backwardsBbutton
            // 
            this.backwardsBbutton.FlatAppearance.BorderSize = 0;
            this.backwardsBbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardsBbutton.Image = ((System.Drawing.Image)(resources.GetObject("backwardsBbutton.Image")));
            this.backwardsBbutton.Location = new System.Drawing.Point(220, 10);
            this.backwardsBbutton.Name = "backwardsBbutton";
            this.backwardsBbutton.Size = new System.Drawing.Size(25, 25);
            this.backwardsBbutton.TabIndex = 3;
            this.backwardsBbutton.UseVisualStyleBackColor = true;
            this.backwardsBbutton.Click += new System.EventHandler(this.backwardsBbutton_Click);
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Location = new System.Drawing.Point(12, 13);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(128, 18);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Редактирование";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.ForeColor = System.Drawing.Color.Gray;
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(31, 427);
            this.phoneMaskedTextBox.Mask = "8 (000) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(204, 19);
            this.phoneMaskedTextBox.TabIndex = 36;
            this.phoneMaskedTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.phoneMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneMaskedTextBox_KeyPress);
            // 
            // positionComboBox
            // 
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionComboBox.ForeColor = System.Drawing.Color.Gray;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.positionComboBox.Location = new System.Drawing.Point(27, 554);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(204, 26);
            this.positionComboBox.TabIndex = 38;
            this.positionComboBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.ForeColor = System.Drawing.Color.Gray;
            this.positionLabel.Location = new System.Drawing.Point(28, 533);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(88, 18);
            this.positionLabel.TabIndex = 52;
            this.positionLabel.Text = "Должность";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.ForeColor = System.Drawing.Color.Gray;
            this.addressTextBox.Location = new System.Drawing.Point(31, 492);
            this.addressTextBox.MaxLength = 150;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 19);
            this.addressTextBox.TabIndex = 37;
            this.addressTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressTextBox_KeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.ForeColor = System.Drawing.Color.Gray;
            this.addressLabel.Location = new System.Drawing.Point(28, 471);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(52, 18);
            this.addressLabel.TabIndex = 51;
            this.addressLabel.Text = "Адрес";
            // 
            // addressPanel
            // 
            this.addressPanel.BackColor = System.Drawing.Color.LightGray;
            this.addressPanel.Location = new System.Drawing.Point(31, 513);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.Size = new System.Drawing.Size(200, 1);
            this.addressPanel.TabIndex = 50;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.ForeColor = System.Drawing.Color.Gray;
            this.phoneLabel.Location = new System.Drawing.Point(28, 403);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(73, 18);
            this.phoneLabel.TabIndex = 49;
            this.phoneLabel.Text = "Телефон";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.middleNameTextBox.Location = new System.Drawing.Point(31, 358);
            this.middleNameTextBox.MaxLength = 20;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.middleNameTextBox.TabIndex = 35;
            this.middleNameTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.middleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.middleNameLabel.Location = new System.Drawing.Point(28, 337);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(76, 18);
            this.middleNameLabel.TabIndex = 48;
            this.middleNameLabel.Text = "Отчество";
            // 
            // moddleNamePanel
            // 
            this.moddleNamePanel.BackColor = System.Drawing.Color.LightGray;
            this.moddleNamePanel.Location = new System.Drawing.Point(31, 378);
            this.moddleNamePanel.Name = "moddleNamePanel";
            this.moddleNamePanel.Size = new System.Drawing.Size(200, 1);
            this.moddleNamePanel.TabIndex = 47;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 268);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(39, 18);
            this.firstNameLabel.TabIndex = 46;
            this.firstNameLabel.Text = "Имя";
            // 
            // firstNamePanel
            // 
            this.firstNamePanel.BackColor = System.Drawing.Color.LightGray;
            this.firstNamePanel.Location = new System.Drawing.Point(31, 315);
            this.firstNamePanel.Name = "firstNamePanel";
            this.firstNamePanel.Size = new System.Drawing.Size(200, 1);
            this.firstNamePanel.TabIndex = 45;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.firstNameTextBox.Location = new System.Drawing.Point(31, 294);
            this.firstNameTextBox.MaxLength = 20;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.firstNameTextBox.TabIndex = 34;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.surnameTextBox.Location = new System.Drawing.Point(31, 227);
            this.surnameTextBox.MaxLength = 20;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 19);
            this.surnameTextBox.TabIndex = 33;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.ForeColor = System.Drawing.Color.Gray;
            this.surnameLabel.Location = new System.Drawing.Point(28, 202);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(75, 18);
            this.surnameLabel.TabIndex = 44;
            this.surnameLabel.Text = "Фамилия";
            // 
            // surnamePanel
            // 
            this.surnamePanel.BackColor = System.Drawing.Color.LightGray;
            this.surnamePanel.Location = new System.Drawing.Point(31, 248);
            this.surnamePanel.Name = "surnamePanel";
            this.surnamePanel.Size = new System.Drawing.Size(200, 1);
            this.surnamePanel.TabIndex = 43;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.Gray;
            this.passwordLabel.Location = new System.Drawing.Point(28, 135);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 18);
            this.passwordLabel.TabIndex = 42;
            this.passwordLabel.Text = "Пароль";
            // 
            // passwordUnderlinePanel
            // 
            this.passwordUnderlinePanel.BackColor = System.Drawing.Color.LightGray;
            this.passwordUnderlinePanel.Location = new System.Drawing.Point(31, 182);
            this.passwordUnderlinePanel.Name = "passwordUnderlinePanel";
            this.passwordUnderlinePanel.Size = new System.Drawing.Size(200, 1);
            this.passwordUnderlinePanel.TabIndex = 41;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextBox.Location = new System.Drawing.Point(31, 161);
            this.passwordTextBox.MaxLength = 32;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 19);
            this.passwordTextBox.TabIndex = 32;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.loginTextBox.Location = new System.Drawing.Point(31, 94);
            this.loginTextBox.MaxLength = 20;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 19);
            this.loginTextBox.TabIndex = 31;
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTextBox_KeyPress);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.ForeColor = System.Drawing.Color.Gray;
            this.loginLabel.Location = new System.Drawing.Point(28, 69);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(52, 18);
            this.loginLabel.TabIndex = 40;
            this.loginLabel.Text = "Логин";
            // 
            // loginUnderlinePanel
            // 
            this.loginUnderlinePanel.BackColor = System.Drawing.Color.LightGray;
            this.loginUnderlinePanel.Location = new System.Drawing.Point(31, 115);
            this.loginUnderlinePanel.Name = "loginUnderlinePanel";
            this.loginUnderlinePanel.Size = new System.Drawing.Size(200, 1);
            this.loginUnderlinePanel.TabIndex = 39;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 602);
            this.ControlBox = false;
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.moddleNamePanel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNamePanel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnamePanel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordUnderlinePanel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginUnderlinePanel);
            this.Controls.Add(this.formBorderPanel);
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
            this.formBorderPanel.ResumeLayout(false);
            this.formBorderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBorderPanel;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.Button backwardsBbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Panel addressPanel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Panel moddleNamePanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel firstNamePanel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Panel surnamePanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel passwordUnderlinePanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel loginUnderlinePanel;
    }
}