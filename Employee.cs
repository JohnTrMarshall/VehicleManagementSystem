using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zip { get; set; }
        private string phoneNumber { get; set; }
        private string eMail { get; set; }
        public string jobTitle { get; set; }


        public Employee()
        {

            
            userName = "";
            password = "";
            firstName = "";
            lastName = "";
            address = "";
            city = "";
            state = "";
            zip = "";
            phoneNumber = "";
            eMail = "";
            jobTitle = "";
            

        }

        public Employee(string userName, int employeeID, string password, string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail, string jobTitle)
        {
            userName = this.userName;
            employeeID = this.employeeID;
            password = this.password;
            firstName = this.firstName;
            lastName = this.lastName;
            address = this.address;
            city = this.city;
            state = this.state;
            zip = this.zip;
            phoneNumber = this.phoneNumber;
            eMail = this.eMail;
            jobTitle = this.jobTitle;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public int getEmployeeID()
        {
            return this.employeeID;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public string getAddress()
        {
            return this.address;
        }

        public string getCity()
        {
            return this.city;
        }

        public string getState()
        {
            return this.state;
        }

        public string getZip()
        {
            return this.zip;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public string getEmail()
        {
            return this.eMail;
        }

        public string getJobTitle()
        {
            return this.jobTitle;
        }

    }

}