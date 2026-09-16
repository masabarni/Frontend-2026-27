namespace NumbersGeneratorInterface
{

    public interface IGenerator
    {
        int Next();

        int Reset();
    }
    
    public class NaturalGenerator : IGenerator      
    {
        public int maxElement = 10;

    }        
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
