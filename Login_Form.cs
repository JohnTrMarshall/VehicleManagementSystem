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
        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public Login_Form()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter query = new SqlDataAdapter("SELECT COUNT(*) FROM [Employee] WHERE userName='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", connection);
           
            DataTable dt = new DataTable(); //this is creating a virtual table  
            query.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                // this is where the new authorized form will be enabled 
                MessageBox.Show("login success");
            }
            else
                MessageBox.Show("Invalid username or password");


        }
    }
}
