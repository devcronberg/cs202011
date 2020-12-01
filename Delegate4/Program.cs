using System;

namespace Delegate4
{
    delegate void Delegate1(string txt);
    delegate int Delegate2(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Test1("Hello World");
            //Delegate1 f = Test1;
            Action<string> f = Test1;

            f("Hello World");

            Action f2 = Test2;
            Action<int, double, string> f3 = Test3;

            Func<int, int, int> f4 = LægSammen;
            Console.WriteLine(LægSammen(5, 5));
            Console.WriteLine(f4(5, 5));

            Func<int> f5 = FindTilfældigTal;

            Func<int, bool> f6 = Match;
            Predicate<int> f7 = Match;

            int[] a = { 4, 1, 10, 8, 1, 10 };
            int nr = System.Array.FindIndex(a, Match);
            Console.WriteLine(nr);

            var res = System.Array.FindAll(a, Match);
            var res2 = System.Array.FindAll(a, x => x < 10);

            // Action
            // Func
            // Predicate


        }

        public static bool Match(int a)
        {
            if (a < 10)
                return true;
            else
                return false;
        }

        public static int FindTilfældigTal()
        {
            return new Random().Next(1, 7);
        }


        public static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static void Test1(string a)
        {
            Console.WriteLine("* " + a);
        }

        static void Test2()
        {
            Console.WriteLine("* ");
        }

        static void Test3(int a, double b, string c)
        {
            Console.WriteLine("* ");
        }

    }
}
