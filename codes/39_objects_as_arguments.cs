using System;

Car car = new Car("Toyota", "White");

Console.WriteLine("Before painting:");
car.ShowDetails();

// Pass the object to a function
PaintCar(car, "Red");

Console.WriteLine("\nAfter painting:");
car.ShowDetails();

// The parameter refers to the same Car object
static void PaintCar(Car vehicle, string newColor)
{
    vehicle.color = newColor;
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

    public void ShowDetails()
    {
        Console.WriteLine($"{color} {brand}");
    }
}