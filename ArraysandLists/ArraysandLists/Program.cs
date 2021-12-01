using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //single D array
            Console.WriteLine("Start of Array");
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            Console.WriteLine(numbers.Length);

            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            Array.Sort(numbers);
            Console.WriteLine("After Sort");
            foreach (int i in numbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Array.Reverse(numbers);
            Console.WriteLine("After Reverse");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("After clear");
            foreach (int n in numbers)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine();


            int[] another = new int[3];
            Array.Copy(numbers, 3, another, 0, 3);
            Console.WriteLine("After Copy");
            foreach(int n in another)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //Lists
            Console.WriteLine("Start of lists");
            var nums= new List<int>() {1,2,3,4};
            nums.Add(1);
            nums.AddRange(new int[3] {5,6,7});
            foreach(var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            var result = nums.IndexOf(1);
            Console.WriteLine("Result of IndexOf");
            Console.WriteLine(result);

            result = nums.LastIndexOf(1);
            Console.WriteLine("Result of LastIndexOf");
            Console.WriteLine(result);

            Console.WriteLine("Count: "+nums.Count);

            nums.Remove(1);
            Console.WriteLine("After remove 1");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}
