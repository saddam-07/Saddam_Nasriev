class Bus : Vehicle, IStart
{
    public Bus(string name, int distance) : base(name, distance) { }

    public override int FuelCost()
    {
        return (Distance * 28) / 100;
    }

    public override void Drive()
    {
        Console.WriteLine("Bus is starting...");
    }
}