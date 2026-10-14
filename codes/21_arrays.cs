using System;

// An array stores multiple values of the same type
string[] cars = { "Toyota", "Honda", "BMW" };

// Access items by index (counting starts at 0)
Console.WriteLine($"First car: {cars[0]}");  // Toyota
Console.WriteLine($"Second car: {cars[1]}"); // Honda
Console.WriteLine($"Third car: {cars[2]}");  // BMW

// Change an item
cars[1] = "Suzuki";
Console.WriteLine($"Updated second car: {cars[1]}");

// Get the number of items
Console.WriteLine($"Number of cars: {cars.Length}");

// Print every item using a loop
Console.WriteLine("\nAll cars:");

for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{i}: {cars[i]}");
}

// An array of integers
int[] scores = { 80, 95, 70, 85, 90 };
int total = 0;

for (int i = 0; i < scores.Length; i++)
{
    total += scores[i];
}

double average = (double)total / scores.Length;

Console.WriteLine($"\nTotal score: {total}");
Console.WriteLine($"Average score: {average}");

// Create an array with space for 3 values
int[] numbers = new int[3];

numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;

Console.WriteLine($"\nLast number: {numbers[2]}");