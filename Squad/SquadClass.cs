using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace LandSeismic.Squad
{
    /// <summary>
    /// Класс отряда
    /// </summary>
    class SquadClass
    {
        static public DataTable DTSquad = new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией об отрядах
        /// </summary>
        static public void GetSquadList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Squad`.`id`" +
                ", `Squad`.`loginSquadLeader`" +
                ", CONCAT_WS(' '" +
                ", `User`.`surname`" +
                ", `User`.`firstName`" +
                ", `User`.`middleName`) " +
                "AS `fullName`" +
                ", `Squad`.`idLocality`" +
                ", `Squad`.`departureDate`" +
                ", `Squad`.`returnDate`" +
                ", `Squad`.`actualReturnDate` " +
                "FROM `Squad`" +
                ", `User`" +
                ", `Locality`" +
                ", `Position` " +
                "WHERE `Squad`.`loginSquadLeader` = `User`.`login` " +
                "AND `User`.`idPosition` = `Position`.`id` " +
                "AND `Position`.`name` = 'Начальник сейсмотряда' " +
                "AND `Squad`.`idLocality` = `Locality`.`id` " +
                "ORDER BY `Squad`.`id`";
            DTSquad.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquad);
        }

        /// <summary>
        /// Заполнение таблицы информацией об отрядах с перечнями
        /// </summary>
        static public void GetSquadListForInventoryList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Squad`.`id`" +
                ", `Squad`.`loginSquadLeader`" +
                ", CONCAT_WS(' '" +
                ", `User`.`surname`" +
                ", `User`.`firstName`" +
                ", `User`.`middleName`) " +
                "AS `fullName`" +
                ", `Squad`.`idLocality`" +
                ", `Squad`.`departureDate`" +
                ", `Squad`.`returnDate`" +
                ", `Squad`.`actualReturnDate` " +
                "FROM `Squad`" +
                ", `User`" +
                ", `Locality`" +
                ", `Position` " +
                "WHERE `Squad`.`loginSquadLeader` = `User`.`login` " +
                "AND `User`.`idPosition` = `Position`.`id` " +
                "AND `Position`.`name` = 'Начальник сейсмотряда' " +
                "AND `Squad`.`idLocality` = `Locality`.`id` " +
                "ORDER BY `Squad`.`id`";
            DTSquad.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquad);
        }

        /// <summary>
        /// Фильтрация по дате отправки
        /// </summary>
        /// <param name="departureDate"></param>
        static public void FilterByDepartureDate(String departureDate)
        {
            DateTime date = Convert.ToDateTime(departureDate);
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Squad`.`id`" +
                ", `Squad`.`loginSquadLeader`" +
                ", CONCAT_WS(' '" +
                ", `User`.`surname`" +
                ", `User`.`firstName`" +
                ", `User`.`middleName`) " +
                "AS `fullName`" +
                ", `Squad`.`idLocality`" +
                ", `Squad`.`departureDate`" +
                ", `Squad`.`returnDate`" +
                ", `Squad`.`actualReturnDate` " +
                "FROM `Squad`" +
                ", `User`" +
                ", `Locality`" +
                ", `Position` " +
                "WHERE `Squad`.`loginSquadLeader` = `User`.`login` " +
                "AND `User`.`idPosition` = `Position`.`id` " +
                "AND `Position`.`name` = 'Начальник сейсмотряда' " +
                "AND `Squad`.`idLocality` = `Locality`.`id` " +
                "AND `Squad`.`departureDate` = '" + date.ToString("yyyy-MM-dd") + "' " +
                "ORDER BY `Squad`.`id`";
            DTSquad.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquad);
        }

        /// <summary>
        /// Фильтрация по дате возвращения
        /// </summary>
        /// <param name="returnDate"></param>
        static public void FilterByReturnDate(String returnDate)
        {
            DateTime date = Convert.ToDateTime(returnDate);
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Squad`.`id`" +
                ", `Squad`.`loginSquadLeader`" +
                ", CONCAT_WS(' '" +
                ", `User`.`surname`" +
                ", `User`.`firstName`" +
                ", `User`.`middleName`) " +
                "AS `fullName`" +
                ", `Squad`.`idLocality`" +
                ", `Squad`.`departureDate`" +
                ", `Squad`.`returnDate`" +
                ", `Squad`.`actualReturnDate` " +
                "FROM `Squad`" +
                ", `User`" +
                ", `Locality`" +
                ", `Position` " +
                "WHERE `Squad`.`loginSquadLeader` = `User`.`login` " +
                "AND `User`.`idPosition` = `Position`.`id` " +
                "AND `Position`.`name` = 'Начальник сейсмотряда' " +
                "AND `Squad`.`idLocality` = `Locality`.`id` " +
                "AND `Squad`.`returnDate` = '" + date.ToString("yyyy-MM-dd") + "' " +
                "ORDER BY `Squad`.`id`";
            DTSquad.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquad);
        }

        /// <summary>
        /// Фильтрация по фактической дате возвращения
        /// </summary>
        /// <param name="actualReturnDate"></param>
        static public void FilterByActualReturnDate(String actualReturnDate)
        {
            DateTime date = Convert.ToDateTime(actualReturnDate);
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `Squad`.`id`" +
                ", `Squad`.`loginSquadLeader`" +
                ", CONCAT_WS(' '" +
                ", `User`.`surname`" +
                ", `User`.`firstName`" +
                ", `User`.`middleName`) " +
                "AS `fullName`" +
                ", `Squad`.`idLocality`" +
                ", `Squad`.`departureDate`" +
                ", `Squad`.`returnDate`" +
                ", `Squad`.`actualReturnDate` " +
                "FROM `Squad`" +
                ", `User`" +
                ", `Locality`" +
                ", `Position` " +
                "WHERE `Squad`.`loginSquadLeader` = `User`.`login` " +
                "AND `User`.`idPosition` = `Position`.`id` " +
                "AND `Position`.`name` = 'Начальник сейсмотряда' " +
                "AND `Squad`.`idLocality` = `Locality`.`id` " +
                "AND `Squad`.`actualReturnDate` = '" + date.ToString("yyyy-MM-dd") + "' " +
                "ORDER BY `Squad`.`id`";
            DTSquad.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTSquad);
        }

        /// <summary>
        /// Добавление информации об отряде
        /// </summary>
        /// <param name="loginSquadLeader"></param>
        /// <param name="idLocality"></param>
        /// <param name="departureDate"></param>
        /// <param name="returnDate"></param>
        /// <param name="actualReturnDate"></param>
        /// <returns></returns>
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
                    "INSERT INTO `Squad` " +
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
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении отряда",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации об отряде
        /// </summary>
        /// <param name="id"></param>
        /// <param name="loginSquadLeader"></param>
        /// <param name="idLocality"></param>
        /// <param name="departureDate"></param>
        /// <param name="returnDate"></param>
        /// <param name="actualReturnDate"></param>
        /// <returns></returns>
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
                    "UPDATE `Squad` " +
                    "SET `loginSquadLeader` = '" + loginSquadLeader + "'" +
                    ", `idLocality` = '" + idLocality + "'" +
                    ", `departureDate` = '" + formatDepartureDate.
                    ToString("yyyy-MM-dd") + "'" +
                    ", `returnDate` = '" + formatReturnDate.
                    ToString("yyyy-MM-dd") + "'" +
                    ", `actualReturnDate` = '" + formatActualReturnDate.
                    ToString("yyyy-MM-dd") + "' " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении отряда",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации об отряде
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropSquad(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `Squad` " +
                    "WHERE `id` = '" + id + "'";
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
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении отряда",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Получение списка должностей
        /// </summary>
        /// <param name="idSquad"></param>
        /// <returns></returns>
        static public String GetPositionList(String idSquad)
        {
            String position = String.Empty;
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT DISTINCT `position`.`name` " +
                "FROM `position`" +
                ", `employee`" +
                ", `squadmember`" +
                ", `group`" +
                ", `squad` " +
                "WHERE `position`.`id` = `employee`.`idPosition` " +
                "AND `squadmember`.`idEmployee` = `employee`.`id` " +
                "AND `group`.id = `squadmember`.`idGroup` " +
                "AND `squad`.`id` = `group`.`idSquad` " +
                "AND `squad`.`id` = '" + idSquad + "'";
            using (MySqlDataReader reader = DBConnection.DBConnection.
                sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                    position += reader[0] + "\n";
                reader.Close();
            }
            return position;
        }
    }
}
