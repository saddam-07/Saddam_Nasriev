class Task6
{
    public static void Run()
    {
        List<string> students = new List<string>() { "Azizov", "Bandaev", "Dadaev", "Burhonov", "Ismoilov" };
        while(true)
        {
            Console.WriteLine("add-добавить студента, search-искать студента, delete-удалить студента, list-вывести всех");
            Console.Write("Введи команду ");
            string comand = Console.ReadLine();

            if (comand == "add")
            {
                Console.Write("Введи имя ");
                string name = Console.ReadLine();
                students.Add(name);
                Console.WriteLine("Успешно добавлено");

            }
            else if (comand == "search")
            {
                Console.Write("Введи имя ");
                string name = Console.ReadLine();
                if (students.Contains(name)) { Console.WriteLine(name + " есть в списке"); }
                else { Console.WriteLine(name + "а нету в списке"); }
            }
            else if (comand == "delete")
            {
                Console.Write("Введи имя ");
                string name = Console.ReadLine();
                if (students.Contains(name))
                {
                    students.RemoveAll(x => x == name);
                    Console.WriteLine("Успешно удалён");
                }
                else
                {
                    Console.WriteLine(name + "а нету в списке");
                }
            }
            else if(comand=="list")
            {
                foreach(string st in students)
                {
                    Console.Write(st + " ");
                }
                Console.Write("\n");
            }
            else
            {
                Console.WriteLine("Такой команды нету");
            }
        }
    }
}