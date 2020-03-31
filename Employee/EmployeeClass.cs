using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace LandSeismic.Employee
{
    class EmployeeClass
    {
        static public DataTable DTEmployee = new DataTable();

        static public void GetEmployeeList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT employee.id" +
                ", employee.surname" +
                ", employee.firstname" +
                ", employee.middlename" +
                ", employee.phone" +
                ", employee.address" +
                ", employee.contactPhone" +
                ", position.name " +
                "FROM employee" +
                ", position " +
                "WHERE employee.idPosition = position.id " +
                "AND employee.isDeleted = 0 " +
                "ORDER BY employee.surname";
            DTEmployee.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTEmployee);
        }

        static public Boolean AddEmployee(String surname, String firstName,
            String middleName, String phone, String address,
            String contactPhone, String position)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                "INSERT INTO employee " +
                "VALUES(NULL" +
                ", '" + surname + "'" +
                ", '" + firstName + "'" +
                ", '" + middleName + "'" +
                ", '" + phone + "'" +
                ", '" + address + "'" +
                ", '" + contactPhone + "'" +
                ", '" + position + "'" +
                ", '0')";
                if (DBConnection.DBConnection.sqlCommand.
                    ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при добавлении сотрудника. " + ex.Message,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean EditEmployee(String id, String surname,
            String firstName, String middleName, String phone, String address,
            String contactPhone, String position)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE employee " +
                    "SET surname = '" + surname + "'" +
                    ", firstName = '" + firstName + "'" +
                    ", middleName = '" + middleName + "'" +
                    ", phone = '" + phone + "'" +
                    ", address = '" + address + "'" +
                    ", contactPhone = '" + contactPhone + "'" +
                    ", idPosition = '" + position + "' " +
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
                    "Ошибка при изменении пользователя. " + ex.Message,
                    "Ошибка добавления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        static public Boolean DropEmployee(String id)
        {
            try
            {
                DBConnection.DBConnection.sqlCommand.CommandText =
                    "UPDATE employee " +
                    "SET isDeleted = 1 " +
                    "WHERE id = '" + id + "'";
                if (DBConnection.DBConnection.sqlCommand.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Ошибка при удаления пользователя. " + ex.Message,
                    "Ошибка удаления",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
