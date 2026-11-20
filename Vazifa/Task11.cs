using System;
using System.Collections.Generic;

class Task11
{
    public static void Run()
    {
        List<Vehicle> cars = new List<Vehicle>();
        cars.Add(new Car("Toyota", 200));
        cars.Add(new Bus("Sprinter", 120));
        cars.Add(new Motocycle("CYber", 230));

        foreach(Vehicle car in cars)
        {
            car.Drive();
            car.PrintInfo();
            Console.WriteLine();
            
        }
    }
}