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
        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ahmed\\Source\\Repos\\VehicleManagementSystem\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public Database()
        {
            
        }

        public string GetConnectionString()
        {

            return connectionString;
        }

    }
}
