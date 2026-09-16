using System;

namespace Armstrong 
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, t, e;
            for (int i = 100; i < 999; i++)
            {
                s = i / 100;
                t = i % 10 / 10;
                e = i % 10;
                if (s * s * s + t * t * t + e * e * e == i)
                {
                    Console.WriteLine(i + " armtrong szám!");
                }
                
            }
        }

    }
}
