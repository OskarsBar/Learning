﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums2xx1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to create a new list, add some elements (string) and print out the collection.
            var colors = new List<string>();

            //TODO: Add 5 colors to list
            colors.Add("Red");
            colors.Add("Red");
            colors.Add("Red");
            colors.Add("Red");
            colors.Add("Red");

            Console.WriteLine(string.Join(",", colors));
            Console.Read();
        }
    }
}
