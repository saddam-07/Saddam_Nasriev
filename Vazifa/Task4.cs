//Masalai 4
class Task4
{
    public static void Run()
    {
        int soat, narx, maosh, dop;
        while (true)
        {
            Console.Write("Soati kori dar 1 moh = ");
            soat = Convert.ToInt16(Console.ReadLine());
            Console.Write("Narxi 1 soati kori = ");
            narx = Convert.ToInt16(Console.ReadLine());

            if (soat <= 240)
            {
                maosh = soat * narx;
                Console.WriteLine("Maosh " + maosh + " somoni");
            }
            else
            {
                maosh = 240 * narx;
                dop = (soat - 240) * narx;
                Console.WriteLine("Maosh " + maosh + " somoni. Ilovagi " + dop);
            }
        }
    }
}