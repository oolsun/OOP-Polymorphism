using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Ellips : Geometri
    {
        public double _dotA { get; set; }
        public double _dotB { get; set; }

        public Ellips()
        {
            _dotA = 3;
            _dotB = 5;
        }
        public override double Area()
        {
            return _dotA * _dotB * Math.PI;
        }
    }
}
