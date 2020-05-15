using System;
using System.Windows.Forms;

namespace LandSeismic.SquadMember
{
    public partial class AddSquadMember : Form
    {
        public AddSquadMember()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSquadMember_Load(object sender, EventArgs e)
        {
            Employee.EmployeeClass.GetEmployeeFullName();
            NameComboBox.DataSource = Employee.EmployeeClass.DTEmployee;
            NameComboBox.DisplayMember = "fullname";
            NameComboBox.ValueMember = "id";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SquadMemberClass.AddSquadMember(Squad.Squad.GroupId,
                NameComboBox.SelectedValue.ToString()))
            {
                SquadMemberClass.GetSquadMemberList(Squad.Squad.GroupId);
                Close();
            }
        }

        private void AddSquadMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddSquadMember_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
