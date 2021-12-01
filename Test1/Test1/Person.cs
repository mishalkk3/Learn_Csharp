using System;

namespace Test1
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("My name is "+firstName+" "+lastName);
        }
    }
}
