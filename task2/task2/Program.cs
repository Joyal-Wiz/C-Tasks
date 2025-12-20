using System;

class Program
{
    static void evenornot(int x)
    {
        if (x < 0)
        {
            Console.WriteLine("negative");
        } else if (x>=1) {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
    static void Main()
    {
        evenornot(-1);
    }
}
