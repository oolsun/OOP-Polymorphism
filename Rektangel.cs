using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Rektangel : Geometri
    {
        double Height { get; set; }
        double Base { get; set; }

        public Rektangel()
        {
            Height = 5;
            Base = 4;
        }
        public override double Area()
        {
            return Height * Base;
        }
    }
}
