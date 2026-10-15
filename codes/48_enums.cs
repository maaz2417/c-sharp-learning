using System;

// Store one of the named enum values
Day today = Day.Wednesday;

Console.WriteLine($"Today is {today}");

// Enum values have underlying numbers
Console.WriteLine($"Day number: {(int)today}"); // 3

// Use an enum in a switch
switch (today)
{
    case Day.Saturday:
    case Day.Sunday:
        Console.WriteLine("It's the weekend!");
        break;

    default:
        Console.WriteLine("It's a weekday.");
        break;
}

// Compare enum values
OrderStatus status = OrderStatus.Pending;

if (status == OrderStatus.Pending)
{
    Console.WriteLine("\nYour order is waiting to be processed.");
}

// Update the status
status = OrderStatus.Shipped;
Console.WriteLine($"Updated order status: {status}");

// Define enums below the top-level code
enum Day
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered
}