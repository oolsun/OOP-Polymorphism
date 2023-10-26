using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    // Child class "Fyrkant" (I interpret it as a square (all sides the same))
    public class Fyrkant : Geometri
    {
        // Properties used to calculate square area.
        double Side { get; set; }
        // Constructor used to set fixed values.
        public Fyrkant()
        {
            Side = 6;
        }
        // Overridden mathod that calculates and return area of square.
        public override double Area()
        {
            return Side * Side;
        }
    }
}
