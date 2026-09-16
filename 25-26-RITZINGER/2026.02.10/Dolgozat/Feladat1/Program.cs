namespace Feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elso = 0;
            int masodik = 0;
            string inoutText = null;
            Console.WriteLine("Egész számok hányadosának kiszámitása.");
            Console.WriteLine("Kérem az első egész számot: ");
            inoutText = Console.ReadLine();
            //elso = int.Parse(inoutText);
            elso = Convert.ToInt32(inoutText);
            Console.Write("Kérem a második egész szzámot: ");
            inoutText = Console.ReadLine();
            masodik = Convert.ToInt32(inoutText);
            Console.WriteLine($"A számok hányados: {(double)elso/masodik:F2} ");
        }
    }
}
