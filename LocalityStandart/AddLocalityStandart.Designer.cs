namespace LandSeismic.LocalityStandart
{
    partial class AddLocalityStandart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLocalityStandart));
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ResourceComboBox = new System.Windows.Forms.ComboBox();
            this.ResourceLabel = new System.Windows.Forms.Label();
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
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
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountNumericUpDown.ForeColor = System.Drawing.Color.Gray;
            this.AmountNumericUpDown.Location = new System.Drawing.Point(31, 203);
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.AmountNumericUpDown.TabIndex = 65;
            this.AmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.ForeColor = System.Drawing.Color.Gray;
            this.AmountLabel.Location = new System.Drawing.Point(28, 181);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(93, 18);
            this.AmountLabel.TabIndex = 64;
            this.AmountLabel.Text = "Количество";
            // 
            // ResourceComboBox
            // 
            this.ResourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResourceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResourceComboBox.ForeColor = System.Drawing.Color.Gray;
            this.ResourceComboBox.FormattingEnabled = true;
            this.ResourceComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResourceComboBox.Location = new System.Drawing.Point(27, 146);
            this.ResourceComboBox.Name = "ResourceComboBox";
            this.ResourceComboBox.Size = new System.Drawing.Size(204, 26);
            this.ResourceComboBox.TabIndex = 62;
            // 
            // ResourceLabel
            // 
            this.ResourceLabel.AutoSize = true;
            this.ResourceLabel.ForeColor = System.Drawing.Color.Gray;
            this.ResourceLabel.Location = new System.Drawing.Point(28, 125);
            this.ResourceLabel.Name = "ResourceLabel";
            this.ResourceLabel.Size = new System.Drawing.Size(58, 18);
            this.ResourceLabel.TabIndex = 63;
            this.ResourceLabel.Text = "Ресурс";
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
            this.LocalityComboBox.TabIndex = 60;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.ForeColor = System.Drawing.Color.Gray;
            this.PositionLabel.Location = new System.Drawing.Point(28, 69);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(88, 18);
            this.PositionLabel.TabIndex = 61;
            this.PositionLabel.Text = "Должность";
            // 
            // AddLocalityStandart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(263, 253);
            this.ControlBox = false;
            this.Controls.Add(this.AmountNumericUpDown);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ResourceComboBox);
            this.Controls.Add(this.ResourceLabel);
            this.Controls.Add(this.LocalityComboBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLocalityStandart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.AddLocalityStandart_Load);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ComboBox ResourceComboBox;
        private System.Windows.Forms.Label ResourceLabel;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.Label PositionLabel;
    }
}