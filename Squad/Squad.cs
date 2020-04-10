using System;
using System.Windows.Forms;

namespace LandSeismic.Squad
{
    public partial class Squad : Form
    {
        static public String SquadId;
        static public String SquadSquadLeader;
        static public String SquadLocality;
        static public String SquadDepartureDate;
        static public String SquadReturnDate;
        static public String SquadActualReturnDate;

        static public String GroupId;
        static public String GroupSquadId;
        static public String GroupType;

        public Squad()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Squad_Load(object sender, EventArgs e)
        {
            SquadClass.GetSquadList();
            SquadGrid.DataSource = SquadClass.DTSquad;

            GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].Value.
                ToString());
            GroupGrid.DataSource = GroupClass.DTGroup;
        }

        private void SquadGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SquadId = SquadGrid.CurrentRow.Cells[2].Value.ToString();
                SquadSquadLeader = SquadGrid.CurrentRow.Cells[3].Value.ToString();
                SquadLocality = SquadGrid.CurrentRow.Cells[5].Value.ToString();
                SquadDepartureDate = SquadGrid.CurrentRow.Cells[6].Value.ToString();
                SquadReturnDate = SquadGrid.CurrentRow.Cells[7].Value.ToString();
                SquadActualReturnDate = SquadGrid.CurrentRow.Cells[8].Value.ToString();
                var editSquad = new EditSquad();
                editSquad.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (SquadClass.DropSquad(
                        SquadGrid.CurrentRow.Cells[2].Value.ToString()))
                        SquadClass.GetSquadList();
            }
            else
            {
                GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].Value.
                    ToString());
                GroupGrid.DataSource = GroupClass.DTGroup;
            }
            GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].Value.
                ToString());
            GroupGrid.DataSource = GroupClass.DTGroup;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addSquad = new AddSquad();
            addSquad.Show();
        }

        private void GroupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

            }
            else if (e.ColumnIndex == 1)
            {
                GroupId = GroupGrid.CurrentRow.Cells[3].Value.ToString();
                GroupSquadId = SquadGrid.CurrentRow.Cells[2].Value.ToString();
                GroupType = GroupGrid.CurrentRow.Cells[6].Value.ToString();
                var editGroup = new EditGroup();
                editGroup.Show();
            }
            else if (e.ColumnIndex == 2)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (GroupClass.DropGroup(
                        GroupGrid.CurrentRow.Cells[3].Value.ToString()))
                        GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].
                            Value.ToString());
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            GroupSquadId = SquadGrid.CurrentRow.Cells[2].Value.ToString();
            var addGroup = new AddGroup();
            addGroup.Show();
        }
    }
}
