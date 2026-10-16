//Masalai 5
class Task5
{
    public static void Run()
    {
        string[] s;
        int[] a = new int[20];
        double btw = 0, max_b, min_b, count_r = 0, count_l = 0;
        while (true)
        {
            s = Console.ReadLine().Split(' ');
            for (int i = 0; i < 20; i++)
            {
                a[i] = Convert.ToInt16(s[i]);
            }
            max_b = a[0];
            min_b = a[0];
            for (int i = 0; i < 20; i++)
            {
                btw += a[i];
                if (a[i] > max_b) max_b = a[i];
                if (a[i] < min_b) min_b = a[i];
                if (a[i] > 50) count_r++;
                else count_l++;
            }
            Console.WriteLine("Bali miyona " + btw / 20 + ". Max=" + max_b + ", Min=" + min_b + ". Guzasht " + count_r + " Nagizasht " + count_l);
            btw = 0; min_b = 0; max_b = 0; count_r = 0; count_l = 0;

        }
    }
}
