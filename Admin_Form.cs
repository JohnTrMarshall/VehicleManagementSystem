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
    public partial class Admin_Form : Form
    {
        Employee employee = new Employee();
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void addUser_Label_Click(object sender, EventArgs e)
        {

        }
        public void loginAdmin(Employee employee)
        {
            // set local employee object
            this.employee = employee;

            this.Show();

            
        }
    }
}
