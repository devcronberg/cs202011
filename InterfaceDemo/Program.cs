using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Bil b = new Bil();
            b.Skriv();

            Hund h = new Hund();
            h.Skriv();
            
            IUdskriv x = new Hund();

            List<IUdskriv> lst = new List<IUdskriv>();
            lst.Add(new Hund());
            lst.Add(new Bil());
            lst.Add(new UBåd());
            foreach (IUdskriv item in lst)
                item.Skriv();


            List<Hest> heste = new List<Hest>();
            heste.Add(new Hest { Navn = "c", AntalBen = 4 });
            heste.Add(new Hest { Navn = "a", AntalBen = 3 });
            heste.Add(new Hest { Navn = "b", AntalBen = 5 });

            heste.Sort(new SortHestNavn());
            
            // IComparable<Hest> d = (IComparable<Hest>)heste[0];
            

        }
    }

    class SortHestAntalBen : IComparer<Hest>
    {
        public int Compare([AllowNull] Hest x, [AllowNull] Hest y)
        {
            throw new NotImplementedException();
        }
    }

    class SortHestNavn : IComparer<Hest>
    {
        public int Compare([AllowNull] Hest x, [AllowNull] Hest y)
        {
            throw new NotImplementedException();
        }
    }

    interface A { }
    interface B { }
    interface C : A, B { }

    class Hest : IComparable<Hest>
    {
        public int AntalBen { get; set; }
        public string Navn { get; set; }

        public int CompareTo([AllowNull] Hest other)
        {
            //if(this.AntalBen < other.AntalBen)
            //    return 1;
            //if (this.AntalBen > other.AntalBen)
            //    return -1;
            //return 0;

            return string.Compare(this.Navn, other.Navn);

        }
    }


    interface IUdskriv {
        void Skriv();
    }

    interface IGem {
            void Gem(int id);
            bool Findes(int id);
    }

    class UBåd : IUdskriv
    {
        public void Skriv()
        {
            Console.WriteLine("UBåd");
        }
    }

    class Dyr { }

    class Hund : Dyr, IUdskriv, IGem {

        public void Spis() { }
        public void Skriv() {
            Console.WriteLine("Hund");
        }

        public void Hent()
        {
            
        }

        public void Gem(int id)
        {
           
        }

        public bool Findes(int id)
        {
            return true;
        }
    }

    class Bil : IUdskriv {
        public void Skriv()
        {
            Console.WriteLine("Bil");
        }
    }
    

    //abstract class A {
    //    public abstract void Test();
    //}

    //class B : A {
    //    public override void Test()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    
}
