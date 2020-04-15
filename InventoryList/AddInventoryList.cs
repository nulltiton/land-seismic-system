using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandSeismic.InventoryList
{
    public partial class AddInventoryList : Form
    {
        public AddInventoryList()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddInventoryList_Load(object sender, EventArgs e)
        {
            Squad.SquadClass.GetSquadList();
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
    }
}
