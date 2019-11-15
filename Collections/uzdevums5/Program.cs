using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> happyList = new List<string>();
            while (true)
            {
                input = Console.ReadLine();
                happy(input, happyList);
            }
            

        }

        private static void happy(string input,List<string> list)
        {
            double sum = 0;
            foreach (var digit in input)
            {
                sum += Math.Pow(int.Parse(digit.ToString()), 2);
            }
            if (sum == 1)
            {
                Console.WriteLine("happy");
                list.Clear();
                return;
            }
            if (list.Contains(sum.ToString()))
            {
                Console.WriteLine("not happy");
                list.Clear();
                return;
            }

            input = sum.ToString();
            list.Add(sum.ToString());
            happy(input, list);
        }
    }
}
