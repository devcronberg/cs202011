using System;

namespace DelegateTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            //t.TilfældigTalFunktion = new TilfældigTalDelegate(FT);
            t.TilfældigTalFunktion = FT;
            t.Ryst();
            Console.WriteLine(t.Værdi);
        }

        public static int FT()
        {
            return new Random().Next(1, 7);
        }

    }





    //public delegate int TilfældigTalDelegate();
    class Terning
    {
        public int Værdi { get; set; }
        //public TilfældigTalDelegate TilfældigTalFunktion { get; set; }
        public Func<int> TilfældigTalFunktion { get; set; }
        public void Ryst()
        {
            this.Værdi = FindTal();
        }
        public int FindTal()
        {
            //return new Random().Next(1, 7);
            //return TilfældigTalFunktion.Invoke();
            if (TilfældigTalFunktion != null)
                return TilfældigTalFunktion();
            return 1;
        }
    }
}
