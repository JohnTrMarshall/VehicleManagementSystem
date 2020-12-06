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
    public partial class showTransaction_Form : Form
    {

        private Customer customer = new Customer();
        private Employee employee = new Employee();
        private Vehicle vehicle = new Vehicle();
        private string process_str = "";

        public showTransaction_Form()
        {
            InitializeComponent();
        }
        public showTransaction_Form(Customer customer, Vehicle vehicle, Employee employee, string process_str)
        {
            InitializeComponent();

            this.customer = customer;
            this.employee = employee;
            this.vehicle = vehicle;
            this.process_str = process_str;
        }
        private void showTransaction_Form_Load(object sender, EventArgs e)
        {
            fillForm();
        }

        private void fillForm()
        {
            fillVehicle();
            fillEmployee();
            fillCustomer();
            process_textbox.Text = process_str;
        }
        private void fillVehicle()
        {
            vin_textbox.Text = this.vehicle.vin;
            make_textbox.Text = this.vehicle.make;
            model_textbox.Text = this.vehicle.model;
            year_textbox.Text = this.vehicle.year.ToString();
            color_textbox.Text = this.vehicle.color;
            price_textbox.Text = "$" + this.vehicle.price.ToString();
            mileage_textbox.Text = this.vehicle.mileage.ToString();

            if (vehicle.returnDate == new DateTime(1900, 1, 1))
            {
                returnBy_textbox.Text = "--";
                returnBy_textbox.TextAlign = HorizontalAlignment.Center;
            }
            else {

                returnBy_textbox.Text = vehicle.returnDate.ToString("yyyy-MM-dd");
            }
        }
        private void fillEmployee()
        {
            employeeName_textbox.Text = this.employee.userName;
            employeeName_textbox.Enabled = false;
        }
        private void fillCustomer()
        {
            firstName_textbox.Text = customer.firstName;
            lastName_textbox.Text = customer.lastName;
            street_Textbox.Text = customer.street;
            city_Textbox.Text = customer.city;
            state_Textbox.Text = customer.state;
            zip_Textbox.Text = customer.zip;
            phoneNumber_Textbox.Text = customer.phoneNumber;
            email_Textbox.Text = customer.email;
        }

        private void returnToMain_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Return to Main?", "Return to Main", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                Main_Form main_Form = new Main_Form(employee);

                employee = new Employee();
                vehicle = new Vehicle();

                this.Hide();
                main_Form.Show();
            }
        }
    }
}
