using System;
using System.Windows.Forms;

namespace LandSeismic.LocalityType
{
    public partial class EditLocalityType : Form
    {
        public EditLocalityType()
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
                if (LocalityTypeClass.EditLocalityType(
                    LocalityType.LocalityTypeId, NameTextBox.Text))
                {
                    LocalityTypeClass.
                        GetLocalityTypeList();
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

        private void EditLocalityType_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = LocalityType.LocalityTypeName;
        }
    }
}
