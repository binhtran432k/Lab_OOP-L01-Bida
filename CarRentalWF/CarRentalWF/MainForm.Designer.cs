﻿namespace CarRentalWF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelNavMenu = new System.Windows.Forms.Panel();
            this.customerBtn = new System.Windows.Forms.Button();
            this.rentalBtn = new System.Windows.Forms.Button();
            this.rentVehicleBtn = new System.Windows.Forms.Button();
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelNavMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavMenu
            // 
            this.panelNavMenu.AutoScroll = true;
            this.panelNavMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelNavMenu.Controls.Add(this.customerBtn);
            this.panelNavMenu.Controls.Add(this.rentalBtn);
            this.panelNavMenu.Controls.Add(this.rentVehicleBtn);
            this.panelNavMenu.Controls.Add(this.vehicleBtn);
            this.panelNavMenu.Controls.Add(this.homeBtn);
            this.panelNavMenu.Controls.Add(this.panelLogo);
            this.panelNavMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavMenu.Location = new System.Drawing.Point(0, 1);
            this.panelNavMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavMenu.Name = "panelNavMenu";
            this.panelNavMenu.Size = new System.Drawing.Size(200, 600);
            this.panelNavMenu.TabIndex = 0;
            // 
            // customerBtn
            // 
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Location = new System.Drawing.Point(0, 280);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customerBtn.Size = new System.Drawing.Size(200, 45);
            this.customerBtn.TabIndex = 5;
            this.customerBtn.Text = "Customer List";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // rentalBtn
            // 
            this.rentalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentalBtn.FlatAppearance.BorderSize = 0;
            this.rentalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalBtn.Location = new System.Drawing.Point(0, 235);
            this.rentalBtn.Name = "rentalBtn";
            this.rentalBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rentalBtn.Size = new System.Drawing.Size(200, 45);
            this.rentalBtn.TabIndex = 4;
            this.rentalBtn.Text = "Rentals";
            this.rentalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalBtn.UseVisualStyleBackColor = true;
            this.rentalBtn.Click += new System.EventHandler(this.RentalBtn_Click);
            // 
            // rentVehicleBtn
            // 
            this.rentVehicleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rentVehicleBtn.FlatAppearance.BorderSize = 0;
            this.rentVehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentVehicleBtn.Location = new System.Drawing.Point(0, 190);
            this.rentVehicleBtn.Name = "rentVehicleBtn";
            this.rentVehicleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rentVehicleBtn.Size = new System.Drawing.Size(200, 45);
            this.rentVehicleBtn.TabIndex = 3;
            this.rentVehicleBtn.Text = "Book and Rent";
            this.rentVehicleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentVehicleBtn.UseVisualStyleBackColor = true;
            this.rentVehicleBtn.Click += new System.EventHandler(this.RentVehicleBtn_Click);
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehicleBtn.FlatAppearance.BorderSize = 0;
            this.vehicleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleBtn.Location = new System.Drawing.Point(0, 145);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleBtn.Size = new System.Drawing.Size(200, 45);
            this.vehicleBtn.TabIndex = 2;
            this.vehicleBtn.Text = "Vehicle Fleet";
            this.vehicleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleBtn.UseVisualStyleBackColor = true;
            this.vehicleBtn.Click += new System.EventHandler(this.VehicleBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(0, 100);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(200, 45);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 1);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(900, 600);
            this.panelChildForm.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 601);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelNavMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Text = "MainForm";
            this.panelNavMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button vehicleBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button rentVehicleBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button rentalBtn;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

