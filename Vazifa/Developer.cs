using System.Collections.Generic;

class Developer : Employee
{
    public string Degree { get; set; }

    public Developer(string name, int age, decimal maosh, string degree) 
        : base(name, age, maosh)
    {
        Degree = degree;
    }

    public override decimal Procent()
    {
        return Maosh + 500m;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.Write($"Degree: {Degree}");
    }
}