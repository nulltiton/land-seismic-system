using MySql.Data.MySqlClient;
using System.Data;

namespace LandSeismic.Position
{
    class PositionClass
    {
        static public DataTable DTPosition = new DataTable();

        static public void GetPositionListForUser()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM position " +
                "WHERE name = 'Геолог' " +
                "OR name = 'Начальник сейсмотряда' " +
                "OR name = 'Ведущий геолог' " +
                "ORDER BY name";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }

        static public void GetPositionListForEmployee()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM position " +
                "WHERE name <> 'Геолог' " +
                "AND name <> 'Начальник сейсмотряда' " +
                "AND name <> 'Ведущий геолог' " +
                "ORDER BY name";
            DTPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(DTPosition);
        }
    }
}
