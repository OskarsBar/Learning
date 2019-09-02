using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums2xx7
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            //      TODO: Check if list contains "White" element
                    if (colors.Contains("White")) {
                        Console.WriteLine("Found the element");
                    } else {
                        Console.WriteLine("There is no such element");
                    }
        }
    }
}
