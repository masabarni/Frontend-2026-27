namespace Fajkezelo6
{

    public class Data
    {
        public string Cim;
        public string Szerzo;
        public string Kategoria;
        public int KiadasEve;
        public int Oldalszam;

        public override string ToString()
        {
            return $"{Cim};{Szerzo};{Kategoria};" +
                $"{KiadasEve};{Oldalszam}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = "konyvtar.txt";

            //Olvasás
            string[] bolvasottSorok = File.ReadAllLines(fajl);
            List<Data> beolvasottak = new List<Data>();
            foreach(string sor in bolvasottSorok)
            {
                string[] reszek = sor.Split(';');
                if (reszek.Length == 5 && int.TryParse(reszek[3], out int kiadasEve)
                    && int.TryParse(reszek[4], out int oldalszam))
                {
                    beolvasottak.Add(new Data
                    {
                        Cim = reszek[0],
                        Szerzo = reszek[1],
                        Kategoria = reszek[2],
                        KiadasEve = kiadasEve,
                        Oldalszam = oldalszam
                    });
                    Console.WriteLine("A beolvasott könyv cime: {0}, Szerzője: {1}," + "Kategóriája: {2}, Kiadás éve: {3}, Oldalszáma: {4}",
                        reszek[0], reszek[1], reszek[2],kiadasEve,oldalszam);
                    Console.WriteLine();
                }
            }
        }
    }
}
