using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.Squad
{
    class GroupClass
    {
        static public DataTable DTGroup = new DataTable();

        static public void GetGroupList(String idSquad)
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Group`.`id`" +
                ", `Group`.`idSquad`" +
                ", `Group`.`idGroupType`" +
                ", `GroupType`.`Name` " +
                "FROM `Group`" +
                ", `GroupType` " +
                "WHERE `Group`.`idGroupType` = `GroupType`.`id` " +
                "AND `Group`.`idSquad` = '" + idSquad + "' " +
                "ORDER BY `GroupType`.`Name`";
            DTGroup.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTGroup);
        }

        static public Boolean AddGroup(String idSquad, String idGroupType)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `Group` " +
                    "WHERE `idSquad` = '" + idSquad + "' " +
                    "AND `idGroupType` = '" + idGroupType + "'";
                if (Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "INSERT INTO `Group` " +
                        "VALUES(NULL" +
                        ", '" + idSquad + "'" +
                        ", '" + idGroupType + "')";
                    if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Невозможно добавить такую группу, так как она уже " +
                        "есть в отряде.",
                        "Ошибка добавления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении группы. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditGroup(String id, String idSquad, 
            String idGroupType, Boolean modified)
        {
            try
            {
                if (modified)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `Group` " +
                    "WHERE `idSquad` = '" + idSquad + "' " +
                    "AND `idGroupType` = '" + idGroupType + "'";
                    if (Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar()) == 0)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "UPDATE `Group` " +
                            "SET `idGroupType` = '" + idGroupType + "' " +
                            ", idSquad = '" + idSquad + "' " +
                            "WHERE `id` = '" + id + "'";
                        if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Невозможно изменить на эту группу, так как она уже " +
                            "есть в отряде.",
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
                  "Ошибка при изменении группы. " + ex,
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropGroup(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `Group` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Невозможно удалить выбранную группу, так как в ней " +
                    "присутствуют участники.",
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении группы. " + ex,
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
