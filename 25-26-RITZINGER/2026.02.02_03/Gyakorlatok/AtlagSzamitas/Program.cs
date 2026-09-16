using System;

namespace AtlagSzamitas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            double avg;
            string inputText;
            Console.WriteLine("Adj meg 3 egész számot:");
            Console.WriteLine("Kiszámolom a átlagukat.");
            Console.WriteLine("Adj meg egy egész számot:");
            inputText = Console.ReadLine();
            int.TryParse(inputText, out a);

            Console.WriteLine("Adj meg még egy egész számot:");
            inputText = Console.ReadLine();
            b=int.Parse(inputText);

            Console.WriteLine("Adj meg még egy egész számot:");
            inputText = Console.ReadLine();
            c=int.Parse(inputText);

            sum = a+b+c;

            avg = sum / 3;
            Console.Write($"A 3 szám átlaga:{avg}");
            Console.WriteLine();
            Console.WriteLine("ENTER-rel lehet kilépni!!");
            Console.ReadLine();
        }

    }
}
