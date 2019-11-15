using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi","Germany", "BMW", "Germany", "Honda","Japan", "Mercedes","Germany", "VolksWagen", "Germany", "Mercedess","Germany", "Tesla","Usa" };
            List<string> list = new List<string>();
            HashSet<string> hasgSet = new HashSet<string>();
            Dictionary<string, string> dic = new Dictionary<string, string>(); 
            for(int x = 0; x < array.Length; x++)
            {
                hasgSet.Add(array[x] + " " + array[x + 1]);
                list.Add(array[x] + " " + array[x + 1]);
                dic.Add(array[x], array[x + 1]);
                x++;
            }
            Console.WriteLine("List");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Hash");
            foreach (var a in hasgSet)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Dir");
            foreach (var a in dic)
            {
                Console.Write(a.Key+" ");
                Console.WriteLine(a.Value);
            }
            Console.Read();
            //todo - replace array with an List and print out the results

            //todo - replace array with a HashSet and print out the results

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
        }


    }
}
