using System.

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a number:");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Squre of {num} is {num * num}"); */
            
            try
            {
                Console.WriteLine("Enter a number:");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            catch
            {
                Console.WriteLine("Error occurred");
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
            
        }
    }
}
