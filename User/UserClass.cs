using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LandSeismic.User
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    class UserClass
    {
        static public DataTable DTUser = new DataTable();
        static public DataTable DTGeologist = new DataTable();
        static public DataTable DTLeadGeologist = new DataTable();
        static public DataTable DTSquadLeader = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о пользователях
        /// </summary>
        static public void GetUserList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `user`.`login`" +
                ", `user`.`password`" +
                ", `user`.`surname`" +
                ", `user`.`firstname`" +
                ", `user`.`middlename`" +
                ", `user`.`phone`" +
                ", `user`.`address`" +
                ", `position`.`name` " +
                "FROM `user`" +
                ", `position` " +
                "WHERE `user`.`idPosition` = `position`.`id` " +
                "AND `user`.`isDeleted` = 0 " +
                "ORDER BY `user`.`login`";
            DTUser.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTUser);
        }

        /// <summary>
        /// Заполнение таблицы информацией о геологах
        /// </summary>
        static public void GetGeologistList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `user`.`login`" +
                ", CONCAT_WS(' ', `user`.`surname`" +
                ", `user`.`firstname`" +
                ", `user`.`middlename`) " +
                "AS `name` " +
                "FROM `user`" +
                ", `position` " +
                "WHERE `user`.`idPosition` = `position`.`id` " +
                "AND `user`.`isDeleted` = 0 " +
                "AND `position`.`name` = 'Геолог'";
            DTGeologist.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTGeologist);
        }

        /// <summary>
        /// Заполнение таблицы информацией о ведущих геологах
        /// </summary>
        static public void GetLeadGeologistList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `user`.`login`" +
                ", CONCAT_WS(' ', `user`.`surname`" +
                ", `user`.`firstname`" +
                ", `user`.`middlename`) " +
                "AS `name` " +
                "FROM `user`" +
                ", `position` " +
                "WHERE `user`.`idPosition` = `position`.`id` " +
                "AND `user`.`isDeleted` = 0 " +
                "AND `position`.`name` = 'Ведущий геолог'";
            DTLeadGeologist.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTLeadGeologist);
        }

        /// <summary>
        /// Заполнение таблицы информацие о начальниках сейсмотряда
        /// </summary>
        static public void GetSquadLeaderList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `user`.`login`" +
                ", CONCAT_WS(' ', `user`.`surname`" +
                ", `user`.`firstname`" +
                ", `user`.`middlename`) " +
                "AS `name` " +
                "FROM `user`" +
                ", `position` " +
                "WHERE `user`.`idPosition` = `position`.`id` " +
                "AND `user`.`isDeleted` = 0 " +
                "AND `position`.`name` = 'Начальник сейсмотряда'";
            DTSquadLeader.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTSquadLeader);
        }

        /// <summary>
        /// Получение полного имени пользователя по логину
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static public String GetUserFullName(String login)
        {
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT CONCAT_WS(' ', `surname` " +
                ", `firstName`" +
                ", `middleName`) " +
                "FROM `user` " +
                "WHERE `login` = '" + login + "'";
            return DBConnection.DBConnection.sqlCommand.ExecuteScalar().
                ToString();
        }

        /// <summary>
        /// Добавление информации о пользователях
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="surname"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        static public Boolean AddUser(String login, String password, 
            String surname, String firstName, String middleName, String phone, 
            String address, String position)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`login`) " +
                    "FROM `user` " +
                    "WHERE `login` = '" + login + "'";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO `user` " +
                    "VALUES('" + login + "'" +
                    ", '" + Validation.ValidationClass.PasswordEncryption(password) + "'" +
                    ", '" + surname + "'" +
                    ", '" + firstName + "'" +
                    ", '" + middleName + "'" +
                    ", '" + phone + "'" +
                    ", '" + address + "'" +
                    ", '" + position + "'" +
                    ", '0')";
                    if (DBConnection.DBConnection.sqlCommand.
                        ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Данный логин уже " +
                        "зарегистрирован в системе",
                        "Ошибка добавления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении пользователя", 
                    "Ошибка добавления", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о пользователях
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="surname"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="position"></param>
        /// <param name="modefied"></param>
        /// <param name="loginModified"></param>
        /// <param name="primordialLogin"></param>
        /// <returns></returns>
        static public Boolean EditUser(String login, String password,
            String surname, String firstName, String middleName, String phone,
            String address, String position, Boolean modefied, 
            Boolean loginModified, String primordialLogin)
        {
            try
            {
                if (modefied)
                {
                    if (!loginModified)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "UPDATE `user` " +
                            "SET `password` = '" + Validation.ValidationClass.
                                PasswordEncryption(password) + "'" +
                            ", `surname` = '" + surname + "'" +
                            ", `firstName` = '" + firstName + "'" +
                            ", `middleName` = '" + middleName + "'" +
                            ", `phone` = '" + phone + "'" +
                            ", `address` = '" + address + "'" +
                            ", `idPosition` = '" + position + "' " +
                            "WHERE `login` = '" + login + "'";
                        if (DBConnection.DBConnection.sqlCommand.
                            ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT COUNT(`login`) " +
                            "FROM `user` " +
                            "WHERE `login` = '" + login + "'";
                        if (Convert.ToByte(DBConnection.DBConnection.
                            sqlCommand.ExecuteScalar()) == 0)
                        {
                            DBConnection.DBConnection.sqlCommand.CommandText =
                                "UPDATE `user` " +
                                "SET `login` = '" + login + "'" +
                                ", `password` = '" + Validation.
                                    ValidationClass.
                                    PasswordEncryption(password) + "'" +
                                ", `surname` = '" + surname + "'" +
                                ", `firstName` = '" + firstName + "'" +
                                ", `middleName` = '" + middleName + "'" +
                                ", `phone` = '" + phone + "'" +
                                ", `address` = '" + address + "'" +
                                ", `idPosition` = '" + position + "' " +
                                "WHERE `login` = '" + primordialLogin + "'";
                            if (DBConnection.DBConnection.sqlCommand.
                                ExecuteNonQuery() > 0)
                                return true;
                            else
                                return false;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show(
                                "Данный логин уже зарегистрирован в системе",
                                "Ошибка изменения",
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else
                    return true;
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
        /// Удаление информации о пользователях
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static public Boolean DropUser(String login)
        {
            try
            {
                Int32 result;

                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `inventorylist` " +
                    "WHERE `logingeologist` = '" + login + "'";
                result = Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar());

                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `squad` " +
                    "WHERE `loginsquadleader` = '" + login + "'";
                result += Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar());

                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `locality` " +
                    "WHERE `logingeologist` = '" + login + "' " +
                    "OR `loginleadgeologist` = '" + login + "' " +
                    "OR `loginsquadleader` = '" + login + "'";
                result += Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar());

                if (result == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "UPDATE `user` " +
                        "SET `isDeleted` = 1 " +
                        "WHERE `login` = '" + login + "'";
                    if (DBConnection.DBConnection.sqlCommand.
                        ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Невозможно удалить пользователя, так как на него " +
                        "записаны данные.",
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
