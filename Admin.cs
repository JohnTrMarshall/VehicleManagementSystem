using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    public class Admin
    {
        private SqlConnection conn;
        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Cheikh\\OneDrive\\Documents\\VehicleManagementSystem-main\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        
        public Admin()
        {
            this.conn = new SqlConnection(this.connectionString);
        }

        public bool addEmployee(Employee employee)
        {
            
            try
            {
                conn.Open();

                string firstName = employee.getFirstName();
                string lastName = employee.getLastName();
                string street = employee.getAddress();
                string city = employee.getCity();
                string state = employee.getState();
                string zip = employee.getZip();
                string phoneNum = employee.getPhoneNumber();
                string emailAdd = employee.getEmail();
                string password = employee.getPassword();
                string userName = employee.getUserName();
                string jobTitle = employee.getJobTitle();

                string insertString = $"INSERT INTO Employee (firstName,lastName,street,city,state,zip,phoneNumber,email,password,jobTitle,userName)" +
                                      $"VALUES ('{firstName}','{lastName}','{street}','{city}','{state}','{zip}','{phoneNum}','{emailAdd}','{password}','{jobTitle}','{userName}')";

                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error, failed to connect to database");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }  
            return true;
        }

        public bool DeleteEmployee(Employee employee)
        {
            
            try
            {
                conn.Open();
                

                int employeeID = employee.getEmployeeID();

                string deleteString = $"Delete From Employee Where employeeID = {employeeID}";

                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error, not functioning properly");
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }

        public Dictionary<int,Employee> getEmployeeData()
        {
            Dictionary<int, Employee> datalist = new Dictionary<int, Employee>();
            SqlDataReader rdr = null; //for reading data

            try
            {
                this.conn.Open();
                SqlCommand getEmployees = new SqlCommand("SELECT * FROM Employee", this.conn); //Sql command to get all employees

                rdr = getEmployees.ExecuteReader(); //execute command

                while(rdr.Read()) //Loop through every entry in the table
                {
                    int employeeID = (int)rdr[0];
                    string fName = (string)rdr[1];
                    string street = (string)rdr[2];
                    string city = (string)rdr[3];
                    string state = (string)rdr[4];
                    string zip = (string)rdr[5];
                    string phoneNum = (string)rdr[6];
                    string email = (string)rdr[7];
                    string password = (string)rdr[8];
                    string jobTitle = (string)rdr[9];
                    string userName = (string)rdr[10];
                    string lName = (string)rdr[11];

                    Employee employee = new Employee(userName, employeeID, password, fName, lName, street, city, state, zip, phoneNum, email, jobTitle);

                    datalist.Add(employeeID, employee); //add employee object to the dictionary
                }
            }
            catch
            {
                MessageBox.Show("Error, failed to get list of employees");
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();        //close data reader

                if (this.conn != null)
                    this.conn.Close();  // close connection
            }
            return datalist;
        }

        public void updateEmployeeInfo(Employee employee)
        {
            string firstName = employee.getFirstName();
            string lastName = employee.getLastName();
            int employeeID = employee.getEmployeeID();
            string street = employee.getAddress();
            string city = employee.getCity();
            string state = employee.getState();
            string zip = employee.getZip();
            string phoneNum = employee.getPhoneNumber();
            string emailAdd = employee.getEmail();
            string password = employee.getPassword();
            string userName = employee.getUserName();
            string jobTitle = employee.getJobTitle();

            try
            {
                conn.Open();

                string updateString = $"UPDATE Employee SET firstName ='{firstName}', street= '{street}', city= '{city}', state= '{state}', zip= '{zip}', phoneNumber= '{phoneNum}', email = '{emailAdd}', password= '{password}', jobTitle= '{jobTitle}', userName ='{userName}', lastName= '{lastName}' WHERE employeeID = '{employeeID}'";

                SqlCommand cmd = new SqlCommand(updateString, conn);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error, failed to connect to database");
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
            
        }

        public bool addVehicle(Vehicle vehicle)
        {
           
            try
            { 
                conn.Open();
                string vin = vehicle.getVin();
                string make = vehicle.getMake();
                string model = vehicle.getModel();
                int year = vehicle.getYear();
                string color = vehicle.getColor();
                string owner = "Dearborn Ford";
                string holder = vehicle.getHolder();
                float price = vehicle.getPrice();
                int mileage = vehicle.getMileage();
               

                string insertString = $"INSERT INTO Vehicle (vin,make,model,year,color,owner,holder,price,mileage)" +
                                      $"VALUES ('{vin}','{make}','{model}',{year},'{color}','{owner}','{holder}',{price}, {mileage})";

                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error, failed to connect to database");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }

        public bool DeleteVehicle(String vin)
        {
            
            
            Vehicle vehicle;

            try
            {
                conn.Open();
                SqlCommand deleteVehicle = new SqlCommand("SELECT *FROM Vehicle", this.conn);

                string deleteString = $"DELETE From Vehicle WHERE vin = '{vin}'";

                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error, failed to connect to database");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }

        public bool updateVehicleInfo(Vehicle vehicle)
        {
            string vin = vehicle.getVin();
            string make = vehicle.getMake();
            string model = vehicle.getModel();
            int year = vehicle.getYear();
            string color = vehicle.getColor();
            string owner = "Dearborn Ford";
            string holder = vehicle.getHolder();
            float price = vehicle.getPrice();
            int mileage = vehicle.getMileage();
            DateTime returnDate = vehicle.getReturnDate();

            try
            {
                conn.Open();

                string updateString = $"UPDATE Vehicle SET make = '{make}', model= '{model}', year= {year}, color= '{color}', owner='{owner}', holder= '{holder}', returnDate= '{returnDate}', price= {price}, mileage= {mileage} WHERE vin= '{vin}'";

                SqlCommand cmd = new SqlCommand(updateString, conn);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error, failed to connect to database");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }

        public Dictionary<int, Vehicle> getVehicleData()
        {
            Dictionary<int, Vehicle> datalist = new Dictionary<int, Vehicle>(); //empty list of vehicles

            SqlDataReader rdr = null; //for reading data

            try
            {
                conn.Open(); //Open the SQL connection

                SqlCommand getVehicleInfo = new SqlCommand("SELECT * FROM Vehicle", this.conn);

                rdr = getVehicleInfo.ExecuteReader();
                
                while (rdr.Read())
                {
                    int vehicleID = (int)rdr[0];
                    string vin = (string)rdr[1];
                    string make = (string)rdr[2];
                    string model = (string)rdr[3];
                    int year = (int)rdr[4];
                    string color = (string)rdr[5];
                    string owner = (string)rdr[6];
                    string holder = (rdr[7] != DBNull.Value) ? (string)rdr[7] : "";
                    DateTime returnDate = new DateTime(2021, 1, 1);
                    float price = Convert.ToSingle(rdr[9]);
                    int mileage = (int)rdr[10];

                    Vehicle vehicle = new Vehicle(vehicleID, vin, make, model, color, owner, holder, price, mileage, year, returnDate); //Create Vehicle data object

                    datalist.Add(vehicleID, vehicle);
                }
            }
            catch
            {
                MessageBox.Show("Error, failed to extract Vehicle data");
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }
                if(this.conn != null)
                {
                    this.conn.Close();
                }
            }
            return datalist; //return the list of data
        }



    }
}
