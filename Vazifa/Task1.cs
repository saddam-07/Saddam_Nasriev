//Masalai 1
class Task1
{
    public static void Run()
    {
        string firstName, lastName, job;
        int age;
        Console.Write("Your Surname = ");
        firstName = Console.ReadLine();
        Console.Write("Your Name = ");
        lastName = Console.ReadLine();
        Console.Write("Your Speciality = ");
        job = Console.ReadLine();
        Console.Write("Your age = ");
        age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("My name is " + firstName + " " + lastName + ". I am " + age.ToString() + " years old. My speciality is " + job);
        Console.ReadKey();
    }
}