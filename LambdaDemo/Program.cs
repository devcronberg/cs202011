using System;
using System.Linq;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 5, 1, 4, 1, 6, 7, 10 };
            //int findes1 = System.Array.FindIndex(array, x => x == 6);  // 4
            //Console.WriteLine(findes1);

            Test1();
            Action f1 = Test1;
            f1();
            //Action f2 = () => { Console.WriteLine("Test"); };
            Action f2 = () => Console.WriteLine("Test"); 
            f2();

            //Func<int, int, int> f3 = Plus;
            //Func<int, int, int> f3 = (int a, int b) => { return a + b; };
            Func<int, int, int> f3 = (a, b) => a + b; 
            Console.WriteLine(f3(5,5));

            //Func<int, bool> f4 = FindTal;
            //Func<int, bool> f4 = (int a) => {return a == 10;};
            Predicate<int> f4 = a => a == 10;

            Console.WriteLine(f4(10));

            int[] array = { 5, 10, 4, 1, 6, 7, 10 };
            var res = System.Array.FindAll(array, a => a == 10);
            Console.WriteLine(string.Join(" ", res));

            int[] array2 = { 10, 10, 10, 1, 6, 7, 10 };
            res = System.Array.FindAll(array2, a => a == 10);
            Console.WriteLine(string.Join(" ", res));

            // var t = array2.Where(w => w < 7);

            //Func<int, int, int> b = (int a, int b) => { return a + b };
            //Func<int, int, int> b = (a, b) => { return a + b };
            Func<int, int, int> b = (a, b) => a + b;




        }

        static void Test1() {
            Console.WriteLine("Test");
        }

        static int Plus(int a, int b) { 
            return a+b;
        }

        static bool FindTal(int a) {
            return a == 10;
        }
    }
}
