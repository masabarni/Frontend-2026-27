namespace Fajlkezeles3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fajl = "binaris.dat";

            //Irás
            using (FileStream fs = new FileStream(fajl, FileMode.Create))
            using(BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(42);
                bw.Write("Hello");
                bw.Write(true);
            }

            //Olvas
            using (FileStream fs = new FileStream(fajl, FileMode.Open))
            using(BinaryReader br = new BinaryReader(fs))
            {
                int szam = br.ReadInt32();
                string szoveg = br.ReadString();
                bool logikailag = br.ReadBoolean();

                Console.WriteLine($"{szam}, {szoveg}, {logikailag}");
            }
        }
    }
}
