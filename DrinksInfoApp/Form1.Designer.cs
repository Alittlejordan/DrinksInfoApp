namespace DrinksInfoApp
{
    partial class Form1
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.drinksComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.thumbnailPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AccessibleName = "";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(160, 24);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // drinksComboBox
            // 
            this.drinksComboBox.FormattingEnabled = true;
            this.drinksComboBox.Location = new System.Drawing.Point(383, 24);
            this.drinksComboBox.Name = "drinksComboBox";
            this.drinksComboBox.Size = new System.Drawing.Size(121, 21);
            this.drinksComboBox.TabIndex = 1;
            this.drinksComboBox.SelectedIndexChanged += new System.EventHandler(this.drinksComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(49, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(49, 165);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 3;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(49, 235);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(174, 8);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.categoryLabel.Size = new System.Drawing.Size(132, 13);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Select Category";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.Location = new System.Drawing.Point(412, 8);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.drinksLabel.Size = new System.Drawing.Size(115, 13);
            this.drinksLabel.TabIndex = 6;
            this.drinksLabel.Text = "Select Drink";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(79, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(82, 146);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Type";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(82, 219);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 13);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Instructions";
            // 
            // thumbnailPictureBox
            // 
            this.thumbnailPictureBox.Location = new System.Drawing.Point(226, 78);
            this.thumbnailPictureBox.Name = "thumbnailPictureBox";
            this.thumbnailPictureBox.Size = new System.Drawing.Size(360, 264);
            this.thumbnailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailPictureBox.TabIndex = 10;
            this.thumbnailPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thumbnailPictureBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.drinksComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox drinksComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.PictureBox thumbnailPictureBox;
    }
}

