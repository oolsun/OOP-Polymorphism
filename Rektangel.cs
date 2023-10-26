using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    // Child class "Rektangel".
    public class Rektangel : Geometri
    {
        // Properties used to calculate rectangle area.
        double Height { get; set; }
        double Base { get; set; }
        // Constructor used to set fixed values
        public Rektangel()
        {
            Height = 5;
            Base = 4;
        }
        // Overridden method that calculates and returns area of rectangle.
        public override double Area()
        {
            return Height * Base;
        }
    }
}
