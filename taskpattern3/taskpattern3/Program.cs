using System;

class Program
{
    static void Main()
    {
        int rows = 5;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write((char)('A' + j) + " ");
            }
            Console.WriteLine();
        }
    }
}
