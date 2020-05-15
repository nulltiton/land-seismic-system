using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.SquadMember
{
    /// <summary>
    /// Класс члены отряда
    /// </summary>
    class SquadMemberClass
    {
        static public DataTable DTSquadMember = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о членах отряда
        /// </summary>
        /// <param name="idGroup"></param>
        static public void GetSquadMemberList(String idGroup)
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `SquadMember`.`id`" +
                ", `SquadMember`.`idGroup`" +
                ", `SquadMember`.`idEmployee` " +
                ", CONCAT_WS(' '" +
                ", `Employee`.`Surname`" +
                ", `Employee`.`FirstName`" +
                ", `Employee`.`MiddleName`) " +
                " AS `fullName`" +
                ", `Employee`.`idPosition`" +
                ", `Position`.`Name` " +
                "FROM `SquadMember`" +
                ", `Employee`" +
                ", `Position`" +
                "WHERE `SquadMember`.`idEmployee` = `Employee`.`id` " +
                "AND `Employee`.`idPosition` = `Position`.`id` " +
                "AND `SquadMember`.`idGroup` = '" + idGroup + "'" +
                "ORDER BY `fullName`";
            DTSquadMember.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquadMember);
        }

        /// <summary>
        /// Добавление информации о члене отряда
        /// </summary>
        /// <param name="idGroup"></param>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        static public Boolean AddSquadMember(String idGroup, String idEmployee)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `squadmember` " +
                    "WHERE `idGroup` = '" + idGroup + "' " +
                    "AND `idEmployee` = '" + idEmployee + "'";
                if (Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "INSERT INTO `SquadMember` " +
                        "VALUES(NULL" +
                        ", '" + idGroup + "'" +
                        ", '" + idEmployee + "')";
                    if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Невозможно добавить этого сотрудника, так как " +
                        "он уже есть в группе.",
                        "Ошибка добавления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении участника отряда. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о члене отряда
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idGroup"></param>
        /// <param name="idEmployee"></param>
        /// <param name="modified"></param>
        /// <returns></returns>
        static public Boolean EditSquadMember(String id, String idGroup, 
            String idEmployee, Boolean modified)
        {
            try
            {
                if (modified)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "SELECT COUNT(`id`) " +
                        "FROM `squadmember` " +
                        "WHERE `idGroup` = '" + idGroup + "' " +
                        "AND `idEmployee` = '" + idEmployee + "'";
                    if (Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar()) == 0)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "UPDATE `SquadMember` " +
                            "SET `idGroup` = '" + idGroup + "'" +
                            ", `idEmployee` = '" + idEmployee + "' " +
                            "WHERE `id` = '" + id + "'";
                        if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Невозможно добавить этого сотрудника, так как " +
                            "он уже есть в группе.",
                            "Ошибка добавления",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении участника отряда. " + ex,
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о члене отряда
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropSquadMember(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `SquadMember` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении участника отряда. " + ex,
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
