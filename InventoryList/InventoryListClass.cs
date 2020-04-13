using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LandSeismic.InventoryList
{
    class InventoryListClass
    {
        static public DataTable DTInventoryList = new DataTable();

        static public void GetInventoryList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `inventorylist`.`id`" +
                ", `inventorylist`.`logingeologist`" +
                ", CONCAT_WS(' '" +
                ", `user`.`surname`" +
                ", `user`.`firstname`" +
                ", `user`.`middlename`) " +
                "AS `fullName`" +
                ", `inventorylist`.`creationDate` " +
                "FROM `InventoryList`" +
                ", `user` " +
                "WHERE `inventorylist`.`logingeologist` = `user`.`login` " +
                "ORDER BY id";
            DTInventoryList.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTInventoryList);
        }

        static public Boolean EditInventoryList(String id, 
            String loginGeologist)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `InventoryList` " +
                    "SET `loginGeologist` = '" + loginGeologist + "' " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении перечня материально-технических " +
                    "ресуров. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropInventoryList(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `InventoryList` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении перечня материально-технических " +
                    "ресуров. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
