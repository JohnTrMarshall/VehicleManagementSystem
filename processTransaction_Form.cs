using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    public partial class processTransaction_Form : Form
    {

        Employee employee = new Employee();
        public processTransaction_Form()
        {
            InitializeComponent();
        }
        public processTransaction_Form(Vehicle vehicle, Employee employee, string process_str)
        {
            InitializeComponent();
            
            this.employee = employee;

            process_textbox.Text = process_str;

            vin_textbox.Text = vehicle.vin;
            make_textbox.Text = vehicle.make;
            model_textbox.Text = vehicle.model;
            year_textbox.Text = vehicle.year.ToString();
            color_textbox.Text = vehicle.color;
            price_textbox.Text = vehicle.price.ToString();
            mileage_textbox.Text = vehicle.mileage.ToString();
        }
        private void vin_label_Click(object sender, EventArgs e)
        {

        }

        private void vehicleInfo_Form_Load(object sender, EventArgs e)
        {

        }

        private void color_label_Click(object sender, EventArgs e)
        {

        }

        private void color_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void clearCustomer_Button_Click(object sender, EventArgs e)
        {
            clearCustomer();
        }

        public void clearCustomer()
        {
            firstName_textbox.Text = "First Name";
            lastName_textbox.Text = "Last Name";
            street_Textbox.Text = "Street";
            city_Textbox.Text = "City";
            state_Textbox.Text = "State";
            zip_Textbox.Text = "Zip";
            phoneNumber_Textbox.Text = "Phone Number";
            email_Textbox.Text = "Email";
        }

        private void firstName_Textbox_Click(object sender, EventArgs e)
        {
            if (firstName_textbox.Text == "First Name")
            {
                firstName_textbox.Clear();
            }
        }

        private void firstNameTextbox_LostFocus(object sender, EventArgs e)
        {
            if (firstName_textbox.Text == "")
            {
                firstName_textbox.Text = "First Name";
            }
        }
        private void lastName_Textbox_Click(object sender, EventArgs e)
        {
            if (lastName_textbox.Text == "Last Name")
            {
                lastName_textbox.Clear();
            }
        }

        private void lastNameTextbox_LostFocus(object sender, EventArgs e)
        {
            if (lastName_textbox.Text == "")
            {
                lastName_textbox.Text = "Last Name";
            }
        }
        private void street_Textbox_Click(object sender, EventArgs e)
        {
            if (street_Textbox.Text == "Street")
            {
                street_Textbox.Clear();
            }
        }
        private void street_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (street_Textbox.Text == "")
            {
                street_Textbox.Text = "Street";
            }
        }
        private void city_Textbox_Click(object sender, EventArgs e)
        {
            if (city_Textbox.Text == "City")
            {
                city_Textbox.Clear();
            }
        }
        private void city_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (city_Textbox.Text == "")
            {
                city_Textbox.Text = "City";
            }
        }
        private void state_Textbox_Click(object sender, EventArgs e)
        {
            if (state_Textbox.Text == "State")
            {
                state_Textbox.Clear();
            }
        }

        private void state_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (state_Textbox.Text == "")
            {
                state_Textbox.Text = "State";
            }
        }

        private void zip_Textbox_Click(object sender, EventArgs e)
        {
            if (zip_Textbox.Text == "Zip")
            {
                zip_Textbox.Clear();
            }
        }

        private void zip_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (zip_Textbox.Text == "")
            {
                zip_Textbox.Text = "Zip";
            }
        }
        private void phoneNumber_Textbox_Click(object sender, EventArgs e)
        {
            if (phoneNumber_Textbox.Text == "Phone Number")
            {
                phoneNumber_Textbox.Clear();
            }
        }

        private void phoneNumber_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (phoneNumber_Textbox.Text == "")
            {
                phoneNumber_Textbox.Text = "Phone Number";
            }
        }

        private void email_Textbox_Click(object sender, EventArgs e)
        {
            if (email_Textbox.Text == "Email")
            {
                email_Textbox.Clear();
            }
        }

        private void email_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (email_Textbox.Text == "")
            {
                email_Textbox.Text = "Email";
            }
        }

        private void addCustomer_Button_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                // adds information currently entered into database
                Customer customer = new Customer(firstName_textbox.Text, lastName_textbox.Text, street_Textbox.Text, city_Textbox.Text, state_Textbox.Text, zip_Textbox.Text, phoneNumber_Textbox.Text, email_Textbox.Text);
                customer.AddCustomer();
            }

        }

        public bool validateForm()
        {

            return validateFirstName() && validateLastName() && validateStreet() && validateCity() && validateState() && validateZip() && validatePhoneNumber() && validateEmail();
        }

        public bool validateFirstName()
        {
            if (firstName_textbox.Text == "First Name" || firstName_textbox.Text.Length > 30)
            {
                MessageBox.Show("Error, invalid first name");
                return false;
            }

            return true;
        }
        public bool validateLastName()
        {
            if (lastName_textbox.Text == "Last Name Name" || lastName_textbox.Text.Length > 30)
            {
                MessageBox.Show("Error, invalid last name");
                return false;
            }

            return true;
        }
        public bool validateStreet()
        {
            if (street_Textbox.Text == "Street" || street_Textbox.Text.Length > 30)
            {
                MessageBox.Show("Erorr, invalid street");
                return false;
            }

            return true;
        }
        public bool validateCity()
        {
            if (city_Textbox.Text == "City" || city_Textbox.Text.Length > 30)
            {
                MessageBox.Show("Erorr, invalid city");
                return false;
            }

            return true;
        }

        public bool validateState()
        {
            if (state_Textbox.Text == "State" || state_Textbox.Text.Length > 30)
            {
                MessageBox.Show("Erorr, invalid state");
                return false;
            }

            return true;
        }
        public bool validateZip()
        {
            if (state_Textbox.Text == "Zip" || state_Textbox.Text.Length > 15)
            {
                MessageBox.Show("Erorr, invalid zip");
                return false;
            }

            return true;
        }
        public bool validatePhoneNumber()
        {
            if (phoneNumber_Textbox.Text == "Phone Number" || phoneNumber_Textbox.Text.Length > 15)
            {
                MessageBox.Show("Erorr, invalid phone number");
                return false;
            }

            return true;
        }

        public bool validateEmail()
        {
            if (email_Textbox.Text == "Email" || email_Textbox.Text.Length > 50)
            {
                MessageBox.Show("Erorr, invalid email");
                return false;
            }

            return true;
        }

        private void addCustomer_Button_Click_1(object sender, EventArgs e)
        {
            if (validateForm())
            {
                // adds information currently entered into database
                Customer customer = new Customer(firstName_textbox.Text, lastName_textbox.Text, street_Textbox.Text, city_Textbox.Text, state_Textbox.Text, zip_Textbox.Text, phoneNumber_Textbox.Text, email_Textbox.Text);
                customer.AddCustomer();
            }

        }

        private void clearCustomer_Button_Click_1(object sender, EventArgs e)
        {
            clearCustomer();
        }

        private void employeeName_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Form main = new Main_Form();
            main.Show();
        }

        private void confirmTransaction_button_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {

              

                connection.Open();
                int year;
                int miles;
                float price;
                if (!int.TryParse(year_textbox.Text, out year)) year = 0;
                if (!int.TryParse(mileage_textbox.Text, out miles)) miles = 0;
                if (!float.TryParse(price_textbox.Text, out price)) price = 0;
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = "INSERT INTO Vehicle (year, make, color, model, mileage, vin, price, owner) VALUES ('" + year + "','" + make_textbox.Text.ToString() + "','" + color_textbox.Text.ToString() + "','" + model_textbox.Text.ToString() + "','" + miles + "','" + vin_textbox.Text.ToString() + "','" + price + "','" + "Dearborn Ford" + "'); ";
               
                cmd.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
                MessageBox.Show("Vehicle added to inventory");
                
            }
        }
    }
}