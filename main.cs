using System;
using System.CodeDom;
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
    public partial class main : Form
    {
     
        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ahmed\\source\\repos\\VehicleManagementSystem\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        Login login = new Login();
        public main()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter query = new SqlDataAdapter("SELECT * FROM Vehicle", connection);

            DataTable table = new DataTable();
            query.Fill(table);

            vehicleList.DataSource = table;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
        }
    }
}
