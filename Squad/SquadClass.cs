using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.Squad
{
    class SquadClass
    {
        static public DataTable DTSquad = new DataTable();

        static public void GetSquadList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT Squad.id" +
                ", Squad.loginSquadLeader" +
                ", CONCAT_WS(' '" +
                ", User.surname" +
                ", User.firstName" +
                ", User.middleName) " +
                "AS fullName" +
                ", Squad.idLocality" +
                ", Squad.departureDate" +
                ", Squad.returnDate" +
                ", Squad.actualReturnDate " +
                "FROM Squad" +
                ", User" +
                ", Locality" +
                ", Position " +
                "WHERE Squad.loginSquadLeader = User.login " +
                "AND User.idPosition = Position.id " +
                "AND Position.name = 'Начальник сейсмотряда' " +
                "AND Squad.idLocality = Locality.id " +
                "ORDER BY Squad.id";
            DTSquad.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquad);
        }

        static public Boolean AddSquad(String loginSquadLeader,
            String idLocality, String departureDate, String returnDate,
            String actualReturnDate = null)
        {
            try
            {
                DateTime formatDepartureDate = Convert.
                    ToDateTime(departureDate);
                DateTime formatReturnDate = Convert.ToDateTime(returnDate);
                DateTime formatActualReturnDate = Convert.
                    ToDateTime(actualReturnDate);
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO Squad " +
                    "VALUES(NULL" +
                    ", '" + loginSquadLeader + "'" +
                    ", '" + idLocality + "'" +
                    ", '" + formatDepartureDate.ToString("yyyy-MM-dd") + "'" +
                    ", '" + formatReturnDate.ToString("yyyy-MM-dd") + "'" +
                    ", '" + formatActualReturnDate.
                    ToString("yyyy-MM-dd") + "')";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении отряда. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditSquad(String id, String loginSquadLeader,
            String idLocality, String departureDate, String returnDate,
            String actualReturnDate)
        {
            try
            {
                DateTime formatDepartureDate = Convert.
                    ToDateTime(departureDate);
                DateTime formatReturnDate = Convert.ToDateTime(returnDate);
                DateTime formatActualReturnDate = Convert.
                    ToDateTime(actualReturnDate);
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE Squad " +
                    "SET loginSquadLeader = '" + loginSquadLeader + "'" +
                    ", idLocality = '" + idLocality + "'" +
                    ", departureDate = '" + formatDepartureDate.
                    ToString("yyyy-MM-dd") + "'" +
                    ", returnDate = '" + formatReturnDate.
                    ToString("yyyy-MM-dd") + "'" +
                    ", actualReturnDate = '" + formatActualReturnDate.
                    ToString("yyyy-MM-dd") + "' " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении отряда. " + ex,
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropSquad(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM Squad " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Невозможно удалить выбранный отряд, так как в нем " +
                    "присутствуют группы.",
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении отряда. " + ex,
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
