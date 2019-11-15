using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums2xx10
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("Original array list: ");
            Console.WriteLine(string.Join(",", colors));

            //TODO: Remove all elements from list
            colors.Clear();

            Console.WriteLine("New array list: ");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}
