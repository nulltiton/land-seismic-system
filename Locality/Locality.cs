using System;
using System.Windows.Forms;

namespace LandSeismic.Locality
{
    public partial class Locality : Form
    {
        static public String LocalityId;
        static public String LocalityIdLocalityType;
        static public String LocalityIdSeismicExplorationType;
        static public String LocalitySize;
        static public String LocalityLatitude;
        static public String LocalityLongitude;
        static public String LocalityLoginGeologist;
        static public String LocalityLoginLeadGeologist;
        static public String LocalityLoginSquadLeader;
        static public String LocalityUsability;

        public Locality()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Locality_Load(object sender, EventArgs e)
        {
            LocalityClass.GetLocalityList();
            LocalityGrid.DataSource = LocalityClass.DTLocality;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addLocality = new AddLocality();
            addLocality.Show();
        }

        private void LocalityGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                LocalityId = LocalityGrid.CurrentRow.Cells[2].Value.ToString();
                LocalityIdLocalityType = LocalityGrid.CurrentRow.Cells[4].
                    Value.ToString();
                LocalityIdSeismicExplorationType = LocalityGrid.CurrentRow.
                    Cells[6].Value.ToString();
                LocalitySize = LocalityGrid.CurrentRow.Cells[7].Value.
                    ToString();
                LocalityLatitude = LocalityGrid.CurrentRow.Cells[8].Value.
                    ToString();
                LocalityLongitude = LocalityGrid.CurrentRow.Cells[9].Value.
                    ToString();
                LocalityLoginGeologist = LocalityGrid.CurrentRow.Cells[11].
                    Value.ToString();
                LocalityLoginLeadGeologist = LocalityGrid.CurrentRow.Cells[13].
                    Value.ToString();
                LocalityLoginSquadLeader = LocalityGrid.CurrentRow.Cells[15].
                    Value.ToString();
                LocalityUsability = LocalityGrid.CurrentRow.Cells[16].Value.
                    ToString();
                var editLocality = new EditLocality();
                editLocality.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (LocalityClass.DropLocality(LocalityGrid.
                        CurrentRow.Cells[2].Value.ToString()))
                        LocalityClass.GetLocalityList();
            }
        }
    }
}
