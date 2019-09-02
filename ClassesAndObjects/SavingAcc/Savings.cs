using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAcc
{
    
    class Savings
    {
        private double _savigAmount;
        private double _interest;
        private double _totalDeposite;
        private double _totalWithdraw;

        public double TotalInterest { get; private set; }
        public double TotalWithdraw
        {
            get { return _totalWithdraw; }
        }
        public double AccAmount
        {
            get { return _savigAmount; }
        }
        public double TotalDeposite
        {
            get { return _totalDeposite; }
        }
        public double Interest
        {
            get
            {
                return _interest;
            }
            set
            {
                _interest = value;
            }
        }

        public Savings(double startMoney)
        {
            _savigAmount = startMoney;
        }
        public void WithDraw (double withDraw)
        {
            _savigAmount -= withDraw;
            _totalWithdraw += withDraw;
        }
        public void AddMoney(double income)
        {
            _savigAmount += income;
            _totalDeposite += income;
        }
        public void AddInterest()
        {
            _savigAmount += _savigAmount*_interest;
            TotalInterest+= _savigAmount * _interest;
        }
    }
}
