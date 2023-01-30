using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndHomeWork_01._30._23.Classes
{
    public class Car : Vehicle
    {
        public Car(double fuelCapacity)
        {
            _fuelCapacity = fuelCapacity;
        }
        double _fuelCapacity;

        double _currentFuel;

        public double FuelFor1Km;
        public double FuelCapacity => _fuelCapacity;

        public double CurrentFuel => _currentFuel;

        public void AddFuel(int litr)
        {
            if (_currentFuel + litr <= _fuelCapacity)
            {
                _currentFuel += litr;
            }
        }

        public override void Drive(double km)
        {

            double needFuel = FuelFor1Km * km;
            if (_currentFuel >= needFuel)
            {
                _currentFuel -= needFuel;
                _milage += km;
            }
        }
    }
}
