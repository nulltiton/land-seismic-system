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
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.ExitPictureBox = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.PositionButton = new System.Windows.Forms.Button();
            this.LocalityStandartButton = new System.Windows.Forms.Button();
            this.PositionStandartButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FormBorderPanel.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBorderPanel
            // 
            this.FormBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderPanel.Controls.Add(this.ExitPictureBox);
            this.FormBorderPanel.Controls.Add(this.FormNameLabel);
            this.FormBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderPanel.ForeColor = System.Drawing.Color.White;
            this.FormBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderPanel.Name = "FormBorderPanel";
            this.FormBorderPanel.Size = new System.Drawing.Size(525, 45);
            this.FormBorderPanel.TabIndex = 0;
            this.FormBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormBorderPanel_MouseDown);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.FlatAppearance.BorderSize = 0;
            this.ExitPictureBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitPictureBox.Image = global::LandSeismic.Properties.Resources.shutdown;
            this.ExitPictureBox.Location = new System.Drawing.Point(481, 9);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(25, 25);
            this.ExitPictureBox.TabIndex = 5;
            this.ExitPictureBox.UseVisualStyleBackColor = true;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(110, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Главное меню";
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.sideMenuPanel.Controls.Add(this.PositionButton);
            this.sideMenuPanel.Controls.Add(this.LocalityStandartButton);
            this.sideMenuPanel.Controls.Add(this.PositionStandartButton);
            this.sideMenuPanel.Controls.Add(this.EmployeeButton);
            this.sideMenuPanel.Controls.Add(this.UserButton);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 45);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(140, 326);
            this.sideMenuPanel.TabIndex = 1;
            // 
            // PositionButton
            // 
            this.PositionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionButton.FlatAppearance.BorderSize = 0;
            this.PositionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionButton.Location = new System.Drawing.Point(0, 260);
            this.PositionButton.Name = "PositionButton";
            this.PositionButton.Size = new System.Drawing.Size(140, 65);
            this.PositionButton.TabIndex = 7;
            this.PositionButton.Text = "Должности";
            this.PositionButton.UseVisualStyleBackColor = true;
            // 
            // LocalityStandartButton
            // 
            this.LocalityStandartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocalityStandartButton.FlatAppearance.BorderSize = 0;
            this.LocalityStandartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocalityStandartButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocalityStandartButton.Location = new System.Drawing.Point(0, 195);
            this.LocalityStandartButton.Name = "LocalityStandartButton";
            this.LocalityStandartButton.Size = new System.Drawing.Size(140, 65);
            this.LocalityStandartButton.TabIndex = 5;
            this.LocalityStandartButton.Text = "Нормативы местности";
            this.LocalityStandartButton.UseVisualStyleBackColor = true;
            // 
            // PositionStandartButton
            // 
            this.PositionStandartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionStandartButton.FlatAppearance.BorderSize = 0;
            this.PositionStandartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositionStandartButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionStandartButton.Location = new System.Drawing.Point(0, 130);
            this.PositionStandartButton.Name = "PositionStandartButton";
            this.PositionStandartButton.Size = new System.Drawing.Size(140, 65);
            this.PositionStandartButton.TabIndex = 4;
            this.PositionStandartButton.Text = "Нормативы должности";
            this.PositionStandartButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeeButton.FlatAppearance.BorderSize = 0;
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeButton.Location = new System.Drawing.Point(0, 65);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(140, 65);
            this.EmployeeButton.TabIndex = 3;
            this.EmployeeButton.Text = "Сотрудники";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserButton.Location = new System.Drawing.Point(0, 0);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(140, 65);
            this.UserButton.TabIndex = 0;
            this.UserButton.Text = "Пользователи";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = global::LandSeismic.Properties.Resources.logo;
            this.LogoPictureBox.Location = new System.Drawing.Point(140, 45);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(385, 326);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 2;
            this.LogoPictureBox.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 371);
            this.ControlBox = false;
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            this.sideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button LocalityStandartButton;
        private System.Windows.Forms.Button PositionStandartButton;
        private System.Windows.Forms.Button PositionButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ExitPictureBox;
    }
}