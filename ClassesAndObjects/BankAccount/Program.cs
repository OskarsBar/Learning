using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bil = new Account("Bill", 10000.365);
            Console.WriteLine(bil.ShowUserNameAndBalance());
            Console.Read();
        }
    }
}
