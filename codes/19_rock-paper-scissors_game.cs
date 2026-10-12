using System;

Random random = new Random();

Console.WriteLine("=== Rock, Paper, Scissors ===");

while (true)
{
    Console.Write("\nChoose rock, paper, or scissors (or quit): ");
    string? input = Console.ReadLine();

    if (input == null)
    {
        break;
    }

    string player = input.Trim().ToLower();

    if (player == "quit")
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }

    if (player != "rock" && player != "paper" && player != "scissors")
    {
        Console.WriteLine("Invalid choice. Try again.");
        continue;
    }

    // Pick the computer's move
    string computer;

    switch (random.Next(1, 4))
    {
        case 1:
            computer = "rock";
            break;
        case 2:
            computer = "paper";
            break;
        default:
            computer = "scissors";
            break;
    }

    Console.WriteLine($"You chose: {player}");
    Console.WriteLine($"Computer chose: {computer}");

    // Decide the winner
    if (player == computer)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (
        (player == "rock" && computer == "scissors") ||
        (player == "paper" && computer == "rock") ||
        (player == "scissors" && computer == "paper"))
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("Computer wins!");
    }
}