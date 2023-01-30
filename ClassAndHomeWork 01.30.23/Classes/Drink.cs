using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndHomeWork_01._30._23.Classes
{
    public class Drink:Product
    {
        int _alcoholPercent;
        public int AlcoholPercent
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    _alcoholPercent = value;
                }
            }
            get
            {
                return _alcoholPercent;
            }
        }
    }
}
