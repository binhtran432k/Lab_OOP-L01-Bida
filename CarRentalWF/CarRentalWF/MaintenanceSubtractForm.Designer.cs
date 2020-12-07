
namespace CarRentalWF
{
    partial class CompareAndSubtractForm
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
            this.service2 = new System.Windows.Forms.Label();
            this.service1 = new System.Windows.Forms.Label();
            this.service2ID = new System.Windows.Forms.TextBox();
            this.service1ID = new System.Windows.Forms.TextBox();
            this.Subtract = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // service2
            // 
            this.service2.AutoSize = true;
            this.service2.Location = new System.Drawing.Point(9, 92);
            this.service2.Name = "service2";
            this.service2.Size = new System.Drawing.Size(160, 17);
            this.service2.TabIndex = 0;
            this.service2.Text = "Enter the ID of service 2";
            // 
            // service1
            // 
            this.service1.AutoSize = true;
            this.service1.Location = new System.Drawing.Point(12, 9);
            this.service1.Name = "service1";
            this.service1.Size = new System.Drawing.Size(160, 17);
            this.service1.TabIndex = 0;
            this.service1.Text = "Enter the ID of service 1";
            // 
            // service2ID
            // 
            this.service2ID.Location = new System.Drawing.Point(9, 134);
            this.service2ID.Name = "service2ID";
            this.service2ID.Size = new System.Drawing.Size(160, 22);
            this.service2ID.TabIndex = 1;
            // 
            // service1ID
            // 
            this.service1ID.Location = new System.Drawing.Point(9, 48);
            this.service1ID.Name = "service1ID";
            this.service1ID.Size = new System.Drawing.Size(160, 22);
            this.service1ID.TabIndex = 1;
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(202, 32);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(99, 49);
            this.Subtract.TabIndex = 2;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(202, 109);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(99, 47);
            this.Compare.TabIndex = 2;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 217);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(289, 22);
            this.Result.TabIndex = 1;
            // 
            // CompareAndSubtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 316);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.service1ID);
            this.Controls.Add(this.service2ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.service1);
            this.Controls.Add(this.service2);
            this.Name = "CompareAndSubtractForm";
            this.Text = "CompareAndSubtractForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label service2;
        private System.Windows.Forms.Label service1;
        private System.Windows.Forms.TextBox service2ID;
        private System.Windows.Forms.TextBox service1ID;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result;
    }
}