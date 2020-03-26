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
            this.formNameLabel = new System.Windows.Forms.Label();
            this.formBorderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBorderPanel
            // 
            this.formBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.formBorderPanel.Controls.Add(this.formNameLabel);
            this.formBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formBorderPanel.ForeColor = System.Drawing.Color.White;
            this.formBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.formBorderPanel.Name = "formBorderPanel";
            this.formBorderPanel.Size = new System.Drawing.Size(877, 44);
            this.formBorderPanel.TabIndex = 0;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 427);
            this.ControlBox = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formBorderPanel;
        private System.Windows.Forms.Label formNameLabel;
    }
}