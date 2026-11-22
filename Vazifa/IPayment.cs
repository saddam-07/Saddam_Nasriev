interface IPayment
{
    void ChashPayment()
    {
        Console.WriteLine("CashPaid...");
    }
    
    void CardPayment()
    {
        Console.WriteLine("CardPaid...");
    }

    void OnlinePayment()
    {
        Console.WriteLine("OnlinePaid...");
    }

    void TypePaid();
}