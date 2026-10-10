using System;

int a = 10;
int b = 3;

Console.WriteLine($"Addition: {a + b}");       // 13
Console.WriteLine($"Subtraction: {a - b}");    // 7
Console.WriteLine($"Multiplication: {a * b}"); // 30
Console.WriteLine($"Integer division: {a / b}"); // 3
Console.WriteLine($"Remainder: {a % b}");      // 1

// Cast to double to keep the fractional part
Console.WriteLine($"Decimal division: {(double)a / b}");

// Increment: increase by 1
a++;
Console.WriteLine($"After a++: {a}"); // 11

// Decrement: decrease by 1
b--;
Console.WriteLine($"After b--: {b}"); // 2