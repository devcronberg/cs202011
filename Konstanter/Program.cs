using System;

namespace Konstanter
{
    class Program
    {
        static void Main(string[] args)
        {

            string person1Navn = "Mathias";
            int person1Alder = 12;
            Køn person1Køn = Køn.Mand;

            Console.WriteLine(Convert.ToInt32(person1Køn));

            string person2Navn = "Lene";
            int person2Alder = 53;
            Køn person2Køn = Køn.Kvinde;
            Console.WriteLine(Convert.ToInt32(person2Køn));

            if (person2Køn == Køn.Kvinde) { } else { }

            int værdi = 2;
            KortKulør kulør = KortKulør.Ruder;

            Console.BackgroundColor = ConsoleColor.DarkGreen;


            DayOfWeek d = DayOfWeek.Monday;
            if(d== DayOfWeek.Monday) { }

            switch (d)
            {
                case DayOfWeek.Sunday:

                    break;
                case DayOfWeek.Monday:

                    break;
                case DayOfWeek.Tuesday:

                    break;
                case DayOfWeek.Wednesday:

                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }

            switch (person2Køn)
            {
                case Køn.Mand:


                    break;
                case Køn.Kvinde:
                    break;
                default:
                    break;
            }

        }
    }

}
