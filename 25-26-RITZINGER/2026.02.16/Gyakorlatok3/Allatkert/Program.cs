namespace Allatkert
{

    public interface IFentarthato
    {
        double Napikoltes();

        const int ELELMISZER_AR = 1200;
    }

    public abstract class Allat : IFentarthato
    {
        protected bool vedett;
        protected double suly;

        public Allat(bool a,double b)
        {
            vedett = a;
            this.suly = b;
        }
        public double Napikoltes()
        {
            double retValue = 0;
            if (!vedett) //Ha édett
            {
                retValue = suly * IFentarthato.ELELMISZER_AR;
            }
            else //Ha védett akkor 2-szer annyi
            {
                retValue = suly * IFentarthato.ELELMISZER_AR * 2;
            }
            return retValue;
        }

        public abstract void HangotAd();

        public override string ToString()
        {

            //return base.ToString();
            //150kg - Védett - 360000 Ft
            string vedettE = vedett ? "Védett" : "Nem Védett"; 
            return $"{suly} kg {vedettE}- - {Napikoltes()} Ft/Nap";
        }
    }

    class Oroszlan : Allat
    {
        public Oroszlan(bool a,double b)
            :base(a,b)
        {

            //Allat(a, b)
            //vedett = a;
            //suly = b;
            
        }

        public override void HangotAd()
        {
            Console.WriteLine("Az Oroszlán ordit");
        }

        public override string ToString()
        {
            //return basa.ToString();
            //Oroszlan - 200 kg - Nem Védett - 240000 Ft/nap
            string vedettE = vedett ? "Védett" : "Nem Védett";
            return $"Oroszlán - {suly} kg - {vedettE} - {Napikoltes()} Ft/Nap";
        }
    }

    public class Papagaj : IFentarthato
    {
        private bool beszel;

        public Papagaj(bool a)
        {
            this.beszel = a;
        }

        public double Napikoltes()
        {
            double retValue = 0;
            if (!beszel) //Ha nem bezsél
            {
                retValue = 0.5 * IFentarthato.ELELMISZER_AR;
            }
            else //Ha beszél
            {
                retValue = 0.8 * IFentarthato.ELELMISZER_AR;
            }
            return retValue;
        }

        public override string ToString()
        {
            //return basa.ToString();
            //Beszélő papagáj - 960 Ft/nap
            string beszelE = beszel ? "Beszél" : "Nem Beszél";
            return $"Papagáj - {beszelE} - {Napikoltes()} Ft/Nap";
        }
    }

    internal class Allatkert
    {
        static void Main(string[] args)
        {
            List<IFentarthato> sajatLista = new List<IFentarthato>();
            sajatLista.Add(new Oroszlan(true, 250.5));
            sajatLista.Add(new Papagaj(true));
            sajatLista.Add(new Oroszlan(false, 355.75));
            sajatLista.Add(new Papagaj(false));

            foreach(IFentarthato item in sajatLista)
            {
                Console.WriteLine(item);
                //Ha az aktuális elem :
                if(item is Oroszlan oroszlan)
                {
                    //Az oroszlán ordit kiirás.
                    oroszlan.HangotAd();
                }
            }
        }
    }
}
