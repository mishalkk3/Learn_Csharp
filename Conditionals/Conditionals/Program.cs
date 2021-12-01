using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //if - else
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's night");
            }

            // Conditional op

            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            //Switch case

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine();
                    break;
                case Season.Summer:
                    Console.WriteLine("Go to Beach");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Beautiful Season");
                    break;
                case Season.Winter:
                    Console.WriteLine("Be Home");
                    break ;
               default:
                    Console.WriteLine("What season is it?");
                    break;
            }
        }
    }
}
