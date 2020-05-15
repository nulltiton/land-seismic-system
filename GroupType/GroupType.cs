using System;
using System.Windows.Forms;

namespace LandSeismic.GroupType
{
    public partial class GroupType : Form
    {
        static public String GroupTypeId;
        static public String GroupTypeName;

        public GroupType()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GroupType_Load(object sender, EventArgs e)
        {
            GroupTypeClass.GetGroupTypeList();
            GroupTypeGrid.DataSource = GroupTypeClass.DTGroupType;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addGroupType = new AddGroupType();
            addGroupType.Show();
        }

        private void GroupTypeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                GroupTypeId = GroupTypeGrid.CurrentRow.Cells[2].Value.
                    ToString();
                GroupTypeName = GroupTypeGrid.CurrentRow.Cells[3].Value.
                    ToString();
                var editGroupType = new EditGroupType();
                editGroupType.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (GroupTypeClass.DropGroupType(
                        GroupTypeGrid.CurrentRow.Cells[2].Value.ToString()))
                        GroupTypeClass.GetGroupTypeList();
            }
        }

        private void GroupType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void GroupType_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Table = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
