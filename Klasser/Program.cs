using System;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t = new Terning();
            //t.ErSekser = Sekser;
            //t.Værdi = 1;
            //t.Skriv();
            //t.Ryst();
            //t.Skriv();
            //t.Ryst();
            //t.Skriv();

            LudoTerning t = new LudoTerning();
            t.Ryst();
            t.Skriv();
            Console.WriteLine(t.ErStjerne());

            //Terning t2 = new Terning();
            //t2.Ryst();
            //t2.Skriv();

        }

        public static void Sekser()
        {
            Console.WriteLine("!!!!");
            Console.Beep();

        }
    }







    public class Terning {

        public Action ErSekser;
        private int værdi;

        public int Værdi
        {
            get {
                // log
                // sikkerhed
                return værdi;

            }
            set {
                // log
                // validering
                if (value < 1 || value > 6)
                    value = 1;
                værdi = value;

            }
        }

        public void Ryst() {
            this.Værdi = new Random().Next(1, 7);
            if (this.værdi == 6)
                ErSekser.Invoke();

        }

        public void Skriv()
        {
            Console.WriteLine("[ " + this.værdi + " ]");
        }

        // felter     = Værdier
        // egenskaber = Indkapsling af felter
        // metoder    = Funktionalitet
        // hændelser  = Afkobling



    }

    public class LudoTerning : Terning{
        public bool ErStjerne() {
            return this.Værdi == 3;
        }
    }
}
