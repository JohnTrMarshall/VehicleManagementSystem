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

        private readonly String connectionString = "Data Source=(LocalDB\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\John\\Development\\VehicleManagementSystem\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        Login login = new Login();
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            fillLists(connection);

        }
        void fillLists(SqlConnection connection)
        {
            fillVehicleList(connection);
            fillMakeCombo(connection);
            fillModelCombo(connection);
            fillYearCombo(connection);

        }
        void fillVehicleList(SqlConnection connection)
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT vin, make, model, year, color, price, mileage FROM Vehicle WHERE owner='Dearborn Ford'", connection);

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
        void fillMakeCombo(SqlConnection connection)
        {
            SqlCommand query = new SqlCommand("SELECT DISTINCT make FROM Vehicle", connection);

            SqlDataReader reader = query.ExecuteReader();

            makeComboBox.Items.Add("Make");

            while (reader.Read())
            {
                makeComboBox.Items.Add(reader["make"].ToString());
            }

            reader.Close();
        }
        void fillModelCombo(SqlConnection connection)
        {

            SqlCommand query = new SqlCommand("SELECT DISTINCT model FROM Vehicle WHERE owner='Dearborn Ford'", connection);

            SqlDataReader reader = query.ExecuteReader();

            modelComboBox.Items.Add("Model");

            while (reader.Read())
            {
                modelComboBox.Items.Add(reader["model"].ToString());
            }

            reader.Close();
        }
        void fillYearCombo(SqlConnection connection)
        {
            SqlCommand query = new SqlCommand("SELECT DISTINCT year FROM Vehicle WHERE owner='Dearborn Ford'", connection);

            SqlDataReader reader = query.ExecuteReader();

            yearComboBox.Items.Add("Year");

            while (reader.Read())
            {
                yearComboBox.Items.Add(reader["year"].ToString());
            }

            reader.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            String make = makeComboBox?.SelectedIndex == -1 ? "%" : makeComboBox.SelectedItem.ToString();
            String model = modelComboBox?.SelectedIndex == -1 ? "%" : modelComboBox.SelectedItem.ToString();
            String year = yearComboBox?.SelectedIndex == -1 ? "%" : yearComboBox.SelectedItem.ToString();

            SqlDataAdapter query = new SqlDataAdapter("SELECT vin, make, model, year, color, price, mileage" +
                                                    " FROM Vehicle " +
                                                    "WHERE owner='Dearborn Ford' AND make='" +
                                                    make + "' AND model='" +
                                                    model + "' AND year='" +
                                                    year + "'", connection);

            DataTable table = new DataTable();

            query.Fill(table);

            vehicleList.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
        }

        private void makeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
