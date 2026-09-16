namespace Metodus1
{
    internal class Program
    {
        static int Osszeadas(int a, int b)
        {
            int eredmeny = a + b;
            return eredmeny;
        }

        static string SzovegHossza(string szoveg)
        {
            return szoveg.Length.ToString();
        }

        static void Kiir()
        {
            Console.WriteLine("");
        }
        static void Main()
        {
            Console.WriteLine(Osszeadas(7,3)); // 10
            Console.WriteLine(SzovegHossza("Hello")); // 5
        }
    }
}
