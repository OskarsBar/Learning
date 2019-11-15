using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums7
{
    class Program
    {
        private const string Path = "C:/Users/codelex/source/repos/Collections/uzdevums7/flights.txt";

        private static void Main(string[] args)
        {
            string[] b;
            Dictionary<string, HashSet<string>> flightList = new Dictionary<string, HashSet<string>>();
            List<string> trip = new List<string>();

            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                b = s.Split(new string[] { " -> " }, StringSplitOptions.None);
                if (!flightList.ContainsKey(b[0]))
                {
                    flightList.Add(b[0], new HashSet<string>() { b[1] });
                }
                else
                {
                    flightList[b[0]].Add(b[1]);
                }
            }
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            var a = Console.ReadLine();
            if (a == "1")
            {
                Console.WriteLine("Chose your city");
                foreach (var flight in flightList)
                {
                    Console.WriteLine(flight.Key);
                }
                var choise = Console.ReadLine();
                trip.Add(choise);
                while (true)
                {
                    Console.WriteLine("Available Destination");
                    foreach (var flight in flightList[choise])
                    {
                        Console.WriteLine(flight);
                    }
                    choise = Console.ReadLine();
                    trip.Add(choise);
                    if (trip[0] == trip[trip.Count - 1]) break;
                }
            }
            Console.WriteLine("Your trip will look like this");
            foreach (var x in trip)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
