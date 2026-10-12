using System;

// Print a rectangle: 3 rows, 5 stars per row
Console.WriteLine("Rectangle:");

for (int row = 1; row <= 3; row++)
{
    for (int column = 1; column <= 5; column++)
    {
        Console.Write("* ");
    }

    Console.WriteLine(); // Move to the next line
}

// Print a triangle: each row has one more star
Console.WriteLine("\nTriangle:");

for (int row = 1; row <= 5; row++)
{
    for (int column = 1; column <= row; column++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}