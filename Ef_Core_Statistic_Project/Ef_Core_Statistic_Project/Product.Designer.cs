namespace Ef_Core_Statistic_Project
{
    partial class Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ProdcutId = new System.Windows.Forms.TextBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ProductStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnTrue = new System.Windows.Forms.RadioButton();
            this.radioBtnFalse = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.cmb_categoryName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ıd_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(878, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.Update);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.Double_Delete);
            // 
            // txt_ProdcutId
            // 
            this.txt_ProdcutId.Location = new System.Drawing.Point(1055, 45);
            this.txt_ProdcutId.Name = "txt_ProdcutId";
            this.txt_ProdcutId.Size = new System.Drawing.Size(238, 22);
            this.txt_ProdcutId.TabIndex = 1;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_List.Location = new System.Drawing.Point(1331, 34);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(194, 33);
            this.btn_List.TabIndex = 3;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1002, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(1055, 97);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(238, 22);
            this.txt_ProductName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1011, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.Location = new System.Drawing.Point(1055, 156);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(238, 22);
            this.txt_ProductPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1015, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stok";
            // 
            // txt_ProductStock
            // 
            this.txt_ProductStock.Location = new System.Drawing.Point(1055, 203);
            this.txt_ProductStock.Name = "txt_ProductStock";
            this.txt_ProductStock.Size = new System.Drawing.Size(238, 22);
            this.txt_ProductStock.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(931, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Category Name:";
            // 
            // radioBtnTrue
            // 
            this.radioBtnTrue.AutoSize = true;
            this.radioBtnTrue.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnTrue.Location = new System.Drawing.Point(61, 29);
            this.radioBtnTrue.Name = "radioBtnTrue";
            this.radioBtnTrue.Size = new System.Drawing.Size(55, 21);
            this.radioBtnTrue.TabIndex = 12;
            this.radioBtnTrue.TabStop = true;
            this.radioBtnTrue.Text = "True";
            this.radioBtnTrue.UseVisualStyleBackColor = true;
            // 
            // radioBtnFalse
            // 
            this.radioBtnFalse.AutoSize = true;
            this.radioBtnFalse.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnFalse.Location = new System.Drawing.Point(187, 29);
            this.radioBtnFalse.Name = "radioBtnFalse";
            this.radioBtnFalse.Size = new System.Drawing.Size(58, 21);
            this.radioBtnFalse.TabIndex = 13;
            this.radioBtnFalse.TabStop = true;
            this.radioBtnFalse.Text = "False";
            this.radioBtnFalse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioBtnTrue);
            this.groupBox1.Controls.Add(this.radioBtnFalse);
            this.groupBox1.Location = new System.Drawing.Point(951, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(1331, 92);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(194, 33);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(1331, 151);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(194, 33);
            this.btn_Sil.TabIndex = 17;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(1331, 206);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(194, 33);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Güncelleme";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Menu.Location = new System.Drawing.Point(1331, 330);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(194, 33);
            this.btn_Menu.TabIndex = 19;
            this.btn_Menu.Text = "Ana Menü";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // cmb_categoryName
            // 
            this.cmb_categoryName.FormattingEnabled = true;
            this.cmb_categoryName.Items.AddRange(new object[] {
            "Meyve",
            "Sebze",
            "İçecek",
            "Ev Aletleri",
            "Teknolojik Aletleri"});
            this.cmb_categoryName.Location = new System.Drawing.Point(1055, 251);
            this.cmb_categoryName.Name = "cmb_categoryName";
            this.cmb_categoryName.Size = new System.Drawing.Size(160, 24);
            this.cmb_categoryName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(978, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seçilen İD:";
            // 
            // ıd_lbl
            // 
            this.ıd_lbl.AutoSize = true;
            this.ıd_lbl.Location = new System.Drawing.Point(1055, 51);
            this.ıd_lbl.Name = "ıd_lbl";
            this.ıd_lbl.Size = new System.Drawing.Size(0, 16);
            this.ıd_lbl.TabIndex = 22;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1549, 504);
            this.Controls.Add(this.ıd_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_categoryName);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ProductStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.txt_ProdcutId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ProdcutId;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ProductStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtnTrue;
        private System.Windows.Forms.RadioButton radioBtnFalse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.ComboBox cmb_categoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ıd_lbl;
    }
}