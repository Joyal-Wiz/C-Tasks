using System;

class Program
{
    static void Main()
    {
        int mark = 85;

        if (mark >= 90 && mark <= 100)
            Console.WriteLine("S grade");
        else if (mark >= 80 && mark < 90)
            Console.WriteLine("A grade");
        else if (mark >= 70 && mark < 80)
            Console.WriteLine("B grade");
        else if (mark >= 60 && mark < 70)
            Console.WriteLine("C grade");
        else if (mark >= 50 && mark < 60)
            Console.WriteLine("D grade");
        else if (mark >= 40 && mark < 50)
            Console.WriteLine("E grade");
        else if (mark >= 0 && mark < 40)
            Console.WriteLine("Student has failed");
        else
            Console.WriteLine("Invalid marks");
    }
}
