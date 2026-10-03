using System;

class Person
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
    }
}

class Student : Person
{
    public int StudentId { get; set; }
    public double GPA { get; set; }

    public Student(string name, string email, int studentId, double gpa)
        : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
    }
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string email, int employeeId, double salary)
        : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;
    }
}

class Teacher : Employee
{
    public string CourseName { get; set; }

    public Teacher(string name, string email, int employeeId,
                   double salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;
    }

    public void Teach()
    {
        Console.WriteLine($"Teacher is teaching {CourseName}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student(
            "Ahmed",
            "ahmed@gmail.com",
            101,
            3.5
        );

        Teacher teacher = new Teacher(
            "Ali",
            "ali@gmail.com",
            501,
            2500,
            "Programming"
        );

        Console.WriteLine("Student:");
        student.DisplayBasicInfo();

        Console.WriteLine();

        Console.WriteLine("Teacher:");
        teacher.DisplayBasicInfo();
        teacher.Teach();
    }
}
