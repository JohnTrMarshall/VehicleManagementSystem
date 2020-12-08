using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Collections.Generic;

namespace VehicleManagementSystem
{
    public partial class Admin_Form : Form
    { 
       public Admin admin;

       public Dictionary<int, Employee> employees;
       public Dictionary<int, Vehicle> vehicles;

   
        
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            admin = new Admin(); //instance of admin database

            employees = admin.getEmployeeData(); //Get a list of all employees
            
            foreach (var pair in employees)
            {
                employeeIDListBox.Items.Add($"{pair.Value.getEmployeeID()}  {pair.Value.getFirstName()}  {pair.Value.getLastName()}");
                modifyEmployeeListBox.Items.Add($"{pair.Value.getEmployeeID()} {pair.Value.getFirstName()} {pair.Value.getLastName()}");

                
            }

            vehicles = admin.getVehicleData(); //Get a list of all vehicles

            foreach(var pair in vehicles)
            {
                vehicleListBox.Items.Add($"{pair.Value.getVin()}");
                modifyVehicleListBox.Items.Add($"{pair.Value.getVin()}");
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            Employee employee;
            int employeeId;

            string employeeItem = employeeIDListBox.SelectedItem.ToString();
            employeeId = Convert.ToInt32(employeeItem.Substring(0, employeeItem.IndexOf(' ')));
            employee = new Employee(null, employeeId, null, null, null, null, null, null, null, null, null, null);
            this.admin.DeleteEmployee(employee);
            employees = this.admin.getEmployeeData();

            employeeIDListBox.Items.Clear();
            modifyEmployeeListBox.Items.Clear();
            //Clear List

            foreach(var pair in employees)
            {
                employeeIDListBox.Items.Add($"{pair.Value.getEmployeeID()} {pair.Value.getFirstName()} {pair.Value.getLastName()}");
                modifyEmployeeListBox.Items.Add($"{pair.Value.getEmployeeID()} {pair.Value.getFirstName()} {pair.Value.getLastName()}");
            }

            employeeIDListBox.Update();
            modifyEmployeeListBox.Update();
        }

        private void modifyUser_Button_Click(object sender, EventArgs e)
        {
            admin = new Admin();
            Employee employee;

            string employeeItem = modifyEmployeeListBox.SelectedItem.ToString();
            int employeeId = Convert.ToInt32(employeeItem.Substring(0, employeeItem.IndexOf(' ')));

            string firstName = modifyFirstName.Text;
            string address = modifyAddress.Text;
            string city = modifyCity.Text;
            string state = modifyState.Text;
            string zip = modifyZip.Text;
            string phoneNumber = modifyPhoneNumber.Text;
            string email = modifyEmail.Text;
            string password = modifyPassword.Text;
            string jobTitle = modifyJobTitle.Text;
            string username = modifyUsername.Text;
            string lastName = modifyLastName.Text;

            employee = new Employee(username, employeeId, password, firstName, lastName, address, city, state, zip, phoneNumber, email, jobTitle);
            this.admin.updateEmployeeInfo(employee);
            employees = admin.getEmployeeData();

            modifyEmployeeListBox.Items.Clear();
            employeeIDListBox.Items.Clear();

            foreach (var pair in employees)
            {
                employeeIDListBox.Items.Add($"{pair.Value.getEmployeeID()} {pair.Value.getFirstName()} {pair.Value.getLastName()}");
                modifyEmployeeListBox.Items.Add($"{pair.Value.getEmployeeID()} {pair.Value.getFirstName()} {pair.Value.getLastName()}");
            }

            employeeIDListBox.Update();
            modifyEmployeeListBox.Update();

        }

        private void addVehicleButton(object sender, EventArgs e)
        {
            admin = new Admin();
            Vehicle vehicle;

            string vin = addVin.Text;
            string make = addMake.Text;
            string model = addModel.Text;
            string color = addColor.Text;
            string owner = "Dearborn Ford";
            string holder = "Dearborn Ford";
            string thePrice = addPrice.Text;
            float price = float.Parse(thePrice);
            string miles = addMileage.Text;
            int mileage = Convert.ToInt32(miles);
            string theYear = addYear.Text;
            int year = Convert.ToInt32(theYear);
            DateTime returnDate = new DateTime(2000, 1, 1);

            vehicle = new Vehicle(1, vin, make, model, color, owner, holder, price, mileage, year, returnDate);
            this.admin.addVehicle(vehicle);
            vehicles = admin.getVehicleData();

            modifyVehicleListBox.Items.Clear();
            vehicleListBox.Items.Clear();

            foreach(var pair in vehicles)
            {
                modifyVehicleListBox.Items.Add($"{pair.Value.getVin()}");
                vehicleListBox.Items.Add($"{pair.Value.getVin()}");
            }
            modifyVehicleListBox.Update();
            vehicleListBox.Update();
        }

        private void deleteVehicle_Button_Click(object sender, EventArgs e)
        { 
            string vin = vehicleListBox.SelectedItem.ToString();
            this.admin.DeleteVehicle(vin);
            vehicles = admin.getVehicleData();

            modifyVehicleListBox.Items.Clear();
            vehicleListBox.Items.Clear();

            foreach (var pair in vehicles)
            {
                modifyVehicleListBox.Items.Add($"{pair.Value.getVin()}");
                vehicleListBox.Items.Add($"{pair.Value.getVin()}");
            }
            modifyVehicleListBox.Update();
            vehicleListBox.Update();
        }

