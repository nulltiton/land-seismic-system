using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LandSeismic.User
{
    class UserClass
    {
        static public DataTable DTUser = new DataTable();

        static public void GetUserList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT user.login" +
                ", user.password" +
                ", user.surname" +
                ", user.firstname" +
                ", user.middlename" +
                ", user.phone" +
                ", user.address" +
                ", position.name " +
                "FROM user" +
                ", position " +
                "WHERE user.idPosition = position.id " +
                "AND user.isDeleted = 0 " +
                "ORDER BY user.login";
            DTUser.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTUser);
        }

        static public Boolean AddUser(String login, String password, 
            String surname, String firstName, String middleName, String phone, 
            String address, String position)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(login) " +
                    "FROM user " +
                    "WHERE login = '" + login + "'";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO user " +
                    "VALUES('" + login + "'" +
                    ", '" + Validation.Validation.PasswordEncryption(password) + "'" +
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
                    System.Windows.Forms.MessageBox.Show("Данный логин уже зарегистрирован в системе",
                        "Ошибка добавления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении пользователя. " + ex.Message, 
                    "Ошибка добавления", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

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
                            "UPDATE user " +
                            "SET password = '" + Validation.Validation.
                                PasswordEncryption(password) + "'" +
                            ", surname = '" + surname + "'" +
                            ", firstName = '" + firstName + "'" +
                            ", middleName = '" + middleName + "'" +
                            ", phone = '" + phone + "'" +
                            ", address = '" + address + "'" +
                            ", idPosition = '" + position + "' " +
                            "WHERE login = '" + login + "'";
                        if (DBConnection.DBConnection.sqlCommand.
                            ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT COUNT(login) " +
                            "FROM user " +
                            "WHERE login = '" + login + "'";
                        if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                            ExecuteScalar()) == 0)
                        {
                            DBConnection.DBConnection.sqlCommand.CommandText =
                                "UPDATE user " +
                                "SET login = '" + login + "'" +
                                ", password = '" + Validation.Validation.
                                    PasswordEncryption(password) + "'" +
                                ", surname = '" + surname + "'" +
                                ", firstName = '" + firstName + "'" +
                                ", middleName = '" + middleName + "'" +
                                ", phone = '" + phone + "'" +
                                ", address = '" + address + "'" +
                                ", idPosition = '" + position + "' " +
                                "WHERE login = '" + primordialLogin + "'";
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при изменении пользователя. " + ex.Message,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropUser(String login)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE user " +
                    "SET isDeleted = 1 " +
                    "WHERE login = '" + login + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при удаления пользователя. " + ex.Message,
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
