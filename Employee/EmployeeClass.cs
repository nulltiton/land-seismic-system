using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.Employee
{
    /// <summary>
    /// Класс сотрудника
    /// </summary>
    class EmployeeClass
    {
        static public DataTable DTEmployee = new DataTable();
        static public DataTable DTFilteredEmployee = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о сотрудниках
        /// </summary>
        static public void GetEmployeeList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `employee`.`id`" +
                ", `employee`.`surname`" +
                ", `employee`.`firstname`" +
                ", `employee`.`middlename`" +
                ", `employee`.`phone`" +
                ", `employee`.`address`" +
                ", `employee`.`contactPhone`" +
                ", `position`.`name` " +
                "FROM `employee`" +
                ", `position` " +
                "WHERE `employee`.`idPosition` = `position`.`id` " +
                "AND `employee`.`isDeleted` = 0 " +
                "ORDER BY `employee`.`surname`";
            DTEmployee.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTEmployee);
        }

        /// <summary>
        /// Конкатенация имени
        /// </summary>
        static public void GetEmployeeFullName()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `id`" +
                ", CONCAT_WS(' '" +
                ", `surname`" +
                ", `firstname`" +
                ", `middlename`) " +
                "AS `fullName`" +
                "FROM `employee` " +
                "WHERE `isDeleted` = 0 " +
                "ORDER BY `fullName`";
            DTEmployee.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTEmployee);
        }

        /// <summary>
        /// Фильтрация по должности
        /// </summary>
        /// <param name="positionId"></param>
        static public void FilterByPosition(String positionId)
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `employee`.`id`" +
                ", `employee`.`surname`" +
                ", `employee`.`firstname`" +
                ", `employee`.`middlename`" +
                ", `employee`.`phone`" +
                ", `employee`.`address`" +
                ", `employee`.`contactPhone`" +
                ", `position`.`name` " +
                "FROM `employee`" +
                ", `position` " +
                "WHERE `employee`.`idPosition` = `position`.`id` " +
                "AND `employee`.`isDeleted` = 0 " +
                "AND `position`.`id` = '" + positionId + "'" +
                "ORDER BY `employee`.`surname`";
            DTFilteredEmployee.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTFilteredEmployee);
        }

        /// <summary>
        /// Добавление информации о сотруднике
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="contactPhone"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        static public Boolean AddEmployee(String surname, String firstName,
            String middleName, String phone, String address,
            String contactPhone, String position)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                "INSERT INTO `employee` " +
                "VALUES(NULL" +
                ", '" + surname + "'" +
                ", '" + firstName + "'" +
                ", '" + middleName + "'" +
                ", '" + phone + "'" +
                ", '" + address + "'" +
                ", '" + contactPhone + "'" +
                ", '" + position + "'" +
                ", '0')";
                if (DBConnection.DBConnection.sqlCommand.
                    ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении сотрудника",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о сотруднике
        /// </summary>
        /// <param name="id"></param>
        /// <param name="surname"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="contactPhone"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        static public Boolean EditEmployee(String id, String surname,
            String firstName, String middleName, String phone, String address,
            String contactPhone, String position)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `employee` " +
                    "SET `surname` = '" + surname + "'" +
                    ", `firstName` = '" + firstName + "'" +
                    ", `middleName` = '" + middleName + "'" +
                    ", `phone` = '" + phone + "'" +
                    ", `address` = '" + address + "'" +
                    ", `contactPhone` = '" + contactPhone + "'" +
                    ", `idPosition` = '" + position + "' " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.
                    ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при изменении пользователя",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о соруднике
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropEmployee(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `squadmember` " +
                    "WHERE `idEmployee` = '" + id + "'";
                if (Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "UPDATE `employee` " +
                        "SET `isDeleted` = 1 " +
                        "WHERE `id` = '" + id + "'";
                    if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Невозможно удалить сотрудника, так как он " +
                        "записан в отряд.",
                        "Ошибка удаления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при удаления пользователя",
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
