using System;
using System.Windows.Forms;

namespace LandSeismic.SeismicExplorationType
{
    public partial class EditSeismicExplorationType : Form
    {
        public EditSeismicExplorationType()
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
                if (SeismicExplorationTypeClass.EditSeismicExplorationType(
                    SeismicExplorationType.SeismicExplorationTypeId, 
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

        private void EditSeismicExplorationType_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = SeismicExplorationType.
                SeismicExplorationTypeName;
        }

        private void EditSeismicExplorationType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditSeismicExplorationType_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
