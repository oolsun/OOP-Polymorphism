using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Fyrkant : Geometri
    {
        double _base { get; set; }
        double _height { get; set; }

        public Fyrkant()
        {
            _base = 6;
            _height = 6;
        }
        public override double Area()
        {
            return _base * _height;
        }
    }
}
