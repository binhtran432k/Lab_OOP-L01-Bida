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
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.cbCustomEndDate = new System.Windows.Forms.CheckBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
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
            this.lblVehicle.Location = new System.Drawing.Point(6, 74);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(131, 20);
            this.lblVehicle.TabIndex = 0;
            this.lblVehicle.Text = "Vehicle ID";
            this.lblVehicle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(153, 71);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(204, 23);
            this.txtVehicle.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(6, 148);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(131, 20);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(153, 145);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(204, 23);
            this.txtStartDate.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(6, 185);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(131, 20);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(153, 182);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(204, 23);
            this.txtEndDate.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(6, 259);
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
            this.cbStatus.Location = new System.Drawing.Point(153, 256);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(204, 24);
            this.cbStatus.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(263, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 42);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReturn);
            this.groupBox1.Controls.Add(this.txtReturnDate);
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
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Controls.Add(this.lblStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Info";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(153, 108);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(204, 23);
            this.txtMileage.TabIndex = 8;
            // 
            // cbCustomEndDate
            // 
            this.cbCustomEndDate.AutoSize = true;
            this.cbCustomEndDate.Location = new System.Drawing.Point(87, 314);
            this.cbCustomEndDate.Name = "cbCustomEndDate";
            this.cbCustomEndDate.Size = new System.Drawing.Size(137, 21);
            this.cbCustomEndDate.TabIndex = 9;
            this.cbCustomEndDate.Text = "Custom End Date";
            this.cbCustomEndDate.UseVisualStyleBackColor = true;
            this.cbCustomEndDate.CheckedChanged += new System.EventHandler(this.cbCustomEndDate_CheckedChanged);
            // 
            // lblMileage
            // 
            this.lblMileage.Location = new System.Drawing.Point(6, 111);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(131, 20);
            this.lblMileage.TabIndex = 10;
            this.lblMileage.Text = "Mileage";
            this.lblMileage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Location = new System.Drawing.Point(153, 219);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(204, 23);
            this.txtReturnDate.TabIndex = 11;
            // 
            // lblReturn
            // 
            this.lblReturn.Location = new System.Drawing.Point(6, 222);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(131, 20);
            this.lblReturn.TabIndex = 12;
            this.lblReturn.Text = "Return Date";
            this.lblReturn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 382);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentInfoForm";
            this.Text = "RentInfoForm";
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
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.CheckBox cbCustomEndDate;
        private System.Windows.Forms.TextBox txtMileage;
    }
}