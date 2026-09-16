using System;

namespace RandomSzam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(100);
            int veletlenSzam = r.Next(1, 100);
            int Tipp = 0;
            bool eltalaltuk = false;
            string inputText = "";
            do
            {
                Console.Write("Kérek egy tippet: ");
                inputText = Console.ReadLine(); ;
                Tipp = int.Parse(inputText);
                if(Tipp < veletlenSzam)
                {
                    Console.Write("A szam nagyobb mint a tipp ");
                }
                else
                {
                    if(Tipp > veletlenSzam)
                    {
                        Console.Write("A szám kissebb mint a tipp volt!");
                    }
                    else
                    {
                        Console.Write("Eltaláltad");
                        eltalaltuk = true;
                    }
                }
            }
            while (!eltalaltuk);

            Console.WriteLine($"Egy véletlen szám: {r.Next(1,100)}");
            Console.WriteLine();
            Console.WriteLine("ENTER-rel lehet kilépni!!");
            Console.ReadLine();
        }

    }
}
