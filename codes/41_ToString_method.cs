using System;

Car car1 = new Car("Toyota", "White", 2022);
Car car2 = new Car("Honda", "Black", 2024);

// Call ToString() directly
Console.WriteLine(car1.ToString());

// WriteLine automatically calls the object's ToString()
Console.WriteLine(car2);

// String interpolation also uses ToString()
Console.WriteLine($"My car: {car1}");

class Car
{
    public string brand;
    public string color;
    public int year;

    public Car(string brand, string color, int year)
    {
        this.brand = brand;
        this.color = color;
        this.year = year;
    }

    // Return a readable description of this object
    public override string ToString()
    {
        return $"{year} {color} {brand}";
    }
}