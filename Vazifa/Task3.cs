//Masalai 3
double bal;
while (true)
{
    Console.Write("Bal = ");
    bal = Convert.ToDouble(Console.ReadLine());
    if (bal >= 90 && bal <= 100)
    {
        Console.WriteLine("Аъло");
    }
    else if (bal < 90 && bal >= 80)
    {
        Console.WriteLine("Хуб");
    }
    else if (bal < 80 && bal > 50)
    {
        Console.WriteLine("Каноатбахш");
    }
    else if (bal <= 50)
    {
        Console.WriteLine("Ноком");
    }
    else
    {
        Console.WriteLine("Балро дуруст дохил кунед!");
    }
}