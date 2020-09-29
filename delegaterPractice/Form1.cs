using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegaterPractice
{
    public partial class Form1 : Form
    {
        List<Product> products;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = new List<Product>();
            productBindingSource3.DataSource = products;
            ProductListReset();
        }

        private void ProductListReset()
        { 
            products.Clear();
            products.Add(new Product(){ Name = "감자", Price = 500 });
            products.Add(new Product() { Name = "사과", Price = 700 });
            products.Add(new Product() { Name = "고구마", Price = 400 });
            products.Add(new Product() { Name = "배추", Price = 600 });
            products.Add(new Product() { Name = "상추", Price = 300 });
           productBindingSource3.ResetBindings(false);

        }

        private void sortButton1_Click(object sender, EventArgs e)
        {
            products.Sort(SortWithPrice);
            productBindingSource3.ResetBindings(false);
        }

        private int SortWithName(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }

        private int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }

        private void sortButton2_Click(object sender, EventArgs e)
        {
            products.Sort(delegate (Product x, Product y)
            {
                return x.Price.CompareTo(y.Price);
            });
            productBindingSource3.ResetBindings(false);
        }

        private void sortButton3_Click(object sender, EventArgs e)
        {
            products.Sort((x, y) =>  x.Price.CompareTo(y.Price) );
            productBindingSource3.ResetBindings(false);
        }

        private void sortResetButton_Click(object sender, EventArgs e)
        {
            ProductListReset();
        }
    }

}
