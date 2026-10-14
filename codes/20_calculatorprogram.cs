using System;

Console.WriteLine("=== Calculator ===");

while (true)
{
    Console.Write("\nEnter the first number (or quit): ");
    string? input = Console.ReadLine();

    if (input == null || input.Trim().ToLower() == "quit")
    {
        break;
    }

    if (!double.TryParse(input, out double first) ||
        !double.IsFinite(first))
    {
        Console.WriteLine("Please enter a valid, finite number.");
        continue;
    }

    Console.Write("Enter an operator (+, -, *, /): ");
    string? operation = Console.ReadLine()?.Trim();

    if (operation == null)
    {
        break;
    }

    if (operation != "+" && operation != "-" &&
        operation != "*" && operation != "/")
    {
        Console.WriteLine("Invalid operator. Try again.");
        continue;
    }

    Console.Write("Enter the second number: ");
    string? secondInput = Console.ReadLine();

    if (secondInput == null)
    {
        break;
    }

    if (!double.TryParse(secondInput, out double second) ||
        !double.IsFinite(second))
    {
        Console.WriteLine("Please enter a valid, finite number.");
        continue;
    }

    double result;

    switch (operation)
    {
        case "+":
            result = first + second;
            break;

        case "-":
            result = first - second;
            break;

        case "*":
            result = first * second;
            break;

        case "/":
            if (second == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                continue;
            }

            result = first / second;
            break;

        default:
            continue;
    }

    Console.WriteLine($"{first} {operation} {second} = {result}");
}

Console.WriteLine("Calculator closed.");

