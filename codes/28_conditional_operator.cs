using System;

// Choose a message based on age
int age = 20;
string status = age >= 18 ? "Adult" : "Minor";

Console.WriteLine($"Status: {status}");

// Check whether a number is even or odd
int number = 7;
string result = number % 2 == 0 ? "Even" : "Odd";

Console.WriteLine($"{number} is {result}.");

// Find the larger number
int a = 10;
int b = 25;
int larger = a > b ? a : b;

Console.WriteLine($"Larger number: {larger}");

// Choose a price based on membership
bool isMember = true;
double price = isMember ? 8.50 : 10.00;

Console.WriteLine($"Ticket price: {price:F2}");