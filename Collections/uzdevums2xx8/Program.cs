﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums2xx8
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to sort a given list.

            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.Write("List before sort: ");
            Console.WriteLine(string.Join(",", colors));

            //TODO: Sort list
            //Collections....
            colors.Sort();
            Console.Write("List after sort: ");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}
