using System;
using TestSelf.classes;

namespace TestSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! ok, that's right?");
            Student one = new Student("chenghsun lu", 45);
            Console.WriteLine(one.name);
        }
    }
}
