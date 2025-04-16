namespace Ef_Core_Statistic_Project
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_CustomerId = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CustomerCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CusotmerCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_List = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Menü = new System.Windows.Forms.Button();
            this.txt_CustomerSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullancı Id:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Search.Location = new System.Drawing.Point(782, 94);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(245, 31);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Ara";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 399);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txt_CustomerId
            // 
            this.txt_CustomerId.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerId.Location = new System.Drawing.Point(101, 6);
            this.txt_CustomerId.Name = "txt_CustomerId";
            this.txt_CustomerId.Size = new System.Drawing.Size(172, 24);
            this.txt_CustomerId.TabIndex = 3;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerName.Location = new System.Drawing.Point(375, 4);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(172, 24);
            this.txt_CustomerName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(277, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullancı Adı:";
            // 
            // txt_CustomerCity
            // 
            this.txt_CustomerCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerCity.Location = new System.Drawing.Point(915, 4);
            this.txt_CustomerCity.Name = "txt_CustomerCity";
            this.txt_CustomerCity.Size = new System.Drawing.Size(172, 24);
            this.txt_CustomerCity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(866, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir";
            // 
            // txt_CusotmerCountry
            // 
            this.txt_CusotmerCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CusotmerCountry.Location = new System.Drawing.Point(1172, 4);
            this.txt_CusotmerCountry.Name = "txt_CusotmerCountry";
            this.txt_CusotmerCountry.Size = new System.Drawing.Size(172, 24);
            this.txt_CusotmerCountry.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1122, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ülke";
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_List.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_List.Location = new System.Drawing.Point(782, 158);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(245, 31);
            this.btn_List.TabIndex = 10;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Location = new System.Drawing.Point(782, 230);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(245, 31);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Location = new System.Drawing.Point(782, 303);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(245, 31);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.Location = new System.Drawing.Point(782, 378);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(245, 31);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Menü
            // 
            this.btn_Menü.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Menü.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Menü.Location = new System.Drawing.Point(1144, 208);
            this.btn_Menü.Name = "btn_Menü";
            this.btn_Menü.Size = new System.Drawing.Size(119, 31);
            this.btn_Menü.TabIndex = 14;
            this.btn_Menü.Text = "Ana Menü";
            this.btn_Menü.UseVisualStyleBackColor = false;
            this.btn_Menü.Click += new System.EventHandler(this.btn_Menü_Click);
            // 
            // txt_CustomerSurname
            // 
            this.txt_CustomerSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_CustomerSurname.Location = new System.Drawing.Point(679, 6);
            this.txt_CustomerSurname.Name = "txt_CustomerSurname";
            this.txt_CustomerSurname.Size = new System.Drawing.Size(172, 24);
            this.txt_CustomerSurname.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(562, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kullancı Soyadı:";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciId.Location = new System.Drawing.Point(89, 2);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(0, 19);
            this.lblKullaniciId.TabIndex = 18;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1347, 456);
            this.Controls.Add(this.lblKullaniciId);
            this.Controls.Add(this.txt_CustomerSurname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Menü);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.txt_CusotmerCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CustomerCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CustomerId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_CustomerId;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CustomerCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CusotmerCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Menü;
        private System.Windows.Forms.TextBox txt_CustomerSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKullaniciId;
    }
}