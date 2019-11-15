using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _name;
        private readonly double _money;
        public Account(string name,double money)
        {
            _name = name;
            _money = money;
        }
        public string ShowUserNameAndBalance()
        {
            if(_money>=0)
                return (_name+@", $"+String.Format("{0:0.##}", _money));
            else
                return (_name + @", -$" + String.Format("{0:0.##}", (_money*-1)));

        }
    }
}
