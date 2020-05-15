using System;
using System.Windows.Forms;

namespace LandSeismic.User
{
    public partial class AddUser : Form
    {
        public AddUser()
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
            if (LoginTextBox.Text != String.Empty && 
                PasswordTextBox.Text != String.Empty &&
                SurnameTextBox.Text != String.Empty &&
                FirstNameTextBox.Text != String.Empty &&
                MiddleNameTextBox.Text != String.Empty &&
                PhoneMaskedTextBox.MaskCompleted &&
                AddressTextBox.Text != String.Empty &&
                PositionComboBox.Text != String.Empty)
            {
                if (UserClass.AddUser(LoginTextBox.Text,
                    PasswordTextBox.Text, SurnameTextBox.Text,
                    FirstNameTextBox.Text, MiddleNameTextBox.Text,
                    PhoneMaskedTextBox.Text, AddressTextBox.Text,
                    PositionComboBox.SelectedValue.ToString()))
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

        private void PhoneMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsNumeral(sender, e);
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbols(sender, e);
        }

        private void AddLeadGeologist_Load(object sender, EventArgs e)
        {
            Position.PositionClass.GetPositionListForUser();
            PositionComboBox.DataSource = Position.PositionClass.DTPosition;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.ValueMember = "id";
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbolsOrNumeral(sender, e);
        }

        private void AddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddUser_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
