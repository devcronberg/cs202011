using System;

namespace Hændelser
{
    class Program
    {
        static void Main(string[] args)
        {

            //Terning t = new Terning();
            //t.ErSekser += (antal, tid) => Console.WriteLine("* = " + antal + " " + tid.ToShortTimeString());
            ////t.ErSekser += Console.Beep;
            //for (int i = 0; i < 10; i++)
            //{
            //    t.Ryst();
            //    Console.WriteLine(t.Værdi);
            //}

            //System.Timers.Timer t = new System.Timers.Timer();
            //t.Interval = 500;
            //t.Enabled = true;
            //t.Elapsed += (s, e) => Console.WriteLine("Tick " +e.SignalTime);

            System.IO.FileSystemWatcher fsw = 
                new System.IO.FileSystemWatcher(@"c:\temp");
            fsw.EnableRaisingEvents = true;
            fsw.Created += (s, e) => Console.WriteLine("Created " + e.FullPath);
            fsw.Deleted += (s, e) => Console.WriteLine("Deleted " + e.FullPath);



            Console.ReadLine();

        }
    }

    class Terning {

        public event Action<int, DateTime> ErSekser;
        private int antalSeksere = 0;
        public int Værdi { get; set; }

        public void Ryst() {
            this.Værdi = new Random().Next(1, 7);
            if (this.Værdi == 6)
            {
                antalSeksere++;
                if (ErSekser != null)
                    ErSekser(antalSeksere, DateTime.Now);
            }
        }
    }
}
