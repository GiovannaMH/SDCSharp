using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Default constructor with no parameters
    public Student()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Constructor with name parameter
    public Student(string name)
    {
        Name = name;
        Age = 0; // Default age
    }

    // Constructor with name and age parameters
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        Student student2 = new Student("Joanne");
        Student student3 = new Student("Andrew", 25);

        student1.DisplayInfo(); // Output: Name: Unknown, Age: 0
        student2.DisplayInfo(); // Output: Name: Joanne, Age: 0
        student3.DisplayInfo(); // Output: Name: Andrew, Age: 25
    }
}
