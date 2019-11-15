using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Car
    {
        double _startKilometers; // Starting odometer reading
        double _endKilometers; // Ending odometer reading
        double _liters; // Liters of gas used between the readings


       public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers = startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }
        public double calculateConsumption()
        {
            return (_endKilometers-_startKilometers)/_liters;
        }
        public bool GasHog()
        {
            return true;
        }
        public bool EconomyCar()
        {
            return true;
        }
    }
}
