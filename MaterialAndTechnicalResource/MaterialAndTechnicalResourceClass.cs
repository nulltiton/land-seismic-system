using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.MaterialAndTechnicalResource
{
    class MaterialAndTechnicalResourceClass
    {
        static public DataTable DTMaterialAndTechnicalResource = 
            new DataTable();

        static public void GetMaterialAndTechnicalResourceList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM MaterialAndTechnicalResource " +
                "ORDER BY name";
            DTMaterialAndTechnicalResource.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTMaterialAndTechnicalResource);
        }

        static public Boolean AddMaterialAndTechnicalResource(String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO MaterialAndTechnicalResource " +
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
                    "Ошибка при добавлении материально-тезнического ресурса. "
                    + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditMaterialAndTechnicalResource(String id, 
            String name)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE MaterialAndTechnicalResource " +
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
                  "Ошибка при изменении материально-технического ресурса. "
                  + ex,
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropMaterialAndTechnicalResource(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM MaterialAndTechnicalResource " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении материально-технического ресурса. "
                   + ex,
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
