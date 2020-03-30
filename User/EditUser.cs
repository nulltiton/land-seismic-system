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

        private void backwardsBbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void phoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsNumeral(sender, e);
        }

        private void addressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            loginTextBox.Text = User.login;
            passwordTextBox.Text = User.password;
            surnameTextBox.Text = User.surname;
            firstNameTextBox.Text = User.firstName;
            middleNameTextBox.Text = User.middleName;
            phoneMaskedTextBox.Text = User.phone;
            addressTextBox.Text = User.address;

            Position.PositionClass.GetPositionList();
            positionComboBox.DataSource = Position.PositionClass.dtPosition;
            positionComboBox.DisplayMember = "name";
            positionComboBox.ValueMember = "id";
            positionComboBox.Text = User.position;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != User.login)
                loginModified = true;

            if (loginTextBox.Text != String.Empty &&
                passwordTextBox.Text != String.Empty &&
                surnameTextBox.Text != String.Empty &&
                firstNameTextBox.Text != String.Empty &&
                middleNameTextBox.Text != String.Empty &&
                phoneMaskedTextBox.MaskCompleted &&
                addressTextBox.Text != String.Empty &&
                positionComboBox.Text != String.Empty)
            {
                if (UserClass.EditUser(loginTextBox.Text,
                    passwordTextBox.Text, surnameTextBox.Text,
                    firstNameTextBox.Text, middleNameTextBox.Text,
                    phoneMaskedTextBox.Text, addressTextBox.Text,
                    positionComboBox.SelectedValue.ToString(),
                    modified, loginModified, User.login))
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

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            modified = true;
        }
    }
}
