using System;

string name = "Maaz Akhund";

// Change case
Console.WriteLine(name.ToUpper()); // MAAZ AKHUND
Console.WriteLine(name.ToLower()); // maaz akhund

// Replace text
Console.WriteLine(name.Replace("Maaz", "Ali")); // Ali Akhund

// Check for text (case-sensitive by default)
Console.WriteLine(name.Contains("Maaz"));     // True
Console.WriteLine(name.StartsWith("Maaz"));   // True
Console.WriteLine(name.EndsWith("Akhund"));   // True

// Positions start at 0
Console.WriteLine(name.IndexOf("Akhund")); // 5

// Extract text: start at position 0, take 4 characters
Console.WriteLine(name.Substring(0, 4)); // Maaz

// Insert or remove text
Console.WriteLine(name.Insert(0, "Hello, ")); // Hello, Maaz Akhund
Console.WriteLine(name.Remove(4));           // Maaz

// Remove spaces from the beginning and end
string message = "   Hello!   ";
Console.WriteLine(message.Trim()); // Hello!

// Split text into separate parts
string fruits = "apple,banana,mango";
string[] fruitList = fruits.Split(',');

Console.WriteLine(fruitList[0]); // apple
Console.WriteLine(fruitList[1]); // banana
Console.WriteLine(fruitList[2]); // mango

// Length is a property, so it doesn't use parentheses
Console.WriteLine(name.Length); // 11