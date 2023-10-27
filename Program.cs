using System;

namespace OOP_Polymorphism
{
    // Olov Olsson Sundqvist .NET23
    internal class Program
    {        
        static void Main(string[] args)
        {
            // Create an object reference from Geometri Class
            Geometri area;
            // Use the same reference to call for overridden methods in different classes (Polymorphic method call). Math.Round(2) for two decimals.
            area = new Rektangel();
            Console.WriteLine("Area rektangel: " + Math.Round(area.Area(), 2));
            area = new Fyrkant();
            Console.WriteLine("Area fyrkant: " + Math.Round(area.Area(), 2));
            area = new Cirkel();
            Console.WriteLine("Area cirkel: " + Math.Round(area.Area(), 2));
            area = new Parallellogram();
            Console.WriteLine("Area parallellogram: " + Math.Round(area.Area(), 2));
            area = new Ellips();
            Console.WriteLine("Area ellips: " + Math.Round(area.Area(), 2));

            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}