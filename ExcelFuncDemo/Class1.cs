using ExcelDna.Integration;
using ExcelDna.IntelliSense;
using System;
using System.Linq;
using System.Runtime.InteropServices;

public static class MyFunctions
{
    [ExcelFunction(Description = "Find sidste mandag")]
    public static DateTime SidsteMandag()
    {
        DateTime d = DateTime.Today;
        while (d.DayOfWeek != DayOfWeek.Monday)
        {
            d = d.AddDays(-1);
        }
        return d;
    }

    [ExcelFunction(Description = "Finder sum af celler")]
    public static double MinSum([ExcelArgument(Name = "Celler", Description = "Celler til sum")] double[] celler)
    {
        try
        {
            return celler.Sum();
        }
        catch (Exception)
        {
            return 0;
        }
    }

    [ComVisible(false)]
    internal class ExcelAddin : IExcelAddIn
    {
        public void AutoOpen()
        {
            IntelliSenseServer.Install();
        }
        public void AutoClose()
        {
            IntelliSenseServer.Uninstall();
        }
    }
}