using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    // Child class "Ellips"
    public class Ellips : Geometri
    {
        // Properties used to calculate ellipse area.
        double DotA { get; set; }
        double DotB { get; set; }
        // Constructor used to set fixed values.
        public Ellips()
        {
            DotA = 3;
            DotB = 5;
        }
        // Overridden method that calculates and returns area of ellipse.
        public override double Area()
        {
            return DotA * DotB * Math.PI;
        }
    }
}
