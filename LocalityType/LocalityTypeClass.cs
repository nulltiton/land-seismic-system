using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.LocalityType
{
    /// <summary>
    /// Класс типа местности
    /// </summary>
    class LocalityTypeClass
    {
        static public DataTable DTLocalityType = new DataTable();
        
        /// <summary>
        /// Заполнить таблицу информацией о типах местности
        /// </summary>
        static public void GetLocalityTypeList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `LocalityType` " +
                "ORDER BY `name`";
            DTLocalityType.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTLocalityType);
        }

        /// <summary>
        /// Добавление информации о типах местности
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean AddLocalityType(String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO `LocalityType` " +
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
                    "Ошибка при добавлении типа местности",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о типах местности
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean EditLocalityType(String id, String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `LocalityType` " +
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
                  "Ошибка при изменении типа местности",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о типах местности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropLocalityType(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `LocalityType` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Невозможно удалить тип местности, так как он используется",
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                                return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении типа местности",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
