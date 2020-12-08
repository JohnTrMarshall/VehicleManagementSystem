using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VehicleManagementSystem
{
    public partial class Login_Form : Form
    {
        public Employee employee = new Employee();
        public Login_Form()
        {
            InitializeComponent();
        }
        public Login_Form(Main_Form mf)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Employee GetLogin()
        {
            return employee;
        }
        public void SetLogin(Employee e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;

            Database db = new Database();

            SqlConnection connection = new SqlConnection(db.GetConnectionString());
            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM [Employee] WHERE userName='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", connection);
           
            DataTable dt = new DataTable(); //this is creating a virtual table 
            query.Fill(dt);

            if (dt.Rows.Count>0)
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
                // this is where the new authorized form will be enabled 

                // create employee object
               employee.firstName =  dt.Rows[0]["firstName"].ToString();
               employee.employeeID = (int)dt.Rows[0]["employeeID"];
               employee.userName = username;

                // pass employee to main form
                Main_Form main = (Main_Form)Application.OpenForms["Main_Form"];
                if (main != null) main.loginEmployee(employee);
            }
            else
                MessageBox.Show("Invalid username or password");


        }
    }
}
