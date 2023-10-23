namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri rektangel = new Rektangel();
            Console.WriteLine("Area rektangel: " + rektangel.Area());
            Geometri fyrkant = new Fyrkant();
            Console.WriteLine("Area fyrkant: " + fyrkant.Area());
            Geometri cirkel = new Cirkel();
            Console.WriteLine("Area Cirkel: " + cirkel.Area());
            Geometri parallellogram = new Parallellogram();
            Console.WriteLine("Area parallellogram: " + parallellogram.Area());
            Geometri ellips = new Ellips();
            Console.WriteLine("Area ellips: " + ellips.Area());
        }
    }
}