using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LandSeismic.Position
{
    /// <summary>
    /// Класс должности
    /// </summary>
    class PositionClass
    {
        static public DataTable DTPosition = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о должностях
        /// </summary>
        static public void GetPositionList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `position` " +
                "ORDER BY `name`";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        /// <summary>
        /// Заполнение таблицы информацией о должностях пользователей
        /// </summary>
        static public void GetPositionListForUser()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `position` " +
                "WHERE `name` = 'Геолог' " +
                "OR `name` = 'Начальник сейсмотряда' " +
                "OR `name` = 'Ведущий геолог' " +
                "ORDER BY `name`";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        /// <summary>
        /// Заполнение таблицы информацией о должностях сотрудников
        /// </summary>
        static public void GetPositionListForEmployee()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `position` " +
                "WHERE `name` <> 'Геолог' " +
                "AND `name` <> 'Начальник сейсмотряда' " +
                "AND `name` <> 'Ведущий геолог' " +
                "ORDER BY `name`";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        /// <summary>
        /// Получить должность по id
        /// </summary>
        /// <param name="id"></param>
        static public void GetPositionById(String id)
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `id` " +
                "FROM `position`" +
                ", `employee` " +
                "WHERE `employee`.`idPosition` = `position`.`id` " +
                "AND `position`.`id` = '" + id + "' " +
                "ORDER BY `name`";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        /// <summary>
        /// Добавление информации о должности
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean AddPosition(String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO `position` " +
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
                    "Ошибка при добавлении должности", 
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,  
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о должности
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public Boolean EditPosition(String id, String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `position` " +
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
                  "Ошибка при изменении должности",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о должности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropPosition(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `position` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Невозможно удалить данную должность, так как " +
                   "она используется. ",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении должности",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
