using System;

namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri area;

            area = new Rektangel();
            Console.WriteLine("Area rektangel: " + area.Area());

            area = new Fyrkant();
            Console.WriteLine("Area fyrkant: " + area.Area());

            area = new Cirkel();
            Console.WriteLine("Area cirkel: " + Math.Round(area.Area(), 2));

            area = new Parallellogram();
            Console.WriteLine("Area parallellogram: " + area.Area());

            area = new Ellips();
            Console.WriteLine("Area ellips: " + Math.Round(area.Area(), 2));

            Console.WriteLine("\nTryck på valfri tangent för att avsluta...");
            Console.ReadKey();
        }
    }
}