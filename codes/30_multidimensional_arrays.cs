using System;

// A 2D array with 3 rows and 3 columns
int[,] numbers =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// Access an item using [row, column]
// Both indexes start at 0
Console.WriteLine($"First item: {numbers[0, 0]}");  // 1
Console.WriteLine($"Middle item: {numbers[1, 1]}"); // 5

// Change an item
numbers[1, 1] = 50;

// Get the size of each dimension
int rows = numbers.GetLength(0);
int columns = numbers.GetLength(1);

Console.WriteLine($"Rows: {rows}");             // 3
Console.WriteLine($"Columns: {columns}");       // 3
Console.WriteLine($"Total items: {numbers.Length}"); // 9

// Print the array as a grid
Console.WriteLine("\nGrid:");

for (int row = 0; row < rows; row++)
{
    for (int column = 0; column < columns; column++)
    {
        Console.Write($"{numbers[row, column],4}");
    }

    Console.WriteLine();
}