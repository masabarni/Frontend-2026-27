using System;

namespace ParosSzamok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy számot:");
            string inputText = Console.ReadLine();
            int n = Convert.ToInt32(inputText);
            int sum = 0;
            int i = 0;

            while (i <= n)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine($"A számok összege:{sum}");
        }
    }
}