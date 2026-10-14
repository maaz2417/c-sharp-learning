using System;

string name = "Maaz";
int age = 20;

// Insert variables into a string using $ and {}
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"You are {age} years old.");

// Calculate expressions inside {}
Console.WriteLine($"Next year, you will be {age + 1}.");

int a = 10;
int b = 5;

Console.WriteLine($"{a} + {b} = {a + b}");

// Format a number to two decimal places
double price = 19.5;

Console.WriteLine($"Price: {price:F2}"); // Price: 19.50

// Call a method inside {}
Console.WriteLine($"Uppercase name: {name.ToUpper()}");

// Display literal braces using {{ and }}
Console.WriteLine($"Your name in braces: {{{name}}}");
// Your name in braces: {Maaz}