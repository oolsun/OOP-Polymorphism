using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    // Child class for "Cirkel".
    public class Cirkel : Geometri
    {
        // Properties used to calculate circle area.
        double Radius { get; set; }
        // Constructor used to set fixed values.
        public Cirkel()
        {
            Radius = 4;
        }
        // Overridden method that calculates and returns area of circle.
        public override double Area()
        {
            return Radius * Radius* Math.PI;
        }
    }
}
