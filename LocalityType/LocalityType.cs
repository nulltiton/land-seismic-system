using System;
using System.Windows.Forms;

namespace LandSeismic.LocalityType
{
    public partial class LocalityType : Form
    {
        static public String LocalityTypeId;
        static public String LocalityTypeName;

        public LocalityType()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LocalityType_Load(object sender, EventArgs e)
        {
            LocalityTypeClass.GetLocalityTypeList();
            LocalityTypeGrid.DataSource = LocalityTypeClass.DTLocalityType;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addLocalityType = new AddLocalityType();
            addLocalityType.Show();
        }

        private void LocalityTypeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                LocalityTypeId = LocalityTypeGrid.CurrentRow.Cells[2].Value.
                    ToString();
                LocalityTypeName = LocalityTypeGrid.CurrentRow.Cells[3].Value.
                    ToString();
                var editLocalityType = new EditLocalityType();
                editLocalityType.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (LocalityTypeClass.DropLocalityType(
                        LocalityTypeGrid.CurrentRow.Cells[2].Value.ToString()))
                        LocalityTypeClass.GetLocalityTypeList();
            }
        }

        private void LocalityType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void LocalityType_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Table = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
