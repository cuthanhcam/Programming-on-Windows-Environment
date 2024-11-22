using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_02
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "A", 20),
                new Student(2, "B", 15),
                new Student(3, "C", 21),
                new Student(4, "D", 18),
                new Student(5, "E", 19)
            };

            // a. In danh sach toan bo hoc sinh
            Console.WriteLine("Danh sach toan bo hoc sinh");
            students.ForEach(s => Console.WriteLine(s));

            // b. Tim va in ra danh sach cac hoc sinh co do tuoi tu 15 den 18
            Console.WriteLine("\nDanh sach cac hoc sinh co do tuoi tu 15 den 18");
            var b = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            b.ForEach(s => Console.WriteLine(s));

            // c. Tim va in ra hoc sinh co ten bat dau bang chu A
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu A");
            var c = students.Where(s => s.Name.StartsWith("A")).ToList();
            c.ForEach(s => Console.WriteLine(s));

            // d. Tinh tong so tuoi tat ca hoc sinh trong danh sach
            var d = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong so tuoi tat ca hoc sinh: {d}");

            // e. Tim va in ra hoc sinh co tuoi lon nhat
            Console.WriteLine("\nHoc sinh co tuoi lon nhat");
            var maxAge = students.Max(s => s.Age);
            var e = students.Where(s => s.Age == maxAge).ToList();
            e.ForEach(s => Console.WriteLine(s));

            // f. Sap xep danh sach hoc sinh theo tuoi tang dan va in ra danh sach sau khi sap xep
            Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan");
            var f = students.OrderBy(s => s.Age).ToList();
            f.ForEach(s => Console.WriteLine(s));

            Console.ReadLine();
        }
    }
}
