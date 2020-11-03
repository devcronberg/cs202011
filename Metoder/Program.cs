using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
          

            MinReturVærdi a = Sum(5, 5);
            Console.WriteLine(a.Sum);
            Console.WriteLine(a.Gns);

            var b = Sum2(5, 5);
            Console.WriteLine(b.Sum);
            Console.WriteLine(b.Gns);

        }

        static void Test()
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                return;

            Console.WriteLine("*");
        }

        static void Test2(int a, int b, bool c)
        {
            int rre = a + b;
            Console.WriteLine(rre);
        }

        static int Test3()
        {
            return 0;
        }

        static int Test4(int a)
        {

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                return a;


            return a * 2;

        }

        static MinReturVærdi Sum(double a, double b)
        {
            double gns = (a + b) / 2;
            MinReturVærdi r = new MinReturVærdi();
            r.Sum = a + b;
            r.Gns = gns;
            return r;
        }

        static (double Sum, double Gns) Sum2(double a, double b)
        {
            double gns = (a + b) / 2;
            return (a + b, gns);
        }


    }

    class MinReturVærdi
    {
        public double Sum;
        public double Gns;
    }

    class Person
    {

        public void Test1()
        {
            Console.WriteLine("I Test1");
        }

        public static void Test2()
        {
            Console.WriteLine("I Test2");
        }

    }
}
