using System;
using System.Windows.Forms;

namespace LandSeismic.Position
{
    public partial class Position : Form
    {
        static public String PositionId;
        static public String PositionName;

        public Position()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            PositionClass.GetPositionList();
            PositionGrid.DataSource = PositionClass.DTPosition;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addPosition = new AddPosition();
            addPosition.Show();
        }

        private void PositionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                PositionId = PositionGrid.CurrentRow.Cells[2].Value.ToString();
                PositionName = PositionGrid.CurrentRow.Cells[3].Value.
                    ToString();
                var editPosition = new EditPosition();
                editPosition.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (PositionClass.DropPosition(PositionGrid.
                        CurrentRow.Cells[2].Value.ToString()))
                        PositionClass.GetPositionList();
            }
        }
    }
}
