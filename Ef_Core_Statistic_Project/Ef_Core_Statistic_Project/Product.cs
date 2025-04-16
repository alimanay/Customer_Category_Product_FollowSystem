using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_Core_Statistic_Project
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        DbProject3Entities db = new DbProject3Entities();
        private void Product_Load(object sender, EventArgs e)
        {
            cmb_categoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_ProdcutId.Visible = false;
            txt_ProdcutId.Enabled = false;  

            
        }
        void List()
        {
            dataGridView1.DataSource = (from p in db.TblProduct
                                        join c in db.TblCategory on p.CategortId equals c.CategoryId into cp
                                        from c in cp.DefaultIfEmpty()
                                        select new
                                        {
                                            p.ProductId,
                                            p.ProductName,
                                            p.ProductStock,
                                            p.ProductStatus,
                                            p.ProductPrice,
                                            CategoryName = c.CategoryName,
                                            CategoryId = (int?)c.CategoryId,
                                            
                                        }).ToList();

        }

        private void btn_List_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource= (from p in db.TblProduct 
                         join c in  db.TblCategory  on p.CategortId equals c.CategoryId into cp from  c in cp.DefaultIfEmpty()
                         select new
                         {
                             p.ProductId,
                             p.ProductName,
                             p.ProductStock,
                             p.ProductStatus,
                             p.ProductPrice,
                             CategoryName = c.CategoryName,
                             CategoryId = (int?)c.CategoryId,
                            
                         } ).ToList();         

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                TblProduct product = new TblProduct();
                TblCategory category = new TblCategory();
                product.ProductName = txt_ProductName.Text;
                product.ProductPrice = decimal.Parse(txt_ProductPrice.Text);
                product.ProductStock = int.Parse(txt_ProductStock.Text);
                int cat_id = db.TblCategory.Where(a => a.CategoryName == cmb_categoryName.Text).Select(a => a.CategoryId).FirstOrDefault();
                product.CategortId = cat_id;
                category.CategoryName = cmb_categoryName.Text;
                if (radioBtnTrue.Checked) product.ProductStatus = radioBtnTrue.Checked;
                if (radioBtnFalse.Checked) product.ProductStatus = radioBtnFalse.Checked = false;
                db.TblProduct.Add(product);
                db.TblCategory.Add(category);
                db.SaveChanges();
                List();
                ıd_lbl.Text = "";
                txt_ProductName.Text = "";
                txt_ProductPrice.Text = "";
                txt_ProductStock.Text = "";
            }
            catch  {
                MessageBox.Show("Lütfen eklenecek bilgileri doğru ve eksiksiz giriniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
              
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
   
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ProdcutId.Text))
            {
                db.TblProduct.Remove(db.TblProduct.Find(int.Parse(txt_ProdcutId.Text)));
                db.SaveChanges();
                List();
                txt_ProdcutId.Text = "";
                ıd_lbl.Text = "";
                txt_ProductName.Text = "";
                txt_ProductPrice.Text = "";
                txt_ProductStock.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünün üstününe 1 kez tıklayın","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
       
          

        }
        private void Double_Delete(object sender, EventArgs e)
        {
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try {
                var value = db.TblProduct.Find(int.Parse(txt_ProdcutId.Text));
                TblCategory cat = new TblCategory();
                value.ProductName = txt_ProductName.Text;
                value.ProductPrice = decimal.Parse(txt_ProductPrice.Text);
                value.ProductStock = int.Parse(txt_ProductStock.Text);
                if (radioBtnTrue.Checked) value.ProductStatus = radioBtnTrue.Checked;
                if (radioBtnFalse.Checked) value.ProductStatus = radioBtnFalse.Checked = false;
                value.TblCategory.CategoryName = cmb_categoryName.Text;
                db.SaveChanges();
                List();
                ıd_lbl.Text = "";
                txt_ProductName.Text = "";
                txt_ProductPrice.Text = "";
                txt_ProductStock.Text = "";



            }
            catch
            {
                MessageBox.Show("Lütfen Bilgileri  Eksiksiz Ve Doğru Giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

                }
        
        

        private void Update(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                txt_ProdcutId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ıd_lbl.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_ProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_ProductPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_ProductStock.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cmb_categoryName.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "True")
                    radioBtnTrue.Checked = true;
                else radioBtnFalse.Checked = true;


                MessageBox.Show("Ürün Başarıyla Seçildi");

            }
          



        }
    }
    }

