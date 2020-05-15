using System;
using System.Windows.Forms;

namespace LandSeismic.Position
{
    public partial class EditPosition : Form
    {
        public EditPosition()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbols(sender, e);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != String.Empty)
            {
                if (PositionClass.EditPosition(Position.PositionId,
                    NameTextBox.Text))
                {
                    PositionClass.GetPositionList();
                    Close();
                }
            }

            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                    "Ошибка корректности ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void EditPosition_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = Position.PositionName;
        }

        private void EditPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void EditPosition_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.AuthorizationHelp.Edit = true;
            var authorizationHelp = new Help.AuthorizationHelp();
            authorizationHelp.ShowDialog();
        }
    }
}
