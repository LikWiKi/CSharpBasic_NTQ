using System;
using System.Collections.ObjectModel;

namespace DateTimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Display the current time zone name.  
            Console.WriteLine("Local time zone Name : {0}\n", TimeZoneInfo.Local.DisplayName);
            //apply base UTC offset  
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            Console.WriteLine("The {0} time zone is {1}:{2} {3} than Coordinated Universal Time.",
            localZone.StandardName,
            Math.Abs(localZone.BaseUtcOffset.Hours),
            Math.Abs(localZone.BaseUtcOffset.Minutes),
            (localZone.BaseUtcOffset >= TimeSpan.Zero) ? "later" : "earlier");

            Console.ReadLine(); 
        }
    }
}
