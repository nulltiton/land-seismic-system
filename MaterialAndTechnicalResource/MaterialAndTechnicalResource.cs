using System;
using System.Windows.Forms;

namespace LandSeismic.MaterialAndTechnicalResource
{
    public partial class MaterialAndTechnicalResource : Form
    {
        static public String MaterialAndTechnicalResourceId;
        static public String MaterialAndTechnicalResourceName;
        static public Boolean MaterialAndTechnicalResourceIsConsumable;

        public MaterialAndTechnicalResource()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaterialAndTechnicalResource_Load(object sender, EventArgs e)
        {
            MaterialAndTechnicalResourceClass.
                GetMaterialAndTechnicalResourceList();
            MaterialAndTechnicalResourceGrid.DataSource = 
                MaterialAndTechnicalResourceClass.
                DTMaterialAndTechnicalResource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var materialAndTechnicalResource =
                new AddMaterialAndTechnicalResource();
            materialAndTechnicalResource.Show();
        }

        private void MaterialAndTechnicalResourceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MaterialAndTechnicalResourceId =
                    MaterialAndTechnicalResourceGrid.CurrentRow.Cells[2].Value.
                    ToString();
                MaterialAndTechnicalResourceName =
                    MaterialAndTechnicalResourceGrid.CurrentRow.Cells[3].Value.
                    ToString();
                MaterialAndTechnicalResourceIsConsumable =
                    Convert.ToBoolean(MaterialAndTechnicalResourceGrid.CurrentRow.Cells[4].Value);
                var editMaterialAndTechnicalResource =
                    new EditMaterialAndTechnicalResource();
                editMaterialAndTechnicalResource.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (MaterialAndTechnicalResourceClass.
                        DropMaterialAndTechnicalResource(
                        MaterialAndTechnicalResourceGrid.CurrentRow.Cells[2].
                        Value.ToString()))
                        MaterialAndTechnicalResourceClass.
                            GetMaterialAndTechnicalResourceList();
            }
        }
    }
}
