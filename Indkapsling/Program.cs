using System;

namespace Indkapsling
{
    class Program
    {


        static void Main(string[] args)
        {
            Terning t = new Terning();
            //t.SetVærdi(-6);
            t.Værdi = 6;

            //t.Skriv();
            //Console.WriteLine(t.GetVærdi());
            Console.WriteLine(t.Værdi);
            ///

            //Terning t = new Terning();

            //var m = t.GetType().GetMethods();

        }
    }


    class Terning
    {

        private int værdi;

        public int Værdi
        {
            get
            {
                // sikkerhed
                return this.værdi;
            }
            set
            {
                // log
                // sikkerhed
                if (value < 1 || value > 6)
                    throw new ApplicationException("Fejl i værdi");
                this.værdi = value;
            }
        }

        private bool snyd;

        public bool Snyd
        {
            get { return snyd; }
            set { snyd = value; }
        }



    }
    //class Terning {

    //    // Felter
    //    // Metoder
    //    // Egenskaber (properties)

    //    private int værdi;

    //    public int GetVærdi() {
    //        // log
    //        // sikkerhed
    //        return værdi;
    //    }

    //    public void SetVærdi(int value)
    //    {
    //        // log
    //        // sikkerhed
    //        // validering
    //        if (value < 1 || value > 6)
    //            throw new ApplicationException("Fejl i værdi");
    //        this.værdi = value;
    //    }

    //    public Terning()
    //    {
    //        værdi = new Random().Next(1, 7);
    //    }

    //    public void Skriv() {
    //        Console.WriteLine("[ " + this.værdi + " ]");
    //    }

    //}
}
