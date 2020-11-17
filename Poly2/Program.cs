using System;

namespace Poly2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            Console.WriteLine(h.Kendelyd());

            Fugl f = new Fugl();
            Console.WriteLine(f.Kendelyd());

            Kæledyr k = new Kæledyr();

        }
    }

    public abstract class Kæledyr
    {
        public string Navn { get; set; }
        public abstract string Kendelyd();



    }

    public class Fugl : Kæledyr
    {
        public bool HåndTam { get; set; }

        public override string Kendelyd()
        {
            return "Pip";
        }

    }

    public class Hund : Kæledyr
    {
        public string HundeRegisterId { get; set; }
        public override string Kendelyd()
        {
            return "Vov";
        }
    }
}
