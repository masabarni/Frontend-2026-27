namespace Fajlkezeles5
{

    class  Termek
    {
        public string Nev {  get; set; }
        public int Ar {  get; set; }

        public double Mennyiseg { get; set; }

        public override string ToString()
        {
            return $"{this.Nev};{this.Ar};{this.Mennyiseg}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = "termek.csv";

            //Irás
            List<Termek> termekek = new List<Termek>
            {
                new Termek { Nev = "Alma", Ar = 500, Mennyiseg = 10.5},
                new Termek { Nev = "Banán", Ar = 300, Mennyiseg = 23.4 }
            };

            //Termék adatok listáját alakitja string listává
            List<string> sorok = termekek.Select(t => t.ToString()).ToList();
            File.WriteAllLines(fajl, sorok);

            //Olvasás
            string[] beolvasottSorok = File.ReadAllLines(fajl);
            List<Termek> beolvasottak = new List<Termek>();
            foreach(string sor in beolvasottSorok)
            {
                string[] reszek = sor.Split(';');
                if (reszek.Length == 3 && int.TryParse(reszek[1],out int ar)&& double.TryParse(reszek[2],out double mennyiseg))
                {
                    beolvasottak.Add(new Termek {Nev = reszek[0],Ar = ar, Mennyiseg = mennyiseg});
                    Console.Write("A beolvasott termek neve: {0}, ára:{1},mennyiseg:{2}", reszek[0],ar,mennyiseg);
                    Console.Write(ar);
                }
            }

        }
    }
}
