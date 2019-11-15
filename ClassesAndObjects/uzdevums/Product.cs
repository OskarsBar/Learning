using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums
{
    class Product
    {
        private double _price;
        private int _amount;
        private string _name;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _price = priceAtStart;
            _amount = amountAtStart;
            _name = name;
        }
        public void PrintProduct()
        {
            Console.WriteLine("{0}, price {1}, amount {2}", _name, _price, _amount);
        }
        public void chagePrice(double price)
        {
            _price = price;
        }
        public void chageAmount(int amount)
        {
            _amount = amount;
        }
    }
}
