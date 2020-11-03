using System;
//using System.Collections;
using System.Collections.Generic;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList lst = new ArrayList();
            //lst.Add("Mikkel");
            //lst.Add("Mathias");

            //lst.Add("Lene");
            //lst.Insert(1, "Michell");

            //foreach (var item in lst)
            //    Console.WriteLine(item);
            //lst.RemoveAt(1);

            //foreach (var item in lst)
            //    Console.WriteLine(item);

            //lst.Add(1);

            //foreach (var item in lst)
            //    Console.WriteLine(item);

            //string navn = lst[0] as string;
            //Console.WriteLine(navn);

            List<string> lst = new List<string>();
            lst.Add("Mikkel");
            lst.Add("Mathias");
            lst.Add("Lene");
            foreach (var item in lst)
                Console.WriteLine(item);

            string navn = lst[0];
            Console.WriteLine(navn);

            // lkhjf lkjs dhf
            // lkjgh lkdjg 
            // lkjsd gflksdj 
            // lkjsd gflksdj 


            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            int t = q.Dequeue();

            Stack<string> s = new Stack<string>();
            s.Push("S8");
            s.Push("R2");
            s.Push("RK");
            string kort = s.Pop();

            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("a", 100);
            d.Add("b", 200);
            int v = d["b"];
            
        }
    }
}
