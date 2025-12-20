using System;

class Program
{
    static void Main()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            for (int s = 1; s <= rows - i; s++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
