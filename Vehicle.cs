using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{

    public class Vehicle
    {
        public String vin { get; set; }
        public String make { get; set; }
        public String model { get; set; }
        public String color { get; set; }
        public String owner { get; set; }
        public String holder { get; set; }
        public float price { get; set; }
        public int mileage { get; set; }
        public int year{ get; set; }
        public DateTime returnDate { get; set; }

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
