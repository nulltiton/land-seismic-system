using System;
using System.Windows.Forms;

namespace LandSeismic.SquadMember
{
    public partial class EditSquadMember : Form
    {
        public EditSquadMember()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditSquadMember_Load(object sender, EventArgs e)
        {
            Employee.EmployeeClass.GetEmployeeFullName();
            NameComboBox.DataSource = Employee.EmployeeClass.DTEmployee;
            NameComboBox.DisplayMember = "fullname";
            NameComboBox.ValueMember = "id";
            NameComboBox.Text = SqaudMember.SquadMemberName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Boolean modified = NameComboBox.Text != SqaudMember.SquadMemberName ?
                true : false;
            if (SquadMemberClass.EditSquadMember(SqaudMember.SquadMemberId, 
                Squad.Squad.GroupId, NameComboBox.SelectedValue.ToString(),
                modified))
            {
                SquadMemberClass.GetSquadMemberList(Squad.Squad.GroupId);
                Close();
            }
        }

        private void EditSquadMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditSquadMember_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
