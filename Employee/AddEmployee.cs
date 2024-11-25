﻿using System;
using System.Windows.Forms;

namespace LandSeismic.Employee
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbols(sender, e);
        }

        private void PhoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsNumeral(sender, e);
        }

        private void ContactPhoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsNumeral(sender, e);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text != String.Empty &&
                FirstNameTextBox.Text != String.Empty &&
                MiddleNameTextBox.Text != String.Empty &&
                PhoneMaskedTextBox.MaskCompleted &&
                AddressTextBox.Text != String.Empty &&
                PositionComboBox.Text != String.Empty)
            {
                if (EmployeeClass.AddEmployee(SurnameTextBox.Text,
                    FirstNameTextBox.Text, MiddleNameTextBox.Text,
                    PhoneMaskedTextBox.Text, AddressTextBox.Text,
                    ContactPhoneMaskedTextBox.Text,
                    PositionComboBox.SelectedValue.ToString()))
                {
                    EmployeeClass.GetEmployeeList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                                    "Ошибка корректности ввода",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            Position.PositionClass.GetPositionListForEmployee();
            PositionComboBox.DataSource = Position.PositionClass.DTPosition;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.ValueMember = "id";
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void AddEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddEmployee_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
