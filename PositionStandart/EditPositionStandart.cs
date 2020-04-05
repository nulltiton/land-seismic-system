using System;
using System.Windows.Forms;

namespace LandSeismic.PositionStandart
{
    public partial class EditPositionStandart : Form
    {
        public EditPositionStandart()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPositionStandart_Load(object sender, EventArgs e)
        {
            Position.PositionClass.GetPositionList();
            PositionComboBox.DataSource = Position.PositionClass.DTPosition;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.ValueMember = "id";
            PositionComboBox.Text = PositionStandart.PrimordialPositionName;

            MaterialAndTechnicalResource.MaterialAndTechnicalResourceClass.
                GetMaterialAndTechnicalResourceList();
            ResourceComboBox.DataSource = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceClass.
                DTMaterialAndTechnicalResource;
            ResourceComboBox.DisplayMember = "name";
            ResourceComboBox.ValueMember = "id";
            ResourceComboBox.Text = PositionStandart.PrimordialResourceName;

            AmountNumericUpDown.Value = Convert.ToByte(PositionStandart.
                PrimordialAmount);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Boolean modified;
            Boolean minorChange;
            if (PositionComboBox.Text != String.Empty &&
                ResourceComboBox.Text != String.Empty &&
                AmountNumericUpDown.Value != null)
            {
                modified = PositionComboBox.Text !=
                    PositionStandart.PrimordialPositionName || 
                    ResourceComboBox.Text != 
                    PositionStandart.PrimordialResourceName ?
                    true : false;

                minorChange = AmountNumericUpDown.Value.ToString() !=
                    PositionStandart.PrimordialAmount ?
                    true : false;


                if (PositionStandartClass.EditPositionStandart(
                    PositionComboBox.SelectedValue.ToString(),
                    ResourceComboBox.SelectedValue.ToString(),
                    AmountNumericUpDown.Value.ToString(), 
                    PositionStandart.PrimordialPositionId, 
                    PositionStandart.PrimordialResourceId, 
                    modified, minorChange))
                {
                    PositionStandartClass.GetPositionStandartList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                                    "Ошибка корректности ввода",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
        }
    }
}
