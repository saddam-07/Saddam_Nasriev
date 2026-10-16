class Task7
{
    public static void Run()
    {
        Dictionary<string, int> num = new Dictionary<string, int>();
        num.Add("Ali", 929998877);
        num.Add("Said", 926095044);
        num.Add("Jafar", 928845677);
        while(true)
        {
            Console.WriteLine("add-добавить, search-найти, change-изменить, remove-удалить, list-вывести список");
            Console.Write("Выведите одну из команд ");
            string comand = Console.ReadLine();
            if(comand=="add")
            {
                Console.Write("Выведите имя и номер ");
                string[] s = Console.ReadLine().Split(' ');
                num.Add(s[0], Convert.ToInt32(s[1]));
                Console.WriteLine("Успешно добавлено");
            }
            else if(comand=="search")
            {
                Console.Write("Выведите имя ");
                string s0 = Console.ReadLine();
                if (num.ContainsKey(s0))
                {
                    Console.WriteLine(s0 + " - " + num[s0]);
                }
                else
                {
                    Console.WriteLine("Такого номера нет");
                }
            }
            else if(comand=="change")
            {
                Console.Write("Введите имя ");
                string s0 = Console.ReadLine();
                Console.WriteLine($"Прежний номер = {num[s0]}");
                Console.Write("Введите новый номер ");
                int s1 = Convert.ToInt32(Console.ReadLine());
                num[s0] = s1;
                Console.WriteLine("Успешно изменено");
            }
            else if(comand=="remove")
            {
                Console.Write("Введите имя ");
                string s0 = Console.ReadLine();
                num.Remove(s0);
                Console.WriteLine("Успешно удалён");
            }
            else if(comand=="list")
            {
                foreach(var x in num)
                {
                    Console.WriteLine($"{x.Key} - {x.Value}");
                }
            }
            else
            {
                Console.WriteLine("Такой команды нет");
            }
        }
    }
}