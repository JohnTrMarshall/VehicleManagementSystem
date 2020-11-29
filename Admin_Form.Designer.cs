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
            this.userFunction_Label = new System.Windows.Forms.Label();
            this.addUser_Label = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.modifyUser_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addVehicle_Button
            // 
            this.addVehicle_Button.Location = new System.Drawing.Point(578, 70);
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
            this.vehicleFunction_Label.Location = new System.Drawing.Point(564, 54);
            this.vehicleFunction_Label.Name = "vehicleFunction_Label";
            this.vehicleFunction_Label.Size = new System.Drawing.Size(116, 13);
            this.vehicleFunction_Label.TabIndex = 1;
            this.vehicleFunction_Label.Text = "Inventory Management";
            // 
            // deleteVehicle_Button
            // 
            this.deleteVehicle_Button.Location = new System.Drawing.Point(578, 99);
            this.deleteVehicle_Button.Name = "deleteVehicle_Button";
            this.deleteVehicle_Button.Size = new System.Drawing.Size(88, 23);
            this.deleteVehicle_Button.TabIndex = 2;
            this.deleteVehicle_Button.Text = "Delete Vehicle";
            this.deleteVehicle_Button.UseVisualStyleBackColor = true;
            // 
            // modifyVehicle_Button
            // 
            this.modifyVehicle_Button.Location = new System.Drawing.Point(578, 128);
            this.modifyVehicle_Button.Name = "modifyVehicle_Button";
            this.modifyVehicle_Button.Size = new System.Drawing.Size(88, 23);
            this.modifyVehicle_Button.TabIndex = 3;
            this.modifyVehicle_Button.Text = "Modify Vehicle";
            this.modifyVehicle_Button.UseVisualStyleBackColor = true;
            this.modifyVehicle_Button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userFunction_Label
            // 
            this.userFunction_Label.AutoSize = true;
            this.userFunction_Label.Location = new System.Drawing.Point(26, 54);
            this.userFunction_Label.Name = "userFunction_Label";
            this.userFunction_Label.Size = new System.Drawing.Size(94, 13);
            this.userFunction_Label.TabIndex = 4;
            this.userFunction_Label.Text = "User Management";
            // 
            // addUser_Label
            // 
            this.addUser_Label.Location = new System.Drawing.Point(29, 70);
            this.addUser_Label.Name = "addUser_Label";
            this.addUser_Label.Size = new System.Drawing.Size(75, 23);
            this.addUser_Label.TabIndex = 5;
            this.addUser_Label.Text = "Add User";
            this.addUser_Label.UseVisualStyleBackColor = true;
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(29, 99);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 6;
            this.deleteUser.Text = "Delete User";
            this.deleteUser.UseVisualStyleBackColor = true;
            // 
            // modifyUser_Button
            // 
            this.modifyUser_Button.Location = new System.Drawing.Point(29, 128);
            this.modifyUser_Button.Name = "modifyUser_Button";
            this.modifyUser_Button.Size = new System.Drawing.Size(75, 23);
            this.modifyUser_Button.TabIndex = 7;
            this.modifyUser_Button.Text = "Modify User";
            this.modifyUser_Button.UseVisualStyleBackColor = true;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.modifyUser_Button);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.addUser_Label);
            this.Controls.Add(this.userFunction_Label);
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
        private System.Windows.Forms.Label userFunction_Label;
        private System.Windows.Forms.Button addUser_Label;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button modifyUser_Button;
    }
}