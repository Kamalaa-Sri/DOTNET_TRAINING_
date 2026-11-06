using System;
using System.Collections.Generic;
using System.Linq;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public int Marks { get; set; }
}

class LinqExample
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Arun", Department = "CSE", Marks = 85 },
            new Student { Id = 2, Name = "Priya", Department = "IT", Marks = 90 },
            new Student { Id = 3, Name = "Kumar", Department = "CSE", Marks = 45 },
            new Student { Id = 4, Name = "Divya", Department = "ECE", Marks = 75 },
            new Student { Id = 5, Name = "Sam", Department = "ECE", Marks = 55 },
            new Student { Id = 6, Name = "Ravi", Department = "IT", Marks = 35 }
        };
        Console.WriteLine("Students with Marks below 30:");
        var result = students.Where(s => s.Marks < 30);
        foreach (var student in result)
        {
            Console.WriteLine(student.Name+" - "+student.Marks);
        }
        Console.WriteLine("\n Students from CSE Department:");
        var cseStudents = students.GroupBy(s => s.Department == "CSE");
        foreach (var group in cseStudents)
        {
            if (group.Key) 
            {
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name + " - " + student.Department);
                }
            }
        }
        Console.WriteLine("\n Students in CSE Department with Marks above 90:");
        var cseAbove90 = students.Where(s => s.Marks > 90).GroupBy(s => s.Department);
        foreach (var group in cseAbove90)
        {
            foreach (var student in group)
            {
                Console.WriteLine(student.Name + " - " + student.Marks);
            }
        }
        Console.WriteLine("\n Student with MAX Marks:");
        var maxMark = students.Max(s => s.Marks);
        foreach (var student in students.Where(s => s.Marks == maxMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        Console.WriteLine("MAX mark in CSE Department:");
        var maxCSEMark = students.Where(s => s.Department == "CSE").Max(s => s.Marks);
        foreach (var student in students.Where(s => s.Department == "CSE" && s.Marks == maxCSEMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        Console.WriteLine("MAX mark in ECE Department:");
        var maxECEMark = students.Where(s => s.Department == "ECE").Max(s => s.Marks);
        foreach (var student in students.Where(s => s.Department == "ECE" && s.Marks == maxECEMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        Console.WriteLine("MAX mark in IT Department:");
        var maxITMark = students.Where(s => s.Department == "IT").Max(s => s.Marks);
        foreach (var student in students.Where(s => s.Department == "IT" && s.Marks == maxITMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        Console.WriteLine("\n MIN mark in CSE Department:");
        var minCSEMark = students.Where(s => s.Department == "CSE").Min(s => s.Marks);
        foreach (var student in students.Where(s => s.Department == "CSE" && s.Marks == minCSEMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        Console.WriteLine("\n MIN mark in ECE Department:");
        var minECEMark = students.Where(s => s.Department == "ECE").Min(s => s.Marks);
        foreach (var student in students.Where(s => s.Department == "ECE" && s.Marks == minECEMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        Console.WriteLine("\n MIN mark in IT Department:");
        var minITMark = students.Where(s => s.Department == "IT").Min(s => s.Marks);
        foreach (var student in students.Where(s => s.Department == "IT" && s.Marks == minITMark))
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
    }
}