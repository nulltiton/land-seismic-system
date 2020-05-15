using System;
using System.Windows.Forms;

namespace LandSeismic.SeismicExplorationType
{
    public partial class SeismicExplorationType : Form
    {
        static public String SeismicExplorationTypeId;
        static public String SeismicExplorationTypeName;

        public SeismicExplorationType()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SeismicExplorationType_Load(object sender, EventArgs e)
        {
            SeismicExplorationTypeClass.GetSeismicExplorationTypeList();
            SeismicExplorationTypeGrid.DataSource =
                SeismicExplorationTypeClass.DTSeismicExplorationType;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addSeismicExmplorationType =
                new AddSeismicExmplorationType();
            addSeismicExmplorationType.Show();
        }

        private void SeismicExplorationTypeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SeismicExplorationTypeId = SeismicExplorationTypeGrid.
                    CurrentRow.Cells[2].Value.ToString();
                SeismicExplorationTypeName = SeismicExplorationTypeGrid.
                    CurrentRow.Cells[3].Value.ToString();
                var editSeismicExplorationType =
                    new EditSeismicExplorationType();
                editSeismicExplorationType.Show();

            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (SeismicExplorationTypeClass.DropSeismicExplorationType(
                        SeismicExplorationTypeGrid.CurrentRow.Cells[2].Value.
                        ToString()))
                        SeismicExplorationTypeClass.
                            GetSeismicExplorationTypeList();
            }
        }

        private void SeismicExplorationType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void SeismicExplorationType_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Table = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
