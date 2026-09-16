using System;

namespace ParosSzamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy egész számot:");
            string inputText = Console.ReadLine();
            int n = int.Parse(inputText);
            if (n % 2 == 0)
            {
                Console.Write(n + "Páros szám!");
            }
            else
            {
                Console.Write(n + "Páratblan");
            }

        }
    }
}