using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lst = new List<int> {5,1,7,1,8,3 ,9};
            //var res = lst.Where(Min);
            var res = lst.Where(i => i < 5);


            Maskine m = new Maskine();
            //m.LogDelegate += F;
            //m.LogDelegate += C;
            //m.LogDelegate += R;
            //m.LogDelegate += (string txt) => { Console.WriteLine(txt); };
            m.LogDelegate += txt => Console.WriteLine(txt);
            m.Start();
            m.Slut();
        }

        static bool Min(int tal) {
            if (tal < 5)
                return true;
            else
                return false;
        }

        static void C(string t) {
            Console.WriteLine(t);
        }

        static void R(string t, int a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(t);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void F(string t) {
             System.IO.File.AppendAllText(@"c:\temp\log.txt", t);
        }
    }












    class Maskine
    {

        public Action<string> LogDelegate;

        public Maskine()
        {

        }

        public void Start()
        {
            Log("Starter");
        }

        public void Slut()
        {
            Log("Slut");
        }

        private void Log(string txt)
        {
            if (LogDelegate != null)
            {
                LogDelegate.Invoke(DateTime.Now.ToShortTimeString() + " " + txt);
            }
            

            
        }
    }
}
