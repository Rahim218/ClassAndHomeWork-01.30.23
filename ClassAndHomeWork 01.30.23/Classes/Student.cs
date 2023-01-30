using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndHomeWork_01._30._23.Classes
{
    public class Student
    {
        public string FullName;
        private int _age = 15;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 15)
                {
                    _age = value;
                }
            }
        }
    }
}
