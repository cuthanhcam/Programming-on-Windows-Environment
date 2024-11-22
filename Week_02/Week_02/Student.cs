using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
            Id = 0;
            Name = "Null";
            Age = 0;
        }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Student(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Age = student.Age;
        }

        public override string ToString()
        {
            return $"Id is: {Id}, Name is: {Name}, Age is: {Age}";
        }
    }
}
