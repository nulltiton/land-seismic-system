using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace LandSeismic.Squad
{
    public partial class Squad : Form
    {
        static public String SquadId;
        static public String SquadSquadLeader;
        static public String SquadLocality;
        static public String SquadDepartureDate;
        static public String SquadReturnDate;
        static public String SquadActualReturnDate;

        static public String GroupId;
        static public String GroupSquadId;
        static public String GroupType;

        public Squad()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Squad_Load(object sender, EventArgs e)
        {
            SquadClass.GetSquadList();
            SquadGrid.DataSource = SquadClass.DTSquad;

            GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].Value.
                ToString());
            GroupGrid.DataSource = GroupClass.DTGroup;
        }

        private void SquadGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SquadId = SquadGrid.CurrentRow.Cells[2].Value.ToString();
                SquadSquadLeader = SquadGrid.CurrentRow.Cells[3].Value.ToString();
                SquadLocality = SquadGrid.CurrentRow.Cells[5].Value.ToString();
                SquadDepartureDate = SquadGrid.CurrentRow.Cells[6].Value.ToString();
                SquadReturnDate = SquadGrid.CurrentRow.Cells[7].Value.ToString();
                SquadActualReturnDate = SquadGrid.CurrentRow.Cells[8].Value.ToString();
                var editSquad = new EditSquad();
                editSquad.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (SquadClass.DropSquad(
                        SquadGrid.CurrentRow.Cells[2].Value.ToString()))
                        SquadClass.GetSquadList();
            }
            else
            {
                GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].Value.
                    ToString());
                GroupGrid.DataSource = GroupClass.DTGroup;
            }
            GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].Value.
                ToString());
            GroupGrid.DataSource = GroupClass.DTGroup;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addSquad = new AddSquad();
            addSquad.Show();
        }

        private void GroupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                GroupId = GroupGrid.CurrentRow.Cells[3].Value.ToString();
                var squadMember = new SquadMember.SqaudMember();
                squadMember.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                GroupId = GroupGrid.CurrentRow.Cells[3].Value.ToString();
                GroupSquadId = SquadGrid.CurrentRow.Cells[2].Value.ToString();
                GroupType = GroupGrid.CurrentRow.Cells[6].Value.ToString();
                var editGroup = new EditGroup();
                editGroup.Show();
            }
            else if (e.ColumnIndex == 2)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (GroupClass.DropGroup(
                        GroupGrid.CurrentRow.Cells[3].Value.ToString()))
                        GroupClass.GetGroupList(SquadGrid.CurrentRow.Cells[2].
                            Value.ToString());
            }
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            GroupSquadId = SquadGrid.CurrentRow.Cells[2].Value.ToString();
            var addGroup = new AddGroup();
            addGroup.Show();
        }

        private void CancellingFilterByDepartureDate_Click(object sender, EventArgs e)
        {
            SquadClass.GetSquadList();
            SquadGrid.DataSource = SquadClass.DTSquad;
        }

        private void FilterByDepartureDateButton_Click(object sender, EventArgs e)
        {
            SquadClass.FilterByDepartureDate(FilterByDepartureDateTimePicker.
                Text);
            SquadGrid.DataSource = SquadClass.DTSquad;
        }

        private void FilterByReturnDateButton_Click(object sender, EventArgs e)
        {
            SquadClass.FilterByReturnDate(FilterByReturnDateTimePicker.Text);
            SquadGrid.DataSource = SquadClass.DTSquad;
        }

        private void CancellingFilterByReturnDateButton_Click(object sender, EventArgs e)
        {
            SquadClass.GetSquadList();
            SquadGrid.DataSource = SquadClass.DTSquad;
        }

        private void FilterByActualReturnDateTimePicker_Click(object sender, EventArgs e)
        {
            SquadClass.FilterByActualReturnDate(FilterByActualReturnDateTimePicker.Text);
            SquadGrid.DataSource = SquadClass.DTSquad;
        }

        private void CancellingFilterByActualReturnDateTimePickerButton_Click(object sender, EventArgs e)
        {
            SquadClass.GetSquadList();
            SquadGrid.DataSource = SquadClass.DTSquad;
        }

        private void JobAssignmentButton_Click(object sender, EventArgs e)
        {
            JobAssignmentSaveDialog.Filter = "Word | *.docx";
            if (JobAssignmentSaveDialog.ShowDialog() == DialogResult.OK)
            {
                DateTime departureDate = Convert.ToDateTime(SquadGrid.
                    CurrentRow.Cells[6].Value.ToString());
                DateTime returnDate = Convert.ToDateTime(SquadGrid.CurrentRow.
                    Cells[7].Value.ToString());
                Int32 dateCount = returnDate.Day - departureDate.Day;
                var app = new Word.Application();
                app.Visible = false;
                String path = Environment.CurrentDirectory + 
                    @"\Templates\Служебное задание.docx";
                var doc = app.Documents.Open(path);
                doc.Activate();

                doc.Bookmarks["idDoc"].Range.Text = SquadGrid.CurrentRow.
                    Cells[2].Value.ToString();
                doc.Bookmarks["createDate"].Range.Text = DateTime.Now.ToShortDateString();
                doc.Bookmarks["seismicExploration"].Range.Text = "Сейсмотряд";
                doc.Bookmarks["position"].Range.Text = SquadClass.
                    GetPositionList(SquadGrid.CurrentRow.Cells[2].Value.
                    ToString());
                doc.Bookmarks["departureDate"].Range.Text = departureDate.
                    ToString("dd.MM.yyyy");
                doc.Bookmarks["returnDate"].Range.Text = returnDate.
                    ToString("dd.MM.yyyy");
                doc.Bookmarks["dateCount"].Range.Text = dateCount.ToString();
                doc.Bookmarks["organization"].Range.Text = "ОАО МАГЭ";

                doc.Saved = true;
                doc.SaveAs2(JobAssignmentSaveDialog.FileName);

                doc.Close();
            }
        }
    }
}
