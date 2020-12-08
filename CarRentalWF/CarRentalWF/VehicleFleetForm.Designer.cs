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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnServeFleet = new System.Windows.Forms.Button();
            this.vehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicleGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button1 = new System.Windows.Forms.Button();
            this.ViewMaintenance = new System.Windows.Forms.Button();
            this.vehicleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(557, 38);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(155, 56);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Vehicle";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnServeFleet
            // 
            this.btnServeFleet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServeFleet.Location = new System.Drawing.Point(557, 477);
            this.btnServeFleet.Margin = new System.Windows.Forms.Padding(4);
            this.btnServeFleet.Name = "btnServeFleet";
            this.btnServeFleet.Size = new System.Drawing.Size(155, 50);
            this.btnServeFleet.TabIndex = 6;
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
            this.vehicleGroupBox.Location = new System.Drawing.Point(35, 26);
            this.vehicleGroupBox.Name = "vehicleGroupBox";
            this.vehicleGroupBox.Size = new System.Drawing.Size(479, 515);
            this.vehicleGroupBox.TabIndex = 2;
            this.vehicleGroupBox.TabStop = false;
            this.vehicleGroupBox.Text = "Vehicle Fleet";
            // 
            // vehicleGridView
            // 
            this.vehicleGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.vehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.vehicleGridView.Location = new System.Drawing.Point(6, 37);
            this.vehicleGridView.Name = "vehicleGridView";
            this.vehicleGridView.ReadOnly = true;
            this.vehicleGridView.RowHeadersWidth = 51;
            this.vehicleGridView.RowTemplate.Height = 24;
            this.vehicleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehicleGridView.Size = new System.Drawing.Size(467, 464);
            this.vehicleGridView.TabIndex = 0;
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
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 82;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Brand";
            this.Column3.HeaderText = "Brand";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 83;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Color";
            this.Column4.HeaderText = "Color";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Year";
            this.Column5.HeaderText = "Year";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 72;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NumberOfSeat";
            this.Column6.HeaderText = "Seat";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 72;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Price";
            this.Column7.HeaderText = "Price";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 77;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Condition";
            this.Column8.HeaderText = "Condition";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 108;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Available";
            this.Column9.HeaderText = "Available";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 82;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(557, 119);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Vehicle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(557, 199);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Vehicle";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnServiceHistory
            // 
            this.btnServiceHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceHistory.Location = new System.Drawing.Point(557, 328);
            this.btnServiceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceHistory.Name = "btnServiceHistory";
            this.btnServiceHistory.Size = new System.Drawing.Size(155, 50);
            this.btnServiceHistory.TabIndex = 3;
            this.btnServiceHistory.Text = "View Service History";
            this.btnServiceHistory.UseVisualStyleBackColor = true;
            this.btnServiceHistory.Click += new System.EventHandler(this.BtnServiceHistory_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(557, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export Service History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewMaintenance
            // 
            this.ViewMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewMaintenance.Location = new System.Drawing.Point(557, 257);
            this.ViewMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.ViewMaintenance.Name = "ViewMaintenance";
            this.ViewMaintenance.Size = new System.Drawing.Size(155, 50);
            this.ViewMaintenance.TabIndex = 7;
            this.ViewMaintenance.Text = "View Maintenance History";
            this.ViewMaintenance.UseVisualStyleBackColor = true;
            this.ViewMaintenance.Click += new System.EventHandler(this.ViewMaintenance_Click);
            // 
            // VehicleFleetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 562);
            this.Controls.Add(this.ViewMaintenance);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.Button btnServiceHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ViewMaintenance;
    }
}