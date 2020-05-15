using System;
using System.Windows.Forms;

namespace LandSeismic.Help
{
    public partial class AuthorizationHelp : Form
    {
        static public Boolean Table;
        static public Boolean MainMenu;
        static public Boolean Add;
        static public Boolean Edit;
        static public Boolean Filter;
        static public Boolean Document;
        static public Boolean List;
        static public Boolean NoPicButton;

        public AuthorizationHelp()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AuthorizationHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                Close();
        }

        private void AuthorizationHelp_Shown(object sender, EventArgs e)
        {
            if (Table)
            {
                HelpTextBox.Text = "Чтобы добавить новую информацию следует " +
                    "нажать на иконку с плюсом. Чтобы редактировать " +
                    "информацию следует нажать на кнопку 'Редактировать'. " +
                    "Чтобы удалить информацию следует нажать на кнопку " +
                    "'Удалить', затем подтвердить решение во всплывшем окне. ";
                Table = false;
            }
            else if (MainMenu)
            {
                HelpTextBox.Text = "Чтобы открыть нужное вам окно выберите " +
                    "его название в меню сбоку. Чтобы закрыть главное меню " +
                    "следует нажать на кнопку выключения. ";
                MainMenu = false;
            }
            else if (Add)
            {
                HelpTextBox.Text = "Чтобы добавить информацию следует " +
                    "заполнить все поля и нажать на иконку с галочкой. " +
                    "Чтобы покинуть форму следует нажать на иконку с дверью " +
                    "или нажать кнопку 'Esc'. ";
                Add = false;
            }
            else if (Edit)
            {
                HelpTextBox.Text = "Чтобы редактировать информацию следует " +
                    "изменить все нужные поля и нажать на иконку с галочкой." +
                    " Чтобы покинуть форму следует нажать на иконку с дверью" +
                    " или нажать кнопку 'Esc'. ";
                Edit = false;
            }
            else if (NoPicButton)
            {
                HelpTextBox.Text = "Чтобы добавить новую информацию следует " +
                    "нажать на кнопку 'Добавить'. Чтобы редактировать " +
                    "информацию следует нажать на кнопку 'Редактировать'. " +
                    "Чтобы удалить информацию следует нажать на кнопку " +
                    "'Удалить', затем подтвердить решение во всплывшем окне. ";
                NoPicButton = false;
            }
            else { }

            if (Filter)
            {
                HelpTextBox.Text += "Чтобы произвести фильтрацию следует " +
                    "выбрать критерий фильтрации и нажать на кнопку " +
                    "'Фильтровать'. Чтобы отменить фильтрацию следует " +
                    "нажать на кнопку 'Отмена'. ";
                Filter = false;
            }

            if (Document)
            {
                HelpTextBox.Text += "Чтобы сохранить документ следует " +
                    "нажать на кнопку 'Служебное задание', а затем выбрать " +
                    "куда вы хотите его сохранить.";
                Document = false;
            }
            else if (List)
            {
                HelpTextBox.Text += "Чтобы сохранить перечень следует " +
                    "нажать на иконку с документом, а затем выбрать " +
                    "куда вы хотите его сохранить.";
                List = false;
            }
            else { }
        }
    }
}
