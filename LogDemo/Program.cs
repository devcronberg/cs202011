using System;
using System.Reflection.Metadata;

namespace LogDemo
{
    class Program
    {

        private static  NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            log.Debug("Start app");

            try
            {
                int a = 10;
                int b = 20;
                int sum = Sum(a, b);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                
            }

            log.Debug("Slut app");
        }

        private static int Sum(int a, int b)
        {
            log.Debug("I sum med " + a + " " + b);
            int sum = a + b;
            string r = null;
            r.ToLower();

            log.Debug("Ude af sum");
            return sum;
        }
    }
}
