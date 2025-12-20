using System;

class GFG
{

    static void printDiamond(int n)
    {
        int space = n - 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < space; j++)
                Console.Write(" ");

            for (int j = 0; j <= i; j++)
                Console.Write("* ");

            Console.Write("\n");
            space--;
        }
        space = 0;
        for (int i = n; i > 0; i--)
        {

            for (int j = 0; j < space; j++)
                Console.Write(" ");

            for (int j = 0; j < i; j++)
                Console.Write("* ");

            Console.Write("\n");
            space++;
        }
    }
    public static void Main()
    {
        printDiamond(5);

    }
}
