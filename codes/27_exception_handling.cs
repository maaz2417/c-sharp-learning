using System;

try
{
    Console.Write("Enter the first whole number: ");
    int first = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Enter the second whole number: ");
    int second = int.Parse(Console.ReadLine() ?? "");

    int result = first / second;

    Console.WriteLine($"Result: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input! Please enter whole numbers.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero.");
}
catch (OverflowException)
{
    Console.WriteLine("A number or calculation exceeded the int range.");
}
finally
{
    Console.WriteLine("Calculation attempt finished.");
}

Console.WriteLine("The program continues after handling the error.");