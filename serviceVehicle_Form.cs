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

namespace VehicleManagementSystem
{
  public partial class serviceVehicle_Form : Form
  {
    Vehicle vehicle = new Vehicle();
    
    public serviceVehicle_Form()
    {
        InitializeComponent();
    }
    
    public processTransaction_Form(Vehicle vehicle, int vin)
    {
        InitializeComponent();

        this.vehicle = vehicle;

        process_textbox.Text = vin;
        process_textbox.Enabled = false;
    }
    
  }
}
