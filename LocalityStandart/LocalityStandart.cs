using System;
using System.Windows.Forms;

namespace LandSeismic.LocalityStandart
{
    public partial class LocalityStandart : Form
    {
        static public String PrimordialLocalityId;
        static public String PrimordialLocalityName;
        static public String PrimordialResourceId;
        static public String PrimordialResourceName;
        static public String PrimordialAmount;

        public LocalityStandart()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LocalityStandartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                PrimordialLocalityId = LocalityStandartGrid.CurrentRow.Cells[2].
                    Value.ToString();
                PrimordialLocalityName = LocalityStandartGrid.CurrentRow.Cells[3].
                    Value.ToString();
                PrimordialResourceId = LocalityStandartGrid.CurrentRow.Cells[4].
                    Value.ToString();
                PrimordialResourceName = LocalityStandartGrid.CurrentRow.
                    Cells[5].Value.ToString();
                PrimordialAmount = LocalityStandartGrid.CurrentRow.Cells[6].Value.
                    ToString();
                var editLocalityStandart = new EditLocalityStandart();
                editLocalityStandart.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (LocalityStandartClass.DropLocalityStandart(
                        LocalityStandartGrid.CurrentRow.Cells[2].Value.ToString(),
                        LocalityStandartGrid.CurrentRow.Cells[4].Value.ToString()))
                        LocalityStandartClass.GetLocalityStandartList();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addLocalityStandart = new AddLocalityStandart();
            addLocalityStandart.Show();
        }

        private void LocalityStandart_Load(object sender, EventArgs e)
        {
            LocalityStandartClass.GetLocalityStandartList();
            LocalityStandartGrid.DataSource = LocalityStandartClass.
                DTLocalityStandart;
        }
    }
}
