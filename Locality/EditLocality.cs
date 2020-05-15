using System;
using System.Windows.Forms;

namespace LandSeismic.Locality
{
    public partial class EditLocality : Form
    {
        public EditLocality()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditLocality_Load(object sender, EventArgs e)
        {
            LocalityType.LocalityTypeClass.GetLocalityTypeList();
            LocalityComboBox.DataSource = LocalityType.LocalityTypeClass.
                DTLocalityType;
            LocalityComboBox.DisplayMember = "name";
            LocalityComboBox.ValueMember = "id";
            LocalityComboBox.Text = Locality.LocalityIdLocalityType;

            SeismicExplorationType.SeismicExplorationTypeClass.GetSeismicExplorationTypeList();
            SeismicExplorationComboBox.DataSource = SeismicExplorationType.
                SeismicExplorationTypeClass.DTSeismicExplorationType;
            SeismicExplorationComboBox.DisplayMember = "name";
            SeismicExplorationComboBox.ValueMember = "id";
            SeismicExplorationComboBox.Text = Locality.
                LocalityIdSeismicExplorationType;

            SizeNumericUpDown.Value = Convert.ToInt32(Locality.LocalitySize);
            LatitudeMaskedTextBox.Text = Locality.LocalityLatitude;
            LongitudeMaskedTextBox.Text = Locality.LocalityLongitude;

            User.UserClass.GetLeadGeologistList();
            LeadGeologistComboBox.DataSource = User.UserClass.DTLeadGeologist;
            LeadGeologistComboBox.DisplayMember = "name";
            LeadGeologistComboBox.ValueMember = "login";
            LeadGeologistComboBox.Text = Locality.LocalityLoginLeadGeologist;

            User.UserClass.GetSquadLeaderList();
            SquadLeaderComboBox.DataSource = User.UserClass.DTSquadLeader;
            SquadLeaderComboBox.DisplayMember = "name";
            SquadLeaderComboBox.ValueMember = "login";
            SquadLeaderComboBox.Text = Locality.LocalityLoginSquadLeader;

            UsabilityCheckBox.Checked = Locality.LocalityUsability == "1" ? 
                true : false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LatitudeMaskedTextBox.MaskCompleted &&
                LongitudeMaskedTextBox.MaskCompleted)
            {
                if (LocalityClass.EditLocality(Locality.LocalityId,
                    LocalityComboBox.SelectedValue.
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

        private void EditLocality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditLocality_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
