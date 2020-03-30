using System;
using System.Windows.Forms;

namespace LandSeismic.User
{
    public partial class User : Form
    {
        static public String login;
        static public String password;
        static public String surname;
        static public String firstName;
        static public String middleName;
        static public String phone;
        static public String address;
        static public String position;

        public User()
        {
            InitializeComponent();
        }

        private void backwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backwardsBbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            UserClass.GetUserList();
            userGrid.DataSource = UserClass.dtLeadGeologist;
        }

        private void userGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                login = userGrid.CurrentRow.Cells[2].Value.ToString();
                password = userGrid.CurrentRow.Cells[3].Value.ToString();
                surname = userGrid.CurrentRow.Cells[4].Value.ToString();
                firstName = userGrid.CurrentRow.Cells[5].Value.ToString();
                middleName = userGrid.CurrentRow.Cells[6].Value.ToString();
                phone = userGrid.CurrentRow.Cells[7].Value.ToString();
                address = userGrid.CurrentRow.Cells[8].Value.ToString();
                position = userGrid.CurrentRow.Cells[9].Value.ToString();
                EditUser editUser = new EditUser();
                editUser.Show();
            }

            if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (UserClass.DropUser(userGrid.
                        CurrentRow.Cells[2].Value.ToString()))
                        UserClass.GetUserList();
            }
        }
    }
}
