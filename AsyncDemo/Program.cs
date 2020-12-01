using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MinTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new";
            Console.WriteLine("Start program");
            using (HttpClient w = new HttpClient())
            {
                var s = System.Diagnostics.Stopwatch.StartNew();
                Console.WriteLine("Finder numre fra random.org");
                Task<string> t1 = w.GetStringAsync(url);
                Task<string> t2 = w.GetStringAsync(url);
                Task<string> t3 = w.GetStringAsync(url);
                var r = await Task.WhenAll(t1, t2, t3);
                s.Stop();
                Console.WriteLine("Tid = " + s.ElapsedMilliseconds);
                int sum = Convert.ToInt32(r[0]) + Convert.ToInt32(r[1]) + Convert.ToInt32(r[2]);
                Console.WriteLine("Sum " + sum);

            }
            Console.WriteLine("Slut program");
        }
    }
}