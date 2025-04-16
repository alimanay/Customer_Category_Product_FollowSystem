namespace Ef_Core_Statistic_Project
{
    partial class Menu
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
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_Product = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Customer.Location = new System.Drawing.Point(72, 42);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(184, 77);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "Müşteri Sayfası";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Status.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Status.Location = new System.Drawing.Point(296, 42);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(182, 72);
            this.btn_Status.TabIndex = 1;
            this.btn_Status.Text = "İstatistikler";
            this.btn_Status.UseVisualStyleBackColor = false;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Product.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Product.Location = new System.Drawing.Point(183, 136);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(182, 72);
            this.btn_Product.TabIndex = 2;
            this.btn_Product.Text = "Product";
            this.btn_Product.UseVisualStyleBackColor = false;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(559, 243);
            this.Controls.Add(this.btn_Product);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.btn_Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_Product;
    }
}