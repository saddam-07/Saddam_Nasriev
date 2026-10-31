using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Maosh { get; set; }

    public Employee(string name, int age, decimal maosh)
    {
        Name = name;
        Age = age;
        Maosh = maosh;
    }

    public decimal Procent(decimal x)
    {
        return Maosh - (Maosh * (x / 100));
    }


}