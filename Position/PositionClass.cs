using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LandSeismic.Position
{
    class PositionClass
    {
        static public DataTable DTPosition = new DataTable();

        static public void GetPositionList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM position " +
                "ORDER BY name";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        static public void GetPositionListForUser()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM position " +
                "WHERE name = 'Геолог' " +
                "OR name = 'Начальник сейсмотряда' " +
                "OR name = 'Ведущий геолог' " +
                "ORDER BY name";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        static public void GetPositionListForEmployee()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM position " +
                "WHERE name <> 'Геолог' " +
                "AND name <> 'Начальник сейсмотряда' " +
                "AND name <> 'Ведущий геолог' " +
                "ORDER BY name";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

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
                "ORDER BY name";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        static public Boolean AddPosition(String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO position " +
                    "VALUES(NULL" +
                    ", '" + name + "')";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении должности. " + ex, 
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,  
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditPosition(String id, String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE position " +
                    "SET name = '" + name + "' " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении должности. " + ex,
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropPosition(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM position " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении должности. " + ex,
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
