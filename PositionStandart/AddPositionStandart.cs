using System;
using System.Windows.Forms;

namespace LandSeismic.PositionStandart
{
    public partial class AddPositionStandart : Form
    {
        public AddPositionStandart()
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
            if (PositionComboBox.Text != String.Empty && 
                ResourceComboBox.Text != String.Empty && 
                AmountNumericUpDown.Value != null)
            {
                if (PositionStandartClass.AddPositionStandart(
                    PositionComboBox.SelectedValue.ToString(),
                    ResourceComboBox.SelectedValue.ToString(), 
                    AmountNumericUpDown.Value.ToString()))
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

        private void AddPositionStandart_Load(object sender, EventArgs e)
        {
            Position.PositionClass.GetPositionList();
            PositionComboBox.DataSource = Position.PositionClass.DTPosition;
            PositionComboBox.DisplayMember = "name";
            PositionComboBox.ValueMember = "id";

            MaterialAndTechnicalResource.MaterialAndTechnicalResourceClass.
                GetMaterialAndTechnicalResourceList();
            ResourceComboBox.DataSource = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceClass.
                DTMaterialAndTechnicalResource;
            ResourceComboBox.DisplayMember = "name";
            ResourceComboBox.ValueMember = "id";
        }

        private void AddPositionStandart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddPositionStandart_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
