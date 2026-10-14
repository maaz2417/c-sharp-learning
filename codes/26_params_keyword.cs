using System;

Console.WriteLine($"Two numbers: {Add(10, 20)}");          // 30
Console.WriteLine($"Four numbers: {Add(1, 2, 3, 4)}");     // 10
Console.WriteLine($"No numbers: {Add()}");                // 0

// You can also pass an existing array
int[] numbers = { 5, 10, 15 };
Console.WriteLine($"Array total: {Add(numbers)}");        // 30

// A regular parameter followed by a params parameter
ShowNames("Students", "Maaz", "Ali", "Sara");

static int Add(params int[] numbers)
{
    int total = 0;

    foreach (int number in numbers)
    {
        total += number;
    }

    return total;
}

static void ShowNames(string heading, params string[] names)
{
    Console.WriteLine($"\n{heading}:");

    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}