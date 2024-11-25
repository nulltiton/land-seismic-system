﻿using System;
using System.Windows.Forms;

namespace LandSeismic.LocalityType
{
    public partial class AddLocalityType : Form
    {
        public AddLocalityType()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != String.Empty)
            {
                if (LocalityTypeClass.AddLocalityType(
                    NameTextBox.Text))
                {
                    LocalityTypeClass.
                        GetLocalityTypeList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                    "Ошибка корректности ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbols(sender, e);
        }

        private void AddLocalityType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddLocalityType_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
