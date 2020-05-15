using System;
using System.Windows.Forms;

namespace LandSeismic.InventoryList
{
    public partial class AddInventoryList : Form
    {
        public AddInventoryList()
        {
            InitializeComponent();
            KeyPreview = false;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddInventoryList_Load(object sender, EventArgs e)
        {
            Squad.SquadClass.GetSquadListForInventoryList();
            SquadComboBox.DataSource = Squad.SquadClass.DTSquad;
            SquadComboBox.DisplayMember = "id";
            SquadComboBox.ValueMember = "id";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InventoryListClass.CreateInventoryList(SquadComboBox.Text, 
                Authorization.AuthorizationClass.Login))
            {
                InventoryListClass.GetInventoryList(Authorization.
                    AuthorizationClass.Login);
                InventoryListClass.GetResourceInList(InventoryList.
                    InventoryListId);
                Close();
            }
        }

        private void AddInventoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AddInventoryList_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Add = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