        private void modifyVehicleButton(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }



        private void addEmployeeButton(object sender, EventArgs e)
        {
            admin = new Admin();
            Employee employee;

            
            string fName = addFname.Text;
            string lName = addLname.Text;
            string address = addAddress.Text;
            string city = addCity.Text;
            string state = addState.Text;
            string zip = addZIP.Text;
            string pNum = addPnumber.Text;
            string email = addEmail.Text;
            string username = addUsername.Text;
            string password = addPassword.Text;
            string job = addJobTitle.Text;
            

            employee = new Employee(username, 1, password, fName, lName, address, city, state, zip, pNum, email, job);
            this.admin.addEmployee(employee);
            employees = admin.getEmployeeData();

            employeeIDListBox.Items.Clear();
            modifyEmployeeListBox.Items.Clear();

            foreach (var pair in employees)
            {
                    employeeIDListBox.Items.Add($"{pair.Value.getEmployeeID()}  {pair.Value.getFirstName()}  {pair.Value.getLastName()}");
                    modifyEmployeeListBox.Items.Add($"{pair.Value.getEmployeeID()}  {pair.Value.getFirstName()} {pair.Value.getLastName()}");
            }

            employeeIDListBox.Update();
            modifyEmployeeListBox.Update();
        }
        private void addFirstNameTextbox(object sender, EventArgs e)
        {
            

        }

        private void addLastNameTextBox(object sender, EventArgs e)
        {

        }

        private void addCityTextbox(object sender, EventArgs e)
        {

        }

        private void addStateTextbox(object sender, EventArgs e)
        {

        }

        private void addZipTextbox(object sender, EventArgs e)
        {

        }

        private void addPhoneNumTextbox(object sender, EventArgs e)
        {

        }

        private void addEmailTextbox(object sender, EventArgs e)
        {

        }

        private void addUsernameTextbox(object sender, EventArgs e)
        {

        }

        private void addPasswordTextbox(object sender, EventArgs e)
        {

        }

        private void addJobTitleTextbox(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeTextbox(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeButton(object sender, EventArgs e)
        {

        }

        private void addVINTextbox(object sender, EventArgs e)
        {

        }

        private void addMakeTextbox(object sender, EventArgs e)
        {

        }

        private void addModelTextbox(object sender, EventArgs e)
        {

        }

        private void addYearTextbox(object sender, EventArgs e)
        {

        }

        private void addColorTextbox(object sender, EventArgs e)
        {

        }

        private void modifyMakeTextbox(object sender, EventArgs e)
        {

        }

        private void ModifyModelTextbox(object sender, EventArgs e)
        {

        }

        private void modifyYearTextbox(object sender, EventArgs e)
        {

        }

        private void modifyColorTextbox(object sender, EventArgs e) { }
        private void modifyFnameTextbox(object sender, EventArgs e)
        {

        }

        private void modifyLnameTextbox(object sender, EventArgs e)
        {

        }

        private void modifyAddressTextbox(object sender, EventArgs e)
        {

        }

        private void modifyCityTextbox(object sender, EventArgs e)
        {

        }

        private void ModifyStateTextbox(object sender, EventArgs e)
        {

        }

        private void modifyZIPTextbox(object sender, EventArgs e)
        {

        }

        private void modifyPnumberTextbox(object sender, EventArgs e)
        {

        }

        private void ModifyEmailTextbox(object sender, EventArgs e)
        {

        }

        private void modifyUsernameTextbox(object sender, EventArgs e)
        {

        }

        private void modifyPasswordTextbox(object sender, EventArgs e)
        {

        }

        private void modifyJobTextbox(object sender, EventArgs e)
        {

        }

        private void employeeIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeId = employeeIDListBox.SelectedIndex + 1;

        }

        private void modifyEmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modifyVehicle_Click_1(object sender, EventArgs e)
        {
            string vin = vehicleListBox.SelectedItem.ToString();
            Vehicle vehicle;

            string make = modifyMake.Text;
            string model = modifyModel.Text;
            string color = modifyColor.Text;
            string owner = "Dearborn Ford";
            string holder = "Dearborn Ford";
            string thePrice = modifyPrice.Text;
            float price = float.Parse(thePrice);
            string miles = modifyMileage.Text;
            int mileage = Convert.ToInt32(miles);
            string theYear = modifyYear.Text;
            int year = Convert.ToInt32(theYear);
            DateTime returnDate = new DateTime(2000, 1, 1);

            vehicle = new Vehicle(1, vin, make, model, color, owner, holder, price, mileage, year, returnDate);
            this.admin.updateVehicleInfo(vehicle);

            vehicles = admin.getVehicleData();

            modifyVehicleListBox.Items.Clear();
            vehicleListBox.Items.Clear();

            foreach (var pair in vehicles)
            {
                modifyVehicleListBox.Items.Add($"{pair.Value.getVin()}");
                vehicleListBox.Items.Add($"{pair.Value.getVin()}");
            }
            modifyVehicleListBox.Update();
            vehicleListBox.Update();

        }
    }
}
