using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Rektangel : Geometri
    {
        double _height {get; set;}
        double _base { get; set; }

        public Rektangel()
        {
            _height = 5;
            _base = 4;
        }
        public override double Area()
        {
            return _height * _base;
        }
    }
}
