using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.Locality
{
    /// <summary>
    /// Класс местности
    /// </summary>
    class LocalityClass
    {
        static public DataTable DTLocality = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о местности
        /// </summary>
        static public void GetLocalityList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Locality`.`id`" +
                ", `Locality`.`idLocalityType` " +
                ", `LocalityType`.`Name`" +
                ", `Locality`.`idSeismicExplorationType`" +
                ", `SeismicExplorationType`.`Name`" +
                ", `Locality`.`Size`" +
                ", `Locality`.`Latitude`" +
                ", `Locality`.`Longitude`" +
                ", `Locality`.`loginGeologist`" +
                ", CONCAT_WS(' ', `Geologist`.`Surname`" +
                ", `Geologist`.`FirstName`" +
                ", `Geologist`.`MiddleName`) " +
                "AS `geologistFullName`" +
                ", `Locality`.`LoginLeadGeologist`" +
                ", CONCAT_WS(' ', `LeadGeologist`.`Surname`" +
                ", `LeadGeologist`.`FirstName`" +
                ", `LeadGeologist`.`MiddleName`) " +
                "AS `leadGeologistFullName`" +
                ", `Locality`.`LoginSquadLeader`" +
                ", CONCAT_WS(' ', `SquadLeader`.`Surname`" +
                ", `SquadLeader`.`FirstName`" +
                ", `SquadLeader`.`MiddleName`) " +
                "AS `squadLeaderFullName`" +
                ", `Locality`.`Usability` " +
                "FROM `Locality` " +
                "INNER JOIN `User` `Geologist` " +
                "ON `Geologist`.`Login` = `Locality`.`loginGeologist` " +
                "INNER JOIN `User` `LeadGeologist` " +
                "ON `LeadGeologist`.`Login` = `Locality`.`LoginLeadGeologist` " +
                "INNER JOIN `User` `SquadLeader` " +
                "ON `SquadLeader`.`Login` = `Locality`.`LoginSquadLeader` " +
                "INNER JOIN `LocalityType` " +
                "ON `Locality`.`idLocalityType` = `LocalityType`.`id` " +
                "INNER JOIN `SeismicExplorationType` " +
                "ON `locality`.`idSeismicExplorationType` = " +
                "`SeismicExplorationType`.`id`";
            DTLocality.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTLocality);
        }

        /// <summary>
        /// Заполнение таблицы информацией о местности для отряда
        /// </summary>
        static public void GetLocalityListForSquad()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Locality`.`id`" +
                ", `Locality`.`idLocalityType` " +
                ", `LocalityType`.`Name`" +
                ", `Locality`.`idSeismicExplorationType`" +
                ", `SeismicExplorationType`.`Name`" +
                ", `Locality`.`Size`" +
                ", `Locality`.`Latitude`" +
                ", `Locality`.`Longitude`" +
                ", `Locality`.`loginGeologist`" +
                ", CONCAT_WS(' ', `Geologist`.`Surname`" +
                ", `Geologist`.`FirstName`" +
                ", `Geologist`.`MiddleName`) " +
                "AS `geologistFullName`" +
                ", `Locality`.`LoginLeadGeologist`" +
                ", CONCAT_WS(' ', `LeadGeologist`.`Surname`" +
                ", `LeadGeologist`.`FirstName`" +
                ", `LeadGeologist`.`MiddleName`) " +
                "AS `leadGeologistFullName`" +
                ", `Locality`.`LoginSquadLeader`" +
                ", CONCAT_WS(' ', `SquadLeader`.`Surname`" +
                ", `SquadLeader`.`FirstName`" +
                ", `SquadLeader`.`MiddleName`) " +
                "AS `squadLeaderFullName`" +
                ", `Locality`.`Usability` " +
                "FROM `Locality` " +
                "INNER JOIN `User` `Geologist` " +
                "ON `Geologist`.`Login` = `Locality`.`loginGeologist` " +
                "INNER JOIN `User` `LeadGeologist` " +
                "ON `LeadGeologist`.`Login` = `Locality`.`LoginLeadGeologist` " +
                "INNER JOIN `User` `SquadLeader` " +
                "ON `SquadLeader`.`Login` = `Locality`.`LoginSquadLeader` " +
                "INNER JOIN `LocalityType` " +
                "ON `Locality`.`idLocalityType` = `LocalityType`.`id` " +
                "INNER JOIN `SeismicExplorationType` " +
                "ON `locality`.`idSeismicExplorationType` = " +
                "`SeismicExplorationType`.`id`" +
                "WHERE `Locality`.`Usability` = '1'";
            DTLocality.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTLocality);
        }

        /// <summary>
        /// Добавить информацию о местности
        /// </summary>
        /// <param name="idLocalityType"></param>
        /// <param name="idSeismicExplorationType"></param>
        /// <param name="size"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="loginGeologist"></param>
        /// <param name="loginLeadGeologist"></param>
        /// <param name="loginSquadLeader"></param>
        /// <param name="usabilityValue"></param>
        /// <returns></returns>
        static public Boolean AddLocality(String idLocalityType, 
            String idSeismicExplorationType, String size, String latitude,
            String longitude, String loginGeologist, String loginLeadGeologist,
            String loginSquadLeader, Boolean usabilityValue)
        {
            try
            {
                String usability = usabilityValue ? "1" : "0";
                DBConnection.DBConnection.sqlCommand.CommandText =
                "INSERT INTO `Locality` " +
                "VALUES(NULL" +
                ", '" + idLocalityType + "'" +
                ", '" + idSeismicExplorationType + "'" +
                ", '" + size + "'" +
                ", '" + latitude + "'" +
                ", '" + longitude + "'" +
                ", '" + loginGeologist + "'" +
                ", '" + loginLeadGeologist + "'" +
                ", '" + loginSquadLeader + "'" +
                ", '" + usability + "')";
                if (DBConnection.DBConnection.sqlCommand.
                    ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении местности",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактировать информацию о местности
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idLocalityType"></param>
        /// <param name="idSeismicExplorationType"></param>
        /// <param name="size"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="loginGeologist"></param>
        /// <param name="loginLeadGeologist"></param>
        /// <param name="loginSquadLeader"></param>
        /// <param name="usabilityValue"></param>
        /// <returns></returns>
        static public Boolean EditLocality(String id, String idLocalityType,
            String idSeismicExplorationType, String size, String latitude,
            String longitude, String loginGeologist, String loginLeadGeologist,
            String loginSquadLeader, Boolean usabilityValue)
        {
            try
            {
                String usability = usabilityValue ? "1" : "0";
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `Locality` " +
                    "SET `idLocalityType` = '" + idLocalityType + "'" +
                    ", `idSeismicExplorationType` = " +
                    "'" + idSeismicExplorationType + "'" +
                    ", `size` = '" + size + "'" +
                    ", `latitude` = '" + latitude + "'" +
                    ", `longitude` = '" + longitude + "'" +
                    ", `loginGeologist` = '" + loginGeologist + "'" +
                    ", `loginLeadGeologist` = '" + loginLeadGeologist + "' " +
                    ", `loginSquadLeader` = '" + loginSquadLeader + "' " +
                    ", `usability` = '" + usability + "' " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.
                    ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при изменении местности",
                    "Ошибка изменения",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удалить информацию о местности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropLocality(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `Locality` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Невозможно удалить местность, так как она используется",
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при удаления местности",
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
