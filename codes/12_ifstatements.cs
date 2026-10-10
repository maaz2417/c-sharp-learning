using System;

Console.Write("Enter your age: ");

if (!int.TryParse(Console.ReadLine(), out int age))
{
    Console.WriteLine("Please enter a valid whole number.");
}
else if (age < 0)
{
    Console.WriteLine("Age cannot be negative.");
}
else if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if (age < 18)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are an adult.");
}