using System;

class Program
{
    static void Main()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            // spaces
            for (int s = 1; s <= rows - i; s++)
            {
                Console.Write("  ");
            }

            // numbers
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}
