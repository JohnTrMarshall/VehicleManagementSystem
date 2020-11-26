namespace VehicleManagementSystem
{
    partial class Main_Form
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
            this.vehicleList = new System.Windows.Forms.DataGridView();
            this.login_Button = new System.Windows.Forms.Button();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.filter_Button = new System.Windows.Forms.Button();
            this.clearFilter_Button = new System.Windows.Forms.Button();
            this.vehicleList_Label = new System.Windows.Forms.Label();
            this.rentVehicle_button = new System.Windows.Forms.Button();
            this.loanVehicle_button = new System.Windows.Forms.Button();
            this.sellVehicle_button = new System.Windows.Forms.Button();
            this.purchaseVehicle_button = new System.Windows.Forms.Button();
            this.leaseVehicle_button = new System.Windows.Forms.Button();
            this.serviceVehicle_button = new System.Windows.Forms.Button();
            this.userName_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleList
            // 
            this.vehicleList.AllowUserToAddRows = false;
            this.vehicleList.AllowUserToDeleteRows = false;
            this.vehicleList.AllowUserToResizeColumns = false;
            this.vehicleList.AllowUserToResizeRows = false;
            this.vehicleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vehicleList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleList.Location = new System.Drawing.Point(2, 71);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(727, 367);
            this.vehicleList.TabIndex = 1;
            // 
            // login_Button
            // 
            this.login_Button.AutoSize = true;
            this.login_Button.Location = new System.Drawing.Point(664, 14);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // makeComboBox
            // 
            this.makeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(12, 12);
            this.makeComboBox.MaxDropDownItems = 100;
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(121, 21);
            this.makeComboBox.TabIndex = 1;
            this.makeComboBox.SelectedIndexChanged += new System.EventHandler(this.makeComboBox_SelectedIndexChanged);
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(266, 12);
            this.yearComboBox.MaxDropDownItems = 100;
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 3;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(139, 12);
            this.modelComboBox.MaxDropDownItems = 100;
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelComboBox.TabIndex = 2;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // filter_Button
            // 
            this.filter_Button.Location = new System.Drawing.Point(393, 10);
            this.filter_Button.Name = "filter_Button";
            this.filter_Button.Size = new System.Drawing.Size(75, 23);
            this.filter_Button.TabIndex = 4;
            this.filter_Button.Text = "Filter";
            this.filter_Button.UseVisualStyleBackColor = true;
            this.filter_Button.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // clearFilter_Button
            // 
            this.clearFilter_Button.Location = new System.Drawing.Point(474, 10);
            this.clearFilter_Button.Name = "clearFilter_Button";
            this.clearFilter_Button.Size = new System.Drawing.Size(75, 23);
            this.clearFilter_Button.TabIndex = 5;
            this.clearFilter_Button.Text = "Clear Filter";
            this.clearFilter_Button.UseVisualStyleBackColor = true;
            this.clearFilter_Button.Click += new System.EventHandler(this.clearFilter_Button_Click);
            // 
            // vehicleList_Label
            // 
            this.vehicleList_Label.AutoSize = true;
            this.vehicleList_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleList_Label.Location = new System.Drawing.Point(4, 44);
            this.vehicleList_Label.Name = "vehicleList_Label";
            this.vehicleList_Label.Size = new System.Drawing.Size(83, 24);
            this.vehicleList_Label.TabIndex = 6;
            this.vehicleList_Label.Text = "Vehicles";
            // 
            // rentVehicle_button
            // 
            this.rentVehicle_button.Location = new System.Drawing.Point(401, 41);
            this.rentVehicle_button.Name = "rentVehicle_button";
            this.rentVehicle_button.Size = new System.Drawing.Size(71, 23);
            this.rentVehicle_button.TabIndex = 12;
            this.rentVehicle_button.Text = "Rent";
            this.rentVehicle_button.UseVisualStyleBackColor = true;
            // 
            // loanVehicle_button
            // 
            this.loanVehicle_button.Location = new System.Drawing.Point(324, 41);
            this.loanVehicle_button.Name = "loanVehicle_button";
            this.loanVehicle_button.Size = new System.Drawing.Size(71, 23);
            this.loanVehicle_button.TabIndex = 11;
            this.loanVehicle_button.Text = "Loan";
            this.loanVehicle_button.UseVisualStyleBackColor = true;
            // 
            // sellVehicle_button
            // 
            this.sellVehicle_button.Location = new System.Drawing.Point(170, 41);
            this.sellVehicle_button.Name = "sellVehicle_button";
            this.sellVehicle_button.Size = new System.Drawing.Size(71, 23);
            this.sellVehicle_button.TabIndex = 10;
            this.sellVehicle_button.Text = "Sell";
            this.sellVehicle_button.UseVisualStyleBackColor = true;
            // 
            // purchaseVehicle_button
            // 
            this.purchaseVehicle_button.Location = new System.Drawing.Point(93, 41);
            this.purchaseVehicle_button.Name = "purchaseVehicle_button";
            this.purchaseVehicle_button.Size = new System.Drawing.Size(71, 23);
            this.purchaseVehicle_button.TabIndex = 9;
            this.purchaseVehicle_button.Text = "Purchase";
            this.purchaseVehicle_button.UseVisualStyleBackColor = true;
            // 
            // leaseVehicle_button
            // 
            this.leaseVehicle_button.Location = new System.Drawing.Point(247, 41);
            this.leaseVehicle_button.Name = "leaseVehicle_button";
            this.leaseVehicle_button.Size = new System.Drawing.Size(71, 23);
            this.leaseVehicle_button.TabIndex = 8;
            this.leaseVehicle_button.Text = "Lease";
            this.leaseVehicle_button.UseVisualStyleBackColor = true;
            // 
            // serviceVehicle_button
            // 
            this.serviceVehicle_button.Location = new System.Drawing.Point(478, 41);
            this.serviceVehicle_button.Name = "serviceVehicle_button";
            this.serviceVehicle_button.Size = new System.Drawing.Size(71, 23);
            this.serviceVehicle_button.TabIndex = 7;
            this.serviceVehicle_button.Text = "Service";
            this.serviceVehicle_button.UseVisualStyleBackColor = true;
            this.serviceVehicle_button.Click += new System.EventHandler(this.serviceVehicle_Button_Click);
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(605, 14);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(53, 20);
            this.userName_label.TabIndex = 13;
            this.userName_label.Text = "Guest";
            this.userName_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.rentVehicle_button);
            this.Controls.Add(this.loanVehicle_button);
            this.Controls.Add(this.sellVehicle_button);
            this.Controls.Add(this.purchaseVehicle_button);
            this.Controls.Add(this.leaseVehicle_button);
            this.Controls.Add(this.serviceVehicle_button);
            this.Controls.Add(this.vehicleList_Label);
            this.Controls.Add(this.clearFilter_Button);
            this.Controls.Add(this.filter_Button);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.makeComboBox);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.vehicleList);
            this.Name = "Main_Form";
            this.Text = "Vehicle Management System";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleList;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button filter_Button;
        private System.Windows.Forms.Button clearFilter_Button;
        private System.Windows.Forms.Label vehicleList_Label;
        private System.Windows.Forms.Button rentVehicle_button;
        private System.Windows.Forms.Button loanVehicle_button;
        private System.Windows.Forms.Button sellVehicle_button;
        private System.Windows.Forms.Button purchaseVehicle_button;
        private System.Windows.Forms.Button leaseVehicle_button;
        private System.Windows.Forms.Button serviceVehicle_button;
        private System.Windows.Forms.Label userName_label;
    }
}

