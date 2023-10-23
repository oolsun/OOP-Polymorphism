using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Parallellogram : Geometri
    {
        double _base { get; set; }
        double _height { get; set; }

        public Parallellogram()
        {
            _base = 4;
            _height = 6;
        }
        public override double Area()
        {
            return _base * _height;
        }
    }
}
