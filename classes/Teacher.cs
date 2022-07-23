using System;
using System.Collections.Generic;
using System.Text;

namespace TestSelf.classes
{
    class Teacher
    {
        public string name;
        public Dictionary<int, Student> sts;
        public Teacher(string name)
        {
            this.name = name;
        }
        public void addStudent(Student st)
        {
            sts.Add(sts.Count, st);
        }
        public void removeStudent(int num)
        {
            sts.Remove(num);
        }
    }
}
