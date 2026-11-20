class Car : Vehicle, IStart
{
    public Car(string name, int distance) : base(name, distance)
    {

    }
    public override int FuelCost()
    {
        return (Distance * 8) / 100;
    }

    public override void Drive()
    {
        Console.WriteLine("Car is starting...");
    }
}