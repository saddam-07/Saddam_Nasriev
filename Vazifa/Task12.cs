class Task12
{
    public static void Run()
    {
        string type;
        while(true)
        {
            Console.WriteLine("Choose the method of payment: cash, card, online");
            type = Console.ReadLine();
            IPayment pay = new Payment(type);

            pay.TypePaid();
        }
    }
}