using System;
using System.Windows.Forms;

namespace LandSeismic.Squad
{
    public partial class EditSquad : Form
    {
        public EditSquad()
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
            String actualReturnDate;
            if (!ActualReturnDateCheckBox.Checked)
                actualReturnDate = null;
            else
                actualReturnDate = ActualReturnDateTimePicker.Text;
            if (SquadClass.EditSquad(Squad.SquadId, SquadLeaderComboBox.SelectedValue.
                ToString(), LocalityComboBox.SelectedValue.ToString(),
                DepartureDateTimePicker.Text, ReturnDateTimePicker.Text,
                actualReturnDate))
            {
                SquadClass.GetSquadList();
                Close();
            }
        }

        private void EditSquad_Load(object sender, EventArgs e)
        {
            User.UserClass.GetSquadLeaderList();
            SquadLeaderComboBox.DataSource = User.UserClass.DTSquadLeader;
            SquadLeaderComboBox.DisplayMember = "name";
            SquadLeaderComboBox.ValueMember = "login";
            SquadLeaderComboBox.Text = Squad.SquadSquadLeader;

            Locality.LocalityClass.GetLocalityListForSquad();
            LocalityComboBox.DataSource = Locality.LocalityClass.DTLocality;
            LocalityComboBox.DisplayMember = "id";
            LocalityComboBox.ValueMember = "id";
            LocalityComboBox.Text = Squad.SquadLocality;

            DepartureDateTimePicker.Text = Squad.SquadDepartureDate;
            ReturnDateTimePicker.Text = Squad.SquadReturnDate;
            ActualReturnDateTimePicker.Text = Squad.SquadReturnDate;
        }

        private void EditSquad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditSquad_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
