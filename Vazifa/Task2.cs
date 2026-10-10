//Masalai 2
double a, b, c = 0;
string amal;
while (true)
{
    Console.Write("a = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Amal = ");
    amal = Console.ReadLine();
    switch (amal)
    {
        case "+":
            c = a + b;
            break;
        case "-":
            c = a - b;
            break;
        case "*":
            c = a * b;
            break;
        case "/":
            c = a / b;
            break;
        case "%":
            c = a % b;
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
    Console.WriteLine(c.ToString("F2"));
    c = 0;

}