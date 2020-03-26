using System;

namespace LandSeismic.Authorization
{
    class AuthorizationClass
    {
        static public String Login;
        static public String LogIn(String login, String password)
        {
            try
            {

                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(login) " +
                    "FROM user " +
                    "WHERE login = '" + login + "'";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) > 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "SELECT position.name " +
                        "FROM user" +
                        ", position " +
                        "WHERE user.login = '" + login + "' " +
                        "AND user.password = '" + Validation.Validation.
                            PasswordEncryption(password) + "' " +
                        "AND user.idPosition = position.id";
                    if (DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar().ToString() != String.Empty)
                    {
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при попытке авторизации. " + ex.Message,
                    "Ошибка авторизации",
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
