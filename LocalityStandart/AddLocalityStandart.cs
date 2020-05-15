using System;
using System.Windows.Forms;

namespace LandSeismic.LocalityStandart
{
    public partial class AddLocalityStandart : Form
    {
        public AddLocalityStandart()
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
            if (LocalityComboBox.Text != String.Empty &&
               ResourceComboBox.Text != String.Empty &&
               AmountNumericUpDown.Value != null)
            {
                if (LocalityStandartClass.AddLocalityStandart(
                    LocalityComboBox.SelectedValue.ToString(),
                    ResourceComboBox.SelectedValue.ToString(),
                    AmountNumericUpDown.Value.ToString()))
                {
                    LocalityStandartClass.GetLocalityStandartList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                                    "Ошибка корректности ввода",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
        }

        private void AddLocalityStandart_Load(object sender, EventArgs e)
        {
            LocalityType.LocalityTypeClass.GetLocalityTypeList();
            LocalityComboBox.DataSource = LocalityType.LocalityTypeClass.
                DTLocalityType;
            LocalityComboBox.DisplayMember = "name";
            LocalityComboBox.ValueMember = "id";

            MaterialAndTechnicalResource.MaterialAndTechnicalResourceClass.
                GetMaterialAndTechnicalResourceList();
            ResourceComboBox.DataSource = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceClass.
                DTMaterialAndTechnicalResource;
            ResourceComboBox.DisplayMember = "name";
            ResourceComboBox.ValueMember = "id";
        }

        private void AddLocalityStandart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddLocalityStandart_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
