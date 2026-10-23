using System;
using System.Collections.Generic;

class Task9
{
    public static void Run()
    {
        string comand;
        decimal amount;
        Console.Write("Имя: ");
        string[] s = Console.ReadLine().Split(' ');
        Console.Write("Возраст: ");
        int age = Convert.ToInt16(Console.ReadLine());
        decimal balance = 0m;

        BankAccount client = new BankAccount(
            s[0],
            s[1],
            age,
            balance
        );

        while (true)
        {
            Console.WriteLine("add-депозит, take-снять, list-баланс");
            Console.Write("Выведите одну из команд ");
            comand = Console.ReadLine();
            if(comand=="add")
            {
                Console.Write("Введите сумму: ");
                amount = Convert.ToDecimal(Console.ReadLine());
                client.AddMoney(amount);
            }
            else if(comand=="take")
            {
                Console.Write("Введите сумму: ");
                amount = Convert.ToDecimal(Console.ReadLine());
                client.TakeMoney(amount);
            }
            else if(comand=="list")
            {
                client.PrintInfo();
            }
            else
            {
                Console.WriteLine("Неправильная команда");
            }
        }

    }
}