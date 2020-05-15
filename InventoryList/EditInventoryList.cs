using System;
using System.Windows.Forms;

namespace LandSeismic.InventoryList
{
    public partial class EditInventoryList : Form
    {
        public EditInventoryList()
        {
            InitializeComponent();
            KeyPreview = true;
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
                InventoryListClass.GetInventoryList(Authorization.
                    AuthorizationClass.Login);
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

        private void EditInventoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditInventoryList_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
