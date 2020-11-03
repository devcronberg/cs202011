using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = new string[5];
            a[0] = "a";
            a[3] = "c";
            Console.WriteLine(a[3]);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            int[] b = { 4, 2, 4, 10, 32, 1, 2 };
            //foreach (var item in b)
            //    Console.WriteLine(item);
            //System.Array.Sort(b);
            //Console.WriteLine();
            //foreach (var item in b)
            //    Console.WriteLine(item);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            Console.WriteLine();
            foreach (var item in b)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine(MindsteTal(b));
            Console.WriteLine();
            foreach (var item in b)
                Console.WriteLine(item);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(string.Join(' ',b));

        }

        //static int MindsteTal(int[] array) {

        //    int m = int.MaxValue;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < m)
        //            m = array[i];
        //    }
        //    return m;
        //}

        static int MindsteTal(int[] array)
        {
            int[] nyt = array.Clone() as int[];
            System.Array.Sort(nyt);
            return nyt[0];
        }
    }
}
