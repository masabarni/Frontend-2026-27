using System;

namespace ParosParatlan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy egész számot:");
            string inputText = Console.ReadLine();
            int n = 0;
            int.TryParse(inputText, out n);
            if (n % 2 == 0)
            {
                Console.Write(n + " páros szám!");
            }
            else
            {
                Console.Write(n + " páratlan szám!");
            }
        }

    }
}
