namespace CarRentalWF
{
    partial class ServiceForm
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
            this.lblService = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGarage = new System.Windows.Forms.Label();
            this.txtGarage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblService.Location = new System.Drawing.Point(13, 9);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(297, 71);
            this.lblService.TabIndex = 0;
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(13, 106);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(67, 23);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(86, 106);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(222, 26);
            this.txtCost.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(106, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblGarage
            // 
            this.lblGarage.Location = new System.Drawing.Point(13, 152);
            this.lblGarage.Name = "lblGarage";
            this.lblGarage.Size = new System.Drawing.Size(67, 23);
            this.lblGarage.TabIndex = 1;
            this.lblGarage.Text = "Garage";
            this.lblGarage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGarage
            // 
            this.txtGarage.Location = new System.Drawing.Point(86, 149);
            this.txtGarage.Name = "txtGarage";
            this.txtGarage.Size = new System.Drawing.Size(222, 26);
            this.txtGarage.TabIndex = 3;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 274);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGarage);
            this.Controls.Add(this.lblGarage);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblService);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGarage;
        private System.Windows.Forms.TextBox txtGarage;
    }
}