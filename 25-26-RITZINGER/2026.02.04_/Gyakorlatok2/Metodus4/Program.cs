namespace Metodus4
{
    internal class Program
    {
        //Out paraméter: visszaad értékeket, inicializálás NEM kell hivás előtt
        static bool Szamfelbontas(string szoveg, out int harmasok,out int parosok)
        {
            harmasok = 0;
            parosok = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0) harmasok++;
                if (i % 2 == 0) parosok++;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int e, p;
            bool retVal;
            Console.WriteLine("== OUT paraméter ==");
            retVal = Szamfelbontas("nem fontos", out e, out p);
            if(retVal)
            {
                Console.WriteLine($"0-100:{e} db 3-zal osztható,{p} db páros");
            }
        }
    }
}
