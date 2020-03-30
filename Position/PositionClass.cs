using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace LandSeismic.Position
{
    class PositionClass
    {
        static public DataTable dtPosition = new DataTable();

        static public void GetPositionList()
        {
            DBConnection.DBConnection.sqlDataAdapter =
                new MySqlDataAdapter(DBConnection.DBConnection.sqlCommand);
            DBConnection.DBConnection.sqlCommand.CommandText =
                "SELECT * " +
                "FROM position " +
                "ORDER BY name";
            dtPosition.Clear();
            DBConnection.DBConnection.sqlDataAdapter.Fill(dtPosition);
        }
    }
}
