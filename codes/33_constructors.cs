using System;

// The constructor runs when each object is created
Car car1 = new Car("Toyota", "White", 2022);
Car car2 = new Car("Honda", "Black", 2024);

car1.ShowDetails();
car2.ShowDetails();

class Car
{
    public string brand;
    public string color;
    public int year;

    // Constructor: same name as the class, no return type
    public Car(string brand, string color, int year)
    {
        // "this" refers to the current object
        this.brand = brand;
        this.color = color;
        this.year = year;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{year} {color} {brand}");
    }
}