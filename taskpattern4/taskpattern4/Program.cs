using System;

class Program
{
    static void Main()
    {
        int rows = 4;
        int num = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
}
