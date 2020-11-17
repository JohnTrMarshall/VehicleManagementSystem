﻿namespace VehicleManagementSystem
{
    partial class customerInfo_Form
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
            this.existingCustomer_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearCustomer_Button = new System.Windows.Forms.Button();
            this.addCustomer_Button = new System.Windows.Forms.Button();
            this.newCustomer_Label = new System.Windows.Forms.Label();
            this.phoneNumber_Textbox = new System.Windows.Forms.TextBox();
            this.zip_Textbox = new System.Windows.Forms.TextBox();
            this.state_Textbox = new System.Windows.Forms.TextBox();
            this.street_Textbox = new System.Windows.Forms.TextBox();
            this.email_Textbox = new System.Windows.Forms.TextBox();
            this.city_Textbox = new System.Windows.Forms.TextBox();
            this.name_Textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // existingCustomer_Label
            // 
            this.existingCustomer_Label.AutoSize = true;
            this.existingCustomer_Label.Location = new System.Drawing.Point(545, 84);
            this.existingCustomer_Label.Name = "existingCustomer_Label";
            this.existingCustomer_Label.Size = new System.Drawing.Size(90, 13);
            this.existingCustomer_Label.TabIndex = 8;
            this.existingCustomer_Label.Text = "Existing Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // clearCustomer_Button
            // 
            this.clearCustomer_Button.Location = new System.Drawing.Point(143, 282);
            this.clearCustomer_Button.Name = "clearCustomer_Button";
            this.clearCustomer_Button.Size = new System.Drawing.Size(81, 23);
            this.clearCustomer_Button.TabIndex = 32;
            this.clearCustomer_Button.Text = "Clear";
            this.clearCustomer_Button.UseVisualStyleBackColor = true;
            this.clearCustomer_Button.Click += new System.EventHandler(this.clearCustomer_Button_Click);
            // 
            // addCustomer_Button
            // 
            this.addCustomer_Button.Location = new System.Drawing.Point(56, 282);
            this.addCustomer_Button.Name = "addCustomer_Button";
            this.addCustomer_Button.Size = new System.Drawing.Size(81, 23);
            this.addCustomer_Button.TabIndex = 31;
            this.addCustomer_Button.Text = "Add Customer";
            this.addCustomer_Button.UseVisualStyleBackColor = true;
            // 
            // newCustomer_Label
            // 
            this.newCustomer_Label.AutoSize = true;
            this.newCustomer_Label.Location = new System.Drawing.Point(53, 84);
            this.newCustomer_Label.Name = "newCustomer_Label";
            this.newCustomer_Label.Size = new System.Drawing.Size(76, 13);
            this.newCustomer_Label.TabIndex = 30;
            this.newCustomer_Label.Text = "New Customer";
            // 
            // phoneNumber_Textbox
            // 
            this.phoneNumber_Textbox.Location = new System.Drawing.Point(56, 230);
            this.phoneNumber_Textbox.Name = "phoneNumber_Textbox";
            this.phoneNumber_Textbox.Size = new System.Drawing.Size(168, 20);
            this.phoneNumber_Textbox.TabIndex = 29;
            this.phoneNumber_Textbox.Text = "Phone Number";
            // 
            // zip_Textbox
            // 
            this.zip_Textbox.Location = new System.Drawing.Point(56, 204);
            this.zip_Textbox.Name = "zip_Textbox";
            this.zip_Textbox.Size = new System.Drawing.Size(168, 20);
            this.zip_Textbox.TabIndex = 28;
            this.zip_Textbox.Text = "Zip";
            // 
            // state_Textbox
            // 
            this.state_Textbox.Location = new System.Drawing.Point(56, 178);
            this.state_Textbox.Name = "state_Textbox";
            this.state_Textbox.Size = new System.Drawing.Size(168, 20);
            this.state_Textbox.TabIndex = 27;
            this.state_Textbox.Text = "State";
            // 
            // street_Textbox
            // 
            this.street_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.street_Textbox.Location = new System.Drawing.Point(56, 126);
            this.street_Textbox.Name = "street_Textbox";
            this.street_Textbox.Size = new System.Drawing.Size(168, 20);
            this.street_Textbox.TabIndex = 26;
            this.street_Textbox.Text = "Street";
            // 
            // email_Textbox
            // 
            this.email_Textbox.Location = new System.Drawing.Point(56, 256);
            this.email_Textbox.Name = "email_Textbox";
            this.email_Textbox.Size = new System.Drawing.Size(168, 20);
            this.email_Textbox.TabIndex = 25;
            this.email_Textbox.Text = "Email";
            // 
            // city_Textbox
            // 
            this.city_Textbox.Location = new System.Drawing.Point(56, 152);
            this.city_Textbox.Name = "city_Textbox";
            this.city_Textbox.Size = new System.Drawing.Size(168, 20);
            this.city_Textbox.TabIndex = 24;
            this.city_Textbox.Text = "City";
            // 
            // name_Textbox
            // 
            this.name_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_Textbox.Location = new System.Drawing.Point(56, 100);
            this.name_Textbox.Name = "name_Textbox";
            this.name_Textbox.Size = new System.Drawing.Size(168, 20);
            this.name_Textbox.TabIndex = 23;
            this.name_Textbox.Text = "Name";
            this.name_Textbox.Click += new System.EventHandler(this.name_Textbox_Click);
            this.name_Textbox.TextChanged += new System.EventHandler(this.name_Textbox_TextChanged);
            // 
            // customerInfo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearCustomer_Button);
            this.Controls.Add(this.addCustomer_Button);
            this.Controls.Add(this.newCustomer_Label);
            this.Controls.Add(this.phoneNumber_Textbox);
            this.Controls.Add(this.zip_Textbox);
            this.Controls.Add(this.state_Textbox);
            this.Controls.Add(this.street_Textbox);
            this.Controls.Add(this.email_Textbox);
            this.Controls.Add(this.city_Textbox);
            this.Controls.Add(this.name_Textbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.existingCustomer_Label);
            this.Name = "customerInfo_Form";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.customerInfo_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label existingCustomer_Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clearCustomer_Button;
        private System.Windows.Forms.Button addCustomer_Button;
        private System.Windows.Forms.Label newCustomer_Label;
        private System.Windows.Forms.TextBox phoneNumber_Textbox;
        private System.Windows.Forms.TextBox zip_Textbox;
        private System.Windows.Forms.TextBox state_Textbox;
        private System.Windows.Forms.TextBox street_Textbox;
        private System.Windows.Forms.TextBox email_Textbox;
        private System.Windows.Forms.TextBox city_Textbox;
        private System.Windows.Forms.TextBox name_Textbox;
    }
}