namespace Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0,b = 0,c = 0;
            double x1 =0,x2 =0;
            string inputText = null;
            Console.WriteLine("=== Másodfokú egyenlet megoldás ===");
            Console.WriteLine("Kérem az (a) együthatót: ");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out a);
            Console.Write("Kérem a (b) együtthatót:");
            double.TryParse(inputText, out b);
            Console.Write("Kérem a (c) együtthatót:");
            double.TryParse(inputText, out c);
            x1 = (-1 * b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            x2 = (-1 * b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.WriteLine($"");
        }
    }
}
