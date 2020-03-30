using System;
using System.Windows.Forms;

namespace LandSeismic.User
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void backwardsBbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != String.Empty && 
                passwordTextBox.Text != String.Empty &&
                surnameTextBox.Text != String.Empty &&
                firstNameTextBox.Text != String.Empty &&
                middleNameTextBox.Text != String.Empty &&
                phoneMaskedTextBox.MaskCompleted &&
                addressTextBox.Text != String.Empty &&
                positionComboBox.Text != String.Empty)
            {
                if (UserClass.AddUser(loginTextBox.Text,
                    passwordTextBox.Text, surnameTextBox.Text,
                    firstNameTextBox.Text, middleNameTextBox.Text,
                    phoneMaskedTextBox.Text, addressTextBox.Text,
                    positionComboBox.SelectedValue.ToString()))
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

        private void phoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsNumeral(sender, e);
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void AddLeadGeologist_Load(object sender, EventArgs e)
        {
            Position.PositionClass.GetPositionList();
            positionComboBox.DataSource = Position.PositionClass.dtPosition;
            positionComboBox.DisplayMember = "name";
            positionComboBox.ValueMember = "id";
        }
    }
}
