using System;
class Program
{
    static void evenornot(int x){
        if (x % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else {
            Console.WriteLine("odd");
        }
    }
    static void Main()
    {
        evenornot(1);
    }
}
