using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Add(10, 5));       // 15
        Console.WriteLine(Add(2.5, 3.7));    // 6.2
        Console.WriteLine(Add(10, 5, 3));    // 18
    }

    // Two integers
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Two decimal numbers
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Three integers
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}