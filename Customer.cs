using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    class Customer
    {

        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        private string name { get; set; }
        private string street { get; set; }
        private string city { get; set; }
        private string state { get; set;  }
        private string zip { get; set; }
        private string phoneNumber { get; set;  }
        private string email { get; set; }

        Customer()
        {
            name = street = city = state = zip = phoneNumber = email = "";
        }

        void addCustomer(Customer C)
        {
           using (SqlConnection connection = new SqlConnection(connectionString)) {

                try
                {
                    connection.Open();

                    SqlCommand query = new System.Data.SqlClient.SqlCommand($"INSERT INTO Customer " +
                    $" VALUES ({C.name}, {C.street}< {C.city}, {C.state}< {C.zip}< {C.phoneNumber}, {C.email})");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }
            
        }
    }
}
