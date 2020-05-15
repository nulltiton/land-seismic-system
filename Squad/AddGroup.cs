using System;
using System.Windows.Forms;

namespace LandSeismic.Squad
{
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
            KeyPreview = true;
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

        private void AddGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddGroup_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
