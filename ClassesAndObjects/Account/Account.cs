using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string _acountName;
        private double _acountMoney;

        public Account(string acuntName, double acountMoney)
        {
            _acountName = acuntName;
            _acountMoney = acountMoney;
            
        }
        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.withdrawal(howMuch);
            to.deposit(howMuch);
        }
        public void withdrawal(double withdrawAmount)
        {
            _acountMoney -= withdrawAmount;
        }

        public string AcountInfo()
        {
            return _acountName+" with balance "+ _acountMoney.ToString();
        }

        public string balance()
        {
            return _acountMoney.ToString();
        }

        public void deposit(double depositeAmount)
        {
            _acountMoney += depositeAmount;
        }
    }
}
