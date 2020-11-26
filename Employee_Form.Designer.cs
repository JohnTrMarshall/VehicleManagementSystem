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
            this.serviceVehicle_button = new System.Windows.Forms.Button();
            this.leaseVehicle_button = new System.Windows.Forms.Button();
            this.purchaseVehicle_button = new System.Windows.Forms.Button();
            this.sellVehicle_button = new System.Windows.Forms.Button();
            this.loanVehicle_button = new System.Windows.Forms.Button();
            this.vehicleFunction_label = new System.Windows.Forms.Label();
            this.rentVehicle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serviceVehicle_button
            // 
            this.serviceVehicle_button.Location = new System.Drawing.Point(634, 72);
            this.serviceVehicle_button.Name = "serviceVehicle_button";
            this.serviceVehicle_button.Size = new System.Drawing.Size(96, 23);
            this.serviceVehicle_button.TabIndex = 0;
            this.serviceVehicle_button.Text = "Service";
            this.serviceVehicle_button.UseVisualStyleBackColor = true;
            this.serviceVehicle_button.Click += new System.EventHandler(this.serviceVehicle_Button_Click);
            // 
            // leaseVehicle_button
            // 
            this.leaseVehicle_button.Location = new System.Drawing.Point(328, 72);
            this.leaseVehicle_button.Name = "leaseVehicle_button";
            this.leaseVehicle_button.Size = new System.Drawing.Size(96, 23);
            this.leaseVehicle_button.TabIndex = 1;
            this.leaseVehicle_button.Text = "Lease";
            this.leaseVehicle_button.UseVisualStyleBackColor = true;
            // 
            // purchaseVehicle_button
            // 
            this.purchaseVehicle_button.Location = new System.Drawing.Point(124, 72);
            this.purchaseVehicle_button.Name = "purchaseVehicle_button";
            this.purchaseVehicle_button.Size = new System.Drawing.Size(96, 23);
            this.purchaseVehicle_button.TabIndex = 2;
            this.purchaseVehicle_button.Text = "Purchase";
            this.purchaseVehicle_button.UseVisualStyleBackColor = true;
            // 
            // sellVehicle_button
            // 
            this.sellVehicle_button.Location = new System.Drawing.Point(226, 72);
            this.sellVehicle_button.Name = "sellVehicle_button";
            this.sellVehicle_button.Size = new System.Drawing.Size(96, 23);
            this.sellVehicle_button.TabIndex = 3;
            this.sellVehicle_button.Text = "Sell";
            this.sellVehicle_button.UseVisualStyleBackColor = true;
            // 
            // loanVehicle_button
            // 
            this.loanVehicle_button.Location = new System.Drawing.Point(430, 72);
            this.loanVehicle_button.Name = "loanVehicle_button";
            this.loanVehicle_button.Size = new System.Drawing.Size(96, 23);
            this.loanVehicle_button.TabIndex = 4;
            this.loanVehicle_button.Text = "Loan";
            this.loanVehicle_button.UseVisualStyleBackColor = true;
            // 
            // vehicleFunction_label
            // 
            this.vehicleFunction_label.AutoSize = true;
            this.vehicleFunction_label.Location = new System.Drawing.Point(27, 72);
            this.vehicleFunction_label.Name = "vehicleFunction_label";
            this.vehicleFunction_label.Size = new System.Drawing.Size(91, 13);
            this.vehicleFunction_label.TabIndex = 5;
            this.vehicleFunction_label.Text = "Vehicle Functions";
            // 
            // rentVehicle_button
            // 
            this.rentVehicle_button.Location = new System.Drawing.Point(532, 72);
            this.rentVehicle_button.Name = "rentVehicle_button";
            this.rentVehicle_button.Size = new System.Drawing.Size(96, 23);
            this.rentVehicle_button.TabIndex = 6;
            this.rentVehicle_button.Text = "Rent";
            this.rentVehicle_button.UseVisualStyleBackColor = true;
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rentVehicle_button);
            this.Controls.Add(this.vehicleFunction_label);
            this.Controls.Add(this.loanVehicle_button);
            this.Controls.Add(this.sellVehicle_button);
            this.Controls.Add(this.purchaseVehicle_button);
            this.Controls.Add(this.leaseVehicle_button);
            this.Controls.Add(this.serviceVehicle_button);
            this.Name = "Employee_Form";
            this.Text = "Employee_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serviceVehicle_button;
        private System.Windows.Forms.Button leaseVehicle_button;
        private System.Windows.Forms.Button purchaseVehicle_button;
        private System.Windows.Forms.Button sellVehicle_button;
        private System.Windows.Forms.Button loanVehicle_button;
        private System.Windows.Forms.Label vehicleFunction_label;
        private System.Windows.Forms.Button rentVehicle_button;
    }
}