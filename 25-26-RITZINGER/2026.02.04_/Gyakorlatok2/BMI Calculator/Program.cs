namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double testsuly;
            double magassag = 0;
            double bmi = 0;
            string inputText = null;


            Console.WriteLine("=== BMI egyenlet megoldás ===");
            Console.WriteLine("Kérem a magasságát (cm-ben): ");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out magassag);
            Console.WriteLine("Kérem a testsulyát.(kg-ban):");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out testsuly);
            bmi = testsuly / Math.Pow(magassag / 100, 2);
            Console.WriteLine($"A BMI értéke:{bmi:F1} ");

            if(bmi < 18.5 )
            {
                Console.WriteLine("Sovány vagy!!!");
            }
            else if (18.5< bmi && bmi<24.9)
            {                                           
                Console.WriteLine("Normál súlyú vagy!!!");
            }
            else if (25.0< bmi && bmi<29.9)
            {
                Console.WriteLine("Túlsúlyos vagy!!!");
            }
            else if (bmi > 30)
            {
                Console.WriteLine("Elhiztál!!!");
            }
        }
    }
}
    