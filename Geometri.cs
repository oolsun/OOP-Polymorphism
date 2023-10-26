using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    // Parent class
    public class Geometri
    {
        // Method that will be overriden in child classes. Set to 0 since it has to have a return value, even though it will never be used.
        public virtual double Area()
        {
            return 0;
        }
    }
}
