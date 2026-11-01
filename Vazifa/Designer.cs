using System.Collections.Generic;

class Designer : Employee
{
    public string Stack { get; set; }

    public Designer(string name, int age, decimal maosh, string stack)
        : base(name, age, maosh)
    {
        Stack = stack;
    }

    public override decimal Procent()
    {
        return Maosh + 150m;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.Write($"Stack: {Stack}");
    }
}