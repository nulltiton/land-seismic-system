using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.PositionStandart
{
    class PositionStandartClass
    {
        static public DataTable DTPositionStandart = new DataTable();

        static public void GetPositionStandartList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT PositionStandart.idPosition" +
                ", Position.name" +
                ", PositionStandart.idResource" +
                ", MaterialAndTechnicalResource.name" +
                ", PositionStandart.Amount " +
                "FROM PositionStandart" +
                ", Position" +
                ", MaterialAndTechnicalResource " +
                "WHERE PositionStandart.idPosition = Position.id " +
                "AND PositionStandart.idResource = " +
                "MaterialAndTechnicalResource.id";
            DTPositionStandart.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPositionStandart);
        }

        static public Boolean AddPositionStandart(String positionId, 
            String resourceId, String amount)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(idPosition) " +
                    "FROM PositionStandart " +
                    "WHERE idPosition = '" + positionId + "' " +
                    "AND idResource = '" + resourceId + "'";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "INSERT INTO PositionStandart " +
                        "VALUES('" + positionId + "'" +
                        ", '" + resourceId + "'" +
                        ", '" + amount + "')";
                    if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Данный норматив уже существует",
                        "Ошибка добавления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении норматива должности. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditPositionStandart(String positionId, 
            String resourceId, String amount, String primordialPositionId,
            String primordialResourceId, Boolean modified, Boolean minorChange)
        {
            try
            {
                if (modified)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(idPosition) " +
                    "FROM PositionStandart " +
                    "WHERE idPosition = '" + positionId + "' " +
                    "AND idResource = '" + resourceId + "'";
                    if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar()) == 0)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "UPDATE PositionStandart " +
                            "SET idPosition = '" + positionId + "'" +
                            ", idResource = '" + resourceId + "'" +
                            ", amount = '" + amount + "'" +
                            "WHERE idPosition = '" + primordialPositionId + "' " +
                            "AND idResource = '" + primordialResourceId + "'";
                        if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Данный норматив уже существует",
                            "Ошибка изменения",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                        return false;
                    }
                }
                else if (minorChange)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "UPDATE PositionStandart " +
                        "SET amount = '" + amount + "'" +
                        "WHERE idPosition = '" + primordialPositionId + "' " +
                        "AND idResource = '" + primordialResourceId + "'";
                    if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении норматива должности. " + ex,
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropPositionStandart(String positionId,
            String resourceId)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM PositionStandart " +
                    "WHERE idPosition = '" + positionId + "' " +
                    "AND idResource = '" + resourceId + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении норматива должности. " + ex,
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}