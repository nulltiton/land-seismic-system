using System;
using System.Windows.Forms;

namespace LandSeismic.SquadMember
{
    public partial class AddSquadMember : Form
    {
        public AddSquadMember()
        {
            InitializeComponent();
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
    }
}
