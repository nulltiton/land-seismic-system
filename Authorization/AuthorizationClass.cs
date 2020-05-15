using System;

namespace LandSeismic.Authorization
{
    /// <summary>
    /// Класс авторизации
    /// </summary>
    class AuthorizationClass
    {
        static public String Login;
        static public String Position;

        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public String LogIn(String login, String password)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`login`) " +
                    "FROM `user` " +
                    "WHERE `login` = '" + login + "' " +
                    "AND `isDeleted` = 0";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) > 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "SELECT `position`.`name` " +
                        "FROM `user`" +
                        ", `position` " +
                        "WHERE `user`.`login` = '" + login + "' " +
                        "AND `user`.`password` = '" + 
                        Validation.ValidationClass.
                            PasswordEncryption(password) + "' " +
                        "AND `user`.`idPosition` = `position`.`id` " +
                        "AND `user`.`isDeleted` = 0";
                    if (DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar() != null)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT `position`.`name` " +
                            "FROM `user`" +
                            ", `position` " +
                            "WHERE `user`.`login` = '" + login + "' " +
                            "AND `user`.`idPosition` = `position`.`id` " +
                            "AND `user`.`isDeleted` = 0";
                        Position = DBConnection.DBConnection.sqlCommand.
                            ExecuteScalar().ToString();
                        Login = login;
                        
                        return DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar().ToString();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Неверный пароль",
                            "Ошибка авторизации",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                        return "";
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Данный логин не зарегистрирован в системе",
                        "Ошибка авторизации",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return "";
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при попытке авторизации",
                    "Ошибка авторизации",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
