using System;
using System.Windows.Forms;

namespace LandSeismic.User
{
    public partial class EditUser : Form
    {
        static public Boolean modified = false;
        static public Boolean loginModified = false;

        public EditUser()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void PhoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsNumeral(sender, e);
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            LoginTextBox.Text = User.Login;
            PasswordTextBox.Text = User.Password;
            SurnameTextBox.Text = User.Surname;
            FirstNameTextBox.Text = User.FirstName;
            MiddleNameTextBox.Text = User.MiddleName;
            PhoneMaskedTextBox.Text = User.Phone;
            AddressTextBox.Text = User.Address;

            Position.PositionClass.GetPositionListForUser();
            PositionComboBox.DataSource = Position.PositionClass.DTPosition;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.ValueMember = "id";
            PositionComboBox.Text = User.Position;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text != User.Login)
                loginModified = true;

            if (LoginTextBox.Text != String.Empty &&
                PasswordTextBox.Text != String.Empty &&
                SurnameTextBox.Text != String.Empty &&
                FirstNameTextBox.Text != String.Empty &&
                MiddleNameTextBox.Text != String.Empty &&
                PhoneMaskedTextBox.MaskCompleted &&
                AddressTextBox.Text != String.Empty &&
                PositionComboBox.Text != String.Empty)
            {
                if (UserClass.EditUser(LoginTextBox.Text,
                    PasswordTextBox.Text, SurnameTextBox.Text,
                    FirstNameTextBox.Text, MiddleNameTextBox.Text,
                    PhoneMaskedTextBox.Text, AddressTextBox.Text,
                    PositionComboBox.SelectedValue.ToString(),
                    modified, loginModified, User.Login))
                {
                    UserClass.GetUserList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                                    "Ошибка корректности ввода",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            modified = true;
        }
    }
}
