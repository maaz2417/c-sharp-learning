using System;

// Read text input
Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "";

// Read numeric input
Console.Write("Enter your age: ");
string ageInput = Console.ReadLine() ?? "";

// Check that the input is a valid whole number
if (int.TryParse(ageInput, out int age))
{
    Console.WriteLine($"Hello, {name}!");
    Console.WriteLine($"You are {age} years old.");
    Console.WriteLine($"Next year, you will be {age + 1}.");
}
else
{
    Console.WriteLine("Please enter a valid whole number for your age.");
}