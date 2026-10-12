using System;

Random random = new Random();
int secretNumber = random.Next(1, 101);
int attempts = 0;

Console.WriteLine("=== Number Guessing Game ===");
Console.WriteLine("I'm thinking of a number from 1 to 100.");

while (true)
{
    Console.Write("Enter your guess: ");
    string? input = Console.ReadLine();

    if (input == null)
    {
        break;
    }

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("Please enter a whole number.");
        continue;
    }

    if (guess < 1 || guess > 100)
    {
        Console.WriteLine("Your guess must be between 1 and 100.");
        continue;
    }

    attempts++;

    if (guess < secretNumber)
    {
        Console.WriteLine("Too low! Try a higher number.");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Too high! Try a lower number.");
    }
    else
    {
        Console.WriteLine($"Correct! The number was {secretNumber}.");
        Console.WriteLine($"You guessed it in {attempts} attempts!");
        break;
    }
}