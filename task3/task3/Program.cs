using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 25, c = 15;

        if (a >= b && a >= c)
            Console.WriteLine("Largest: " + a);
        else if (b >= a && b >= c)
            Console.WriteLine("Largest: " + b);
        else
            Console.WriteLine("Largest: " + c);
    }
}
