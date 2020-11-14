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
        private String make = "%", model = "%", year = "%";

        private readonly String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VehicleManagementSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        Login_Form login = new Login_Form();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
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

        }
        void fillData(SqlConnection connection)
        {
            fillVehicleList(connection);
            fillCombos(connection);

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
        void fillCombos(SqlConnection connection)
        {
            fillMakeCombo(connection);
            fillModelCombo(connection);
            fillYearCombo(connection);
        }
        void fillMakeCombo(SqlConnection connection)
        {

            makeComboBox.Items.Clear();

            SqlCommand query = new SqlCommand("SELECT DISTINCT make FROM Vehicle WHERE owner='Dearborn Ford'", connection);


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

            SqlCommand query = new SqlCommand("SELECT DISTINCT model FROM Vehicle WHERE owner='Dearborn Ford'", connection);

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

            SqlCommand query = new SqlCommand("SELECT DISTINCT year FROM Vehicle WHERE owner='Dearborn Ford'", connection);

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
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    make = makeComboBox?.SelectedIndex == 0 ? "%" : makeComboBox.SelectedItem.ToString();
                    model = modelComboBox?.SelectedIndex == 0 ? "%" : modelComboBox.SelectedItem.ToString();
                    year = yearComboBox?.SelectedIndex == 0 ? "%" : yearComboBox.SelectedItem.ToString();

                    SqlDataAdapter query = new SqlDataAdapter("SELECT vin, make, model, year, color, price, mileage" +
                                                            " FROM Vehicle " +
                                                            "WHERE owner='Dearborn Ford' AND make LIKE '" +
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
        }
    }
}
