using System;
using System.Windows.Forms;

namespace LandSeismic.MainMenu
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            User.User user = new User.User();
            user.Show();
        }

        private void FormBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Capture = false;
            //Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            //WndProc(ref m);
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
    }
}
