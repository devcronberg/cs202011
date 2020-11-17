using System;

namespace Poly1
{
    class Program
    {
        static void Main(string[] args)
        {

            Kæledyr k = new Kæledyr() { Navn = "a" };
            Console.WriteLine(k.Kendelyd());

            Hund h = new Hund() { Navn = "b", HundeRegisterId = "1" };
            Console.WriteLine(h.Kendelyd());


            Fugl f = new Fugl() { Navn = "c", HåndTam= true };
            Console.WriteLine(f.Kendelyd());

            Console.WriteLine(f.ToString());
            Console.WriteLine(h.ToString());
        }
    }

    internal class Kæledyr
    {
        public string Navn { get; set; }
        public virtual string Kendelyd()
        {
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
            return "Jeg er en fugl og hedder " + this.Navn;
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
            return "Jeg er en hund og hedder " + this.Navn + " og har id " + this.HundeRegisterId;
        }

    }
}
