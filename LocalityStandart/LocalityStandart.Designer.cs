namespace LandSeismic.LocalityStandart
{
    partial class LocalityStandart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalityStandart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormBorderPanel = new System.Windows.Forms.Panel();
            this.BackwardsButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FormNameLabel = new System.Windows.Forms.Label();
            this.LocalityStandartGrid = new System.Windows.Forms.DataGridView();
            this.IdLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLocality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameResource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FormBorderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalityStandartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBorderPanel
            // 
            this.FormBorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderPanel.Controls.Add(this.BackwardsButton);
            this.FormBorderPanel.Controls.Add(this.AddButton);
            this.FormBorderPanel.Controls.Add(this.FormNameLabel);
            this.FormBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormBorderPanel.ForeColor = System.Drawing.Color.White;
            this.FormBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.FormBorderPanel.Name = "FormBorderPanel";
            this.FormBorderPanel.Size = new System.Drawing.Size(773, 45);
            this.FormBorderPanel.TabIndex = 0;
            // 
            // BackwardsButton
            // 
            this.BackwardsButton.FlatAppearance.BorderSize = 0;
            this.BackwardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwardsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackwardsButton.Image")));
            this.BackwardsButton.Location = new System.Drawing.Point(727, 10);
            this.BackwardsButton.Name = "BackwardsButton";
            this.BackwardsButton.Size = new System.Drawing.Size(25, 25);
            this.BackwardsButton.TabIndex = 2;
            this.BackwardsButton.UseVisualStyleBackColor = true;
            this.BackwardsButton.Click += new System.EventHandler(this.BackwardsButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::LandSeismic.Properties.Resources.plus;
            this.AddButton.Location = new System.Drawing.Point(678, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(25, 25);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FormNameLabel
            // 
            this.FormNameLabel.AutoSize = true;
            this.FormNameLabel.Location = new System.Drawing.Point(12, 13);
            this.FormNameLabel.Name = "FormNameLabel";
            this.FormNameLabel.Size = new System.Drawing.Size(150, 18);
            this.FormNameLabel.TabIndex = 0;
            this.FormNameLabel.Text = "Норматив месности";
            // 
            // LocalityStandartGrid
            // 
            this.LocalityStandartGrid.AllowUserToAddRows = false;
            this.LocalityStandartGrid.AllowUserToDeleteRows = false;
            this.LocalityStandartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LocalityStandartGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.LocalityStandartGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalityStandartGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LocalityStandartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalityStandartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLocality,
            this.NameLocality,
            this.IdResource,
            this.NameResource,
            this.Amount,
            this.EditButton,
            this.DeleteButton});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalityStandartGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.LocalityStandartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalityStandartGrid.Location = new System.Drawing.Point(0, 45);
            this.LocalityStandartGrid.Name = "LocalityStandartGrid";
            this.LocalityStandartGrid.ReadOnly = true;
            this.LocalityStandartGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LocalityStandartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalityStandartGrid.Size = new System.Drawing.Size(773, 381);
            this.LocalityStandartGrid.TabIndex = 1;
            this.LocalityStandartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocalityStandartGrid_CellContentClick);
            // 
            // IdLocality
            // 
            this.IdLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdLocality.DataPropertyName = "idlocality";
            this.IdLocality.HeaderText = "IdLocality";
            this.IdLocality.Name = "IdLocality";
            this.IdLocality.ReadOnly = true;
            this.IdLocality.Visible = false;
            this.IdLocality.Width = 241;
            // 
            // NameLocality
            // 
            this.NameLocality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameLocality.DataPropertyName = "name";
            this.NameLocality.HeaderText = "Местность";
            this.NameLocality.Name = "NameLocality";
            this.NameLocality.ReadOnly = true;
            this.NameLocality.Width = 200;
            // 
            // IdResource
            // 
            this.IdResource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdResource.DataPropertyName = "idresource";
            this.IdResource.HeaderText = "IdResource";
            this.IdResource.Name = "IdResource";
            this.IdResource.ReadOnly = true;
            this.IdResource.Visible = false;
            this.IdResource.Width = 241;
            // 
            // NameResource
            // 
            this.NameResource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameResource.DataPropertyName = "name1";
            this.NameResource.HeaderText = "Ресурс";
            this.NameResource.Name = "NameResource";
            this.NameResource.ReadOnly = true;
            this.NameResource.Width = 200;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditButton.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.HeaderText = "";
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseColumnTextForButtonValue = true;
            this.EditButton.Width = 130;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.HeaderText = "";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            this.DeleteButton.Width = 85;
            // 
            // LocalityStandart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(773, 426);
            this.ControlBox = false;
            this.Controls.Add(this.LocalityStandartGrid);
            this.Controls.Add(this.FormBorderPanel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalityStandart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalityStandart";
            this.Load += new System.EventHandler(this.LocalityStandart_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.LocalityStandart_HelpRequested);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LocalityStandart_KeyDown);
            this.FormBorderPanel.ResumeLayout(false);
            this.FormBorderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalityStandartGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormBorderPanel;
        private System.Windows.Forms.Label FormNameLabel;
        private System.Windows.Forms.DataGridView LocalityStandartGrid;
        private System.Windows.Forms.Button BackwardsButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLocality;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameResource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}