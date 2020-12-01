using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LinqDemo
{
    class Program
    {

        class MinFil {
            public string Name { get; set; }
            public long Length { get; set; }
        }
        static void Main(string[] args)
        {
            var mappe = new System.IO.DirectoryInfo(@"c:\git");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //var res = filer.Where(i => i.Length > 1000)
            //    .Select(i => new MinFil { Name = i.Name, Length = i.Length }).ToList();
            var res = filer.Where(i => i.Length > 1000).ToList();

            var fil = res.FirstOrDefault();

            //var res = filer.OrderBy(i=>i.Name).GroupBy(i => i.Extension);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var f in item)
            //    {
            //        Console.WriteLine("\t" + f.Name);
            //    }
            //}
            //var res = filer.Where(i => true).ToList();
            //Console.WriteLine(Guid.NewGuid().ToString());
            //int[] a = { 4, 45, 21, 4, 3, 1 };
            //var res1 = a.OrderBy(i => i).ToList();

            System.Diagnostics.Debugger.Break();
            ////var res1 = from fil in filer where 
            ////           fil.Length > 1000 orderby fil.Name select fil;
            ////Console.WriteLine(res1.Count());

            //var a = filer.Where(q => q.Length > 1000);
            //var b = a.OrderBy(i => i.Name).ToList();



            //int y = 10;


            //Console.WriteLine($"Har fundet {filer.Length} i {mappe.Name}");
            //var res1 = FindFilerStørreEndSorteretEfterNavn(filer, 1000);

            //var res2 = filer
            //    .Where(i => i.Length > 1000)
            //    .OrderBy(i => i.Name);


            ////Console.WriteLine(res2.Count());
            //int[] array = { 3, 3, 5, 3, 2, 3, 5, 2 };


        }

        static List<FileInfo> FindFilerStørreEndSorteretEfterNavn(FileInfo[] filer, long størrelse)
        {
            List<FileInfo> tmp = new List<FileInfo>();
            foreach (var item in filer)
            {
                if (item.Length > størrelse)
                {
                    tmp.Add(item);
                }
            }
            tmp.Sort(new SorterFiler());
            return tmp;
        }

        class SorterFiler : IComparer<FileInfo>
        {
            public int Compare(FileInfo x, FileInfo y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
    }
}
