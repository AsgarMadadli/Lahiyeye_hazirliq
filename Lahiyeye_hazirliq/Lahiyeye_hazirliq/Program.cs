using System;
using System.Collections.Generic;

public class Teacher
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Subject { get; set; }
    public List<Student>Teacher { get; set; }

    public Teacher(List<Student> teacher)
    {
        Teacher = teacher;
    }

    public Teacher(string name, int age, string subject)
    {
        Name = name;
        Age = age;
        Subject = subject;
        Teacher = new List<Student>();
    }

    public override string ToString()
    {
        return $"Teacher: {Name}, Age: {Age}, Subject: {Subject}";
    }
}