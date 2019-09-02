using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums3
{
    class Odometer
    {
        private double _curMile;
        private const int _maxMil= 999999;
        private const int _minMil = 0;
        private FuelGauge fuelGouge;

        
        public void Report()
        {
            Console.WriteLine("{0} miles driven", _curMile);
        }
        public void Increment()
        {
            if (_curMile < _maxMil)
                _curMile++;
            else
                _curMile = 0;
        }
    }

}
