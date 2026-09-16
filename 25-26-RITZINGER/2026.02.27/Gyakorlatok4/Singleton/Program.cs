namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.GetSingleton();
            Singleton obj2 = Singleton.GetSingleton();

            if(obj1.Equals(obj2))
            {
                Console.WriteLine("obj1 and obj2 are the same instance.");
            }
            else
            {
                Console.WriteLine("obj1 and obj2 are different instances.");
            }
        }
    }
}
