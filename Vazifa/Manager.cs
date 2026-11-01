using System.Collections.Generic;

class Manager : Employee
{
    public int TimeOfWork { get; set; }

    public Manager(string name, int age, decimal maosh, int timeofwork)
        : base(name, age, maosh)
    {
        TimeOfWork = timeofwork;
    }
    
    public override decimal Procent()
    {
        return Maosh + (TimeOfWork * 50);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.Write($"Experience: {TimeOfWork}");
    }
    
}