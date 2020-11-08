namespace VehicleManagementSystem
{
    partial class main
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
            this.button1 = new System.Windows.Forms.Button();
            this.makeComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(394, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.makeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vehicleList);
            this.Name = "main";
            this.Text = "Vehicle Management System";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox makeComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Button searchButton;
    }
}

