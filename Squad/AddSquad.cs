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
    public partial class AddSquad : Form
    {
        public AddSquad()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSquad_Load(object sender, EventArgs e)
        {
            User.UserClass.GetSquadLeaderList();
            SquadLeaderComboBox.DataSource = User.UserClass.DTSquadLeader;
            SquadLeaderComboBox.DisplayMember = "name";
            SquadLeaderComboBox.ValueMember = "login";

            Locality.LocalityClass.GetLocalityList();
            LocalityComboBox.DataSource = Locality.LocalityClass.DTLocality;
            LocalityComboBox.DisplayMember = "id";
            LocalityComboBox.ValueMember = "id";
        }

        private void ActualReturnDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActualReturnDateCheckBox.Checked)
                ActualReturnDateTimePicker.Enabled = true;
            else
                ActualReturnDateTimePicker.Enabled = false;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String actualReturnDate;
            if (!ActualReturnDateCheckBox.Checked)
                actualReturnDate = null;
            else
                actualReturnDate = ActualReturnDateTimePicker.Text;
            if (SquadClass.AddSquad(SquadLeaderComboBox.SelectedValue.
                ToString(), LocalityComboBox.SelectedValue.ToString(),
                DepartureDateTimePicker.Text, ReturnDateTimePicker.Text,
                actualReturnDate))
            {
                SquadClass.GetSquadList();
                Close();
            }
        }
    }
}
