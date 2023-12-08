using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public Double Price { get; set; }

        public Product() { }
        public Product(string name, Double price)
        {
            Name = name;
            Price = price;
        }
    }
}
