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
    public partial class EditInventoryList : Form
    {
        public EditInventoryList()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InventoryListClass.EditInventoryList(
                InventoryList.InventoryListId, UserComboBox.SelectedValue.
                ToString()))
            {
                InventoryListClass.GetInventoryList();
                Close();
            }
        }

        private void EditInventoryList_Load(object sender, EventArgs e)
        {
            User.UserClass.GetGeologistList();
            UserComboBox.DataSource = User.UserClass.DTGeologist;
            UserComboBox.DisplayMember = "name";
            UserComboBox.ValueMember = "login";
            UserComboBox.Text = InventoryList.InventoryListGeologist;
        }
    }
}
