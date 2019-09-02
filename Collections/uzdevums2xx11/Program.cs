using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums2xx11
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            List<string> list = new List<string>()
            { "dfg",
                "sdfsd",
                "s123fsd",
                "sdhersd",
                "sdjhgfsd",
                "sdiuytfsd",
                "sjhfgfsd",
                "sdmnbvfsd",
                "sdnbvfsd",
                "sdfhgdssd",
                "sdfojhtsd" };
            //TODO: Add 10 values to list

            //TODO: Add new value at 5th position
            list[4] = "dcrtguhdcrgi";
            //TODO: Change value at last position (Calculate last position programmatically)
            list[list.Count - 1] = "drtgcgdrcjdrg";
            //TODO: Sort your list in alphabetical order
            list.Sort();
            //TODO: Check if your list contains "Foobar" element
            list.Contains("Foobar");
            //TODO: Print each element of list using loop
            foreach(var line in list)
            {
                Console.WriteLine(line);
            }
            Console.Read();
        }
    }
}
