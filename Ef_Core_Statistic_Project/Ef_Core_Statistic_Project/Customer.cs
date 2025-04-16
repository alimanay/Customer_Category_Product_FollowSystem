using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_Core_Statistic_Project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        DbProject3Entities db = new DbProject3Entities();
        private void Product_Load(object sender, EventArgs e)
        {
            txt_CustomerId.Visible = false; 
            txt_CustomerId.Enabled= false;
        }
        void List()
        {
            //var CustomerList = db.TblCustomer.ToList();
            //dataGridView1.DataSource = CustomerList;
       dataGridView1.DataSource = (from c in db.TblCustomer

                        
                         select new
                         {
                             c.CustomerId,
                             c.CustomerName,
                             c.CustomerSurname,
                             c.CustomerCity,
                             c.CustomerCountry,
                           

                         }).ToList();
         


        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            var value = (from c in db.TblCustomer
                         select new
                         {
                             c.CustomerId,
                             c.CustomerName,
                             c.CustomerSurname,
                             c.CustomerCity,
                             c.CustomerCountry,
                           

                         }).ToList();
            dataGridView1.DataSource = value;



        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            TblCustomer customer = new TblCustomer();

            if (!string.IsNullOrEmpty(txt_CustomerName.Text) && !string.IsNullOrEmpty(txt_CustomerCity.Text) && !string.IsNullOrEmpty(txt_CusotmerCountry.Text) && !string.IsNullOrEmpty(txt_CustomerSurname.Text))
            {

                customer.CustomerName = txt_CustomerName.Text;
                customer.CustomerSurname = txt_CustomerSurname.Text;
                customer.CustomerCity = txt_CustomerCity.Text;
                customer.CustomerCountry = txt_CusotmerCountry.Text;
                db.TblCustomer.Add(customer);
                db.SaveChanges();
                List();

                MessageBox.Show("Kişi Başarıyla Eklendi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_CustomerSurname.Text = "";
            txt_CustomerName.Text = "";
            txt_CustomerCity.Text = "";
            txt_CusotmerCountry.Text = "";
            lblKullaniciId.Text = "";


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {


            try {
                var value = db.TblCustomer.Find(Convert.ToInt16(txt_CustomerId.Text));
                db.TblCustomer.Remove(value);
                db.SaveChanges();
                List();
                txt_CustomerName.Text = "";
                txt_CustomerSurname.Text = "";
                txt_CustomerCity.Text = "";
                txt_CusotmerCountry.Text = "";
                lblKullaniciId.Text = "";
                
                MessageBox.Show("Seçilen ID'li kişi başarıyla silinmiştir.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Bir Id Giriniz.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
              txt_CustomerId.Text = "";
                 lblKullaniciId.Text = "";

        }

            
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                var value = db.TblCustomer.Find(Convert.ToInt16(txt_CustomerId.Text));

                value.CustomerName = txt_CustomerName.Text;
                value.CustomerSurname = txt_CustomerSurname.Text;
                value.CustomerCity = txt_CustomerCity.Text;
                value.CustomerCountry = txt_CusotmerCountry.Text;
                db.SaveChanges();
                List();
                MessageBox.Show("Kişi Başarıyla Güncellenmiştir", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch
            {

                MessageBox.Show("Güncellenecek Kişinin Id'sini ve bilgilerini giriniz", " Eksik Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_CustomerId.Text = "";
            txt_CustomerName.Text = "";
            txt_CustomerSurname.Text = "";
            txt_CustomerCity.Text = "";
            txt_CusotmerCountry.Text = "";
            lblKullaniciId.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerName.Text) || !string.IsNullOrEmpty(txt_CustomerCity.Text) || !string.IsNullOrEmpty(txt_CusotmerCountry.Text)||!string.IsNullOrEmpty(txt_CustomerSurname.Text))
            {
                TblCustomer tblCustomer = new TblCustomer();
                dataGridView1.DataSource = db.TblCustomer.Where(u => u.CustomerName == txt_CustomerName.Text || u.CustomerCity == txt_CustomerCity.Text || u.CustomerCountry == txt_CusotmerCountry.Text || u.CustomerSurname== txt_CustomerSurname.Text).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen Arancak Kişinin Bilgisini Giriniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_CustomerName.Text = "";
            txt_CustomerSurname.Text = "";
            txt_CustomerCity.Text = "";
            txt_CusotmerCountry.Text = "";
            lblKullaniciId.Text = "";


        }

        private void btn_Menü_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_CustomerId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                lblKullaniciId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_CustomerName.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_CustomerSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_CustomerCity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_CusotmerCountry.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }

        }
    }
    }

