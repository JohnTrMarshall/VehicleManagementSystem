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
                                                    
        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\John\\Development\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        private string name { get; set; }
        private string street { get; set; }
        private string city { get; set; }
        private string state { get; set;  }
        private string zip { get; set; }
        private string phoneNumber { get; set;  }
        private string email { get; set; }

        public Customer()
        {
            name = street = city = state = zip = phoneNumber = email = "";
        }
        public Customer(string name, string street, string city, string state, string zip, string phoneNumber, string email)
        {
            this.name = name;
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public void AddCustomer()
        {
           using (SqlConnection connection = new SqlConnection(connectionString)) {


                connection.Open();

                String query_Str = $"INSERT INTO Customer " +
                    $"VALUES ('{this.name}', '{this.street}', '{this.city}', '{this.state}', '{this.zip}', '{this.phoneNumber}', '{this.email}' )";

                MessageBox.Show(query_Str);

                SqlCommand query = new System.Data.SqlClient.SqlCommand(query_Str, connection);

                int rowsChanged = query.ExecuteNonQuery();

                MessageBox.Show(rowsChanged + " Customer has successfully been added");

                try
                {
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }
            
        }
    }
}
