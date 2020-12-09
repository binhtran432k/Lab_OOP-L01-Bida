
namespace CarRentalWF
{
    partial class SearchForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.minPriceText = new System.Windows.Forms.TextBox();
            this.brandText = new System.Windows.Forms.TextBox();
            this.colorText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.maxPriceText = new System.Windows.Forms.TextBox();
            this.maxPriceLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 327);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // minPriceText
            // 
            this.minPriceText.Location = new System.Drawing.Point(137, 229);
            this.minPriceText.Name = "minPriceText";
            this.minPriceText.Size = new System.Drawing.Size(244, 23);
            this.minPriceText.TabIndex = 67;
            // 
            // brandText
            // 
            this.brandText.Location = new System.Drawing.Point(137, 184);
            this.brandText.Name = "brandText";
            this.brandText.Size = new System.Drawing.Size(244, 23);
            this.brandText.TabIndex = 59;
            // 
            // colorText
            // 
            this.colorText.Location = new System.Drawing.Point(137, 143);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(244, 23);
            this.colorText.TabIndex = 57;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(137, 102);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(244, 23);
            this.nameText.TabIndex = 56;
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.Location = new System.Drawing.Point(31, 228);
            this.minPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(92, 20);
            this.minPriceLabel.TabIndex = 66;
            this.minPriceLabel.Text = "Min price";
            this.minPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // brandLabel
            // 
            this.brandLabel.Location = new System.Drawing.Point(69, 183);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(54, 20);
            this.brandLabel.TabIndex = 62;
            this.brandLabel.Text = "Brand";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(74, 143);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(49, 20);
            this.colorLabel.TabIndex = 60;
            this.colorLabel.Text = "Color";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(70, 103);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(78, 63);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(45, 20);
            this.typeLabel.TabIndex = 55;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(137, 60);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(244, 24);
            this.typeComboBox.TabIndex = 54;
            // 
            // maxPriceText
            // 
            this.maxPriceText.Location = new System.Drawing.Point(137, 270);
            this.maxPriceText.Name = "maxPriceText";
            this.maxPriceText.Size = new System.Drawing.Size(244, 23);
            this.maxPriceText.TabIndex = 69;
            // 
            // maxPriceLable
            // 
            this.maxPriceLable.Location = new System.Drawing.Point(31, 273);
            this.maxPriceLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxPriceLable.Name = "maxPriceLable";
            this.maxPriceLable.Size = new System.Drawing.Size(92, 20);
            this.maxPriceLable.TabIndex = 70;
            this.maxPriceLable.Text = "Max price";
            this.maxPriceLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 391);
            this.Controls.Add(this.maxPriceLable);
            this.Controls.Add(this.maxPriceText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.minPriceText);
            this.Controls.Add(this.brandText);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox minPriceText;
        private System.Windows.Forms.TextBox brandText;
        private System.Windows.Forms.TextBox colorText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox maxPriceText;
        private System.Windows.Forms.Label maxPriceLable;
    }
}