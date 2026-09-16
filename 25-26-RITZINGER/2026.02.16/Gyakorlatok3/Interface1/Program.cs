namespace Interface1
{

    public interface IAnimal
    {
        //public int age = 0;
        //public string gender;

        public bool isMammal()
        {
            return false;
        }

        public void mate()
        {

        }
    }

    public class Duck : IAnimal
    {
        public int age = 0;
        public string gender = "";
        public string beakColor = "red";

        public void swim()
        {
            Console.WriteLine("Duck is swiming.");
        }

        public void quack()
        {
            Console.WriteLine("Duck is quacking");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IAnimal animal = new Duck();
            //animal.swim();
            //animal.quack();

            Duck duck = new Duck();
            duck.quack();
            duck.swim();


            //Console.WriteLine("Hello, World!");
        }
    }
}
