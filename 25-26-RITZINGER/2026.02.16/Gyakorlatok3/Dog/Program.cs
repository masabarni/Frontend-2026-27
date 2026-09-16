namespace Dog
{
    public class Dog
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Dog() 
        {
            Color = "";
            Name = "";
            Breed = "";
            Height = 0;
            Width = 0;
        }
        public Dog(string color, string name, string breed,double height, double weight)
        {
            this.Color = color;
            this.Name = name;
            this.Breed = breed;
            this.Height = height;
            this.Width = weight;
        }

        public void WagTail()
        {
            Console.WriteLine($"{Name} csoválja a farkát!");
        }

        public void Shit()
        {
            Console.WriteLine($"{Name} kupacot gyárt!");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} ugat: Vau Vau!");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eszik");
        }

        public void LieDown()
        {
            Console.WriteLine($"{Name} lefekszik.");
        }

        public void Shake()
        {
            Console.WriteLine($"{Name} Megrázza magát!");
        }

        public override string ToString()
        {
            return $"Dog: {Name}({Breed}), Color: {Color}, Height: {Height} cm ({Width} kg)";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog bobby = new Dog();
            Dog Rex = new Dog("Black","Rex","Német Juhász",50.0,60.0);
            bobby.Color = "Yellow Brown";
            bobby.Name = "Bobby";
            bobby.Breed = "Labrador";
            bobby.Height = 43.18;
            bobby.Width = 10.89;

            Console.WriteLine(bobby);
            bobby.WagTail();
            bobby.Bark();
            bobby.Eat();
            bobby.LieDown();
            bobby.Shake();
            bobby.Shit();

            Console.WriteLine(Rex);
            Rex.WagTail();
            Rex.Bark();
            Rex.Eat();
            Rex.LieDown();
            Rex.Shake();
            Rex.Shit();
        }
    }
}
