using System;
using System.Collections.Generic;

namespace KlasserDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning[] bæger = new Terning[5];
            bæger[0] = new Terning();


            Terning t1;
            t1 = new Terning();

            

            for (int i = 0; i < 10; i++)
            {
                t1.Skriv();
                Console.WriteLine("Antal: "  + t1.AntalSeksere());
                t1.Ryst();

            }            




        }
    }



}
