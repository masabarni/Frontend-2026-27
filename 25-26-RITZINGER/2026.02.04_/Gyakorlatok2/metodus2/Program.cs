namespace metodus2
{
    internal class Program
    {
        static void Rendeles(string termeknev, int mennyiseg = 1, decimal kedvezmeny = 0m)
        {
            decimal osszeg = mennyiseg * 1000m* (1m - kedvezmeny);
            Console.WriteLine($"{mennyiseg} db {termeknev}: {osszeg:F0} Ft");
        }

        static void Main()
        {
            Console.WriteLine("== Optinal argumnetek ==");
            Rendeles("Egér");
            Rendeles("Billentyűzet", 2);
            Rendeles(termeknev: "Monitor", kedvezmeny: 0.1m);
            Console.WriteLine("\n== Named argumentek tetszőleges sorrendben ==");
            Rendeles(kedvezmeny: 0.2m, mennyiseg: 3, termeknev: "Laptop"); 
        }
    }
}
