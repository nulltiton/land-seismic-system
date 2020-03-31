using System;
using System.Windows.Forms;

namespace LandSeismic.Employee
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
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
                if (EmployeeClass.EditEmployee(Employee.Id, 
                    SurnameTextBox.Text, FirstNameTextBox.Text, 
                    MiddleNameTextBox.Text, PhoneMaskedTextBox.Text, 
                    AddressTextBox.Text, ContactPhoneMaskedTextBox.Text,
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

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            SurnameTextBox.Text = Employee.Surname;
            FirstNameTextBox.Text = Employee.FirstName;
            MiddleNameTextBox.Text = Employee.MiddleName;
            PhoneMaskedTextBox.Text = Employee.Phone;
            AddressTextBox.Text = Employee.Address;
            ContactPhoneMaskedTextBox.Text = Employee.ContactPhone;
            Position.PositionClass.GetPositionListForEmployee();
            PositionComboBox.DataSource = Position.PositionClass.DTPosition;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.ValueMember = "id";
            PositionComboBox.Text = Employee.Position;
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbols(sender, e);
        }

        private void PhoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsNumeral(sender, e);
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbolsOrNumeral(sender, e);
        }
    }
}
