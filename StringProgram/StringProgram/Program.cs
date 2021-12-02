using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var fullName = "            Mosh Hamedani           ";
            fullName = fullName.Trim();
            Console.WriteLine("Trim: '{0}'",fullName);
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.ToUpper());

            Console.WriteLine("Using Indexing");
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);   

            var names = fullName.Split(' ');
            Console.WriteLine("Using split");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            fullName = fullName.Replace("Mosh", "Mishal");
            Console.WriteLine(fullName);
            

            //Validation
            if(String.IsNullOrWhiteSpace("   "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

            Console.WriteLine("--------------------------------------------------------------");

            var sentence = "This is a really really really really really really really really really really long text";
            Console.WriteLine(StringUtility.SummerizeText(sentence));

            // String Builder
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            builder.Replace('-', '+');
            builder.Remove(0,10);
            builder.Insert(0,new string('-',10));
            Console.WriteLine(builder);
        }
    }
}
