using System;
using System.Windows.Forms;

namespace LandSeismic.Employee
{
    public partial class Employee : Form
    {
        static public String Id;
        static public String Surname;
        static public String FirstName;
        static public String MiddleName;
        static public String Phone;
        static public String Address;
        static public String ContactPhone;
        static public String Position;

        public Employee()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackwardsBbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LandSeismic.Position.PositionClass.GetPositionListForEmployee();
            FilterByPositionComboBox.DataSource = LandSeismic.Position.
                PositionClass.DTPosition;
            FilterByPositionComboBox.DisplayMember = "name";
            FilterByPositionComboBox.ValueMember = "id";
            EmployeeClass.GetEmployeeList();
            EmployeeGrid.DataSource = EmployeeClass.DTEmployee;
        }

        private void EmployeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Id = EmployeeGrid.CurrentRow.Cells[2].Value.ToString();
                Surname = EmployeeGrid.CurrentRow.Cells[3].Value.ToString();
                FirstName = EmployeeGrid.CurrentRow.Cells[4].Value.ToString();
                MiddleName = EmployeeGrid.CurrentRow.Cells[5].Value.ToString();
                Phone = EmployeeGrid.CurrentRow.Cells[6].Value.ToString();
                Address = EmployeeGrid.CurrentRow.Cells[7].Value.ToString();
                ContactPhone = EmployeeGrid.CurrentRow.Cells[8].Value.ToString();
                Position = EmployeeGrid.CurrentRow.Cells[9].Value.ToString();
                var editEmployee = new EditEmployee();
                editEmployee.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (EmployeeClass.DropEmployee(EmployeeGrid.
                        CurrentRow.Cells[2].Value.ToString()))
                        EmployeeClass.GetEmployeeList();
            }
        }

        private void FilterCancellationButton_Click(object sender, EventArgs e)
        {
            EmployeeClass.GetEmployeeList();
            EmployeeGrid.DataSource = EmployeeClass.DTEmployee;
        }

        private void FilterByPositionButton_Click(object sender, EventArgs e)
        {
            EmployeeClass.FilterByPosition(FilterByPositionComboBox.
                SelectedValue.ToString());
            EmployeeGrid.DataSource = EmployeeClass.DTFilteredEmployee;
        }
    }
}
