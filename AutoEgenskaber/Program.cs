using System;

namespace AutoEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //class Person {
    //    //private string navn;

    //    //public string Navn
    //    //{
    //    //    get { return navn; }
    //    //    set { navn = value; }
    //    //}

    //    // Auto egenskaber
    //    public string Navn { get; set; }

    //}

    class Terning {

        public int Værdi { get; set; }
        //private int værdi;

        //public int Værdi
        //{
        //    get { return værdi; }
        //    set { 
                
                
        //        værdi = value; }
        //}


    }

    

    class Faktura {
        public int FakturaNummer { get; private set; } = 1;
        public string KundeNavn { get; set; }


    }

}
