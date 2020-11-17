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
            name_Textbox.Clear();
            name_Textbox.Text
        }

        private void name_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
