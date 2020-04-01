using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text;

namespace LandSeismic.MainMenu
{
    public partial class MainMenu : Form
    {
        static public String Log;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            User.User user = new User.User();
            user.Show();
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Employee.Employee employee = new Employee.Employee();
            employee.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Size.Height / 2,
                Screen.PrimaryScreen.Bounds.Size.Width / 8);
            Size = new Size(567, 435);

            if (Authorization.AuthorizationClass.Position == "Ведущий геолог")
            {
                InventoryListButton.Visible = false;
                LocalityButton.Visible = false;
                LocalityTypeButton.Visible = false;
                MaterialAndTechnicalResourceButton.Visible = false;
                SquadButton.Visible = false;
                GroupButton.Visible = false;
                GroupTypeButton.Visible = false;
                Log = "Ведущий геолог " + User.UserClass.GetUserFullName(
                    Authorization.AuthorizationClass.Login) + ", дата входа: " 
                    + DateTime.Now.ToShortDateString() + ", время входа: " +
                    DateTime.Now.ToShortTimeString();
            }
            else if (Authorization.AuthorizationClass.Position == "Геолог")
            {
                UserButton.Visible = false;
                EmployeeButton.Visible = false;
                PositionStandartButton.Visible = false;
                LocalityStandartButton.Visible = false;
                PositionButton.Visible = false;
                SeismicExplorationTypeButton.Visible = false;
                SquadButton.Visible = false;
                GroupButton.Visible = false;
                GroupTypeButton.Visible = false;
                InventoryListButton.Location = new Point(0, 0);
                LocalityButton.Location = new Point(0, 65);
                LocalityTypeButton.Location = new Point(0, 130);
                MaterialAndTechnicalResourceButton.Location = new Point(0,195);
                Log = "Геолог " + User.UserClass.GetUserFullName(
                    Authorization.AuthorizationClass.Login) + ", дата входа: "
                    + DateTime.Now.ToShortDateString() + ", время входа: " +
                    DateTime.Now.ToShortTimeString();
            }
            else if (Authorization.AuthorizationClass.Position == 
                "Начальник сейсмотряда")
            {
                UserButton.Visible = false;
                EmployeeButton.Visible = false;
                PositionStandartButton.Visible = false;
                LocalityStandartButton.Visible = false;
                PositionButton.Visible = false;
                SeismicExplorationTypeButton.Visible = false;
                InventoryListButton.Visible = false;
                LocalityButton.Visible = false;
                LocalityTypeButton.Visible = false;
                MaterialAndTechnicalResourceButton.Visible = false;
                SquadButton.Location = new Point(0, 0);
                GroupButton.Location = new Point(0, 65);
                GroupTypeButton.Location = new Point(0, 130);
                Log = "Начальник сейсмотряда " + User.UserClass.
                    GetUserFullName(Authorization.AuthorizationClass.Login) + 
                    ", дата входа: " + DateTime.Now.ToShortDateString() + 
                    ", время входа: " + DateTime.Now.ToShortTimeString();
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log += ", время выхода: " + DateTime.Now.ToShortTimeString();
            FileStream fileStream = new FileStream("Log.txt", FileMode.Append,
                FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.
                UTF8);
            streamWriter.WriteLine(Log);
            streamWriter.Close();
        }

        private void PositionButton_Click(object sender, EventArgs e)
        {
            Position.Position position = new Position.Position();
            position.Show();
        }

        private void SeismicExplorationTypeButton_Click(object sender, EventArgs e)
        {
            SeismicExplorationType.SeismicExplorationType
                seismicExplorationType = new SeismicExplorationType.
                SeismicExplorationType();
            seismicExplorationType.Show();
        }

        private void MaterialAndTechnicalResourceButton_Click(object sender, EventArgs e)
        {
            MaterialAndTechnicalResource.MaterialAndTechnicalResource
                materialAndTechnicalResource = 
                new MaterialAndTechnicalResource.MaterialAndTechnicalResource();
            materialAndTechnicalResource.Show();
        }

        private void LocalityTypeButton_Click(object sender, EventArgs e)
        {
            LocalityType.LocalityType localityType =
                new LocalityType.LocalityType();
            localityType.Show();
        }
    }
}
