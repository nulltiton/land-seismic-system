using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.PositionStandart
{
    /// <summary>
    /// Класс нормативов должности
    /// </summary>
    class PositionStandartClass
    {
        static public DataTable DTPositionStandart = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о нормативах должности
        /// </summary>
        static public void GetPositionStandartList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `PositionStandart`.`idPosition`" +
                ", `Position`.`name`" +
                ", `PositionStandart`.`idResource`" +
                ", `MaterialAndTechnicalResource`.`name`" +
                ", `PositionStandart`.`Amount` " +
                "FROM `PositionStandart`" +
                ", `Position`" +
                ", `MaterialAndTechnicalResource` " +
                "WHERE `PositionStandart`.`idPosition` = `Position`.`id` " +
                "AND `PositionStandart`.`idResource` = " +
                "`MaterialAndTechnicalResource`.`id`";
            DTPositionStandart.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPositionStandart);
        }

        /// <summary>
        /// Добавление информации о нормативе должности
        /// </summary>
        /// <param name="positionId"></param>
        /// <param name="resourceId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        static public Boolean AddPositionStandart(String positionId, 
            String resourceId, String amount)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`idPosition`) " +
                    "FROM `PositionStandart` " +
                    "WHERE `idPosition` = '" + positionId + "' " +
                    "AND `idResource` = '" + resourceId + "'";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "INSERT INTO `PositionStandart` " +
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
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении норматива должности",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о нормативах должности
        /// </summary>
        /// <param name="positionId"></param>
        /// <param name="resourceId"></param>
        /// <param name="amount"></param>
        /// <param name="primordialPositionId"></param>
        /// <param name="primordialResourceId"></param>
        /// <param name="modified"></param>
        /// <param name="minorChange"></param>
        /// <returns></returns>
        static public Boolean EditPositionStandart(String positionId, 
            String resourceId, String amount, String primordialPositionId,
            String primordialResourceId, Boolean modified, Boolean minorChange)
        {
            try
            {
                if (modified)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`idPosition`) " +
                    "FROM `PositionStandart` " +
                    "WHERE `idPosition` = '" + positionId + "' " +
                    "AND `idResource` = '" + resourceId + "'";
                    if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar()) == 0)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "UPDATE `PositionStandart` " +
                            "SET `idPosition` = '" + positionId + "'" +
                            ", `idResource` = '" + resourceId + "'" +
                            ", `amount` = '" + amount + "'" +
                            "WHERE `idPosition` = '" + primordialPositionId + "' " +
                            "AND `idResource` = '" + primordialResourceId + "'";
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
                        "UPDATE `PositionStandart` " +
                        "SET `amount` = '" + amount + "'" +
                        "WHERE `idPosition` = '" + primordialPositionId + "' " +
                        "AND `idResource` = '" + primordialResourceId + "'";
                    if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении норматива должности",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о нормативах должности
        /// </summary>
        /// <param name="positionId"></param>
        /// <param name="resourceId"></param>
        /// <returns></returns>
        static public Boolean DropPositionStandart(String positionId,
            String resourceId)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `PositionStandart` " +
                    "WHERE `idPosition` = '" + positionId + "' " +
                    "AND `idResource` = '" + resourceId + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении норматива должности",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}