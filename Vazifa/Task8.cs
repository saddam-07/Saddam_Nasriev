using System;
using System.Collections.Generic;

class Task8
{
    public static void Run()
    {
        List<string> firstName = new List<string>();
        firstName.Add("Solizoda");
        firstName.Add("Burhonov");

        List<string> lastName = new List<string>();
        lastName.Add("Karim");
        lastName.Add("Bakhtiyor");

        List<int> age = new List<int>();
        age.Add(17);
        age.Add(19);

        for(int i = 0; i<firstName.Count(); i++)
        {
            Student student = new Student(
                firstName[i],
                lastName[i],
                age[i],
                new List<double> { 100, 98, 67, 87 }
            );

            student.PrintInfo();
        }

    }
}