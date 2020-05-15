namespace LandSeismic.Squad
{
    partial class AddSquad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSquad));
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.SquadLeaderComboBox = new System.Windows.Forms.ComboBox();
            this.SquadLeaderLabel = new System.Windows.Forms.Label();
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.LocalityLabel = new System.Windows.Forms.Label();
            this.DepartureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureLabel = new System.Windows.Forms.Label();
            this.ReturnLabel = new System.Windows.Forms.Label();
            this.ReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActualReturnDateLabel = new System.Windows.Forms.Label();
            this.ActualReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActualReturnDateCheckBox = new System.Windows.Forms.CheckBox();
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
            this.SaveButton.TabIndex = 4;
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
            this.BackwardsButton.TabIndex = 3;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(94, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Добавление";
            // 
            // SquadLeaderComboBox
            // 
            this.SquadLeaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SquadLeaderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquadLeaderComboBox.ForeColor = System.Drawing.Color.Gray;
            this.SquadLeaderComboBox.FormattingEnabled = true;
            this.SquadLeaderComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SquadLeaderComboBox.Location = new System.Drawing.Point(27, 90);
            this.SquadLeaderComboBox.Name = "SquadLeaderComboBox";
            this.SquadLeaderComboBox.Size = new System.Drawing.Size(204, 26);
            this.SquadLeaderComboBox.TabIndex = 82;
            // 
            // SquadLeaderLabel
            // 
            this.SquadLeaderLabel.AutoSize = true;
            this.SquadLeaderLabel.ForeColor = System.Drawing.Color.Gray;
            this.SquadLeaderLabel.Location = new System.Drawing.Point(28, 69);
            this.SquadLeaderLabel.Name = "SquadLeaderLabel";
            this.SquadLeaderLabel.Size = new System.Drawing.Size(144, 18);
            this.SquadLeaderLabel.TabIndex = 83;
            this.SquadLeaderLabel.Text = "Начальник отряда";
            // 
            // LocalityComboBox
            // 
            this.LocalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocalityComboBox.ForeColor = System.Drawing.Color.Gray;
            this.LocalityComboBox.FormattingEnabled = true;
            this.LocalityComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LocalityComboBox.Location = new System.Drawing.Point(27, 146);
            this.LocalityComboBox.Name = "LocalityComboBox";
            this.LocalityComboBox.Size = new System.Drawing.Size(204, 26);
            this.LocalityComboBox.TabIndex = 84;
            // 
            // LocalityLabel
            // 
            this.LocalityLabel.AutoSize = true;
            this.LocalityLabel.ForeColor = System.Drawing.Color.Gray;
            this.LocalityLabel.Location = new System.Drawing.Point(28, 125);
            this.LocalityLabel.Name = "LocalityLabel";
            this.LocalityLabel.Size = new System.Drawing.Size(69, 18);
            this.LocalityLabel.TabIndex = 85;
            this.LocalityLabel.Text = "Участок";
            // 
            // DepartureDateTimePicker
            // 
            this.DepartureDateTimePicker.CalendarFont = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartureDateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.DepartureDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DepartureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DepartureDateTimePicker.Location = new System.Drawing.Point(27, 203);
            this.DepartureDateTimePicker.Name = "DepartureDateTimePicker";
            this.DepartureDateTimePicker.Size = new System.Drawing.Size(204, 26);
            this.DepartureDateTimePicker.TabIndex = 86;
            // 
            // DepartureLabel
            // 
            this.DepartureLabel.AutoSize = true;
            this.DepartureLabel.ForeColor = System.Drawing.Color.Gray;
            this.DepartureLabel.Location = new System.Drawing.Point(28, 182);
            this.DepartureLabel.Name = "DepartureLabel";
            this.DepartureLabel.Size = new System.Drawing.Size(101, 18);
            this.DepartureLabel.TabIndex = 87;
            this.DepartureLabel.Text = "Дата выхода";
            // 
            // ReturnLabel
            // 
            this.ReturnLabel.AutoSize = true;
            this.ReturnLabel.ForeColor = System.Drawing.Color.Gray;
            this.ReturnLabel.Location = new System.Drawing.Point(28, 237);
            this.ReturnLabel.Name = "ReturnLabel";
            this.ReturnLabel.Size = new System.Drawing.Size(144, 18);
            this.ReturnLabel.TabIndex = 89;
            this.ReturnLabel.Text = "Дата возвращения";
            // 
            // ReturnDateTimePicker
            // 
            this.ReturnDateTimePicker.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.ReturnDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.ReturnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDateTimePicker.Location = new System.Drawing.Point(27, 258);
            this.ReturnDateTimePicker.Name = "ReturnDateTimePicker";
            this.ReturnDateTimePicker.Size = new System.Drawing.Size(204, 26);
            this.ReturnDateTimePicker.TabIndex = 88;
            // 
            // ActualReturnDateLabel
            // 
            this.ActualReturnDateLabel.AutoSize = true;
            this.ActualReturnDateLabel.ForeColor = System.Drawing.Color.Gray;
            this.ActualReturnDateLabel.Location = new System.Drawing.Point(29, 292);
            this.ActualReturnDateLabel.Name = "ActualReturnDateLabel";
            this.ActualReturnDateLabel.Size = new System.Drawing.Size(189, 18);
            this.ActualReturnDateLabel.TabIndex = 91;
            this.ActualReturnDateLabel.Text = "Дата факт. возвращения";
            // 
            // ActualReturnDateTimePicker
            // 
            this.ActualReturnDateTimePicker.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.ActualReturnDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.ActualReturnDateTimePicker.Enabled = false;
            this.ActualReturnDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ActualReturnDateTimePicker.Location = new System.Drawing.Point(28, 313);
            this.ActualReturnDateTimePicker.Name = "ActualReturnDateTimePicker";
            this.ActualReturnDateTimePicker.Size = new System.Drawing.Size(204, 26);
            this.ActualReturnDateTimePicker.TabIndex = 90;
            // 
            // ActualReturnDateCheckBox
            // 
            this.ActualReturnDateCheckBox.AutoSize = true;
            this.ActualReturnDateCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualReturnDateCheckBox.Location = new System.Drawing.Point(220, 297);
            this.ActualReturnDateCheckBox.Name = "ActualReturnDateCheckBox";
            this.ActualReturnDateCheckBox.Size = new System.Drawing.Size(12, 11);
            this.ActualReturnDateCheckBox.TabIndex = 92;
            this.ActualReturnDateCheckBox.UseVisualStyleBackColor = true;
            this.ActualReturnDateCheckBox.CheckedChanged += new System.EventHandler(this.ActualReturnDateCheckBox_CheckedChanged);
            // 
            // AddSquad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 368);
            this.ControlBox = false;
            this.Controls.Add(this.ActualReturnDateCheckBox);
            this.Controls.Add(this.ActualReturnDateLabel);
            this.Controls.Add(this.ActualReturnDateTimePicker);
            this.Controls.Add(this.ReturnLabel);
            this.Controls.Add(this.ReturnDateTimePicker);
            this.Controls.Add(this.DepartureLabel);
            this.Controls.Add(this.DepartureDateTimePicker);
            this.Controls.Add(this.LocalityComboBox);
            this.Controls.Add(this.LocalityLabel);
            this.Controls.Add(this.SquadLeaderComboBox);
            this.Controls.Add(this.SquadLeaderLabel);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSquad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.AddSquad_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AddSquad_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddSquad_KeyDown);
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
        private System.Windows.Forms.ComboBox SquadLeaderComboBox;
        private System.Windows.Forms.Label SquadLeaderLabel;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.Label LocalityLabel;
        private System.Windows.Forms.DateTimePicker DepartureDateTimePicker;
        private System.Windows.Forms.Label DepartureLabel;
        private System.Windows.Forms.Label ReturnLabel;
        private System.Windows.Forms.Label ActualReturnDateLabel;
        private System.Windows.Forms.DateTimePicker ActualReturnDateTimePicker;
        public System.Windows.Forms.DateTimePicker ReturnDateTimePicker;
        private System.Windows.Forms.CheckBox ActualReturnDateCheckBox;
    }
}