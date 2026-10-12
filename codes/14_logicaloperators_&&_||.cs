using System;

int age = 20;
bool hasTicket = true;
bool isMember = false;

// && (AND): both conditions must be true
if (age >= 18 && hasTicket)
{
    Console.WriteLine("You can enter the event.");
}
else
{
    Console.WriteLine("You must be 18 or older AND have a ticket.");
}

// || (OR): at least one condition must be true
if (age < 12 || age >= 65)
{
    Console.WriteLine("You qualify for an age discount.");
}
else
{
    Console.WriteLine("You pay the regular price.");
}

// ! (NOT): reverses true and false
if (!isMember)
{
    Console.WriteLine("Sign up to become a member.");
}