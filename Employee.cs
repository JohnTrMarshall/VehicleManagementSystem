using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string name { get; set; }
        public string userName { get; set; }

        

        public Employee()
        {

            name = userName = "";
            employeeID = 0;
        }
        
    }
}