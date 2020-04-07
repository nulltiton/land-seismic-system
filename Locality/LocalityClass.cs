using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.Locality
{
    class LocalityClass
    {
        static public DataTable DTLocality = new DataTable();

        static public void GetLocalityList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT Locality.id" +
                ", Locality.idLocalityType " +
                ", LocalityType.Name" +
                ", Locality.idSeismicExplorationType" +
                ", SeismicExplorationType.Name" +
                ", Locality.Size" +
                ", Locality.Latitude" +
                ", Locality.Longitude" +
                ", Locality.loginGeologist" +
                ", CONCAT_WS(' ', Geologist.Surname" +
                ", Geologist.FirstName" +
                ", Geologist.MiddleName) " +
                "AS geologistFullName" +
                ", Locality.LoginLeadGeologist" +
                ", CONCAT_WS(' ', LeadGeologist.Surname" +
                ", LeadGeologist.FirstName" +
                ", LeadGeologist.MiddleName) " +
                "AS leadGeologistFullName" +
                ", Locality.LoginSquadLeader" +
                ", CONCAT_WS(' ', SquadLeader.Surname" +
                ", SquadLeader.FirstName" +
                ", SquadLeader.MiddleName) " +
                "AS squadLeaderFullName" +
                ", Locality.Usability " +
                "FROM Locality " +
                "INNER JOIN User Geologist " +
                "ON Geologist.Login = Locality.loginGeologist " +
                "INNER JOIN User LeadGeologist " +
                "ON LeadGeologist.Login = Locality.LoginLeadGeologist " +
                "INNER JOIN User SquadLeader " +
                "ON SquadLeader.Login = Locality.LoginSquadLeader " +
                "INNER JOIN LocalityType " +
                "ON Locality.idLocalityType = LocalityType.id " +
                "INNER JOIN SeismicExplorationType " +
                "ON locality.idSeismicExplorationType = " +
                "SeismicExplorationType.id";
            DTLocality.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTLocality);
        }

        static public Boolean AddLocality(String idLocalityType, 
            String idSeismicExplorationType, String size, String latitude,
            String longitude, String loginGeologist, String loginLeadGeologist,
            String loginSquadLeader, Boolean usabilityValue)
        {
            try
            {
                String usability = usabilityValue ? "1" : "0";
                DBConnection.DBConnection.sqlCommand.CommandText =
                "INSERT INTO Locality " +
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении местности. " + ex.Message,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditLocality(String id, String idLocalityType,
            String idSeismicExplorationType, String size, String latitude,
            String longitude, String loginGeologist, String loginLeadGeologist,
            String loginSquadLeader, Boolean usabilityValue)
        {
            try
            {
                String usability = usabilityValue ? "1" : "0";
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE Locality " +
                    "SET idLocalityType = '" + idLocalityType + "'" +
                    ", idSeismicExplorationType = " +
                    "'" + idSeismicExplorationType + "'" +
                    ", size = '" + size + "'" +
                    ", latitude = '" + latitude + "'" +
                    ", longitude = '" + longitude + "'" +
                    ", loginGeologist = '" + loginGeologist + "'" +
                    ", loginLeadGeologist = '" + loginLeadGeologist + "' " +
                    ", loginSquadLeader = '" + loginSquadLeader + "' " +
                    ", usability = '" + usability + "' " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.
                    ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при изменении местности. " + ex.Message,
                    "Ошибка изменения",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropLocality(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM Locality " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при удаления местности. " + ex.Message,
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
