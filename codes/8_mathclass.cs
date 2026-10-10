using System;

// Square root
Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}"); // 5

// Power: 2 raised to 3
Console.WriteLine($"2 cubed: {Math.Pow(2, 3)}"); // 8

// Absolute value: distance from zero
Console.WriteLine($"Absolute value of -10: {Math.Abs(-10)}"); // 10

// Larger and smaller values
Console.WriteLine($"Maximum: {Math.Max(10, 20)}"); // 20
Console.WriteLine($"Minimum: {Math.Min(10, 20)}"); // 10

// Rounding
double number = 3.7;

Console.WriteLine($"Round to nearest: {Math.Round(number)}"); // 4
Console.WriteLine($"Round down: {Math.Floor(number)}");        // 3
Console.WriteLine($"Round up: {Math.Ceiling(number)}");        // 4

// Round to two decimal places
Console.WriteLine($"Two decimal places: {Math.Round(3.14159, 2)}"); // 3.14

// Calculate a circle's area using Pi
double radius = 5;
double area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine($"Circle area: {area}");