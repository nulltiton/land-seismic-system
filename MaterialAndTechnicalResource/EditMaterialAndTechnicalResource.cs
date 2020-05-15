using System;
using System.Windows.Forms;

namespace LandSeismic.MaterialAndTechnicalResource
{
    public partial class EditMaterialAndTechnicalResource : Form
    {
        public EditMaterialAndTechnicalResource()
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
                    EditMaterialAndTechnicalResource(
                    MaterialAndTechnicalResource.
                    MaterialAndTechnicalResourceId, NameTextBox.Text,
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

        private void EditMaterialAndTechnicalResource_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceName;
            FoodCheckBox.Checked = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceIsConsumable;
        }

        private void EditMaterialAndTechnicalResource_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditMaterialAndTechnicalResource_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
