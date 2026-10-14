using System;

// Create two separate objects from the same class
Car car1 = new Car();
car1.brand = "Toyota";
car1.color = "White";
car1.year = 2022;

Car car2 = new Car();
car2.brand = "Honda";
car2.color = "Black";
car2.year = 2024;

// Display each object's data
car1.ShowDetails();
car2.ShowDetails();

// Call a method on each object
car1.Drive();
car2.Drive();

// Changing one object does not change the other
car1.color = "Red";

Console.WriteLine("\nAfter repainting car1:");
car1.ShowDetails();
car2.ShowDetails();

// Class definition
class Car
{
    public string brand = "";
    public string color = "";
    public int year;

    public void ShowDetails()
    {
        Console.WriteLine($"{year} {color} {brand}");
    }

    public void Drive()
    {
        Console.WriteLine($"The {brand} is driving.");
    }
}