using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegaterPractice
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get => price; set => price = value; }
        public string NamePrice { 
            get => this.Name + "(" + this.price + ")";
            set => NamePrice = value;
        }

        private int price;

    }
}
