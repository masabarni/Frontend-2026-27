namespace Alagzatok
{
    public class Circele
    {
        private double r = 0;
        public Circele(double r)
        {
            this.r = r;
        }

        public double Terulet()
        {
            return Math.PI * r * r;
        }

        public double Kerulet()
        {
            return Math.PI * 2 * r;
        }
        
        public void Kiir()
        {
            Console.WriteLine($"Kőr sugara: {this.r}");
        }

        /*public override string ToString()
        {

        }*/
    }

    public class Rectangle
    {
        private double a = 0;
        private double b = 0;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
         public double Kerulet()
        {
            return a * b;
        }

        public double Terulet()
        {
            return 2 * (a + b);
        }

        public void Kiir()
        {
            Console.WriteLine($"Téglalap a: {this.a}, b: {this.b}");
        }

        /*public override string ToString()
        {

        }*/

    }

    public class Square
    {
        public double a = 0;

        public Square(double a)
        {
            this.a = a;
        }

        public double Terulet()
        {
            return a * a;
        }

        public double Kerulet()
        {
            return 4 * a;
        }

        public void Kiir()
        {
            Console.WriteLine($"A Négyzet oldala: {this.a}");
        }

        /*public override string ToString()
        {

        }*/
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circele k = new Circele(67.34);
            k.Kiir();
            Console.Write("A kör területe:" + k.Terulet());
            Console.WriteLine();
            Console.WriteLine("A kör kerülete: " + k.Kerulet());
            Console.WriteLine(k);

            Square n = new Square(101.34);
            n.Kiir();
            Console.WriteLine("A négyzet területe: " + n.Terulet());
            Console.WriteLine();
            Console.WriteLine("A négyzet kerülete: " + n.Kerulet());
            Console.WriteLine(n);

            Rectangle t = new Rectangle(34.12, 56.11);
            t.Kiir();
            Console.WriteLine("A tégélalap területe: " + t.Terulet());
            Console.WriteLine();
            Console.WriteLine("A téglalap kerülete: " + t.Kerulet());
            Console.WriteLine(t);
            
            
        }
    }
}
