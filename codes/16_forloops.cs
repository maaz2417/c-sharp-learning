using System;

// Count from 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Count: {i}");
}

// Count backwards from 5 to 1
Console.WriteLine("Countdown:");

for (int i = 5; i >= 1; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("Go!");

// Print the 7 times table
Console.WriteLine("7 times table:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"7 × {i} = {7 * i}");
}