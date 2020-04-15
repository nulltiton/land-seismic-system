using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandSeismic.MaterialAndTechnicalResource
{
    public partial class EditMaterialAndTechnicalResource : Form
    {
        public EditMaterialAndTechnicalResource()
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
                if (MaterialAndTechnicalResourceClass.
                    EditMaterialAndTechnicalResource(
                    MaterialAndTechnicalResource.
                    MaterialAndTechnicalResourceId, NameTextBox.Text,
                    FoodCheckBox.Checked))
                {
                    MaterialAndTechnicalResourceClass.
                        GetMaterialAndTechnicalResourceList();
                    Close();
                }
            }
            else
                MessageBox.Show("Пожалуйста, заполните все поля",
                    "Ошибка корректности ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void EditMaterialAndTechnicalResource_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceName;
            FoodCheckBox.Checked = MaterialAndTechnicalResource.
                MaterialAndTechnicalResourceIsConsumable;
        }
    }
}
