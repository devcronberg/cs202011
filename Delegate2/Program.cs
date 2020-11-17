using System;

namespace Delegate2
{

    public delegate void DelegateVoid();
    public delegate void DelegateStringVoid(string a);
    public delegate bool DelegateStringIntBool(string a, int b);
    public delegate int DelegateIntIntInt(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            // Direkte kald
            Test1();

            // Inddirekte 
            DelegateVoid d1 = new DelegateVoid(Test1);
            d1.Invoke();
            Kør(d1);

            DelegateVoid d2 = HentDelegate();
            d2.Invoke();


            //DelegateIntIntInt d3 = new DelegateIntIntInt(LægSammen);
            DelegateIntIntInt d3 = LægSammen;
            // Direkte
            Console.WriteLine(LægSammen(1,1));
            // Inddirekte
            //Console.WriteLine(d3.Invoke(1, 1));
            Console.WriteLine(d3(1, 1));


            DelegateIntIntInt minRegner = FindTilfældigRegneArt();
            Console.WriteLine(minRegner.Invoke(5,5));



        }

        static void Kør(DelegateVoid func) {
            // kljdfhgklsdjgf
            // æjdhafgkldjhfgdkls
            func.Invoke();
        }

        static DelegateVoid HentDelegate() { 
            return new DelegateVoid(Test1); 
        }

        static DelegateIntIntInt FindTilfældigRegneArt() {
            if (DateTime.Now.Millisecond % 2 == 0) {
                return new DelegateIntIntInt(LægSammen);
            } else {
                return new DelegateIntIntInt(TrækFra);
            }
        
        }
        static void Test1()
        {
            Console.WriteLine("I Test1");
        }

        static int LægSammen(int a, int b) {

            return a + b;

        }

        static int TrækFra(int a, int b)
        {
            return a - b;
        }

    }
}
