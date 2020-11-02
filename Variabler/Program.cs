using System;
using System.Linq;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                //int a = 10;
                //var b = "10.56";



                //System.Int32 b = 10;

                //System.Int32 c = new System.Int32();
                //c = 10;

                //DateTime d = new DateTime(2020, 12, 24);

                //int q = 10;
                //{
                //    int a = 1;

                //}

                //{
                //    int a = 10;

                //}

                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine(i);
                //}

                double b = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
                Console.WriteLine(b);


                //int a = 10;

                //Console.WriteLine(System.Int32.MaxValue);


                //Console.WriteLine(DateTime.DaysInMonth(2020,2));

                //int y = 10;
                //y = y + 10;
                //y += 10;

                //y = y + 1;


                //y++;
                //if (y == 20) { 

                //}

                //checked
                //{
                //    byte r = 255;
                //    Console.WriteLine(r);
                //    r++;
                //    Console.WriteLine(r);
                //}

                double v = 239842034.3445;
                Console.WriteLine(v);
                Console.WriteLine(v.ToString());
                Console.WriteLine(v.ToString("F2"));
                bool w = true;

                DateTime n = DateTime.Now;
                DateTime y = new DateTime(2020, 12, 24, 15, 10, 15);
                Console.WriteLine(y);

                TimeSpan t = y - n;
                Console.WriteLine(t.TotalSeconds);

                //y = y.AddDays(1);
                //Console.WriteLine(y.ToString("dd-MM-yy"));

                TimeSpan t1 = new TimeSpan(15, 10, 15);
                TimeSpan t2 = new TimeSpan(17, 0, 0);
                TimeSpan t3 = t2 - t1;
                Console.WriteLine(t3.TotalMinutes);


                //DateTime p = DateTime.Now;
                //Console.WriteLine(p);

            }

            {
                byte a = 100;
                int b = 100;

                a = System.Convert.ToByte(b);
                // a = (byte)b;
                Console.WriteLine(a);

                double r = Convert.ToDouble("123543.445");
                r++;
                Console.WriteLine(r.ToString("N2"));
            }



        }
    }

    
}
