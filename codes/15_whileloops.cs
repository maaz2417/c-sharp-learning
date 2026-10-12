using System;

// Count from 1 to 5
int count = 1;

while (count <= 5)
{
    Console.WriteLine($"Count: {count}");
    count++; // Increase count by 1 each time
}

Console.WriteLine("Counting finished!");

// Keep asking until the user enters a name
Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "";

while (string.IsNullOrWhiteSpace(name))
{
    Console.Write("Name cannot be empty. Try again: ");
    name = Console.ReadLine() ?? "";
}

Console.WriteLine($"Hello, {name}!");