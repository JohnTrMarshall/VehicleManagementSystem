namespace VehicleManagementSystem
{
    partial class Employee_Form
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
            this.serviceVehicle_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serviceVehicle_Button
            // 
            this.serviceVehicle_Button.Location = new System.Drawing.Point(563, 178);
            this.serviceVehicle_Button.Name = "serviceVehicle_Button";
            this.serviceVehicle_Button.Size = new System.Drawing.Size(96, 23);
            this.serviceVehicle_Button.TabIndex = 0;
            this.serviceVehicle_Button.Text = "Service Vehicle";
            this.serviceVehicle_Button.UseVisualStyleBackColor = true;
            this.serviceVehicle_Button.Click += new System.EventHandler(this.serviceVehicle_Button_Click);
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serviceVehicle_Button);
            this.Name = "Employee_Form";
            this.Text = "Employee_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serviceVehicle_Button;
    }
}