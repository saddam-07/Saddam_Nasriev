using System.Collections.Generic;

class Designer : Employee
{
    public string Stack { get; set; }

    public Designer(string name, int age, decimal maosh, string stack)
        : base(name, age, maosh)
    {
        Stack = stack;
    }
}