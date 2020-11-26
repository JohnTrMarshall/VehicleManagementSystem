using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{

    class Vehicle
    {
        private String vin { get; set; }
        private String make { get; set; }
        private String model { get; set; }
        private String color { get; set; }
        private String owner { get; set; }
        private String holder { get; set; }
        private float price { get; set; }
        private int mileage { get; set; }
        private int year{ get; set; }
        private DateTime returnDate { get; set; }

        public Vehicle()
        {
            vin = make = model = color = owner = holder = "";
            price = 0;
            mileage = year = 0;
            returnDate = new DateTime(2000, 1, 1);
        }
        public void addVehicle(Vehicle v)
        {

            Database db = new Database();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                Vehicle nv = new Vehicle();

                try
                {
                    connection.Open();

                    String query_str = ($"INSERT INTO Vehicle " +
                    $" VALUES ({v.vin}, {v.make}< {v.model}, {v.year}< {v.color}< {v.owner}, {v.holder}, {v.returnDate}, {v.price}, {v.mileage})");

                    
                    SqlCommand query = new System.Data.SqlClient.SqlCommand(query_str, connection);

                    query.ExecuteNonQuery();

                    MessageBox.Show("Vehicle has successfully been added");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }     // end sql connection       
        }

        public void removeVehicle()
        {
            
        }
    }
}
