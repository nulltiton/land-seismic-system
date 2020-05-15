using System;
using System.Windows.Forms;

namespace LandSeismic.InventoryList
{
    public partial class InventoryList : Form
    {
        static public String InventoryListId;
        static public String InventoryListGeologist;

        public InventoryList()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            InventoryListClass.GetInventoryList(Authorization.
                AuthorizationClass.Login);
            InventoryListGrid.DataSource = InventoryListClass.DTInventoryList;
            if (InventoryListGrid.Rows.Count != 0)
            {
                InventoryListClass.GetResourceInList(InventoryListGrid.CurrentRow.
                    Cells[2].Value.ToString());
                ResourceGrid.DataSource = InventoryListClass.DTResourceInListList;
            }

        }

        private void InventoryListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                InventoryListId = InventoryListGrid.CurrentRow.Cells[2].
                    Value.ToString();
                InventoryListGeologist = InventoryListGrid.CurrentRow.
                    Cells[4].Value.ToString();
                var editInventoryList = new EditInventoryList();
                editInventoryList.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (InventoryListClass.DropInventoryList(
                        InventoryListGrid.CurrentRow.Cells[2].Value.
                        ToString()))
                        InventoryListClass.GetInventoryList(Authorization.
                            AuthorizationClass.Login);
            }
            else
                InventoryListClass.GetResourceInList(InventoryListGrid.
                    CurrentRow.Cells[2].Value.ToString());
        }

        private void AddInventoryListButton_Click(object sender, EventArgs e)
        {
            var addInventoryList = new AddInventoryList();
            addInventoryList.Show();
        }

        private void DocumentButton_Click(object sender, EventArgs e)
        {

            InventoryListSaveDialog.Filter = "Excel | *.csv";
            if (InventoryListSaveDialog.ShowDialog() == DialogResult.OK)
            {
                InventoryListClass.DocumentInventoryList(InventoryListGrid.
                    CurrentRow.Cells[2].Value.ToString(), InventoryListGrid.
                    CurrentRow.Cells[3].Value.ToString(), InventoryListClass.
                    DepartureDateBySquad(InventoryListGrid.CurrentRow.
                    Cells[3].Value.ToString()), InventoryListClass.
                    ReturnDateBySquad(InventoryListGrid.CurrentRow.Cells[3].
                    Value.ToString()), InventoryListSaveDialog.FileName);
            }
        }

        private void InventoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void InventoryList_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Table = true;
            Help.AuthorizationHelp.List = true;
            Help.AuthorizationHelp.Filter = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
