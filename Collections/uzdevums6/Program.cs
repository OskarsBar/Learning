using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzdevums6
{
    class Program
    {
        private const string Path = "C:/Users/codelex/source/repos/Collections/uzdevums6/lear.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            int sumOfChars = 0;
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }
            
            var fullText = String.Join(" ", readText);
            var words = fullText.Split();
            foreach (char s in fullText)
            {
                if (Char.IsLetterOrDigit(s))
                    sumOfChars++;
                
            }
            Console.WriteLine("Words: {0}",words.Length);
            Console.WriteLine("Lines: {0}",readText.Length);
            Console.WriteLine("chars: {0}", sumOfChars);
            Console.Read();
        }
    }
}
