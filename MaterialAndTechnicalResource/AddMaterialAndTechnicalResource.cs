using System;
using System.Windows.Forms;

namespace LandSeismic.MaterialAndTechnicalResource
{
    public partial class AddMaterialAndTechnicalResource : Form
    {
        public AddMaterialAndTechnicalResource()
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
                if (MaterialAndTechnicalResourceClass.
                    AddMaterialAndTechnicalResource(NameTextBox.Text, 
                    FoodCheckBox.Checked))
                {
                    MaterialAndTechnicalResourceClass.
                        GetMaterialAndTechnicalResourceList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                    "Ошибка корректности ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void AddMaterialAndTechnicalResource_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddMaterialAndTechnicalResource_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
