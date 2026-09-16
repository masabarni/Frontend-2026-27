namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Add\n 2. Subtract\n 3.Multiply\n 4.Division");
            //int choice = int.Parse(Console.ReadLine());
            //char choice = (char)Console.Read();
            //string choice = Console.ReadLine();
            float choice = float.Parse(Console.ReadLine());
            int a = 10, b = 5;
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Sum: " + (a+b));
                    break;
                case 2:
                    Console.WriteLine("Differente" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Product" + (a*b));
                    break;
                case 4:
                    Console.WriteLine("Quotient" +(a/b));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
