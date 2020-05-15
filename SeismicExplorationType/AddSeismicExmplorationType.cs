using System;
using System.Windows.Forms;

namespace LandSeismic.SeismicExplorationType
{
    public partial class AddSeismicExmplorationType : Form
    {
        public AddSeismicExmplorationType()
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
                if (SeismicExplorationTypeClass.AddSeismicExplorationType(
                    NameTextBox.Text))
                {
                    SeismicExplorationTypeClass.
                        GetSeismicExplorationTypeList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                    "Ошибка корректности ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void AddSeismicExmplorationType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddSeismicExmplorationType_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
