using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Cirkel : Geometri
    {
        public double _radius { get; set; }

        public Cirkel()
        {
            _radius = 4;
        }
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
