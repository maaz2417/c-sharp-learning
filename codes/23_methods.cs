using System;

// Call the methods
SayHello();

GreetUser("Maaz");
GreetUser("Ali");

int answer = Add(10, 5);
Console.WriteLine($"Sum: {answer}");

double area = CalculateArea(4, 3);
Console.WriteLine($"Rectangle area: {area}");

// Define the methods
static void SayHello()
{
    Console.WriteLine("Hello! Welcome to C# methods.");
}

// A parameter receives a value when the method is called
static void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// Return a result to the code that called this method
static int Add(int a, int b)
{
    return a + b;
}

static double CalculateArea(double width, double height)
{
    return width * height;
}