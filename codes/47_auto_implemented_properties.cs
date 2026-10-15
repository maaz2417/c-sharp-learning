using System;

Car car = new Car("Toyota", "White", 2024);

// Read properties using their getters
Console.WriteLine($"Brand: {car.Brand}");
Console.WriteLine($"Color: {car.Color}");
Console.WriteLine($"Year: {car.Year}");

// Change a property using its setter
car.Color = "Red";

Console.WriteLine($"\nAfter repainting: {car.Color}");

// This would cause an error because Brand has a private setter:
// car.Brand = "Honda";

class Car
{
    // Only this class can set Brand
    public string Brand { get; private set; }

    // Code outside the class can read and change Color
    public string Color { get; set; }

    // Getter-only property: assigned in the constructor
    public int Year { get; }

    public Car(string brand, string color, int year)
    {
        Brand = brand;
        Color = color;
        Year = year;
    }
}