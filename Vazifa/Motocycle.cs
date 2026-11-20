class Motocycle : Vehicle, IStart
{
    public Motocycle(string name, int distance) : base(name, distance) { }

    public override int FuelCost()
    {
        return (Distance * 4) / 100;
    }

    public override void Drive()
    {
        Console.WriteLine("Motocycle is starting...");
    }
}