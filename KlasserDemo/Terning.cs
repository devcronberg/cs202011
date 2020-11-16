using System;

namespace KlasserDemo
{
    public class Terning
    {

        public int Værdi;
        public bool Snyd;
        private int antalSeksere;

        // Default
        public Terning() 
        {
            this.Ryst();
        }

        // Custom
        public Terning(int værdi) : this(værdi, false) {

        }

        public Terning(bool snyd) : this(1, snyd)
        {

        }

        public Terning(int værdi, bool snyd)
        {
            // val
            // ini
            // log
            // sik
            if (værdi < 1 || værdi > 6)
                this.Værdi = 1;
            else
                this.Værdi = værdi;

            this.Snyd = snyd;
        }

        public void Ryst() {
            this.Værdi = new Random().Next(1, 7);
            if (this.Værdi == 6)
                antalSeksere++;
        }

        public void Skriv() {
            Console.WriteLine($"[ {this.Værdi} ]");
        }

        public int AntalSeksere()
        {
            return antalSeksere;
        }
    }



}
