using System;
using System.Collections.Generic;

// Create a list containing Car objects
List<Car> cars = new List<Car>
{
    new Car("Toyota", "White"),
    new Car("Honda", "Black")
};

// Add another object
cars.Add(new Car("BMW", "Blue"));

// Access an object and change its colour
cars[0].color = "Red";

// Display every object
Console.WriteLine("All cars:");

foreach (Car car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine($"Total cars: {cars.Count}");

// Remove the second object (index 1)
cars.RemoveAt(1);

Console.WriteLine("\nAfter removing Honda:");

foreach (Car car in cars)
{
    Console.WriteLine(car);
}

class Car
{
    public string brand;
    public string color;

    public Car(string brand, string color)
    {
        this.brand = brand;
        this.color = color;
    }

    public override string ToString()
    {
        return $"{color} {brand}";
    }
}