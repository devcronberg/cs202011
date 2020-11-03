using System;

namespace Fejl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int tal = Sum(1, 1);
                Console.WriteLine(tal);
                tal = Sum(-1, 1);
            }
            catch (Exception ex)
            {
                // log
                Console.WriteLine(ex.ToString());
                //if(ex.InnerException!=null)
                //    Console.WriteLine(ex.InnerException.Message);
                //Console.WriteLine(ex.Message);

            }


        }


        public static int Sum(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                Exception e = new Exception("Forkerte argumenter");
                throw new ArgumentException("a er forkert");
            }
            return a + b;
        }

        private static int HentTalFraFil(string sti)
        {
            try
            {
                string talSomStreng = System.IO.File.ReadAllText(sti);
                int tal = Convert.ToInt32(talSomStreng);
                return tal;
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Kan ikke konvertere tal fra {sti}", ex);
            }
        }



        static void F1()
        {
            F2();
        }
        static void F2()
        {
            string a = null;
            a.ToUpper();
        }
    }
}
