using System;
using System.Windows.Forms;

namespace LandSeismic.GroupType
{
    public partial class AddGroupType : Form
    {
        public AddGroupType()
        {
            InitializeComponent();
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
                if (GroupTypeClass.AddGroupType(NameTextBox.Text))
                {
                    GroupTypeClass.GetGroupTypeList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                    "Ошибка корректности ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
    }
}
