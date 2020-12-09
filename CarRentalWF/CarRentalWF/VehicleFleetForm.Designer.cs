namespace CarRentalWF
{
    partial class VehicleFleetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnServeFleet = new System.Windows.Forms.Button();
            this.vehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicleGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnServiceHistory = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.ViewMaintenance = new System.Windows.Forms.Button();
            this.vehicleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(690, 50);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(160, 50);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Vehicle";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnServeFleet
            // 
            this.btnServeFleet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServeFleet.Location = new System.Drawing.Point(690, 476);
            this.btnServeFleet.Margin = new System.Windows.Forms.Padding(4);
            this.btnServeFleet.Name = "btnServeFleet";
            this.btnServeFleet.Size = new System.Drawing.Size(160, 50);
            this.btnServeFleet.TabIndex = 5;
            this.btnServeFleet.Text = "Serve Fleet";
            this.btnServeFleet.UseVisualStyleBackColor = true;
            this.btnServeFleet.Click += new System.EventHandler(this.BtnServeFleet_Click);
            // 
            // vehicleGroupBox
            // 
            this.vehicleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleGroupBox.Controls.Add(this.vehicleGridView);
            this.vehicleGroupBox.Location = new System.Drawing.Point(20, 20);
            this.vehicleGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleGroupBox.Name = "vehicleGroupBox";
            this.vehicleGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.vehicleGroupBox.Size = new System.Drawing.Size(640, 520);
            this.vehicleGroupBox.TabIndex = 2;
            this.vehicleGroupBox.TabStop = false;
            this.vehicleGroupBox.Text = "Vehicle Fleet";
            // 
            // vehicleGridView
            // 
            this.vehicleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.vehicleGridView.Location = new System.Drawing.Point(8, 30);
            this.vehicleGridView.Name = "vehicleGridView";
            this.vehicleGridView.ReadOnly = true;
            this.vehicleGridView.RowHeadersVisible = false;
            this.vehicleGridView.RowHeadersWidth = 51;
            this.vehicleGridView.RowTemplate.Height = 24;
            this.vehicleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleGridView.Size = new System.Drawing.Size(626, 470);
            this.vehicleGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 40;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Type";
            this.Column10.HeaderText = "Type";
            this.Column10.MinimumWidth = 50;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Brand";
            this.Column3.HeaderText = "Brand";
            this.Column3.MinimumWidth = 70;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Color";
            this.Column4.HeaderText = "Color";
            this.Column4.MinimumWidth = 60;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Year";
            this.Column5.HeaderText = "Year";
            this.Column5.MinimumWidth = 50;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NumberOfSeat";
            this.Column6.HeaderText = "Seat";
            this.Column6.MinimumWidth = 46;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Price";
            this.Column7.HeaderText = "Price";
            this.Column7.MinimumWidth = 70;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Condition";
            dataGridViewCellStyle1.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.HeaderText = "Condition";
            this.Column8.MinimumWidth = 76;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Available";
            this.Column9.HeaderText = "Available";
            this.Column9.MinimumWidth = 70;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(690, 121);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Vehicle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(690, 192);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Vehicle";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnServiceHistory
            // 
            this.btnServiceHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceHistory.Location = new System.Drawing.Point(690, 334);
            this.btnServiceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceHistory.Name = "btnServiceHistory";
            this.btnServiceHistory.Size = new System.Drawing.Size(160, 50);
            this.btnServiceHistory.TabIndex = 3;
            this.btnServiceHistory.Text = "View Service History";
            this.btnServiceHistory.UseVisualStyleBackColor = true;
            this.btnServiceHistory.Click += new System.EventHandler(this.BtnServiceHistory_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(690, 405);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 50);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export Service History";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // ViewMaintenance
            // 
            this.ViewMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewMaintenance.Location = new System.Drawing.Point(690, 263);
            this.ViewMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.ViewMaintenance.Name = "ViewMaintenance";
            this.ViewMaintenance.Size = new System.Drawing.Size(160, 50);
            this.ViewMaintenance.TabIndex = 7;
            this.ViewMaintenance.Text = "View Maintenance History";
            this.ViewMaintenance.UseVisualStyleBackColor = true;
            this.ViewMaintenance.Click += new System.EventHandler(this.ViewMaintenance_Click);
            // 
            // VehicleFleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ViewMaintenance);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnServiceHistory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.vehicleGroupBox);
            this.Controls.Add(this.btnServeFleet);
            this.Controls.Add(this.btnNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleFleetForm";
            this.Text = "VehicleFleetForm";
            this.Load += new System.EventHandler(this.VehicleFleetForm_Load);
            this.vehicleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnServeFleet;
        private System.Windows.Forms.GroupBox vehicleGroupBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView vehicleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.Button btnServiceHistory;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button ViewMaintenance;
    }
}
