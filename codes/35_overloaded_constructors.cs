using System;

// Each call uses a different constructor
Car car1 = new Car();
Car car2 = new Car("Toyota");
Car car3 = new Car("Honda", "Black", 2024);

car1.ShowDetails();
car2.ShowDetails();
car3.ShowDetails();

class Car
{
    public string brand;
    public string color;
    public int year;

    // Constructor with no parameters
    public Car()
    {
        brand = "Unknown";
        color = "White";
        year = 2020;
    }

    // Constructor with one parameter
    public Car(string brand)
    {
        this.brand = brand;
        color = "White";
        year = 2020;
    }

    // Constructor with three parameters
    public Car(string brand, string color, int year)
    {
        this.brand = brand;
        this.color = color;
        this.year = year;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{year} {color} {brand}");
    }
}