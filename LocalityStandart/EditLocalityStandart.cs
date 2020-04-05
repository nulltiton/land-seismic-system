using System;
using System.Windows.Forms;

namespace LandSeismic.LocalityStandart
{
    public partial class EditLocalityStandart : Form
    {
        public EditLocalityStandart()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Boolean modified;
            Boolean minorChange;
            if (LocalityComboBox.Text != String.Empty &&
               ResourceComboBox.Text != String.Empty &&
               AmountNumericUpDown.Value != null)
            {
                modified = LocalityComboBox.Text !=
                   LocalityStandart.PrimordialLocalityName ||
                   ResourceComboBox.Text !=
                   LocalityStandart.PrimordialResourceName ?
                   true : false;

                minorChange = AmountNumericUpDown.Value.ToString() !=
                    LocalityStandart.PrimordialAmount ?
                    true : false;

                if (LocalityStandartClass.EditLocalityStandart(
                    LocalityComboBox.SelectedValue.ToString(),
                    ResourceComboBox.SelectedValue.ToString(),
                    AmountNumericUpDown.Value.ToString(), 
                    LocalityStandart.PrimordialLocalityId, 
                    LocalityStandart.PrimordialResourceId, modified, 
                    minorChange))
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

        private void EditLocalityStandart_Load(object sender, EventArgs e)
        {
            LocalityType.LocalityTypeClass.GetLocalityTypeList();
            LocalityComboBox.DataSource = LocalityType.LocalityTypeClass.
                DTLocalityType;
            LocalityComboBox.DisplayMember = "name";
            LocalityComboBox.ValueMember = "id";
            LocalityComboBox.Text = LocalityStandart.PrimordialLocalityName;

            MaterialAndTechnicalResource.MaterialAndTechnicalResourceClass.
                GetMaterialAndTechnicalResourceList();
            ResourceComboBox.DataSource = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceClass.
                DTMaterialAndTechnicalResource;
            ResourceComboBox.DisplayMember = "name";
            ResourceComboBox.ValueMember = "id";
            ResourceComboBox.Text = LocalityStandart.PrimordialResourceName;

            AmountNumericUpDown.Value = Convert.ToByte(LocalityStandart.
                PrimordialAmount);
        }
    }
}
