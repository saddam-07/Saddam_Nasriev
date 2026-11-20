abstract class Vehicle : IStart
{
	public string Name { get; set; }
	public string TypeOfFuel { get; set; } = "Бензин";
	public int Distance { get; set; }

	public Vehicle(string name, int distance) {
		Name = name;
		Distance = distance;
	}

	public abstract int FuelCost();

	public void PrintInfo() 
	{
		Console.WriteLine($"{Name} на {Distance}км расходует {FuelCost()}л {TypeOfFuel}а");
	}

	public abstract void Drive();

}

interface IStart
{
	void Drive();
}
