using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem
{
    public partial class customerInfo_Form : Form
    {
        public customerInfo_Form()
        {
            InitializeComponent();
        }

        private void customerInfo_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearCustomer_Button_Click(object sender, EventArgs e)
        {
            clearCustomer();
        }

        public void clearCustomer()
        {
            name_Textbox.Text = "Name";
            street_Textbox.Text = "Street";
            city_Textbox.Text = "City";
            state_Textbox.Text = "State";
            zip_Textbox.Text = "Zip";
            phoneNumber_Textbox.Text = "Phone Number";
            email_Textbox.Text = "Email";
        }

        private void name_Textbox_Click(object sender, EventArgs e)
        {
            if (name_Textbox.Text == "Name")
            {
                name_Textbox.Clear();
            }
        }

        private void name_Textbox_LostFocus(object sender, EventArgs e)
        {
            if (name_Textbox.Text == "")
            {
                name_Textbox.Text = "Name";
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
                Customer customer = new Customer(name_Textbox.Text, street_Textbox.Text, city_Textbox.Text, state_Textbox.Text, zip_Textbox.Text, phoneNumber_Textbox.Text, email_Textbox.Text);
                customer.AddCustomer();
            }
            
        }

        public bool validateForm()
        {

            return validateName() && validateStreet() && validateCity() && validateState() && validateZip() && validatePhoneNumber() && validateEmail();
        }

        public bool validateName()
        {
            if (name_Textbox.Text == "Name" || name_Textbox.Text.Length > 50)
            {
                MessageBox.Show("Error, invalid name");
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
            if (state_Textbox.Text == "State"  || state_Textbox.Text.Length > 30)
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
    }
}
