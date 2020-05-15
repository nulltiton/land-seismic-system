namespace LandSeismic.Authorization
{
    partial class Authorization
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
            this.formBorderPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginUnderlinePanel = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordUnderlinePanel = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.formBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBorderPanel
            // 
            this.formBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.formBorderPanel.Controls.Add(this.logoLabel);
            this.formBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBorderPanel.ForeColor = System.Drawing.Color.White;
            this.formBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.formBorderPanel.Name = "formBorderPanel";
            this.formBorderPanel.Size = new System.Drawing.Size(260, 136);
            this.formBorderPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Calisto MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(12, 32);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(239, 74);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "MAGE";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginTextBox.Location = new System.Drawing.Point(30, 184);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(200, 19);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginUnderlinePanel
            // 
            this.LoginUnderlinePanel.BackColor = System.Drawing.Color.LightGray;
            this.LoginUnderlinePanel.Location = new System.Drawing.Point(30, 205);
            this.LoginUnderlinePanel.Name = "LoginUnderlinePanel";
            this.LoginUnderlinePanel.Size = new System.Drawing.Size(200, 1);
            this.LoginUnderlinePanel.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.ForeColor = System.Drawing.Color.Gray;
            this.LoginLabel.Location = new System.Drawing.Point(27, 159);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(52, 18);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.Gray;
            this.PasswordLabel.Location = new System.Drawing.Point(27, 225);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(62, 18);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Пароль";
            // 
            // PasswordUnderlinePanel
            // 
            this.PasswordUnderlinePanel.BackColor = System.Drawing.Color.LightGray;
            this.PasswordUnderlinePanel.Location = new System.Drawing.Point(30, 272);
            this.PasswordUnderlinePanel.Name = "PasswordUnderlinePanel";
            this.PasswordUnderlinePanel.Size = new System.Drawing.Size(200, 1);
            this.PasswordUnderlinePanel.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.Location = new System.Drawing.Point(30, 251);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 19);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(25, 295);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(99, 30);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(131, 295);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 30);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(260, 360);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordUnderlinePanel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginUnderlinePanel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.formBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Authorization_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authorization_KeyDown);
            this.formBorderPanel.ResumeLayout(false);
            this.formBorderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formBorderPanel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Panel LoginUnderlinePanel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel PasswordUnderlinePanel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ExitButton;
    }
}