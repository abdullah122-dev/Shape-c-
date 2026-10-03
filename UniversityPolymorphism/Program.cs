using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Person: {Name}");
    }
}

class Student : Person
{
    public int StudentId { get; set; }

    public Student(string name, int studentId)
        : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, ID: {StudentId}");
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string name, double salary)
        : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
    }
}

class Teacher : Person
{
    public string CourseName { get; set; }

    public Teacher(string name, string courseName)
        : base(name)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Course: {CourseName}");
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        people.Add(new Student("Ahmed", 101));
        people.Add(new Employee("Mohammed", 3000));
        people.Add(new Teacher("Ali", "C# Programming"));

        foreach (Person person in people)
        {
            Console.WriteLine(
                $"Runtime Type: {person.GetType().Name}"
            );

            person.DisplayInfo();

            Console.WriteLine();
        }
    }
}
