using System;
using System.Collections.Generic;
using System.Text;

namespace TestSelf.classes
{
    class Student
    {
        public string name;
        public int age;
        private Work job;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
