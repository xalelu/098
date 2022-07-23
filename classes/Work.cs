using System;
using System.Collections.Generic;
using System.Text;

namespace TestSelf.classes
{
    class Work
    {
        public Work()
        {
            
        }
        public void addWork(string msg)
        {
            Console.WriteLine("i wanna to add" + msg);
        }
        public void removeWork(string msg)
        {
            Console.WriteLine(System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            Console.WriteLine("remove some job " + msg);
        }
        public void addWork()
        {
            Console.WriteLine("i wanna to add work");
        }
        public void removeWork()
        {
            Console.WriteLine("i wanna to removework");
        }
    }
}
