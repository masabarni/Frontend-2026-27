using System;

namespace Osszegzo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy egész számot:");
            string inputText = Console.ReadLine();
            int N = Convert.ToInt32(inputText);
            int sum = 0;
            int i = 1;

            while (i <= N)
            {
                sum = sum + i;
                i++;
            }

            //Console.WriteLine("A számok összeg: " + sum); 
            Console.WriteLine($"A számok összeg: {sum} ");
        }

    }
}
