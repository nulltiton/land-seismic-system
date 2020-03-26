using System;
using MySql.Data.MySqlClient;

namespace LandSeismic.DBConnection
{
    class DBConnection
    {
        static public String connectionString = "DataBase = landseismic; " +
            "DataSource = localhost; UserId = root; Password = root; " +
            "Charset = utf8";
        static public MySqlDataAdapter sqlDataAdapter;
        static public MySqlConnection sqlConnection;
        static public MySqlCommand sqlCommand;

        static public Boolean Connect(String connectionString)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);
                sqlConnection.Open();
                sqlCommand = new MySqlCommand();
                sqlCommand.Connection = sqlConnection;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Не удалось подключиться к базе данных. " + ex.Message,
                    "Ошибка подключения", System.Windows.Forms.
                    MessageBoxButtons.OK, System.Windows.Forms.
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
