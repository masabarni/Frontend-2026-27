namespace Reszveny
{

    public class Reszveny
    {
        //mezők,belső változok,properties
        private readonly string reszvenynev;
        private double reszvényarfolyam = 0.0;
        public int Darabszam;

        public Reszveny(string nev,double arfolyam,int darabszam)
        {
            reszvenynev = nev;
            reszvényarfolyam = arfolyam;
            Darabszam = darabszam;
        }

        public void Vetel(int mennyiseg)
        {
            //Darabszam += mennyiseg;
            Darabszam = Darabszam + mennyiseg;
        }

        public void Eladas(int mennyiseg)
        {
            //Darabszam -= mennyiseg;
            if(Darabszam > mennyiseg)
            {
                Darabszam = Darabszam - mennyiseg;
            }
            else
            {
                Console.WriteLine("Nincs annyi részvény!!!!");
            }
        }

        public void ArfolyamBealitasa(double arfolyam)
        {
            reszvényarfolyam = arfolyam; 
        }

        public double Ertek()
        {
            return reszvényarfolyam * Darabszam;
        }

        ~Reszveny()
        {
            Console.WriteLine("Destruktor Meghivódott!!!!!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Reszveny IBM = new Reszveny("IBM", 77.59, 100);
            Reszveny nVidia = new Reszveny("NVIDIA", 21.49,100);

            //IBM.Darabszam = 23;
            //IBM.reszvényarfolyam = 24.23;
            IBM.Vetel(50);
            nVidia.Vetel(25);
            nVidia.ArfolyamBealitasa(29.15);
            nVidia.Eladas(50);
            Console.WriteLine("Az IBM részvényeim értéke: " + nVidia.Ertek());
            Console.WriteLine();
            Console.WriteLine("Az nVidia részvényeim értéke: " +IBM.Ertek());
        }
    }
}
