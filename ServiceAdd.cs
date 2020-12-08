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

namespace ServiceAdd
{
    public void serviceVehicle(Vehicle vehicle)
        {
            Database db = new Database();
            int vin = vehicle.getvin();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {

                connection.Open();

                String query_str = ($"UPDATE Vehicle SET owner='{Dearborn Ford}', holder='{Dearborn Ford}' WHERE vin='{this.vin}'");

                SqlCommand query = new SqlCommand(query_str, connection);

                if (query.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Error, no changes to database were made");
                }
                try
                {
                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, failed to connect to database");
                }
            }
        }
}
