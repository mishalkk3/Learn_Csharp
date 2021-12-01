using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            //For loop
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            //For each loop
            string name = "John Smith";

            foreach(char s in name)
            {
                Console.WriteLine(s);
            }

            //While loop
            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("echo "+input);
            }

            //Random Class
            var random = new Random();
            char[] buffer = new char[10];
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a'+random.Next(0,26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
