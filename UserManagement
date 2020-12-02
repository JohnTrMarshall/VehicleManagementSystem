using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace UserManagement
{
  public class UserManagement
  {
    private SqlConnection conn;
    private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\John\\Development\\VehicleManagementSystem\\VehicleManagementSystemDatabase.mdf;Initial Catalog=VehicleManagement;User ID=;Password=;
    
    public UserManagement()
    {
      this.conn = new SqlConnection(this.connectionString);
    }
    
    public bool createNewCustomer(Customer customer)
    {
      try
      {
        conn.Open();
        
        string firstName = customer.getfirstName();
        string lastName = customer.getlastName();
        string street = customer.getstreet();
        string city = customer.getcity();
        string state = customer.getstate();
        int zip = customer.getzip();
        int phoneNumber = customer.getphoneNumber();
        string email = customer.getemail();
    
        string insertString = $"INSERT INTO Customer " +
                              $"VALUES ('{firstName}','{lastName}','{street}','{city}','{state}','{zip}','{phoneNumber}','{email}')";
                              
        SqlCommand cmd = new SqlCommand(insertString, conn);
        
        cmd.ExecuteNonQuery();
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
    
    public bool createNewEmployee(Employee employee)
        {
            try
            {
                conn.Open();

                int employeeID = employee.getemployeeID();
                string name = employee.getname();
                string userName = employee.getuserName();
             
                string insertString = $"INSERT INTO Employee (employeeID, Name, userName)" +
                                      $"VALUES ('{employeeID}','{name}','{userName}')";

                SqlCommand cmd = new SqlCommand(insertString, conn);

                cmd.ExecuteNonQuery();
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
    
    public bool updateCustomerInformation(int customerId, string newFirstName, string newLastName, string newStreet, string newCity, string newState, int newZip, int newPhoneNumber, string newEmail)
    {
      try
      {
        conn.Open();
        
        string updateString = $"UPDATE Customer SET FirstName = '{newFirstName}', LastName = '{newLastNameName}', Street = '{newStreet}, City = '{newCity}', State = '{newState}', Zip = '{newZip}', PhoneNumber = '{newPhoneNumber}', Email = '{newEmail}' WHERE CustomerId = {customerId}";
        
        SqlCommand cmd = new SqlCommand(updateString, conn);
        
        cmd.ExecuteNonQuery();
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
