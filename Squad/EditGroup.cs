using System;
using System.Windows.Forms;

namespace LandSeismic.Squad
{
    public partial class EditGroup : Form
    {
        public EditGroup()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditGroup_Load(object sender, EventArgs e)
        {
            GroupType.GroupTypeClass.GetGroupTypeList();
            GroupTypeComboBox.DataSource = GroupType.GroupTypeClass.
                DTGroupType;
            GroupTypeComboBox.DisplayMember = "name";
            GroupTypeComboBox.ValueMember = "id";
            GroupTypeComboBox.Text = Squad.GroupType;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Boolean modified = GroupTypeComboBox.Text != Squad.GroupType ?
                true : false;
            if (GroupClass.EditGroup(Squad.GroupId, Squad.GroupSquadId, 
                GroupTypeComboBox.SelectedValue.ToString(), modified))
            {
                GroupClass.GetGroupList(Squad.GroupSquadId);
                Close();
            }
        }

        private void EditGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditGroup_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
