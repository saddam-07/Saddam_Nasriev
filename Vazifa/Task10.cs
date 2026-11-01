using System.Collections.Generic;

class Task10
{
    public static void Run()
    {

        List<Employee> employees = new List<Employee>();
        employees.Add(new Manager(
            "Aziz",
            25,
            2500m,
            3
        ));
        employees.Add(new Designer(
            "Ali",
            23,
            3000,
            "UX/UI"
        ));
        employees.Add(new Developer(
            "Burhon",
            30,
            5400,
            "Middle"
        ));

        foreach(Employee emp in employees)
        {
            emp.PrintInfo();
            Console.WriteLine();
        }
    }
}