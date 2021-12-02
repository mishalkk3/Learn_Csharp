using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateStringFiles
{
    class DateTimeProgram
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(1997, 11, 20);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour : "+now.Hour);
            Console.WriteLine("Minute : " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            /*
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yy-MM-dd"));
            */

            //Time Span
            var timespan = new TimeSpan(1,2,3);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;
            Console.WriteLine(duration);

            Console.WriteLine("Minutes : " + timespan.Minutes);
            Console.WriteLine("Total Minutes : " + timespan.TotalMinutes);

            //Add and subtract
            Console.WriteLine(timespan);
            Console.WriteLine(timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timespan.Subtract(TimeSpan.FromMinutes(10)));

            //Parse
            Console.Write(TimeSpan.Parse("01:02:03"));
            Console.WriteLine();
        }
    }
}
