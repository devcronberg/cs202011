using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {

            System.IO.File.ReadAllText("", System.Text.Encoding.UTF8);

            using (WebClient w = new WebClient())
            {
                string s = w.DownloadString("https://dawa.aws.dk/kommuner/");
            }
        }
    }
}
