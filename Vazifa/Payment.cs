class Payment : IPayment
{
    public string Type { get; set; }
    public Payment(string type)
    {
        Type = type;
    }

    public void CashPayment()
    {
        Console.WriteLine("I choose CashPaid...");
    }

    public void CardPayment()
    {
        Console.WriteLine("I choose CardPaid...");
    }

    public void OnlinePayment()
    {
        Console.WriteLine("I choose OnlinePaid...");
    }

    public void TypePaid()
    {
        if (Type == "cash") { CashPayment(); }
        if (Type == "card") { CardPayment(); }
        if(Type=="online") { OnlinePayment(); }
    }
}