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
            Database db = new Database();

           using (SqlConnection connection = new SqlConnection(db.GetConnectionString())) {

                try
                {
                    String query_str = $"INSERT INTO Customer " +
                       $"VALUES ('{this.name}', '{this.street}', '{this.city}', '{this.state}', '{this.zip}', '{this.phoneNumber}', '{this.email}' )";

                    SqlCommand query = new System.Data.SqlClient.SqlCommand(query_str, connection);

                    query.ExecuteNonQuery();

                    MessageBox.Show("Customer has successfully been added");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }
            
        }
    }
}
