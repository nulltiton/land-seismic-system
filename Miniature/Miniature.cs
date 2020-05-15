using System.Windows.Forms;
using System;

namespace LandSeismic.Miniature
{
    public partial class Miniature : Form
    {
        public Miniature()
        {
            InitializeComponent();
        }

        private void Miniature_Shown(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += delegate
            {
                Close();
            };
            timer.Start();
        }
    }
}
