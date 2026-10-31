using System.Collections.Generic;

class Task10
{
    public static void Run()
    {
        Manager manager = new Manager(
            "Aziz",
            25,
            2500m,
            3
        );

        Console.WriteLine($"Name: {manager.Name}, Age: {manager.Age}, Amount: {manager.Procent(5)}, Experience: {manager.TimeOfWork}");

        Designer designer = new Designer(
            "Ali",
            23,
            3000,
            "UX/UI"
        );
        Console.WriteLine($"Name: {designer.Name}, Age: {designer.Age}, Amount: {designer.Procent(7)}, Stack: {designer.Stack}");

        Developer developer = new Developer(
            "Burhon",
            30,
            5400,
            "Middle"
         );

        Console.WriteLine($"Name: {developer.Name}, Age: {developer.Age}, Amount: {developer.Procent(8)}, Degree: {developer.Degree}");

    }
}