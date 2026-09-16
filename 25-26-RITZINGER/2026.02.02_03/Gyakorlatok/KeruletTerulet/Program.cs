using System;

namespace ParosParatlan
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0, K=0,T=0, S=0;
            string inputText = "";

            Console.WriteLine("Háromszög kerület/Terület számitás");
            Console.Write("Adja meg a háromszög első oldalhosszát:");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out a);

            Console.Write("Adja meg a háromszög masodik oldalhosszát:");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out b);

            Console.Write("Adja meg a háromszög harmadik oldalhosszát:");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out c);

            K= a+b +c;
            S = K / 2;
            T=Math.Sqrt(S*(S-a)*(S-b)*(S-c));

            Console.WriteLine($"A háromszög kerülete:{K}");
            Console.WriteLine($"A háromszög területe:{T}");
            Console.WriteLine();
            Console.WriteLine("ENTER-rel lehet kilépni!!");
            Console.ReadLine(); 
        }

    }
}
