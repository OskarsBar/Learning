using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", 70.00, 14);
            Product iPhone = new Product("iPhone 5s", 999.99, 3);
            Product epsonEBU05 = new Product("Epson EB-U05", 440.46, 1);
            mouse.PrintProduct();
            iPhone.PrintProduct();
            epsonEBU05.PrintProduct();
            mouse.chagePrice(123.124);
            mouse.PrintProduct();
            Console.Read();

        }
    }
}
