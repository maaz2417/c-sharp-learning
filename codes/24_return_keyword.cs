using System;

// Store a returned value
int sum = Add(10, 5);
Console.WriteLine($"Sum: {sum}"); // 15

// Use a returned value directly
Console.WriteLine($"Square of 4: {Square(4)}"); // 16

// Use a returned Boolean in a condition
if (IsEven(8))
{
    Console.WriteLine("8 is even.");
}

// Exit a function early
ShowAge(-5);
ShowAge(20);

// Function definitions
static int Add(int a, int b)
{
    return a + b;
}

static int Square(int number)
{
    return number * number;
}

static bool IsEven(int number)
{
    return number % 2 == 0;
}

static void ShowAge(int age)
{
    if (age < 0)
    {
        Console.WriteLine("Age cannot be negative.");
        return; // Exit immediately without returning a value
    }

    Console.WriteLine($"Your age is {age}.");
}