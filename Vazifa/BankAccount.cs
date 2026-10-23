using System.Collections.Generic;

class BankAccount
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    private decimal Balance { get; set; }


    public BankAccount(string firstName, string lastName, int age, decimal balance)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Balance = balance;
    }

    public void AddMoney(decimal amount)
    {
        if(amount<=0)
        {
            Console.WriteLine("Некорректная сумма!");
            return;
        }
        Balance += amount;
        Console.WriteLine("Успешно!");

    }

    public void TakeMoney(decimal amount)
    {
        if(amount<=0)
        {
            Console.WriteLine("Неккоректная сумма!");
        }
        else if(amount>Balance)
        {
            Console.WriteLine("Недостаточно средств!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Успешно!");
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя {FirstName} {LastName}. {Age} лет.");
        Console.WriteLine($"Баланс : {Balance} сомони");
        Console.WriteLine();
    }
}