using System;
class Program
{
    static void Main()
    {
        int number = 7;
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;

        for (int i = 2; i <= number / 2 && isPrime; i++)
        {
            if (number % i == 0)
                isPrime = false;
        }
        Console.WriteLine(isPrime
            ? $"{number} is a Prime number"
            : $"{number} is not a Prime number");
    }
}
