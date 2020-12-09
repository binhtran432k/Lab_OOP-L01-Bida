
namespace CarRentalWF
{
    partial class RentUserForm
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
            this.btnRent = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbCustomEndDate = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(263, 189);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(94, 42);
            this.btnRent.TabIndex = 7;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(153, 34);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(204, 23);
            this.txtCustomer.TabIndex = 1;
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(153, 157);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(204, 23);
            this.txtPeriod.TabIndex = 5;
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(6, 161);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(131, 20);
            this.lblPeriod.TabIndex = 0;
            this.lblPeriod.Text = " Period (Day)";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(6, 78);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(131, 20);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.cbCustomEndDate);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnRent);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.txtPeriod);
            this.groupBox1.Controls.Add(this.lblPeriod);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Info";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(6, 119);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(131, 20);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(153, 116);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(204, 23);
            this.dtEndDate.TabIndex = 12;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(153, 75);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(204, 23);
            this.dtStartDate.TabIndex = 11;
            // 
            // cbCustomEndDate
            // 
            this.cbCustomEndDate.AutoSize = true;
            this.cbCustomEndDate.Location = new System.Drawing.Point(80, 205);
            this.cbCustomEndDate.Name = "cbCustomEndDate";
            this.cbCustomEndDate.Size = new System.Drawing.Size(137, 21);
            this.cbCustomEndDate.TabIndex = 10;
            this.cbCustomEndDate.Text = "Custom End Date";
            this.cbCustomEndDate.UseVisualStyleBackColor = true;
            this.cbCustomEndDate.CheckedChanged += new System.EventHandler(this.CbCustomEndDate_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCondition);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblSeat);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.lblBrand);
            this.groupBox2.Controls.Add(this.lblVehicleName);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(430, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 266);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehicle Info";
            // 
            // lblCondition
            // 
            this.lblCondition.Location = new System.Drawing.Point(112, 205);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(209, 24);
            this.lblCondition.TabIndex = 23;
            this.lblCondition.Text = "NULL";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(112, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(209, 24);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "NULL";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeat
            // 
            this.lblSeat.Location = new System.Drawing.Point(112, 157);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(209, 24);
            this.lblSeat.TabIndex = 21;
            this.lblSeat.Text = "NULL";
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(112, 133);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(209, 24);
            this.lblYear.TabIndex = 20;
            this.lblYear.Text = "NULL";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(112, 109);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(209, 24);
            this.lblColor.TabIndex = 19;
            this.lblColor.Text = "NULL";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(112, 85);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(209, 24);
            this.lblBrand.TabIndex = 18;
            this.lblBrand.Text = "NULL";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.Location = new System.Drawing.Point(112, 61);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(209, 24);
            this.lblVehicleName.TabIndex = 17;
            this.lblVehicleName.Text = "NULL";
            this.lblVehicleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(112, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(209, 24);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "NULL";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Condition:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seat:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brand:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RentUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RentUserForm";
            this.Text = "RentUserForm";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.CheckBox cbCustomEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
    }
}