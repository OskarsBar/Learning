using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> myHash = new HashSet<string>();
            while (true)
            {
                myHash.Add( Console.ReadLine());
                if (myHash.Contains(""))
                    break;
            }
            Console.WriteLine(string.Join(",", myHash));
            Console.Read();
        }
    }
}
