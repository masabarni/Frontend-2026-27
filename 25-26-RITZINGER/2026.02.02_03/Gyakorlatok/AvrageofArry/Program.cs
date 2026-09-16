using System;

namespace AvrageOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 10, 20, 30, 40 };
            double avg = numbers.Average();
            Console.WriteLine("Average" + avg);*/

            int[] numbers;
            int tombHossz;
            string inputText;
            double avg;

            Console.WriteLine("Adjunk be egész számokat:");
            Console.WriteLine("Hány számot olvasunk be?");
            inputText = Console.ReadLine();
            tombHossz = Convert.ToInt32(inputText);

            numbers = new int[tombHossz];

            for (int i = 0;  i < tombHossz; i++)
            {
                Console.WriteLine($"Kérjük a{i}-edik számot:");
                inputText= Console.ReadLine();
                numbers[i] = Convert.ToInt32(inputText);

            }

            avg = numbers.Average();
            Console.WriteLine("Average" +  avg);

            Console.WriteLine();
            Console.WriteLine("ENTER-rel lehet kilépni");
            Console.ReadLine();
        }
    }
}