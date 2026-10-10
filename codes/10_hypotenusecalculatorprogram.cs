using System;

Console.WriteLine("Right Triangle Hypotenuse Calculator");

// Read the two sides next to the right angle
Console.Write("Enter side A: ");
if (!double.TryParse(Console.ReadLine(), out double a) ||
    !double.IsFinite(a) || a <= 0)
{
    Console.WriteLine("Please enter a positive, finite number.");
    return;
}

Console.Write("Enter side B: ");
if (!double.TryParse(Console.ReadLine(), out double b) ||
    !double.IsFinite(b) || b <= 0)
{
    Console.WriteLine("Please enter a positive, finite number.");
    return;
}

// Pythagorean theorem: c = √(a² + b²)
double hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine($"Hypotenuse: {hypotenuse:F2}");