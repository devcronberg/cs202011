using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Char a = '*';
            //Console.WriteLine(a);
            //Console.WriteLine(Convert.ToInt32(a));

            //int b = 42;
            //Console.WriteLine(Convert.ToChar(b));

            //string a = "Mikkel";
            //Console.WriteLine(a);

            //Console.WriteLine(a.Substring(0,2));

            //Console.WriteLine(a + " " + "Cronberg");

            //a = a.ToUpper();
            //Console.WriteLine(a);


            //if (a == "Mikkel")
            //{

            //}

            ////string fil = "c:\temp\test.txt";
            ////Console.WriteLine(fil);

            //Console.WriteLine("mikkel\r\nmikkel\r\nmikkel");

            //string navn = "Mathias";
            //int alder = 15;
            ////string res = "Hej - mit navn er " + navn + " og jeg er " + alder + " år";
            //string res = $"Hej - mit navn er {navn} og jeg er {alder:F2} år";
            //Console.WriteLine(res);

            //int q = 10;

            //string w = "mikkel";
            //Console.WriteLine(w.ToUpper());
            //w = null;
            //if (w != null)
            //    Console.WriteLine(w.ToUpper());

            //Console.WriteLine(w?.ToUpper());


            // Stopur
            //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            //s.Start();
            //string a = "";
            //for (int i = 0; i < 500_000; i++)
            //{
            //    a += "*";
            //}
            //s.Stop();
            //Console.WriteLine($"ms = {s.ElapsedMilliseconds}");


            // Stopur
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            s.Start();
            for (int i = 0; i < 5_000_000; i++)
            {
                sb.Append("*");
            }
            s.Stop();
            Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            string qq = null;
            Console.WriteLine(qq);

            
        }
    }
}
