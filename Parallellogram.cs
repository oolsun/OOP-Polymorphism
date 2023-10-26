using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    // Child class "Parallellogram".
    public class Parallellogram : Geometri
    {
        // Properties used to calculate parallelogram area.
        double Base { get; set; }
        double Height { get; set; }
        // Constructor used to set fixed values.
        public Parallellogram()
        {
            Base = 4;
            Height = 6;
        }
        // Overridden method that calculates and returns area of parallelogram.
        public override double Area()
        {
            return Base * Height;
        }
    }
}
