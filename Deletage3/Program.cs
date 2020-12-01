using System;

namespace Deletage3
{

    delegate void DeletageStringVoid(string txt);
    delegate int DeletageStringIntInt(string txt, int a);


    class Program
    {
        static void Main(string[] args)
        {
            Test("Hello world");
            DeletageStringVoid a = new DeletageStringVoid(Test);
            a.Invoke("Hello world");
            Test2(a);

        }

        public static void Test(string a) {
            Console.WriteLine("* " + a);
        }

        public static void Test2(DeletageStringVoid f) {
            f.Invoke("Hello World");
        }
    }
}
