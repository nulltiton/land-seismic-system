using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandSeismic.Squad
{
    public partial class EditSquad : Form
    {
        public EditSquad()
        {
            InitializeComponent();
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

            Locality.LocalityClass.GetLocalityList();
            LocalityComboBox.DataSource = Locality.LocalityClass.DTLocality;
            LocalityComboBox.DisplayMember = "id";
            LocalityComboBox.ValueMember = "id";
            LocalityComboBox.Text = Squad.SquadLocality;

            DepartureDateTimePicker.Text = Squad.SquadDepartureDate;
            ReturnDateTimePicker.Text = Squad.SquadReturnDate;
            ActualReturnDateTimePicker.Text = Squad.SquadReturnDate;
        }
    }
}
