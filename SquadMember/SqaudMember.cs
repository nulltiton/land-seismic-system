using System;
using System.Windows.Forms;

namespace LandSeismic.SquadMember
{
    public partial class SqaudMember : Form
    {
        static public String SquadMemberId;
        static public String SquadMemberName;

        public SqaudMember()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SqaudMember_Load(object sender, EventArgs e)
        {
            SquadMemberClass.GetSquadMemberList(Squad.Squad.GroupId);
            SquadMemberGrid.DataSource = SquadMemberClass.DTSquadMember;
        }

        private void SquadMemberGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SquadMemberId = SquadMemberGrid.CurrentRow.Cells[2].Value.
                    ToString();
                SquadMemberName = SquadMemberGrid.CurrentRow.Cells[5].Value.
                    ToString();
                var editSquadMember = new EditSquadMember();
                editSquadMember.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (SquadMemberClass.DropSquadMember(SquadMemberGrid.
                        CurrentRow.Cells[2].Value.ToString()))
                        SquadMemberClass.GetSquadMemberList(Squad.Squad.
                            GroupId);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addSquadMember = new AddSquadMember();
            addSquadMember.Show();
        }

        private void SqaudMember_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void SqaudMember_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Table = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
