using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Ellips : Geometri
    {
        double DotA { get; set; }
        double DotB { get; set; }

        public Ellips()
        {
            DotA = 3;
            DotB = 5;
        }
        public override double Area()
        {
            return DotA * DotB * Math.PI;
        }
    }
}
