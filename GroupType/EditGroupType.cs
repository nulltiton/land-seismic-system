using System;
using System.Windows.Forms;

namespace LandSeismic.GroupType
{
    public partial class EditGroupType : Form
    {
        public EditGroupType()
        {
            InitializeComponent();
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != String.Empty)
            {
                if (GroupTypeClass.EditGroupType(GroupType.GroupTypeId, 
                    NameTextBox.Text))
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

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.ValidationClass.IsRussianSymbols(sender, e);
        }

        private void EditGroupType_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = GroupType.GroupTypeName;
        }
    }
}
