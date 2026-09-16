using System;

namespace SzorzoTabla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szorzótábla");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 10; j++)
                {
                    int eredmeny = 0;
                    eredmeny = i * j;
                    if (eredmeny < 10)
                    {
                        Console.Write(eredmeny + "  ");
                    }
                    else
                        Console.Write(eredmeny + " ");
                }
            }
        }
    }

}

