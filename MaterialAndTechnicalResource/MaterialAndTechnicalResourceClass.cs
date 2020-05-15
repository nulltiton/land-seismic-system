using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.MaterialAndTechnicalResource
{
    /// <summary>
    /// Класс материально-технических ресурсов
    /// </summary>
    class MaterialAndTechnicalResourceClass
    {
        static public DataTable DTMaterialAndTechnicalResource = 
            new DataTable();

        /// <summary>
        /// Заполнение таблицы информацией о материально-технических ресурсах
        /// </summary>
        static public void GetMaterialAndTechnicalResourceList()
        {
            DBConnection.DBConnection.sqlDataAdapter = new MySqlDataAdapter(
                DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM `MaterialAndTechnicalResource` " +
                "ORDER BY `name`";
            DTMaterialAndTechnicalResource.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(
                DTMaterialAndTechnicalResource);
        }

        /// <summary>
        /// Добавление информации о материально-технических ресурсах
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isConsumableValue"></param>
        /// <returns></returns>
        static public Boolean AddMaterialAndTechnicalResource(String name, 
            Boolean isConsumableValue)
        {
            try
            {
                String isConsumable = isConsumableValue ? "1" : "0";
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "INSERT INTO `MaterialAndTechnicalResource` " +
                    "VALUES(NULL" +
                    ", '" + name + "'" +
                    ", '" + isConsumable + "')";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении материально-тезнического ресурса",
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Редактирование информации о материально-технических ресурсах
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="isConsumableValue"></param>
        /// <returns></returns>
        static public Boolean EditMaterialAndTechnicalResource(String id, 
            String name, Boolean isConsumableValue)
        {
            try
            {
                String isConsumable = isConsumableValue ? "1" : "0";
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE `MaterialAndTechnicalResource` " +
                    "SET `name` = '" + name + "'" +
                    ", `isConsumable` = '" + isConsumable + "' " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                  "Ошибка при изменении материально-технического ресурса",
                  "Ошибка изменения",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Удаление информации о материально-технических ресурсах
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Boolean DropMaterialAndTechnicalResource(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "DELETE FROM `MaterialAndTechnicalResource` " +
                    "WHERE `id` = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show(
                   "Ошибка при удалении материально-технического ресурса",
                   "Ошибка удаления",
                   System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
