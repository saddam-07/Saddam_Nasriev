class Product
{
    public string Name { get; private set; }
    public decimal Price { get; set; }
    public int Quanlity { get; set; }

    public Product(string name, decimal price, int quanlity)
    {
        Name = name;
        Price = price;
        Quanlity = quanlity;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name {Name}, Price {Price}, Quanlity {Quanlity}");
        
    }
}

struct ProductInfo
{
    public string Factor { get; private set; }
    public double Weight { get; set; }
    public string Category { get; private set; }

    public ProductInfo(string factor, double weight, string category)
    {
        Factor = factor;
        Weight = weight;
        Category = category;
    }
    public void Print()
    {
        Console.WriteLine($"Factory {Factor}, Weight {Weight}, Category {Category}");
    }
}

public enum OrderStatus
{
    New,
    Processing,
    Completed,
    Canceled
}

class Order
{
    public OrderStatus Status { get; set; }

    public void PrintStatus()
    {
        Console.WriteLine($"Order Status is {Status}");
    }
}