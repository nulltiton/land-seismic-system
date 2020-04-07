using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandSeismic.Locality
{
    public partial class AddLocality : Form
    {
        public AddLocality()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LatitudeMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsNumeral(sender, e);
        }

        private void AddLocality_Load(object sender, EventArgs e)
        {
            LocalityType.LocalityTypeClass.GetLocalityTypeList();
            LocalityComboBox.DataSource = LocalityType.LocalityTypeClass.
                DTLocalityType;
            LocalityComboBox.DisplayMember = "name";
            LocalityComboBox.ValueMember = "id";

            SeismicExplorationType.SeismicExplorationTypeClass.GetSeismicExplorationTypeList();
            SeismicExplorationComboBox.DataSource = SeismicExplorationType.
                SeismicExplorationTypeClass.DTSeismicExplorationType;
            SeismicExplorationComboBox.DisplayMember = "name";
            SeismicExplorationComboBox.ValueMember = "id";

            User.UserClass.GetLeadGeologistList();
            LeadGeologistComboBox.DataSource = User.UserClass.DTLeadGeologist;
            LeadGeologistComboBox.DisplayMember = "name";
            LeadGeologistComboBox.ValueMember = "login";

            User.UserClass.GetSquadLeaderList();
            SquadLeaderComboBox.DataSource = User.UserClass.DTSquadLeader;
            SquadLeaderComboBox.DisplayMember = "name";
            SquadLeaderComboBox.ValueMember = "login";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LatitudeMaskedTextBox.MaskCompleted &&
                LongitudeMaskedTextBox.MaskCompleted)
            {
                if (LocalityClass.AddLocality(LocalityComboBox.SelectedValue.
                    ToString(), SeismicExplorationComboBox.SelectedValue.
                    ToString(), SizeNumericUpDown.Value.ToString(), 
                    LatitudeMaskedTextBox.Text, LongitudeMaskedTextBox.Text, 
                    Authorization.AuthorizationClass.Login, 
                    LeadGeologistComboBox.SelectedValue.ToString(), 
                    SquadLeaderComboBox.SelectedValue.ToString(), 
                    UsabilityCheckBox.Checked))
                {
                    LocalityClass.GetLocalityList();
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
