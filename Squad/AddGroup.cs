using System;
using System.Windows.Forms;

namespace LandSeismic.Squad
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            GroupType.GroupTypeClass.GetGroupTypeList();
            GroupTypeComboBox.DataSource = GroupType.GroupTypeClass.
                DTGroupType;
            GroupTypeComboBox.DisplayMember = "name";
            GroupTypeComboBox.ValueMember = "id";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (GroupClass.AddGroup(Squad.GroupSquadId, GroupTypeComboBox.
                SelectedValue.ToString()))
            {
                GroupClass.GetGroupList(Squad.GroupSquadId);
                Close();
            }
        }
    }
}
