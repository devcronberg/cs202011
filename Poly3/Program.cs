using System;
using System.Collections.Generic;

namespace Poly3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kæledyr k = new Kæledyr();
            //Console.WriteLine(k.Kendelyd());

            Hund h = new Hund();
            //Console.WriteLine(h.Kendelyd());

            Fugl f = new Fugl();
            //Console.WriteLine(f.Kendelyd());


            Kæledyr k2 = new Hund();
            //Console.WriteLine(k2.Kendelyd());

            Kæledyr k3 = new Fugl() { HåndTam = true };
            //Console.WriteLine(k3.Kendelyd());

            if (k3 is Object)
                Console.WriteLine("Ja");
            else
                Console.WriteLine("Nej");

            //Hund f1 = k3 as Hund;
            Fugl f1 = (Fugl)k3;
            Console.WriteLine(f1.HåndTam);
            

            //List<Kæledyr> dyr = new List<Kæledyr>();
            //dyr.Add(new Hund() { Navn = "a", HundeRegisterId = "1" });
            //dyr.Add(new Hund() { Navn = "b", HundeRegisterId = "2" });
            //dyr.Add(new Fugl { Navn = "c", HåndTam = true });
            //dyr.Add(new Fugl { Navn = "d", HåndTam = false });
            //dyr.Add(new Hest { Navn = "e" });

            //foreach (Object item in dyr)
            //    Console.WriteLine(item.ToString());


        }
    }


    class Hest : Kæledyr {
        public override string ToString()
        {
            return $"Jeg er en hest der hedder {Navn} og siger {Kendelyd()}";
        }
    }
    internal class Kæledyr
    {
        public string Navn { get; set; }
        public virtual string Kendelyd() {
            return "?";
        }
    }

    internal class Fugl : Kæledyr
    {
        public bool HåndTam { get; set; }
        public override string Kendelyd()
        {
            return "Pip";
        }
        public override string ToString()
        {
            return $"Jeg er en fugl der hedder {Navn} og siger {Kendelyd()}";
        }
    }

    internal class Hund : Kæledyr
    {
        public string HundeRegisterId { get; set; }
        public override string Kendelyd()
        {
            return "Vov";
        }
        public override string ToString()
        {
            return $"Jeg er en hund der hedder {Navn} og siger {Kendelyd()}";
        }
    }
}
