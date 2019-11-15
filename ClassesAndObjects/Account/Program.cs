using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount.AcountInfo());
            Console.WriteLine(bartosSwissAccount.AcountInfo());

            
            bartosAccount.withdrawal(20);
            Console.WriteLine("Barto's account balance is now: "+bartosAccount.balance());
            bartosSwissAccount.deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: "+bartosSwissAccount.balance());
            

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount.AcountInfo());
            Console.WriteLine(bartosSwissAccount.AcountInfo());

            var testAcc = new Account("My acount", 100.00);
            testAcc.deposit(20);
            Console.WriteLine(testAcc.AcountInfo());

            var myAcc = new Account("My acount", 0);
            var matAcc = new Account("Mats acount", 1000);
            matAcc.withdrawal(100);
            myAcc.deposit(100);
            Console.WriteLine(matAcc.AcountInfo());
            Console.WriteLine(myAcc.AcountInfo());

            var a = new Account("A", 100);
            var b = new Account("B", 0);
            var c = new Account("C", 0);

            Account.Transfer(a, b, 50);
            Account.Transfer(b, c, 25);

            Console.WriteLine(a.AcountInfo());
            Console.WriteLine(b.AcountInfo());
            Console.WriteLine(c.AcountInfo());




            Console.Read();
        }
    }
}
