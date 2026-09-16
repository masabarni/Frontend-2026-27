namespace UMLGyak
{
    public class Animal
    {
        public int age = 0;
        public string gender;

        public bool isMammal()
        {
            return false;
        }

        public void mate()
        {

        }
    }

    public class Duck:Animal
    {
        public string beakColor = "red";

        public void swim()
        {

        }

        public void quack()
        {

        }
    }

    public class Fish : Animal
    {
        public int sizeInFeet = 0;

        public bool canEat()
        {
            return false;
        }
    }

    public class Zebra : Animal
    {
        public bool is_wild = false;

        public void run()
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
