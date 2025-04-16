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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
           
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
           
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();  
            statistic.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }
    }
}
