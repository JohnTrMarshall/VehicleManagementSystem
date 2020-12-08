using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    public partial class Main_Form : Form
    {

        Employee employee = new Employee();

        private String make = "%", model = "%", year = "%";

        Database db = new Database();

        Login_Form login = new Login_Form();
        public Main_Form()
        {
            InitializeComponent();
        }
        public Main_Form(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;


        }
        private void main_Load(object sender, EventArgs e)
        {

            purchaseVehicle_button.Hide();
            sellVehicle_button.Hide();
            leaseVehicle_button.Hide();
            loanVehicle_button.Hide();
            rentVehicle_button.Hide();
            serviceVehicle_button.Hide();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    fillData(connection);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }


            if (employee.employeeID != 0)
            {
                loginEmployee(employee);
            }
        }
        public void test(Object sender, EventArgs e)
        {
            Employee test = (sender as Login_Form).GetLogin();
        }
        void fillData(SqlConnection connection)
        {
            fillVehicleList(connection);
            fillCombos(connection);

        }
        void fillVehicleList(SqlConnection connection)
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT vin, make, model, year, color, price, mileage FROM Vehicle WHERE holder='Dearborn Ford'", connection);

            DataTable table = new DataTable();

            query.Fill(table);

            vehicleList.DataSource = table;

            vehicleList.Columns[0].HeaderText = "VIN";
            vehicleList.Columns[1].HeaderText = "Make";
            vehicleList.Columns[2].HeaderText = "Model";
            vehicleList.Columns[3].HeaderText = "Year";
            vehicleList.Columns[4].HeaderText = "Color";
            vehicleList.Columns[5].HeaderText = "Price";
            vehicleList.Columns[6].HeaderText = "Mileage";
        }
        void fillCombos(SqlConnection connection)
        {
            fillMakeCombo(connection);
            fillModelCombo(connection);
            fillYearCombo(connection);
        }
        void fillMakeCombo(SqlConnection connection)
        {

            makeComboBox.Items.Clear();

            SqlCommand query = new SqlCommand("SELECT DISTINCT make FROM Vehicle WHERE holder='Dearborn Ford'", connection);


            SqlDataReader reader = query.ExecuteReader();

            makeComboBox.Items.Add("Make");

            while (reader.Read())
            {
                makeComboBox.Items.Add(reader["make"].ToString());
            }

            reader.Close();

            makeComboBox.SelectedIndex = 0;
        }
        void fillModelCombo(SqlConnection connection)
        {

            modelComboBox.Items.Clear();

            SqlCommand query = new SqlCommand("SELECT DISTINCT model FROM Vehicle WHERE holder='Dearborn Ford'", connection);

            SqlDataReader reader = query.ExecuteReader();

            modelComboBox.Items.Add("Model");

            while (reader.Read())
            {
                modelComboBox.Items.Add(reader["model"].ToString());
            }

            reader.Close();

            modelComboBox.SelectedIndex = 0;
        }
        void fillYearCombo(SqlConnection connection)
        {

            yearComboBox.Items.Clear();

            SqlCommand query = new SqlCommand("SELECT DISTINCT year FROM Vehicle WHERE holder='Dearborn Ford'", connection);

            SqlDataReader reader = query.ExecuteReader();

            yearComboBox.Items.Add("Year");

            while (reader.Read())
            {
                yearComboBox.Items.Add(reader["year"].ToString());
            }

            reader.Close();

            yearComboBox.SelectedIndex = 0;
        }
        void clearFilter()
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {

                makeComboBox.SelectedIndex = 0;
                modelComboBox.SelectedIndex = 0;
                yearComboBox.SelectedIndex = 0;

                make = model = year = "%";

                try
                {
                    connection.Open();
                    fillData(connection);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, connection to database lost");
                }
            }
        }
        
        public void filter()
        {

            if(makeComboBox.SelectedIndex != 0 || modelComboBox.SelectedIndex != 0 || yearComboBox.SelectedIndex != 0)
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {

                    make = makeComboBox?.SelectedIndex == 0 ? "%" : makeComboBox.SelectedItem.ToString();
                    model = modelComboBox?.SelectedIndex == 0 ? "%" : modelComboBox.SelectedItem.ToString();
                    year = yearComboBox?.SelectedIndex == 0 ? "%" : yearComboBox.SelectedItem.ToString();

                    SqlDataAdapter query = new SqlDataAdapter("SELECT vin, make, model, year, color, price, mileage" +
                                                            " FROM Vehicle " +
                                                            "WHERE holder='Dearborn Ford' AND make LIKE '" +
                                                            make + "' AND model LIKE '" +
                                                            model + "' AND year LIKE '" +
                                                            year + "'", connection);

                    DataTable table = new DataTable();

                    query.Fill(table);

                    vehicleList.DataSource = table;

                    try
                    {
                        connection.Open();
                        fillCombos(connection);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error, connection to database lost");
                    }
                }

                filter_Button.Enabled = false;
            }
        }

        private void clearFilter_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {

                makeComboBox.SelectedIndex = 0;
                modelComboBox.SelectedIndex = 0;
                yearComboBox.SelectedIndex = 0;

                make = model = year = "%";

                try
                {
                    connection.Open();
                    fillData(connection);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, connection to database lost");
                }
            }

            filter_Button.Enabled = true;
        }

        private void makeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(makeComboBox.SelectedIndex != 0)
            {
                filter_Button.Enabled = true;
            }
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelComboBox.SelectedIndex != 0)
            {
                filter_Button.Enabled = true;
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex != 0)
            {
                filter_Button.Enabled = true;
            }
        }

        private void serviceVehicle_Button_Click(object sender, EventArgs e)
        {
           // serviceVehicle(Vehicle vehicle, int vin);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            
            if (employee.employeeID == 0)
            {
                login.Show();
            }
            else
            {
                logoutEmployee();
            }
        }

        private void sellVehicle_button_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.vin = vehicleList.CurrentRow.Cells[0].Value.ToString();
            vehicle.make = vehicleList.CurrentRow.Cells[1].Value.ToString();
            vehicle.model = vehicleList.CurrentRow.Cells[2].Value.ToString();
            vehicle.year = (int)vehicleList.CurrentRow.Cells[3].Value;
            vehicle.color = vehicleList.CurrentRow.Cells[4].Value.ToString();
            vehicle.price = float.Parse(vehicleList.CurrentRow.Cells[5].Value.ToString());
            vehicle.mileage = (int)vehicleList.CurrentRow.Cells[6].Value;

            processTransaction_Form vi_form = new processTransaction_Form(vehicle, employee, "Sell");

            this.Hide();
            vi_form.Show();


        }

        private void purchaseVehicle_button_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

         
    
            processTransaction_Form vi_form = new processTransaction_Form(vehicle, employee, "Purchase");
          
            this.Hide();
            vi_form.Show();
        }

        private void vehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void leaseVehicle_button_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vin = vehicleList.CurrentRow.Cells[0].Value.ToString();
            vehicle.make = vehicleList.CurrentRow.Cells[1].Value.ToString();
            vehicle.model = vehicleList.CurrentRow.Cells[2].Value.ToString();
            vehicle.year = (int)vehicleList.CurrentRow.Cells[3].Value;
            vehicle.color = vehicleList.CurrentRow.Cells[4].Value.ToString();
            vehicle.price = float.Parse(vehicleList.CurrentRow.Cells[5].Value.ToString());
            vehicle.mileage = (int)vehicleList.CurrentRow.Cells[6].Value;
            processTransaction_Form_Lease vi_form = new processTransaction_Form_Lease(vehicle, employee, "Lease");
            
            this.Hide();
            vi_form.Show();
        }

        private void loanVehicle_button_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vin = vehicleList.CurrentRow.Cells[0].Value.ToString();
            vehicle.make = vehicleList.CurrentRow.Cells[1].Value.ToString();
            vehicle.model = vehicleList.CurrentRow.Cells[2].Value.ToString();
            vehicle.year = (int)vehicleList.CurrentRow.Cells[3].Value;
            vehicle.color = vehicleList.CurrentRow.Cells[4].Value.ToString();
            vehicle.price = float.Parse(vehicleList.CurrentRow.Cells[5].Value.ToString());
            vehicle.mileage = (int)vehicleList.CurrentRow.Cells[6].Value;
            processTransaction_Form_Lease vi_form = new processTransaction_Form_Lease(vehicle, employee, "Loan");
            this.Hide();
            vi_form.Show();
        }

        private void rentVehicle_button_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.vin = vehicleList.CurrentRow.Cells[0].Value.ToString();
            vehicle.make = vehicleList.CurrentRow.Cells[1].Value.ToString();
            vehicle.model = vehicleList.CurrentRow.Cells[2].Value.ToString();
            vehicle.year = (int)vehicleList.CurrentRow.Cells[3].Value;
            vehicle.color = vehicleList.CurrentRow.Cells[4].Value.ToString();
            vehicle.price = float.Parse(vehicleList.CurrentRow.Cells[5].Value.ToString());
            vehicle.mileage = (int)vehicleList.CurrentRow.Cells[6].Value;
            processTransaction_Form_Lease vi_form = new processTransaction_Form_Lease(vehicle, employee, "Rent");
            this.Hide();
            vi_form.Show();
        }

        public void loginEmployee(Employee employee)
        {
            // set local employee object
            this.employee = employee;

            //update labels
            userName_label.Text = this.employee.userName;
            login_Button.Text = "Logout";

            // show employee buttons
            purchaseVehicle_button.Show();
            sellVehicle_button.Show();
            leaseVehicle_button.Show();
            loanVehicle_button.Show();
            rentVehicle_button.Show();
            serviceVehicle_button.Show();
        }
        public void logoutEmployee()
        {
            // reset local employee object
            employee = new Employee();

            // update labels
            userName_label.Text = "Guest";
            login_Button.Text = "Login";

            // hide employee buttons
            purchaseVehicle_button.Hide();
            sellVehicle_button.Hide();
            leaseVehicle_button.Hide();
            loanVehicle_button.Hide();
            rentVehicle_button.Hide();
            serviceVehicle_button.Hide();
        }
    }
}
