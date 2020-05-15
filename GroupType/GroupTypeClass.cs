using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.GroupType
{
    /// <summary>
    /// Класс типа группы
    /// </summary>
    class GroupTypeClass
    {
        static public DataTable DTGroupType = new DataTable();

        /// <summary>
        /// Заполнение таблицы инфомацией о типах групп
        /// </summary>
        static public void GetGroupTypeList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `GroupType` " +
                "ORDER BY `name`";
            DTGroupType.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTGroupType);
        }

        /// <summary>
        /// Добавление информации о типе группы
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean AddGroupType(String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO `GroupType` " +
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
                    "Ошибка при добавлении типа группы",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о типе группы
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean EditGroupType(String id, String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `GroupType` " +
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
                  "Ошибка при изменении типа группы",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о типе группы
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropGroupType(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `GroupType` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Невозможно удалить тип группы, " +
                   "так как он используется. ",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении типа группы",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
