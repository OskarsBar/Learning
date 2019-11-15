using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("How much money is in the account?: ");
            Savings mySavingAcc = new Savings(Convert.ToDouble( Console.ReadLine()));
            Console.WriteLine("Enter the annual interest rate: ");
            mySavingAcc.Interest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How long has the account been opened?");
            month = Convert.ToInt32( Console.ReadLine());
            for (int i = 0; i < month; i++)
            {
                Console.WriteLine("Enter amount deposited for month {0}", i + 1);
                mySavingAcc.AddMoney(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter amount withdrawn for month {0}", i + 1);
                mySavingAcc.WithDraw(Convert.ToDouble(Console.ReadLine()));
                mySavingAcc.AddInterest();
            }
            
            Console.WriteLine("total interest is {0}",mySavingAcc.TotalInterest);
            Console.WriteLine("total withdraw is {0}", mySavingAcc.TotalWithdraw);
            Console.WriteLine("total deposite is {0}", mySavingAcc.TotalDeposite);
            Console.WriteLine("Ending balace {0}", mySavingAcc.AccAmount);
            Console.Read();

        }
    }
}
