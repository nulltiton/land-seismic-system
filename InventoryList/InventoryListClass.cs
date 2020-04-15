using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace LandSeismic.InventoryList
{
    class InventoryListClass
    {
        static public DataTable DTInventoryList = new DataTable();
        static public DataTable DTResourceInListList = new DataTable();

        static public void GetInventoryList(String login)
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `inventorylist`.`id`" +
                ", `inventorylist`.`idsquad`" +
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
                "AND `inventorylist`.`logingeologist` = '" + login + "'";
            DTInventoryList.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTInventoryList);
        }

        static public void GetResourceInList(String idList)
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `resourceinlist`.`idList`" +
                ", `resourceinlist`.`idResource`" +
                ", `materialandtechnicalresource`.`name`" +
                ", `resourceinlist`.`amount` " +
                "FROM `resourceinlist`" +
                ", `materialandtechnicalresource` " +
                "WHERE `resourceinlist`.`idResource` = " +
                "`materialandtechnicalresource`.`id` " +
                "AND `resourceinlist`.`idList` = '" + idList + "'" +
                "ORDER BY `materialandtechnicalresource`.`name`";
            DTResourceInListList.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTResourceInListList);
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
                    "Ошибка при изменении перечня материально-технических " +
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
            catch (MySqlException)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Невозможно удалить перечень, в котором находятся ресурсы",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при удалении перечня материально-технических " +
                    "ресуров. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean CreateInventoryList(String idSquad, 
            String loginGeologist)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT COUNT(`id`) " +
                    "FROM `inventorylist` " +
                    "WHERE `idSquad` = '" + idSquad + "'";

                if (Convert.ToInt32(DBConnection.DBConnection.sqlCommand.
                    ExecuteScalar()) == 0)
                {
                    #region Создать запись в InventoryList 

                    DateTime creationDate = DateTime.Now;
                    DBConnection.DBConnection.sqlCommand.CommandText =
                        "INSERT INTO `InventoryList` " +
                        "VALUES(NULL" +
                        ", '" + idSquad + "'" +
                        ", '" + loginGeologist + "'" +
                        ", '" + creationDate.ToString("yyyy-MM-dd") + "')";

                    #endregion

                    if (DBConnection.DBConnection.sqlCommand.
                        ExecuteNonQuery() > 0)
                    {
                        #region Записать в переменную id inventory list

                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT LAST_INSERT_ID()" +
                            "FROM `inventorylist`";
                        Int32 idInventoryList = Convert.ToInt32(DBConnection.
                            DBConnection.sqlCommand.ExecuteScalar());

                        #endregion

                        #region Записать в переменную количество дней

                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT DATEDIFF(`squad`.`returnDate`" +
                            ", `squad`.`departureDate`) " +
                            "FROM `inventorylist`" +
                            ", `squad` " +
                            "WHERE `squad`.`id` = `inventorylist`.`idSquad` " +
                            "AND `squad`.`id` = '" + idSquad + "'";
                        Int32 dateCount = Convert.ToInt32(DBConnection.
                            DBConnection.sqlCommand.ExecuteScalar());

                        #endregion

                        #region Записать в переменную количество членов отряда

                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT COUNT(`squadmember`.`id`) " +
                            "FROM `squadmember`" +
                            ", `group`" +
                            ", `squad`" +
                            ", `inventorylist` " +
                            "WHERE `squadmember`.`idGroup` = `group`.`id` " +
                            "AND `group`.`idSquad` = `squad`.`id` " +
                            "AND `inventorylist`.`idSquad` = `squad`.`id`" +
                            "AND `inventorylist`.`idSquad` = " +
                            "'" + idSquad + "'";
                        Int32 memberCount = Convert.ToInt32(DBConnection.
                            DBConnection.sqlCommand.ExecuteScalar());

                        #endregion

                        #region Записать в переменную тип местности

                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT `locality`.`idLocalityType` " +
                            "FROM `locality`" +
                            ", `squad`" +
                            ", `inventorylist` " +
                            "WHERE `inventorylist`.`idSquad` = `squad`.`id` " +
                            "AND `squad`.`idLocality` = `locality`.`id` " +
                            "AND `squad`.`id` = '" + idSquad + "'";
                        Int32 localityType = Convert.ToInt32(DBConnection.
                            DBConnection.sqlCommand.ExecuteScalar());
                        #endregion

                        #region Записать в лист ресурсы для местности и их количество

                        var localityStandartId = new List<String>();
                        var localityStandartAmount = new List<String>();

                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT `idResource`" +
                            ", `amount` " +
                            "FROM `localityStandart` " +
                            "WHERE `idLocality` = " +
                            "'" + localityType + "'";

                        using (MySqlDataReader reader = DBConnection.
                            DBConnection.sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                localityStandartId.Add(reader[0].ToString());
                                localityStandartAmount.Add(reader[1].
                                    ToString());
                            }
                            reader.Close();
                        }

                        #endregion

                        #region Добавить ресурсы по типу местности и их количество

                        for (Int32 i = 0; i < localityStandartId.Count; i++)
                        {
                            DBConnection.DBConnection.sqlCommand.CommandText =
                                "INSERT INTO `resourceinlist` VALUES(" +
                                "'" + localityStandartId[i] + "'" +
                                ", '" + idInventoryList + "'" +
                                ", '" + Convert.ToInt32(localityStandartAmount[i]) * memberCount + "')";
                            DBConnection.DBConnection.sqlCommand.
                                ExecuteNonQuery();
                        }
                        #endregion

                        #region Записать в лист должности участников

                        var position = new List<String>();
                        DBConnection.DBConnection.sqlCommand.CommandText =
                            "SELECT `employee`.`idPosition` " +
                            "FROM `employee`" +
                            ", `squadmember`" +
                            ", `group`" +
                            ", `squad`" +
                            ", `inventorylist` " +
                            "WHERE `squadmember`.`idEmployee` = " +
                            "`employee`.`id` " +
                            "AND `squadmember`.`idGroup` = `group`.`id` " +
                            "AND `group`.`idSquad` = `squad`.`id` " +
                            "AND `inventorylist`.`idSquad` = `squad`.`id`" +
                            "AND `group`.`idSquad` = '" + idSquad + "'";
                        using (MySqlDataReader reader = DBConnection.
                            DBConnection.sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                                position.Add(reader[0].ToString());
                            reader.Close();
                        }

                        #endregion

                        #region Записать в лист ресурсы для должности и их количество

                        var positionStandartId = new List<String>();
                        var positionStandartAmount = new List<String>();
                        
                        for (Int32 i = 0; i < position.Count; i++)
                        {
                            DBConnection.DBConnection.sqlCommand.CommandText =
                                "SELECT `idResource`" +
                                ", `amount` " +
                                "FROM `positionStandart` " +
                                "WHERE `idPosition` = " +
                                "'" + position[i] + "'";

                            using (MySqlDataReader reader = DBConnection.
                                DBConnection.sqlCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    positionStandartId.Add(reader[0].
                                        ToString());
                                    positionStandartAmount.Add(reader[1].
                                        ToString());
                                }
                                reader.Close();
                            }
                        }

                        #endregion

                        #region Добавить ресурсы по должности и их количество

                        for (Int32 i = 0; i < positionStandartId.Count; i++)
                        {
                            DBConnection.DBConnection.sqlCommand.CommandText =
                                "SELECT `isConsumable` " +
                                "FROM `materialandtechnicalresource` " +
                                "WHERE `id` = " +
                                "'" + positionStandartId[i] + "'";

                            positionStandartAmount[i] = Convert.ToBoolean
                                (DBConnection.DBConnection.sqlCommand.
                                ExecuteScalar()) ? (Convert.ToInt32(
                                    positionStandartAmount[i]) * dateCount).
                                    ToString()
                                    : positionStandartAmount[i];

                            DBConnection.DBConnection.sqlCommand.CommandText =
                                "SELECT COUNT(`idResource`) " +
                                "FROM `resourceinlist` " +
                                "WHERE `idResource` = " +
                                "'" + positionStandartId[i] + "' " +
                                "AND `idList` = '" + idInventoryList + "'";

                            if (Convert.ToInt32(DBConnection.DBConnection.
                                sqlCommand.ExecuteScalar()) == 0)
                            {
                                DBConnection.DBConnection.sqlCommand.CommandText =
                                    "INSERT INTO `resourceinlist` VALUES(" +
                                    "'" + positionStandartId[i] + "'" +
                                    ", '" + idInventoryList + "'" +
                                    ", '" + positionStandartAmount[i] + "')";
                                DBConnection.DBConnection.sqlCommand.
                                    ExecuteNonQuery();
                            }
                            else if (Convert.ToInt32(DBConnection.DBConnection.
                                sqlCommand.ExecuteScalar()) > 0)
                            {
                                DBConnection.DBConnection.sqlCommand.CommandText =
                                    "UPDATE `resourceinlist` " +
                                    "SET amount = amount + " +
                                    "'" + positionStandartAmount[i] + "' " +
                                    "WHERE `idList` = " +
                                    "'" + idInventoryList + "' " +
                                    "AND `idResource` = " +
                                    "'" + positionStandartId[i] + "'";
                                DBConnection.DBConnection.sqlCommand.
                                ExecuteNonQuery();
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show(
                                    "Ошибка при оформлении перечня " +
                                    "материально-технических ресуров.",
                                    "Ошибка добавления",
                                    System.Windows.Forms.MessageBoxButtons.OK,
                                    System.Windows.Forms.MessageBoxIcon.Error);
                                return false;
                            }
                        }

                        #endregion
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "Ошибка при оформлении перечня " +
                            "материально-технических ресуров. ",
                            "Ошибка добавления",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Данный отряд уже собран.",
                        "Ошибка добавления",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при оформлении перечня материально-технических " +
                    "ресуров. " + ex,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DocumentInventoryList(String idList,
            String idSquad, String departureDateValue, String returnDateValue,
            String path)
        {
            try
            {
                var Resource = new List<String>();
                var Amount = new List<String>();
                DateTime departureDate = Convert.ToDateTime(departureDateValue);
                DateTime returnDate = Convert.ToDateTime(returnDateValue);

                DBConnection.DBConnection.sqlCommand.CommandText =
                    "SELECT `idResource`" +
                    ", `Amount` " +
                    "FROM `resourceinlist` " +
                    "WHERE `idList` = '" + idList + "'";

                using (MySqlDataReader reader = DBConnection.DBConnection.
                    sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Resource.Add(reader[0].ToString());
                        Amount.Add(reader[1].ToString());
                    }
                    reader.Close();
                }

                FileStream fileStream = new FileStream(path, FileMode.Create, 
                    FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream, 
                    Encoding.UTF8);

                streamWriter.WriteLine(
                    "Перечень материально-технических ресурсов");
                streamWriter.WriteLine(";ОАО МАГЭ");
                streamWriter.WriteLine(";для отряда №" + idSquad);
                streamWriter.WriteLine(";с " + departureDate.
                    ToString("dd.MM.yyyy") + " по " + returnDate.
                    ToString("dd.MM.yyyy"));

                for (Int32 i = 0; i < Resource.Count; i++)
                    streamWriter.WriteLine(";" + Resource[i] + ";" + 
                        Amount[i] + ";");

                streamWriter.WriteLine(";;;;________");
                streamWriter.WriteLine(";;;;подпись");
                streamWriter.Close();
                fileStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при создании документа. " + ex,
                    "Ошибка создания документа",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public String DepartureDateBySquad(String id)
        {
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `squad`.`departureDate` " +
                "FROM `InventoryList`" +
                ", `Squad` " +
                "WHERE `inventorylist`.`idSquad` = `Squad`.`id` " +
                "AND `squad`.`id` = '" + id + "'";
            return DBConnection.DBConnection.sqlCommand.ExecuteScalar().
                ToString();
        }

        static public String ReturnDateBySquad(String id)
        {
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT `squad`.`returnDate` " +
                "FROM `InventoryList`" +
                ", `Squad` " +
                "WHERE `inventorylist`.`idSquad` = `Squad`.`id` " +
                "AND `squad`.`id` = '" + id + "'";
            return DBConnection.DBConnection.sqlCommand.ExecuteScalar().
                ToString();
        }
    }
}
