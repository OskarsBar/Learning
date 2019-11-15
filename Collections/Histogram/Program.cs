using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        Dictionary<string, string> myDictionary = new Dictionary<string, string>();
        private const string Path = "C:/Users/codelex/source/repos/Collections/Histogram/midtermscores.txt";

        private static void Main(string[] args)
        {
            SortedDictionary<string, string> myDictionary = new SortedDictionary<string, string>();
            var readText = File.ReadAllLines(Path);
            int leftover = 0;
            string text="";
            foreach(var x in readText)
            {
                text += x;
            }
            
            foreach (string s in text.Split(' '))
            {


                leftover = int.Parse(s.Trim(' '));
                leftover /= 10;


                if (myDictionary.ContainsKey(leftover + "0-" + leftover + "9"))
                {
                    myDictionary[leftover + "0-" + leftover + "9"] += "*";
                }
                else
                {
                    myDictionary.Add(leftover + "0-" + leftover + "9", "*");
                }

            }
            
            foreach(var a in myDictionary)
            {
                Console.WriteLine(a.Key + "" + a.Value);
            }
            
            Console.Read();
        }

    }
}
