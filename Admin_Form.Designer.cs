namespace VehicleManagementSystem
{
    partial class Admin_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addVehicle_Button = new System.Windows.Forms.Button();
            this.vehicleFunction_Label = new System.Windows.Forms.Label();
            this.deleteVehicle_Button = new System.Windows.Forms.Button();
            this.modifyVehicle_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicle_Button
            // 
            this.addVehicle_Button.Location = new System.Drawing.Point(553, 70);
            this.addVehicle_Button.Name = "addVehicle_Button";
            this.addVehicle_Button.Size = new System.Drawing.Size(88, 23);
            this.addVehicle_Button.TabIndex = 0;
            this.addVehicle_Button.Text = "Add Vehicle";
            this.addVehicle_Button.UseVisualStyleBackColor = true;
            this.addVehicle_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleFunction_Label
            // 
            this.vehicleFunction_Label.AutoSize = true;
            this.vehicleFunction_Label.Location = new System.Drawing.Point(539, 54);
            this.vehicleFunction_Label.Name = "vehicleFunction_Label";
            this.vehicleFunction_Label.Size = new System.Drawing.Size(116, 13);
            this.vehicleFunction_Label.TabIndex = 1;
            this.vehicleFunction_Label.Text = "Inventory Management";
            // 
            // deleteVehicle_Button
            // 
            this.deleteVehicle_Button.Location = new System.Drawing.Point(553, 99);
            this.deleteVehicle_Button.Name = "deleteVehicle_Button";
            this.deleteVehicle_Button.Size = new System.Drawing.Size(88, 23);
            this.deleteVehicle_Button.TabIndex = 2;
            this.deleteVehicle_Button.Text = "Delete Vehicle";
            this.deleteVehicle_Button.UseVisualStyleBackColor = true;
            // 
            // modifyVehicle_Button
            // 
            this.modifyVehicle_Button.Location = new System.Drawing.Point(553, 128);
            this.modifyVehicle_Button.Name = "modifyVehicle_Button";
            this.modifyVehicle_Button.Size = new System.Drawing.Size(88, 23);
            this.modifyVehicle_Button.TabIndex = 3;
            this.modifyVehicle_Button.Text = "Modify Vehicle";
            this.modifyVehicle_Button.UseVisualStyleBackColor = true;
            this.modifyVehicle_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyVehicle_Button);
            this.Controls.Add(this.deleteVehicle_Button);
            this.Controls.Add(this.vehicleFunction_Label);
            this.Controls.Add(this.addVehicle_Button);
            this.Name = "Admin_Form";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVehicle_Button;
        private System.Windows.Forms.Label vehicleFunction_Label;
        private System.Windows.Forms.Button deleteVehicle_Button;
        private System.Windows.Forms.Button modifyVehicle_Button;
    }
}