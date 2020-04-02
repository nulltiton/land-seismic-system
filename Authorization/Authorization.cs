using System;
using System.Windows.Forms;

namespace LandSeismic.Authorization
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (!DBConnection.DBConnection.Connect(DBConnection.DBConnection.
                connectionString))
                Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text != String.Empty ||
                PasswordTextBox.Text != String.Empty)
            {
                if (AuthorizationClass.LogIn(LoginTextBox.Text, PasswordTextBox.
                    Text) != String.Empty)
                {
                    var mainMenu = new MainMenu.MainMenu();
                    mainMenu.Show();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля", 
                    "Ошибка корректности ввода", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsEnglishSybolsOrNumeral(sender, e);
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsEnglishSybolsOrNumeral(sender, e);
        }
    }
}
