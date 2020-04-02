using System;
using System.Windows.Forms;

namespace LandSeismic.User
{
    public partial class User : Form
    {
        static public String Login;
        static public String Password;
        static public String Surname;
        static public String FirstName;
        static public String MiddleName;
        static public String Phone;
        static public String Address;
        static public String Position;

        public User()
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
            var addUser = new AddUser();
            addUser.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {
            UserClass.GetUserList();
            UserGrid.DataSource = UserClass.DTUser;
        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Login = UserGrid.CurrentRow.Cells[2].Value.ToString();
                Password = UserGrid.CurrentRow.Cells[3].Value.ToString();
                Surname = UserGrid.CurrentRow.Cells[4].Value.ToString();
                FirstName = UserGrid.CurrentRow.Cells[5].Value.ToString();
                MiddleName = UserGrid.CurrentRow.Cells[6].Value.ToString();
                Phone = UserGrid.CurrentRow.Cells[7].Value.ToString();
                Address = UserGrid.CurrentRow.Cells[8].Value.ToString();
                Position = UserGrid.CurrentRow.Cells[9].Value.ToString();
                var editUser = new EditUser();
                editUser.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    if (UserClass.DropUser(UserGrid.
                        CurrentRow.Cells[2].Value.ToString()))
                        UserClass.GetUserList();
            }
        }
    }
}
