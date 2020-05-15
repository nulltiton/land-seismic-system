using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.LocalityStandart
{
    /// <summary>
    /// Класс норматив местности 
    /// </summary>
    class LocalityStandartClass
    {
        static public DataTable DTLocalityStandart = new DataTable();

        /// <summary>
        /// Заполнить таблицу информацией о нормативах местности
        /// </summary>
        static public void GetLocalityStandartList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `LocalityStandart`.`idLocality`" +
                ", `LocalityType`.`name`" +
                ", `LocalityStandart`.`idResource`" +
                ", `MaterialAndTechnicalResource`.`name`" +
                ", `LocalityStandart`.`Amount` " +
                "FROM `LocalityStandart`" +
                ", `LocalityType`" +
                ", `MaterialAndTechnicalResource` " +
                "WHERE `LocalityStandart`.`idLocality` = `LocalityType`.`id` " +
                "AND `LocalityStandart`.`idResource` = " +
                "`MaterialAndTechnicalResource`.`id`";
            DTLocalityStandart.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTLocalityStandart);
        }

        /// <summary>
        /// Добавление информации о нормативе местности
        /// </summary>
        /// <param name="localityId"></param>
        /// <param name="resourceId"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        static public Boolean AddLocalityStandart(String localityId,
            String resourceId, String amount)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`idLocality`) " +
                    "FROM `LocalityStandart` " +
                    "WHERE `idLocality` = '" + localityId + "' " +
                    "AND `idResource` = '" + resourceId + "'";
                if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "INSERT INTO `LocalityStandart` " +
                        "VALUES('" + localityId + "'" +
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
                    "Ошибка при добавлении норматива местности",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о нормативе местности
        /// </summary>
        /// <param name="localityId"></param>
        /// <param name="resourceId"></param>
        /// <param name="amount"></param>
        /// <param name="primordialLocalityId"></param>
        /// <param name="primordialResourceId"></param>
        /// <param name="modified"></param>
        /// <param name="minorChange"></param>
        /// <returns></returns>
        static public Boolean EditLocalityStandart(String localityId,
            String resourceId, String amount, String primordialLocalityId,
            String primordialResourceId, Boolean modified, Boolean minorChange)
        {
            try
            {
                if (modified)
                {
                    DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`idLocality`) " +
                    "FROM `LocalityStandart` " +
                    "WHERE `idLocality` = '" + localityId + "' " +
                    "AND `idResource` = '" + resourceId + "'";
                    if (Convert.ToByte(DBConnection.DBConnection.sqlCommand.
                        ExecuteScalar()) == 0)
                    {
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "UPDATE `LocalityStandart` " +
                            "SET `idLocality` = '" + localityId + "'" +
                            ", `idResource` = '" + resourceId + "'" +
                            ", `amount` = '" + amount + "'" +
                            "WHERE `idLocality` = '" + primordialLocalityId + "' " +
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
                        "UPDATE `LocalityStandart` " +
                        "SET `amount` = '" + amount + "'" +
                        "WHERE `idLocality` = '" + primordialLocalityId + "' " +
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
                  "Ошибка при изменении норматива местности",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о нормативе местности
        /// </summary>
        /// <param name="localityId"></param>
        /// <param name="resourceId"></param>
        /// <returns></returns>
        static public Boolean DropLocalityStandart(String localityId,
            String resourceId)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `LocalityStandart` " +
                    "WHERE `idLocality` = '" + localityId + "' " +
                    "AND `idResource` = '" + resourceId + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении норматива местности",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
