using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Math;

namespace Test1
{
    public enum ShippingMethod
    {
        Regular=1,
        Registered=2,
        Express=3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.firstName = "John";
            john.lastName = "Harris";
            john.introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(12, 6);
            Console.WriteLine(result);

            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[3] { "Jack", "John", "Mary" };
            string name = string.Format("{0} {1}", names[0], names[1]);
            string list = string.Join(",", numbers);
            Console.WriteLine(name);
            Console.WriteLine(list);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.WriteLine((ShippingMethod)method);
        }
    }
}
