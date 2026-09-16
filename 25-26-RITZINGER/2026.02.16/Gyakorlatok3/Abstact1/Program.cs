namespace Abstact1
{

    public abstract class Animal
    {
        public int age = 0;
        public string gender;

        public abstract bool isMammal();

        public abstract void mate();
    }

    public class Duck : Animal
    {
        public string beakColor = "red";

        public void swim()
        {

        }

        public void quack()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
