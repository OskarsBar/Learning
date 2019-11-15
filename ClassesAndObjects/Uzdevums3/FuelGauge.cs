using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums3
{
    class FuelGauge
    {

        private double _currentFuel;
        private const double _maxLevel = 70;
        private const double _minLevel = 0;

        public void CurrentFuel()
        {
            Console.WriteLine("There is {0} littres left", _currentFuel);
        }
        public void FuelFill()
        {
            if(_currentFuel<_maxLevel)
            _currentFuel++;
        }
        public void FuelSpill()
        {
            if (_currentFuel > _minLevel)
                _currentFuel--;
        }
    }
}
