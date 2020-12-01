using System;

namespace Hændelse2
{
    class Program
    {
        static void Main(string[] args)
        {
            EventDelegate a = new EventDelegate();
            //a.DelegateTest += (s, e) => { };
            //a.DelegateTest += (s, e) => { };
            //a.DelegateTest += (s, e) => { };
            //a.DelegateTest = null;

            //a.EventTest += (s, e) => { };
            //a.EventTest += (s, e) => { };
            //a.EventTest += (s, e) => { };
            //a.EventTest = null;
            //a.Event4 += (s, e) => { e. };

            Konto k = new Konto(100);
            //k.KontoIMinus += (s, e) => Console.WriteLine("MINUS");
            k.Indsæt(10);
            k.Udtræk(200);
        }
    }
    class EventDelegate
    {
        public Action<object, EventArgs> DelegateTest;
        public event Action<object, EventArgs> EventTest;
        //public event EventHandler<System.IO.FileSystemEventArgs> Event4;
        public void Test()
        {
            DelegateTest?.Invoke(this, new EventArgs());
            EventTest?.Invoke(this, new EventArgs());
        }
    }
    class Konto
    {
        public double Saldo { get; private set; }
        public event EventHandler KontoIMinus;
        public Konto(double saldo)
        {
            Saldo = saldo;
        }

        public void Indsæt(double beløb)
        {
            Saldo += beløb;
            if (Saldo < 0)
                if(KontoIMinus!=null)
                    KontoIMinus(this, new EventArgs());
        }

        public void Udtræk(double beløb)
        {
            Saldo -= beløb;
            if (Saldo < 0)
                KontoIMinus?.Invoke(this, new EventArgs());
        }
    }
}
