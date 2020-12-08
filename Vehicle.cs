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
        public int vehicleID { get; set; }
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
            vehicleID = 0;
            vin = "";
            make = "";
            model = "";
            color = "";
            owner = "Dearborn Ford";
            holder = "";
            price = 0;
            mileage = 0;
            year = 0;
            returnDate = new DateTime(2000, 1, 1);
        }

        public Vehicle(int vehicleID, string vin, string make, string model, string color, string owner, string holder, float price, int mileage, int year, DateTime returnDate)
        {
            vehicleID = this.vehicleID;
            vin = this.vin;
            make = this.make;
            model = this.model;
            color = this.color;
            owner = this.owner;
            holder = this.owner;
            price = this.price;
            mileage = this.mileage;
            year = this.year;
            returnDate = this.returnDate;
        }


        public String getVin()
        {
            return this.vin;
        }

        public string getMake()
        {
            return this.make;
        }

        public string getModel()
        {
            return this.model;
        }

        public string getColor()
        {
            return this.color;
        }

        public string getOwner()
        {
            return this.owner;
        }

        public string getHolder()
        {
            return this.holder;
        }

        public float getPrice()
        {
            return this.price;

        }

        public int getMileage()
        {
            return this.mileage;
        }

        public int getYear()
        {
            return this.year;
        }

        public DateTime getReturnDate()
        {
            return this.returnDate;
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
                    $" VALUES ('({v.vin})', '({v.make})', '({v.model})', '({v.year})', '({v.color})', 'Dearborn Ford', '({v.holder})', '({v.returnDate})', '({v.price})', '({v.mileage})')");

                    
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

        public void removeVehicle(Vehicle v)
        {
            Vehicle nv = new Vehicle();

            Database db = new Database();

            using(SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            try
            {
                    connection.Open();

                    string v1 = ($"DELETE FROM Vehicle WHERE vin = ({v.vin})");
                    String query_str = v1;

                    SqlCommand query = new System.Data.SqlClient.SqlCommand(query_str, connection);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
        }
        public void sellVehicle()
        {
            Database db = new Database();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {

                connection.Open();

                String query_str = ($"UPDATE Vehicle SET owner='{this.owner}', holder='{this.owner}' WHERE vin='{this.vin}'");

                SqlCommand query = new SqlCommand(query_str, connection);

                if (query.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Error, no changes to database were made");
                }
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
