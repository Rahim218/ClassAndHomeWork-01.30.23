using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndHomeWork_01._30._23.Classes
{
    public class Vehicle
    {

        protected double _milage;
        public double Milage => _milage;

        public virtual void Drive(double km)
        {
            _milage += km;
        }

    }
}
