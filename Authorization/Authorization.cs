using LandSeismic.Help;
using System;
using System.Windows.Forms;

namespace LandSeismic.Authorization
{
    public partial class Authorization : Form
    {
        static public Int32 MiniatureCount = 0;

        public Authorization()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (!DBConnection.DBConnection.Connect(DBConnection.DBConnection.
                connectionString))
                Close();

            MiniatureCount++;
            if (MiniatureCount == 1)
            {
                var miniature = new Miniature.Miniature();
                miniature.ShowDialog();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text != String.Empty ||
                PasswordTextBox.Text != String.Empty)
            {
                if (AuthorizationClass.LogIn(LoginTextBox.Text, 
                    PasswordTextBox.Text) != String.Empty)
                {
                    var mainMenu = new MainMenu.MainMenu();
                    mainMenu.Show();
                    Hide();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля", 
                    "Ошибка корректности ввода", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
        }

        private void LoginTextBox_KeyPress(object sender, 
            KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.
                IsEnglishSybolsOrNumeral(sender, e);
        }

        private void PasswordTextBox_KeyPress(object sender, 
            KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.
                IsEnglishSybolsOrNumeral(sender, e);
        }

        private void Authorization_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var authorizationHelp = new AuthorizationHelp();
            authorizationHelp.ShowDialog();
            
        }

        private void Authorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Application.Exit();
        }
    }
}
