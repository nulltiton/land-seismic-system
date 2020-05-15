using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.SeismicExplorationType
{
    /// <summary>
    /// Класс типа сейсморазведки
    /// </summary>
    class SeismicExplorationTypeClass
    {
        static public DataTable DTSeismicExplorationType = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о типах сейсморазведки
        /// </summary>
        static public void GetSeismicExplorationTypeList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `seismicExplorationType` " +
                "ORDER BY `name`";
            DTSeismicExplorationType.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSeismicExplorationType);
        }

        /// <summary>
        /// Добавление информации о типах сейсморазведки
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean AddSeismicExplorationType(String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO `seismicExplorationType` " +
                    "VALUES(NULL" +
                    ", '" + name + "')";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении типа сейсморазведки",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о типах сейсморазведки
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean EditSeismicExplorationType(String id, String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `seismicExplorationType` " +
                    "SET `name` = '" + name + "' " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении типа сейсморазведки",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о типах сейсморазведки
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropSeismicExplorationType(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `seismicExplorationType` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Невозможно удалить тип сейсморазведки, " +
                   "так как он используется. ",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении типа сейсморазведки",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
