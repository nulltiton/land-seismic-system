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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void leadGeologistButton_Click(object sender, EventArgs e)
        {
            User.User leadGeologist = 
                new User.User();
            leadGeologist.Show();
        }

        private void formBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Capture = false;
            //Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            //WndProc(ref m);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
