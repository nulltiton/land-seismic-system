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
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            InventoryListClass.GetInventoryList();
            InventoryListGrid.DataSource = InventoryListClass.DTInventoryList;
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
                        InventoryListClass.GetInventoryList();
            }
        }
    }
}
