using System;
using System.Net;
using Teknologisk.TerningApp.Kerne;

namespace TerningDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ITilfældighedsGenerator r = new Saturn();
            Terning t = new Terning(r);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(t.Skriv());
                t.Ryst();

            }

            //ITilfældighedsGenerator r = new TilfældighedsGeneratorMock();
            //Console.WriteLine(r.Next(1,7));
        }
    }

    public class Saturn : ITilfældighedsGenerator
    {
        public int Next(int min, int max)
        {
            using (WebClient w = new WebClient())
            {
                string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                return Convert.ToInt32(s);
            }
        }
    }


}
