using System;

// Print each car in an array
string[] cars = { "Toyota", "Honda", "BMW" };

Console.WriteLine("Cars:");

foreach (string car in cars)
{
    Console.WriteLine(car);
}

// Add up all the scores
int[] scores = { 80, 95, 70, 85, 90 };
int total = 0;

foreach (int score in scores)
{
    total += score;
}

Console.WriteLine($"\nTotal score: {total}");

// Loop through each character in a string
string name = "Maaz";

Console.WriteLine("\nLetters in your name:");

foreach (char letter in name)
{
    Console.WriteLine(letter);
}