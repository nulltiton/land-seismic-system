using System;
using System.Windows.Forms;

namespace LandSeismic.PositionStandart
{
    public partial class PositionStandart : Form
    {
        static public String PrimordialPositionId;
        static public String PrimordialPositionName;
        static public String PrimordialResourceId;
        static public String PrimordialResourceName;
        static public String PrimordialAmount;

        public PositionStandart()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PositionStandart_Load(object sender, EventArgs e)
        {
            PositionStandartClass.GetPositionStandartList();
            PositionStandartGrid.DataSource = PositionStandartClass.
                DTPositionStandart;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addPositionStandart = new AddPositionStandart();
            addPositionStandart.Show();
        }

        private void PositionStandartGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                PrimordialPositionId = PositionStandartGrid.CurrentRow.Cells[2].
                    Value.ToString();
                PrimordialPositionName = PositionStandartGrid.CurrentRow.Cells[3].
                    Value.ToString();
                PrimordialResourceId = PositionStandartGrid.CurrentRow.Cells[4].
                    Value.ToString();
                PrimordialResourceName = PositionStandartGrid.CurrentRow.
                    Cells[5].Value.ToString();
                PrimordialAmount = PositionStandartGrid.CurrentRow.Cells[6].Value.
                    ToString();
                var editPositionStandart = new EditPositionStandart();
                editPositionStandart.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (PositionStandartClass.DropPositionStandart(
                        PositionStandartGrid.CurrentRow.Cells[2].Value.ToString(), 
                        PositionStandartGrid.CurrentRow.Cells[4].Value.ToString()))
                        PositionStandartClass.GetPositionStandartList();
            }
        }

        private void PositionStandart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void PositionStandart_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Table = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
