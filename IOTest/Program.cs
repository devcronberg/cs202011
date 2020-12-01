using System;

namespace IOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var f = new System.IO.FileInfo(@"c:\temp\data.txt");
            //Console.WriteLine(f.Name);
            //Console.WriteLine(f.Length);
            //Console.WriteLine(f.DirectoryName);

            //var m = new System.IO.DirectoryInfo(@"c:\temp");
            //var filer = m.GetFiles("*.*");

            using (Hund h = new Hund())
            {
            }





        }

        class Hund : IDisposable
        {
            public Hund()
            {
                Console.WriteLine("Jeg fødes");
            }

            public void Dispose()
            {
                Console.WriteLine("Jeg dør");
            }
        }
    }
}
