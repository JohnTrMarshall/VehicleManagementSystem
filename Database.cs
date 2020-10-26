using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    public class Database
    {
        private String connectionString;

        public Database()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\John\\source\\repos\\VehicleManagementSystem\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public SqlConnection Connect()
        {

           return new SqlConnection(connectionString);
        }

    }
}
