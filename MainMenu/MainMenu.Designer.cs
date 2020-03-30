namespace LandSeismic.MainMenu
{
    partial class MainMenu
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
            this.exitButton = new System.Windows.Forms.Button();
            this.formNameLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.positionButton = new System.Windows.Forms.Button();
            this.localityStandartButton = new System.Windows.Forms.Button();
            this.positionStandartButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.formBorderPanel.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // formBorderPanel
            // 
            this.formBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.formBorderPanel.Controls.Add(this.exitButton);
            this.formBorderPanel.Controls.Add(this.formNameLabel);
            this.formBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBorderPanel.ForeColor = System.Drawing.Color.White;
            this.formBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.formBorderPanel.Name = "formBorderPanel";
            this.formBorderPanel.Size = new System.Drawing.Size(525, 45);
            this.formBorderPanel.TabIndex = 0;
            this.formBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBorderPanel_MouseDown);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::LandSeismic.Properties.Resources.shutdown;
            this.exitButton.Location = new System.Drawing.Point(481, 9);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 5;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // formNameLabel
            // 
            this.formNameLabel.AutoSize = true;
            this.formNameLabel.Location = new System.Drawing.Point(12, 13);
            this.formNameLabel.Name = "formNameLabel";
            this.formNameLabel.Size = new System.Drawing.Size(110, 18);
            this.formNameLabel.TabIndex = 0;
            this.formNameLabel.Text = "Главное меню";
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.sideMenuPanel.Controls.Add(this.positionButton);
            this.sideMenuPanel.Controls.Add(this.localityStandartButton);
            this.sideMenuPanel.Controls.Add(this.positionStandartButton);
            this.sideMenuPanel.Controls.Add(this.employeeButton);
            this.sideMenuPanel.Controls.Add(this.userButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 45);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(140, 326);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // positionButton
            // 
            this.positionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.positionButton.FlatAppearance.BorderSize = 0;
            this.positionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionButton.Location = new System.Drawing.Point(0, 260);
            this.positionButton.Name = "positionButton";
            this.positionButton.Size = new System.Drawing.Size(140, 65);
            this.positionButton.TabIndex = 7;
            this.positionButton.Text = "Должности";
            this.positionButton.UseVisualStyleBackColor = true;
            // 
            // localityStandartButton
            // 
            this.localityStandartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.localityStandartButton.FlatAppearance.BorderSize = 0;
            this.localityStandartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localityStandartButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localityStandartButton.Location = new System.Drawing.Point(0, 195);
            this.localityStandartButton.Name = "localityStandartButton";
            this.localityStandartButton.Size = new System.Drawing.Size(140, 65);
            this.localityStandartButton.TabIndex = 5;
            this.localityStandartButton.Text = "Нормативы местности";
            this.localityStandartButton.UseVisualStyleBackColor = true;
            // 
            // positionStandartButton
            // 
            this.positionStandartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.positionStandartButton.FlatAppearance.BorderSize = 0;
            this.positionStandartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionStandartButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.positionStandartButton.Location = new System.Drawing.Point(0, 130);
            this.positionStandartButton.Name = "positionStandartButton";
            this.positionStandartButton.Size = new System.Drawing.Size(140, 65);
            this.positionStandartButton.TabIndex = 4;
            this.positionStandartButton.Text = "Нормативы должности";
            this.positionStandartButton.UseVisualStyleBackColor = true;
            // 
            // employeeButton
            // 
            this.employeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeButton.Location = new System.Drawing.Point(0, 65);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(140, 65);
            this.employeeButton.TabIndex = 3;
            this.employeeButton.Text = "Сотрудники";
            this.employeeButton.UseVisualStyleBackColor = true;
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userButton.Location = new System.Drawing.Point(0, 0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(140, 65);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Пользователи";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.leadGeologistButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::LandSeismic.Properties.Resources.logo;
            this.logoPictureBox.Location = new System.Drawing.Point(140, 45);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(385, 326);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 371);
            this.ControlBox = false;
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.formBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.formBorderPanel.ResumeLayout(false);
            this.formBorderPanel.PerformLayout();
            this.sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBorderPanel;
        private System.Windows.Forms.Label formNameLabel;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button localityStandartButton;
        private System.Windows.Forms.Button positionStandartButton;
        private System.Windows.Forms.Button positionButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button exitButton;
    }
}