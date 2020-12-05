using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    public class Customer
    {
                                                    
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set;  }
        public string zip { get; set; }
        public string phoneNumber { get; set;  }
        public string email { get; set; }

        public Customer()
        {
            firstName = lastName = street = city = state = zip = phoneNumber = email = "";
        }
        public Customer(string firstName, string lastName, string street, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
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

                    connection.Open();

                    String query_str = $"INSERT INTO Customer " +
                       $"VALUES ('{this.firstName}', '{this.lastName}', '{this.street}', '{this.city}', '{this.state}', '{this.zip}', '{this.phoneNumber}', '{this.email}' )";

                    SqlCommand query = new System.Data.SqlClient.SqlCommand(query_str, connection);

                    query.ExecuteNonQuery();

                 }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }
            
        }
    }
}
