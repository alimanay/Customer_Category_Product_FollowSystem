using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef_Core_Statistic_Project
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        DbProject3Entities db  = new DbProject3Entities();
        private async void Form1_Load(object sender, EventArgs e)
        {
            try {
                //Toplam  kategori sayısı
                lblCategoryCount.Text = db.TblCategory.Count().ToString();
                //Toplam  Ürün sayısı
                lblProductCount.Text = db.TblProduct.Count().ToString();
                //Toplam  Müşteri sayısı
                lblCustomerCount.Text = db.TblCustomer.Count().ToString();
                //Toplam  Sipariş sayısı
                lblOrderCount.Text = db.TblOrder.Count().ToString();
                //TOPLAM STOCK SAYISI
                lblProductTotalStock.Text = db.TblProduct.Sum(p => p.ProductStock).ToString();
                //Ortalam ürün fiyatı
                lblProductAveragePrice.Text = db.TblProduct.Average(p => p.ProductPrice).ToString() + " ₺";
                //Toplam Meyve stoku  sayısı
                lblProductCountByCategoryIsFruit.Text = db.TblProduct.Where(p => p.CategortId == 1).Sum(p => p.ProductStock).ToString();
                // Gazozun Toplam İşlem Hacmi
                lblTotalPriceByProductNameIsGazoz.Text = db.TblProduct.Where(p => p.ProductName == "Gazoz").Sum(p => p.ProductPrice * p.ProductStock).ToString() + " ₺";
                //Stok sayısı 100 den az olan stoklar
                lblProductStockSmallerThen100.Text = db.TblProduct.Where(p => p.ProductStock < 100).Count().ToString();
                //Kategorisi sebze ve durumu  true  olan ürün  stok toplamı
                lblProductCountByCategorySebzeAndStatusTrue.Text = db.TblProduct
                .Where(p => p.CategortId == (db.TblCategory
                 .Where(c => c.CategoryName == "Sebze"))
                  .Select(c => c.CategoryId)
                  .FirstOrDefault() && p.ProductStatus == true)
                   .Sum(p => p.ProductStock).ToString();
                //Türkiyeden  yapılan siparişler Sql QUERY
                var orderCountFromTurkiye = db.Database.SqlQuery<int>("select Count(*) from   TblOrder\r\nwhere CusrtomerId in(select CusrtomerId from TblCustomer\r\nwhere CustomerCountry ='Türkiye')").FirstOrDefault();
                lblOrderCountFromTurkiyeBySQL.Text = orderCountFromTurkiye.ToString();
                //Türkiyeden yapılan siparişler Ef Metodu  ile
                var turkisCustomerId = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye").Select(y => y.CustomerId).ToList();
                var orderCountFromTurkiyeWithEf = db.TblCustomer.Count(x => turkisCustomerId.Contains(x.CustomerId)).ToString();
                lblOrderCountFromTurkiyeByEf.Text = orderCountFromTurkiye.ToString();
                //Sipairşler içerisinde katergoirisi meyve olan ürünlerin toplam satış fiyatı
                //Sql QUERY  TARZI  
                lblOrderTotalPriceByCategoryIsMeyve.Text = db.Database.SqlQuery<decimal>("SELECT SUM(TotalPrice) FROM TblOrder WHERE ProductId IN (SELECT ProductId FROM TblCategory WHERE CategoryName = 'Sebze')").FirstOrDefault().ToString() + " ₺";


                //Ef Core  LİNQ  ile yazılması
                lblOrderTotalPriceByCategoryIsMeyveByEf.Text = (from o in db.TblOrder

                                                                join p in db.TblProduct
                                                                on o.ProductId equals p.ProductId
                                                                join c in db.TblCategory
                                                                on p.CategortId equals c.CategoryId
                                                                where c.CategoryName == "Meyve" select o.TotalPrice).Sum().ToString() + " ₺";

                //SON  EKLENEN ÜRÜN
                lblLastProductName.Text = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault().ToString();

                //sON EKLENEN  ÜRÜN KATEGORİSİ
                var lastProductcategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategortId).FirstOrDefault();
                var lastProductcategoryName = db.TblCategory.Where(z => z.CategoryId == lastProductcategoryId).Select(y => y.CategoryName).FirstOrDefault();
                lblLastProductCategoryName.Text = lastProductcategoryName.ToString();

                //Aktif ürün sayısı
                lblActiveProductCount.Text = db.TblProduct.Where(x => x.ProductStatus == true).Count().ToString();
                // Toplam kola  kazanç tutarı
                lblTotalPriceWithStockByCola.Text = db.TblProduct.Where(p => p.ProductName == "kola").Sum(p => p.ProductStock * p.ProductPrice).ToString() + " ₺";

                //Son  sipariş veren  müşteri adı

                var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(p => p.CusrtomerId).FirstOrDefault();
                var lastCustomerName = db.TblCustomer.Where(x => x.CustomerId == lastCustomerId).Select(p => p.CustomerName).FirstOrDefault();
                lblLastCustomerName.Text = lastCustomerName.ToString();

                //Ülke çeşitiliği sayısı
                lblCountryDifferentCount.Text = db.TblCustomer.Select(x => x.CustomerCountry).Distinct().Count().ToString();

            }


            catch
            {

            }
            }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
