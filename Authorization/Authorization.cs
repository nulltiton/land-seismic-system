using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandSeismic.Authorization
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (!DBConnection.DBConnection.Connect(DBConnection.DBConnection.
                connectionString))
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != String.Empty ||
                passwordTextBox.Text != String.Empty)
            {
                if (AuthorizationClass.LogIn(loginTextBox.Text, passwordTextBox.
                    Text) == "Ведущий геолог")
                {
                    MainMenu.MainMenu mainMenu = new MainMenu.MainMenu();
                    mainMenu.Show();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля", 
                    "Ошибка корректности ввода", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybols(sender, e);
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.Validation.IsEnglishSybols(sender, e);
        }
    }
}
