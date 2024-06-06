using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Triangle
{
    internal class Triangle
    {
        private double _base;
        private double _height;

        public double Base
        {
            get { return _base; }
            set
            {
                if (value  <= 0)
                {
                    throw new ArgumentException("Base must be positive value");
                }
                _base = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive value");
                }
                _height = value;
            }
        }

        public double GetArea()
        {
            return 0.5 * _base * _height;
        }
    }
}
