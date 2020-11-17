using System;

namespace Recap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura();
            f.KundeNavn = "mikkel";
            Console.WriteLine(f.NavnMedStort());
        }
    }

    class Faktura {

        private int fakturaNr;

        public int FakturaNr
        {
            get { return fakturaNr; }
            set { fakturaNr = value; }
        }

        private string kundeNavn;

        public string KundeNavn
        {
            get { return kundeNavn; }
            set {
                if (value == null)
                    value = "";
                kundeNavn = value; }
        }

        public Faktura()
        {
            this.KundeNavn = "";
        }


        //public string NavnMedStort
        //{
        //    get
        //    {
        //        return this.KundeNavn.ToUpper();
        //    }
        //}

        public string NavnMedStort()
        {
                return this.KundeNavn.ToUpper();
        }

    }

    class A {
        
    }

    class B : A { }

    sealed class C: B { }

    


}
