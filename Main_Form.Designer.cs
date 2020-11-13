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
            this.filterVehicles_Button = new System.Windows.Forms.Button();
            this.clearFilter_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleList
            // 
            this.vehicleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleList.Location = new System.Drawing.Point(12, 71);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(776, 367);
            this.vehicleList.TabIndex = 1;
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(713, 12);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // makeComboBox
            // 
            this.makeComboBox.FormattingEnabled = true;
            this.makeComboBox.Location = new System.Drawing.Point(12, 14);
            this.makeComboBox.Name = "makeComboBox";
            this.makeComboBox.Size = new System.Drawing.Size(121, 21);
            this.makeComboBox.TabIndex = 11;
            this.makeComboBox.Text = "Make";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(266, 14);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 12;
            this.yearComboBox.Text = "Year";
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(139, 14);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelComboBox.TabIndex = 13;
            this.modelComboBox.Text = "Model";
            // 
            // filterVehicles_Button
            // 
            this.filterVehicles_Button.Location = new System.Drawing.Point(394, 11);
            this.filterVehicles_Button.Name = "filterVehicles_Button";
            this.filterVehicles_Button.Size = new System.Drawing.Size(75, 23);
            this.filterVehicles_Button.TabIndex = 14;
            this.filterVehicles_Button.Text = "Filter";
            this.filterVehicles_Button.UseVisualStyleBackColor = true;
            this.filterVehicles_Button.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearFilter_Button
            // 
            this.clearFilter_Button.Location = new System.Drawing.Point(475, 11);
            this.clearFilter_Button.Name = "clearFilter_Button";
            this.clearFilter_Button.Size = new System.Drawing.Size(75, 23);
            this.clearFilter_Button.TabIndex = 15;
            this.clearFilter_Button.Text = "Clear Filter";
            this.clearFilter_Button.UseVisualStyleBackColor = true;
            this.clearFilter_Button.Click += new System.EventHandler(this.clearFilter_Button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.clearFilter_Button);
            this.Controls.Add(this.filterVehicles_Button);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleList;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button filterVehicles_Button;
        private System.Windows.Forms.Button clearFilter_Button;
    }
}

