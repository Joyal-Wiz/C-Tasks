using System;

class Program
{
    static void Main()
    {
        int year = 2024;

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine("Leap year");
        else
            Console.WriteLine("Not a leap year");
    }
}
