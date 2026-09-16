namespace Metodus3
{
    internal class Program
    {

        static void ErtekAtadas(int szam)
        {
            szam = 999;
            Console.WriteLine($"Benső: {szam}");
        }

        static void RefAtadas(ref int szam)
        {
            szam = 888;
            Console.WriteLine($"Benső ref:{szam}");
        }

        static void Main(string[] args)
        {
            int ertek = 123;
            Console.WriteLine("== ÉRTÉK ADÁS ==");
            Console.WriteLine($"Külső előtte:{ertek}");
            ErtekAtadas(ertek);
            Console.WriteLine($"Külső utánna: {ertek}");//123 marad

            Console.WriteLine("\n== REFERENCIA ADÁS ==");
            Console.WriteLine($"Külső előtte:{ertek}");
            RefAtadas(ref ertek);
            Console.WriteLine($"Külső utána:{ertek}"); //888 lesz
        }
    }
}
