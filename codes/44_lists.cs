using System;
using System.Collections.Generic;

// Create a list
List<string> fruits = new List<string>
{
    "Apple",
    "Banana",
    "Mango"
};

// Add an item to the end
fruits.Add("Orange");

// Insert an item at index 1
fruits.Insert(1, "Grapes");

// Access and change an item
Console.WriteLine($"First fruit: {fruits[0]}");
fruits[0] = "Strawberry";

// Remove an item by value
fruits.Remove("Banana");

// Check whether an item exists
Console.WriteLine($"Contains Mango: {fruits.Contains("Mango")}");

// Sort alphabetically
fruits.Sort();

Console.WriteLine("\nAll fruits:");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Lists use Count to get the number of items
Console.WriteLine($"\nNumber of fruits: {fruits.Count}");

// Remove an item by index
fruits.RemoveAt(0);

Console.WriteLine($"After removing the first item: {fruits.Count}");

// Remove every item
fruits.Clear();

Console.WriteLine($"After clearing the list: {fruits.Count}");