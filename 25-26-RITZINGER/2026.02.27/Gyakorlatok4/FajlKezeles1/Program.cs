using System;
using System.IO;

namespace FajlKezeles1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "teszt.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("A{0} keresett fájl létezik!",path);
                File.WriteAllText(path, "Hello file Handling in C#");
            }
            else
            {
                Console.WriteLine("A {0} fájl nem létezik",path);
            }
        }
    }
}
