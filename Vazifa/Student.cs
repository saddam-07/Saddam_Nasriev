using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<double> Grades { get; set; }

    public Student(string firstName, string lastName, int age, List<double> grades)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Grades = grades;
    }

    public double BtwBal()
    {
        if(Grades.Count == 0)
        {
            return 0;
        }
        double summa = 0;
        foreach(double bals in Grades)
        {
            summa += bals;
        }

        return summa / Grades.Count();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Firstname: {FirstName}");
        Console.WriteLine($"Lastname: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Bal: {BtwBal()}");
        Console.WriteLine();
    }
}