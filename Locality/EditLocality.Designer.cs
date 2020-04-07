namespace LandSeismic.Locality
{
    partial class EditLocality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLocality));
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.UsabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.UsabilityLabel = new System.Windows.Forms.Label();
            this.SquadLeaderComboBox = new System.Windows.Forms.ComboBox();
            this.SquadLeaderLabel = new System.Windows.Forms.Label();
            this.LeadGeologistComboBox = new System.Windows.Forms.ComboBox();
            this.LeadGeologistLabel = new System.Windows.Forms.Label();
            this.LongitudeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LongitudeLabel = new System.Windows.Forms.Label();
            this.LatitudeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LatitudeLabel = new System.Windows.Forms.Label();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SeismicExplorationComboBox = new System.Windows.Forms.ComboBox();
            this.SeismicExplorationLabel = new System.Windows.Forms.Label();
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
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
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(128, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Редактирование";
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
            // UsabilityCheckBox
            // 
            this.UsabilityCheckBox.AutoSize = true;
            this.UsabilityCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsabilityCheckBox.Location = new System.Drawing.Point(33, 511);
            this.UsabilityCheckBox.Name = "UsabilityCheckBox";
            this.UsabilityCheckBox.Size = new System.Drawing.Size(12, 11);
            this.UsabilityCheckBox.TabIndex = 100;
            this.UsabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsabilityLabel
            // 
            this.UsabilityLabel.AutoSize = true;
            this.UsabilityLabel.ForeColor = System.Drawing.Color.Gray;
            this.UsabilityLabel.Location = new System.Drawing.Point(28, 485);
            this.UsabilityLabel.Name = "UsabilityLabel";
            this.UsabilityLabel.Size = new System.Drawing.Size(92, 18);
            this.UsabilityLabel.TabIndex = 99;
            this.UsabilityLabel.Text = "Полезность";
            // 
            // SquadLeaderComboBox
            // 
            this.SquadLeaderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SquadLeaderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquadLeaderComboBox.ForeColor = System.Drawing.Color.Gray;
            this.SquadLeaderComboBox.FormattingEnabled = true;
            this.SquadLeaderComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SquadLeaderComboBox.Location = new System.Drawing.Point(27, 450);
            this.SquadLeaderComboBox.Name = "SquadLeaderComboBox";
            this.SquadLeaderComboBox.Size = new System.Drawing.Size(204, 26);
            this.SquadLeaderComboBox.TabIndex = 97;
            // 
            // SquadLeaderLabel
            // 
            this.SquadLeaderLabel.AutoSize = true;
            this.SquadLeaderLabel.ForeColor = System.Drawing.Color.Gray;
            this.SquadLeaderLabel.Location = new System.Drawing.Point(28, 429);
            this.SquadLeaderLabel.Name = "SquadLeaderLabel";
            this.SquadLeaderLabel.Size = new System.Drawing.Size(144, 18);
            this.SquadLeaderLabel.TabIndex = 98;
            this.SquadLeaderLabel.Text = "Начальник отряда";
            // 
            // LeadGeologistComboBox
            // 
            this.LeadGeologistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeadGeologistComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeadGeologistComboBox.ForeColor = System.Drawing.Color.Gray;
            this.LeadGeologistComboBox.FormattingEnabled = true;
            this.LeadGeologistComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LeadGeologistComboBox.Location = new System.Drawing.Point(27, 393);
            this.LeadGeologistComboBox.Name = "LeadGeologistComboBox";
            this.LeadGeologistComboBox.Size = new System.Drawing.Size(204, 26);
            this.LeadGeologistComboBox.TabIndex = 95;
            // 
            // LeadGeologistLabel
            // 
            this.LeadGeologistLabel.AutoSize = true;
            this.LeadGeologistLabel.ForeColor = System.Drawing.Color.Gray;
            this.LeadGeologistLabel.Location = new System.Drawing.Point(28, 372);
            this.LeadGeologistLabel.Name = "LeadGeologistLabel";
            this.LeadGeologistLabel.Size = new System.Drawing.Size(127, 18);
            this.LeadGeologistLabel.TabIndex = 96;
            this.LeadGeologistLabel.Text = "Ведущий геолог";
            // 
            // LongitudeMaskedTextBox
            // 
            this.LongitudeMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LongitudeMaskedTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LongitudeMaskedTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LongitudeMaskedTextBox.Location = new System.Drawing.Point(31, 330);
            this.LongitudeMaskedTextBox.Mask = "00.000000°";
            this.LongitudeMaskedTextBox.Name = "LongitudeMaskedTextBox";
            this.LongitudeMaskedTextBox.Size = new System.Drawing.Size(204, 19);
            this.LongitudeMaskedTextBox.TabIndex = 93;
            // 
            // LongitudeLabel
            // 
            this.LongitudeLabel.AutoSize = true;
            this.LongitudeLabel.ForeColor = System.Drawing.Color.Gray;
            this.LongitudeLabel.Location = new System.Drawing.Point(28, 306);
            this.LongitudeLabel.Name = "LongitudeLabel";
            this.LongitudeLabel.Size = new System.Drawing.Size(67, 18);
            this.LongitudeLabel.TabIndex = 94;
            this.LongitudeLabel.Text = "Долгота";
            // 
            // LatitudeMaskedTextBox
            // 
            this.LatitudeMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LatitudeMaskedTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LatitudeMaskedTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LatitudeMaskedTextBox.Location = new System.Drawing.Point(31, 267);
            this.LatitudeMaskedTextBox.Mask = "00.000000°";
            this.LatitudeMaskedTextBox.Name = "LatitudeMaskedTextBox";
            this.LatitudeMaskedTextBox.Size = new System.Drawing.Size(204, 19);
            this.LatitudeMaskedTextBox.TabIndex = 91;
            // 
            // LatitudeLabel
            // 
            this.LatitudeLabel.AutoSize = true;
            this.LatitudeLabel.ForeColor = System.Drawing.Color.Gray;
            this.LatitudeLabel.Location = new System.Drawing.Point(28, 243);
            this.LatitudeLabel.Name = "LatitudeLabel";
            this.LatitudeLabel.Size = new System.Drawing.Size(67, 18);
            this.LatitudeLabel.TabIndex = 92;
            this.LatitudeLabel.Text = "Широта";
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.SizeNumericUpDown.Location = new System.Drawing.Point(31, 203);
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.SizeNumericUpDown.TabIndex = 90;
            this.SizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.ForeColor = System.Drawing.Color.Gray;
            this.SizeLabel.Location = new System.Drawing.Point(28, 181);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(60, 18);
            this.SizeLabel.TabIndex = 89;
            this.SizeLabel.Text = "Размер";
            // 
            // SeismicExplorationComboBox
            // 
            this.SeismicExplorationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeismicExplorationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeismicExplorationComboBox.ForeColor = System.Drawing.Color.Gray;
            this.SeismicExplorationComboBox.FormattingEnabled = true;
            this.SeismicExplorationComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SeismicExplorationComboBox.Location = new System.Drawing.Point(27, 146);
            this.SeismicExplorationComboBox.Name = "SeismicExplorationComboBox";
            this.SeismicExplorationComboBox.Size = new System.Drawing.Size(204, 26);
            this.SeismicExplorationComboBox.TabIndex = 87;
            // 
            // SeismicExplorationLabel
            // 
            this.SeismicExplorationLabel.AutoSize = true;
            this.SeismicExplorationLabel.ForeColor = System.Drawing.Color.Gray;
            this.SeismicExplorationLabel.Location = new System.Drawing.Point(28, 125);
            this.SeismicExplorationLabel.Name = "SeismicExplorationLabel";
            this.SeismicExplorationLabel.Size = new System.Drawing.Size(108, 18);
            this.SeismicExplorationLabel.TabIndex = 88;
            this.SeismicExplorationLabel.Text = "Тип разведки";
            // 
            // LocalityComboBox
            // 
            this.LocalityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocalityComboBox.ForeColor = System.Drawing.Color.Gray;
            this.LocalityComboBox.FormattingEnabled = true;
            this.LocalityComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LocalityComboBox.Location = new System.Drawing.Point(27, 90);
            this.LocalityComboBox.Name = "LocalityComboBox";
            this.LocalityComboBox.Size = new System.Drawing.Size(204, 26);
            this.LocalityComboBox.TabIndex = 85;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.ForeColor = System.Drawing.Color.Gray;
            this.PositionLabel.Location = new System.Drawing.Point(28, 69);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(86, 18);
            this.PositionLabel.TabIndex = 86;
            this.PositionLabel.Text = "Местность";
            // 
            // EditLocality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 553);
            this.ControlBox = false;
            this.Controls.Add(this.UsabilityCheckBox);
            this.Controls.Add(this.UsabilityLabel);
            this.Controls.Add(this.SquadLeaderComboBox);
            this.Controls.Add(this.SquadLeaderLabel);
            this.Controls.Add(this.LeadGeologistComboBox);
            this.Controls.Add(this.LeadGeologistLabel);
            this.Controls.Add(this.LongitudeMaskedTextBox);
            this.Controls.Add(this.LongitudeLabel);
            this.Controls.Add(this.LatitudeMaskedTextBox);
            this.Controls.Add(this.LatitudeLabel);
            this.Controls.Add(this.SizeNumericUpDown);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SeismicExplorationComboBox);
            this.Controls.Add(this.SeismicExplorationLabel);
            this.Controls.Add(this.LocalityComboBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLocality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.EditLocality_Load);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox UsabilityCheckBox;
        private System.Windows.Forms.Label UsabilityLabel;
        private System.Windows.Forms.ComboBox SquadLeaderComboBox;
        private System.Windows.Forms.Label SquadLeaderLabel;
        private System.Windows.Forms.ComboBox LeadGeologistComboBox;
        private System.Windows.Forms.Label LeadGeologistLabel;
        private System.Windows.Forms.MaskedTextBox LongitudeMaskedTextBox;
        private System.Windows.Forms.Label LongitudeLabel;
        private System.Windows.Forms.MaskedTextBox LatitudeMaskedTextBox;
        private System.Windows.Forms.Label LatitudeLabel;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ComboBox SeismicExplorationComboBox;
        private System.Windows.Forms.Label SeismicExplorationLabel;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.Label PositionLabel;
    }
}