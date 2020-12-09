namespace CarRentalWF
{
    partial class RentInfoForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.cbCustomEndDate = new System.Windows.Forms.CheckBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer ID";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(153, 34);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(204, 23);
            this.txtCustomer.TabIndex = 1;
            // 
            // lblVehicle
            // 
            this.lblVehicle.Location = new System.Drawing.Point(6, 81);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(131, 20);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "Vehicle ID";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(153, 73);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(204, 23);
            this.txtVehicle.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(6, 119);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(131, 20);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(6, 157);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(131, 20);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 309);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(153, 307);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(204, 24);
            this.cbStatus.TabIndex = 6;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.CbStatus_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 42);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtReturnDate);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.lblPeriod);
            this.groupBox1.Controls.Add(this.lblReturn);
            this.groupBox1.Controls.Add(this.lblMileage);
            this.groupBox1.Controls.Add(this.cbCustomEndDate);
            this.groupBox1.Controls.Add(this.txtMileage);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.lblVehicle);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtVehicle);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Info";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.CustomFormat = "dd/MM/yyyy";
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReturnDate.Location = new System.Drawing.Point(153, 229);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(204, 23);
            this.dtReturnDate.TabIndex = 15;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(153, 151);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(204, 23);
            this.dtEndDate.TabIndex = 14;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(153, 190);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(204, 23);
            this.txtPeriod.TabIndex = 14;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(153, 112);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(204, 23);
            this.dtStartDate.TabIndex = 13;
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(6, 195);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(131, 20);
            this.lblPeriod.TabIndex = 13;
            this.lblPeriod.Text = "Period (Day)";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReturn
            // 
            this.lblReturn.Location = new System.Drawing.Point(6, 233);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(131, 20);
            this.lblReturn.TabIndex = 12;
            this.lblReturn.Text = "Return Date";
            this.lblReturn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMileage
            // 
            this.lblMileage.Location = new System.Drawing.Point(6, 271);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(131, 20);
            this.lblMileage.TabIndex = 10;
            this.lblMileage.Text = "Mileage";
            this.lblMileage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCustomEndDate
            // 
            this.cbCustomEndDate.AutoSize = true;
            this.cbCustomEndDate.Location = new System.Drawing.Point(87, 367);
            this.cbCustomEndDate.Name = "cbCustomEndDate";
            this.cbCustomEndDate.Size = new System.Drawing.Size(137, 21);
            this.cbCustomEndDate.TabIndex = 9;
            this.cbCustomEndDate.Text = "Custom End Date";
            this.cbCustomEndDate.UseVisualStyleBackColor = true;
            this.cbCustomEndDate.CheckedChanged += new System.EventHandler(this.CbCustomEndDate_CheckedChanged);
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(153, 268);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(204, 23);
            this.txtMileage.TabIndex = 8;
            // 
            // RentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 453);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RentInfoForm";
            this.Text = "RentInfoForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RentInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.CheckBox cbCustomEndDate;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
    }
}