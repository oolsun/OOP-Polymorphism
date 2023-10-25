using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Parallellogram : Geometri
    {
        double Base { get; set; }
        double Height { get; set; }

        public Parallellogram()
        {
            Base = 4;
            Height = 6;
        }
        public override double Area()
        {
            return Base * Height;
        }
    }
}
