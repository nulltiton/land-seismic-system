using System;
using MySql.Data.MySqlClient;

namespace LandSeismic.DBConnection
{

    /// <summary>
    /// Класс работы с базой данных
    /// </summary>
    class DBConnection
    {
        static public String connectionString = "DataBase = landseismic; " +
            "DataSource = localhost; UserId = root; Password = root; " +
            "Charset = utf8";
        static public MySqlDataAdapter sqlDataAdapter;
        static public MySqlConnection sqlConnection;
        static public MySqlCommand sqlCommand;

        /// <summary>
        /// Подключение к базе данных
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
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
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Не удалось подключиться к базе данных",
                    "Ошибка подключения", System.Windows.Forms.
                    MessageBoxButtons.OK, System.Windows.Forms.
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
