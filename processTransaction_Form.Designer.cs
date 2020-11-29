namespace VehicleManagementSystem
{
    partial class processTransaction_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vin_textbox = new System.Windows.Forms.TextBox();
            this.model_textbox = new System.Windows.Forms.TextBox();
            this.make_textbox = new System.Windows.Forms.TextBox();
            this.vin_label = new System.Windows.Forms.Label();
            this.year_textbox = new System.Windows.Forms.TextBox();
            this.process_textbox = new System.Windows.Forms.TextBox();
            this.color_textbox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.mileage_label = new System.Windows.Forms.Label();
            this.mileage_textbox = new System.Windows.Forms.TextBox();
            this.employeeName_label = new System.Windows.Forms.Label();
            this.employeeName_textbox = new System.Windows.Forms.TextBox();
            this.vehicleLabel_label = new System.Windows.Forms.Label();
            this.customerInfo_label = new System.Windows.Forms.Label();
            this.clearCustomer_Button = new System.Windows.Forms.Button();
            this.addCustomer_Button = new System.Windows.Forms.Button();
            this.phoneNumber_Textbox = new System.Windows.Forms.TextBox();
            this.zip_Textbox = new System.Windows.Forms.TextBox();
            this.state_Textbox = new System.Windows.Forms.TextBox();
            this.street_Textbox = new System.Windows.Forms.TextBox();
            this.email_Textbox = new System.Windows.Forms.TextBox();
            this.city_Textbox = new System.Windows.Forms.TextBox();
            this.firstName_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.newCustomer_Label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lastName_textbox = new System.Windows.Forms.TextBox();
            this.confirmTransaction_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Process";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_label.Location = new System.Drawing.Point(26, 232);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(46, 20);
            this.color_label.TabIndex = 2;
            this.color_label.Text = "Color";
            this.color_label.Click += new System.EventHandler(this.color_label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // vin_textbox
            // 
            this.vin_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vin_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vin_textbox.Location = new System.Drawing.Point(86, 309);
            this.vin_textbox.Name = "vin_textbox";
            this.vin_textbox.Size = new System.Drawing.Size(210, 26);
            this.vin_textbox.TabIndex = 16;
            this.vin_textbox.Text = "Vin";
            // 
            // model_textbox
            // 
            this.model_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.model_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_textbox.Location = new System.Drawing.Point(84, 149);
            this.model_textbox.Name = "model_textbox";
            this.model_textbox.Size = new System.Drawing.Size(212, 26);
            this.model_textbox.TabIndex = 12;
            this.model_textbox.Text = "Model";
            // 
            // make_textbox
            // 
            this.make_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.make_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_textbox.Location = new System.Drawing.Point(84, 109);
            this.make_textbox.Name = "make_textbox";
            this.make_textbox.Size = new System.Drawing.Size(212, 26);
            this.make_textbox.TabIndex = 11;
            this.make_textbox.Text = "Make";
            // 
            // vin_label
            // 
            this.vin_label.AutoSize = true;
            this.vin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vin_label.Location = new System.Drawing.Point(36, 312);
            this.vin_label.Name = "vin_label";
            this.vin_label.Size = new System.Drawing.Size(36, 20);
            this.vin_label.TabIndex = 8;
            this.vin_label.Text = "VIN";
            this.vin_label.Click += new System.EventHandler(this.vin_label_Click);
            // 
            // year_textbox
            // 
            this.year_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.year_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textbox.Location = new System.Drawing.Point(86, 189);
            this.year_textbox.Name = "year_textbox";
            this.year_textbox.Size = new System.Drawing.Size(210, 26);
            this.year_textbox.TabIndex = 13;
            this.year_textbox.Text = "Year";
            // 
            // process_textbox
            // 
            this.process_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.process_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_textbox.Location = new System.Drawing.Point(86, 15);
            this.process_textbox.Name = "process_textbox";
            this.process_textbox.Size = new System.Drawing.Size(100, 26);
            this.process_textbox.TabIndex = 30;
            this.process_textbox.Text = "Transaction";
            // 
            // color_textbox
            // 
            this.color_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.color_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_textbox.Location = new System.Drawing.Point(86, 229);
            this.color_textbox.Name = "color_textbox";
            this.color_textbox.Size = new System.Drawing.Size(210, 26);
            this.color_textbox.TabIndex = 14;
            this.color_textbox.Text = "Color";
            this.color_textbox.TextChanged += new System.EventHandler(this.color_textbox_TextChanged);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(28, 352);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(44, 20);
            this.price_label.TabIndex = 12;
            this.price_label.Text = "Price";
            // 
            // price_textbox
            // 
            this.price_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.price_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_textbox.Location = new System.Drawing.Point(86, 349);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(210, 26);
            this.price_textbox.TabIndex = 17;
            this.price_textbox.Text = "Price";
            // 
            // mileage_label
            // 
            this.mileage_label.AutoSize = true;
            this.mileage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileage_label.Location = new System.Drawing.Point(8, 272);
            this.mileage_label.Name = "mileage_label";
            this.mileage_label.Size = new System.Drawing.Size(64, 20);
            this.mileage_label.TabIndex = 14;
            this.mileage_label.Text = "Mileage";
            // 
            // mileage_textbox
            // 
            this.mileage_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mileage_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mileage_textbox.Location = new System.Drawing.Point(84, 269);
            this.mileage_textbox.Name = "mileage_textbox";
            this.mileage_textbox.Size = new System.Drawing.Size(212, 26);
            this.mileage_textbox.TabIndex = 15;
            this.mileage_textbox.Text = "Mileage";
            // 
            // employeeName_label
            // 
            this.employeeName_label.AutoSize = true;
            this.employeeName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName_label.Location = new System.Drawing.Point(543, 15);
            this.employeeName_label.Name = "employeeName_label";
            this.employeeName_label.Size = new System.Drawing.Size(79, 20);
            this.employeeName_label.TabIndex = 17;
            this.employeeName_label.Text = "Employee";
            // 
            // employeeName_textbox
            // 
            this.employeeName_textbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.employeeName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName_textbox.Location = new System.Drawing.Point(632, 12);
            this.employeeName_textbox.Name = "employeeName_textbox";
            this.employeeName_textbox.Size = new System.Drawing.Size(156, 26);
            this.employeeName_textbox.TabIndex = 30;
            this.employeeName_textbox.Text = "Employee Name";
            // 
            // vehicleLabel_label
            // 
            this.vehicleLabel_label.AutoSize = true;
            this.vehicleLabel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLabel_label.Location = new System.Drawing.Point(12, 68);
            this.vehicleLabel_label.Name = "vehicleLabel_label";
            this.vehicleLabel_label.Size = new System.Drawing.Size(146, 20);
            this.vehicleLabel_label.TabIndex = 19;
            this.vehicleLabel_label.Text = "Vehicle Information";
            // 
            // customerInfo_label
            // 
            this.customerInfo_label.AutoSize = true;
            this.customerInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfo_label.Location = new System.Drawing.Point(414, 68);
            this.customerInfo_label.Name = "customerInfo_label";
            this.customerInfo_label.Size = new System.Drawing.Size(163, 20);
            this.customerInfo_label.TabIndex = 21;
            this.customerInfo_label.Text = "Customer Information";
            // 
            // clearCustomer_Button
            // 
            this.clearCustomer_Button.Location = new System.Drawing.Point(679, 218);
            this.clearCustomer_Button.Name = "clearCustomer_Button";
            this.clearCustomer_Button.Size = new System.Drawing.Size(81, 23);
            this.clearCustomer_Button.TabIndex = 10;
            this.clearCustomer_Button.Text = "Clear";
            this.clearCustomer_Button.UseVisualStyleBackColor = true;
            this.clearCustomer_Button.Click += new System.EventHandler(this.clearCustomer_Button_Click_1);
            // 
            // addCustomer_Button
            // 
            this.addCustomer_Button.Location = new System.Drawing.Point(592, 218);
            this.addCustomer_Button.Name = "addCustomer_Button";
            this.addCustomer_Button.Size = new System.Drawing.Size(81, 23);
            this.addCustomer_Button.TabIndex = 9;
            this.addCustomer_Button.Text = "Add Customer";
            this.addCustomer_Button.UseVisualStyleBackColor = true;
            this.addCustomer_Button.Click += new System.EventHandler(this.addCustomer_Button_Click_1);
            // 
            // phoneNumber_Textbox
            // 
            this.phoneNumber_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneNumber_Textbox.Location = new System.Drawing.Point(418, 192);
            this.phoneNumber_Textbox.Name = "phoneNumber_Textbox";
            this.phoneNumber_Textbox.Size = new System.Drawing.Size(168, 20);
            this.phoneNumber_Textbox.TabIndex = 7;
            this.phoneNumber_Textbox.Text = "Phone Number";
            this.phoneNumber_Textbox.Click += new System.EventHandler(this.phoneNumber_Textbox_Click);
            this.phoneNumber_Textbox.LostFocus += new System.EventHandler(this.phoneNumber_Textbox_LostFocus);
            // 
            // zip_Textbox
            // 
            this.zip_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.zip_Textbox.Location = new System.Drawing.Point(592, 166);
            this.zip_Textbox.Name = "zip_Textbox";
            this.zip_Textbox.Size = new System.Drawing.Size(168, 20);
            this.zip_Textbox.TabIndex = 6;
            this.zip_Textbox.Text = "Zip";
            this.zip_Textbox.Click += new System.EventHandler(this.zip_Textbox_Click);
            this.zip_Textbox.LostFocus += new System.EventHandler(this.zip_Textbox_LostFocus);
            // 
            // state_Textbox
            // 
            this.state_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.state_Textbox.Location = new System.Drawing.Point(418, 166);
            this.state_Textbox.Name = "state_Textbox";
            this.state_Textbox.Size = new System.Drawing.Size(168, 20);
            this.state_Textbox.TabIndex = 5;
            this.state_Textbox.Text = "State";
            this.state_Textbox.Click += new System.EventHandler(this.state_Textbox_Click);
            this.state_Textbox.LostFocus += new System.EventHandler(this.state_Textbox_LostFocus);
            // 
            // street_Textbox
            // 
            this.street_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.street_Textbox.Location = new System.Drawing.Point(418, 140);
            this.street_Textbox.Name = "street_Textbox";
            this.street_Textbox.Size = new System.Drawing.Size(168, 20);
            this.street_Textbox.TabIndex = 3;
            this.street_Textbox.Text = "Street";
            this.street_Textbox.Click += new System.EventHandler(this.street_Textbox_Click);
            this.street_Textbox.LostFocus += new System.EventHandler(this.street_Textbox_LostFocus);
            // 
            // email_Textbox
            // 
            this.email_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.email_Textbox.Location = new System.Drawing.Point(592, 192);
            this.email_Textbox.Name = "email_Textbox";
            this.email_Textbox.Size = new System.Drawing.Size(168, 20);
            this.email_Textbox.TabIndex = 8;
            this.email_Textbox.Text = "Email";
            this.email_Textbox.Click += new System.EventHandler(this.email_Textbox_Click);
            this.email_Textbox.LostFocus += new System.EventHandler(this.email_Textbox_LostFocus);
            // 
            // city_Textbox
            // 
            this.city_Textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.city_Textbox.Location = new System.Drawing.Point(592, 140);
            this.city_Textbox.Name = "city_Textbox";
            this.city_Textbox.Size = new System.Drawing.Size(168, 20);
            this.city_Textbox.TabIndex = 4;
            this.city_Textbox.Text = "City";
            this.city_Textbox.Click += new System.EventHandler(this.city_Textbox_Click);
            this.city_Textbox.LostFocus += new System.EventHandler(this.city_Textbox_LostFocus);
            // 
            // firstName_textbox
            // 
            this.firstName_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.firstName_textbox.Location = new System.Drawing.Point(418, 114);
            this.firstName_textbox.Name = "firstName_textbox";
            this.firstName_textbox.Size = new System.Drawing.Size(168, 20);
            this.firstName_textbox.TabIndex = 1;
            this.firstName_textbox.Text = "First Name";
            this.firstName_textbox.Click += new System.EventHandler(this.firstName_Textbox_Click);
            this.firstName_textbox.LostFocus += new System.EventHandler(this.firstNameTextbox_LostFocus);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 180);
            this.dataGridView1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Existing Customer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newCustomer_Label
            // 
            this.newCustomer_Label.AutoSize = true;
            this.newCustomer_Label.Location = new System.Drawing.Point(415, 98);
            this.newCustomer_Label.Name = "newCustomer_Label";
            this.newCustomer_Label.Size = new System.Drawing.Size(76, 13);
            this.newCustomer_Label.TabIndex = 40;
            this.newCustomer_Label.Text = "New Customer";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 52);
            this.splitter1.TabIndex = 41;
            this.splitter1.TabStop = false;
            // 
            // lastName_textbox
            // 
            this.lastName_textbox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lastName_textbox.Location = new System.Drawing.Point(592, 114);
            this.lastName_textbox.Name = "lastName_textbox";
            this.lastName_textbox.Size = new System.Drawing.Size(168, 20);
            this.lastName_textbox.TabIndex = 2;
            this.lastName_textbox.Text = "Last Name";
            this.lastName_textbox.Click += new System.EventHandler(this.lastName_Textbox_Click);
            this.lastName_textbox.LostFocus += new System.EventHandler(this.lastNameTextbox_LostFocus);
            // 
            // confirmTransaction_button
            // 
            this.confirmTransaction_button.Location = new System.Drawing.Point(83, 401);
            this.confirmTransaction_button.Name = "confirmTransaction_button";
            this.confirmTransaction_button.Size = new System.Drawing.Size(89, 37);
            this.confirmTransaction_button.TabIndex = 18;
            this.confirmTransaction_button.Text = "Confirm Transaction";
            this.confirmTransaction_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel Transacction";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // processTransaction_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmTransaction_button);
            this.Controls.Add(this.lastName_textbox);
            this.Controls.Add(this.newCustomer_Label);
            this.Controls.Add(this.clearCustomer_Button);
            this.Controls.Add(this.addCustomer_Button);
            this.Controls.Add(this.phoneNumber_Textbox);
            this.Controls.Add(this.zip_Textbox);
            this.Controls.Add(this.state_Textbox);
            this.Controls.Add(this.street_Textbox);
            this.Controls.Add(this.email_Textbox);
            this.Controls.Add(this.city_Textbox);
            this.Controls.Add(this.firstName_textbox);
            this.Controls.Add(this.customerInfo_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicleLabel_label);
            this.Controls.Add(this.employeeName_label);
            this.Controls.Add(this.employeeName_textbox);
            this.Controls.Add(this.mileage_textbox);
            this.Controls.Add(this.mileage_label);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.color_textbox);
            this.Controls.Add(this.process_textbox);
            this.Controls.Add(this.year_textbox);
            this.Controls.Add(this.vin_label);
            this.Controls.Add(this.make_textbox);
            this.Controls.Add(this.model_textbox);
            this.Controls.Add(this.vin_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "processTransaction_Form";
            this.Text = "Process Transaction";
            this.Load += new System.EventHandler(this.vehicleInfo_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vin_textbox;
        private System.Windows.Forms.TextBox model_textbox;
        private System.Windows.Forms.TextBox make_textbox;
        private System.Windows.Forms.Label vin_label;
        private System.Windows.Forms.TextBox year_textbox;
        private System.Windows.Forms.TextBox process_textbox;
        private System.Windows.Forms.TextBox color_textbox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.Label mileage_label;
        private System.Windows.Forms.TextBox mileage_textbox;
        private System.Windows.Forms.Label employeeName_label;
        private System.Windows.Forms.TextBox employeeName_textbox;
        private System.Windows.Forms.Label vehicleLabel_label;
        private System.Windows.Forms.Label customerInfo_label;
        private System.Windows.Forms.Button clearCustomer_Button;
        private System.Windows.Forms.Button addCustomer_Button;
        private System.Windows.Forms.TextBox phoneNumber_Textbox;
        private System.Windows.Forms.TextBox zip_Textbox;
        private System.Windows.Forms.TextBox state_Textbox;
        private System.Windows.Forms.TextBox street_Textbox;
        private System.Windows.Forms.TextBox email_Textbox;
        private System.Windows.Forms.TextBox city_Textbox;
        private System.Windows.Forms.TextBox firstName_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newCustomer_Label;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox lastName_textbox;
        private System.Windows.Forms.Button confirmTransaction_button;
        private System.Windows.Forms.Button button1;
    }
}