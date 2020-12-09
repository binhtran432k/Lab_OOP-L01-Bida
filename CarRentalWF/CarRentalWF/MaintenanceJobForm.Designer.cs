
namespace CarRentalWF
{
    partial class MaintenanceJobForm
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
            this.gbVehicle1 = new System.Windows.Forms.GroupBox();
            this.maintenanceDataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVehicle2 = new System.Windows.Forms.GroupBox();
            this.maintenanceDataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbVehicle1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView1)).BeginInit();
            this.gbVehicle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVehicle1
            // 
            this.gbVehicle1.Controls.Add(this.maintenanceDataGridView1);
            this.gbVehicle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVehicle1.Location = new System.Drawing.Point(4, 4);
            this.gbVehicle1.Margin = new System.Windows.Forms.Padding(4);
            this.gbVehicle1.Name = "gbVehicle1";
            this.gbVehicle1.Padding = new System.Windows.Forms.Padding(4);
            this.gbVehicle1.Size = new System.Drawing.Size(492, 481);
            this.gbVehicle1.TabIndex = 0;
            this.gbVehicle1.TabStop = false;
            this.gbVehicle1.Text = "vehicle1";
            // 
            // maintenanceDataGridView1
            // 
            this.maintenanceDataGridView1.AllowUserToAddRows = false;
            this.maintenanceDataGridView1.AllowUserToDeleteRows = false;
            this.maintenanceDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintenanceDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.maintenanceDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.maintenanceDataGridView1.Location = new System.Drawing.Point(8, 27);
            this.maintenanceDataGridView1.Name = "maintenanceDataGridView1";
            this.maintenanceDataGridView1.ReadOnly = true;
            this.maintenanceDataGridView1.RowHeadersVisible = false;
            this.maintenanceDataGridView1.RowHeadersWidth = 51;
            this.maintenanceDataGridView1.RowTemplate.Height = 24;
            this.maintenanceDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maintenanceDataGridView1.Size = new System.Drawing.Size(477, 447);
            this.maintenanceDataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "VehicleID";
            this.Column2.HeaderText = "Vehicle ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Kind";
            this.Column3.HeaderText = "Kind";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 71;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Type";
            this.Column4.HeaderText = "Type";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 74;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Mileage";
            this.Column5.HeaderText = "Mileage";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 96;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cost";
            this.Column6.HeaderText = "Cost";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 73;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Garage";
            this.Column7.HeaderText = "Garage";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 93;
            // 
            // gbVehicle2
            // 
            this.gbVehicle2.Controls.Add(this.maintenanceDataGridView2);
            this.gbVehicle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVehicle2.Location = new System.Drawing.Point(504, 4);
            this.gbVehicle2.Margin = new System.Windows.Forms.Padding(4);
            this.gbVehicle2.Name = "gbVehicle2";
            this.gbVehicle2.Padding = new System.Windows.Forms.Padding(4);
            this.gbVehicle2.Size = new System.Drawing.Size(492, 481);
            this.gbVehicle2.TabIndex = 1;
            this.gbVehicle2.TabStop = false;
            this.gbVehicle2.Text = "vehicle2";
            // 
            // maintenanceDataGridView2
            // 
            this.maintenanceDataGridView2.AllowUserToAddRows = false;
            this.maintenanceDataGridView2.AllowUserToDeleteRows = false;
            this.maintenanceDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maintenanceDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.maintenanceDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.maintenanceDataGridView2.Location = new System.Drawing.Point(8, 26);
            this.maintenanceDataGridView2.Name = "maintenanceDataGridView2";
            this.maintenanceDataGridView2.ReadOnly = true;
            this.maintenanceDataGridView2.RowHeadersVisible = false;
            this.maintenanceDataGridView2.RowHeadersWidth = 51;
            this.maintenanceDataGridView2.RowTemplate.Height = 24;
            this.maintenanceDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maintenanceDataGridView2.Size = new System.Drawing.Size(477, 447);
            this.maintenanceDataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VehicleID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vehicle ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kind";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kind";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 71;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mileage";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 96;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 73;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Garage";
            this.dataGridViewTextBoxColumn7.HeaderText = "Garage";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 93;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.btnCompare);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 73);
            this.panel1.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(116, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(769, 26);
            this.txtResult.TabIndex = 1;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(891, 18);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(98, 43);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubtract.Location = new System.Drawing.Point(12, 18);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(98, 43);
            this.btnSubtract.TabIndex = 0;
            this.btnSubtract.Text = "Substract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.BtnSubstract_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbVehicle1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbVehicle2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 489);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MaintenanceJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaintenanceJobForm";
            this.Text = "MaintainanceJobForm";
            this.Load += new System.EventHandler(this.MaintenanceJobForm_Load);
            this.gbVehicle1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView1)).EndInit();
            this.gbVehicle2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVehicle1;
        private System.Windows.Forms.GroupBox gbVehicle2;
        private System.Windows.Forms.DataGridView maintenanceDataGridView1;
        private System.Windows.Forms.DataGridView maintenanceDataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}