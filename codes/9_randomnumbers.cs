using System;

Random random = new Random();

// Random integer from 1 to 10
// The upper limit (11) is excluded
int number = random.Next(1, 11);
Console.WriteLine($"Random number: {number}");

// Roll a six-sided die: 1 to 6
int dice = random.Next(1, 7);
Console.WriteLine($"Dice roll: {dice}");

// Random decimal: 0 included, 1 excluded
double decimalNumber = random.NextDouble();
Console.WriteLine($"Random decimal: {decimalNumber}");

// Flip a coin
int coin = random.Next(0, 2);

if (coin == 0)
{
    Console.WriteLine("Coin flip: Heads");
}
else
{
    Console.WriteLine("Coin flip: Tails");
}