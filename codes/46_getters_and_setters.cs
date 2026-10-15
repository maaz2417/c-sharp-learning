using System;

Person person = new Person();

// Assigning a property calls its setter
person.Name = "Maaz";
person.Age = 20;

// Reading a property calls its getter
Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");

// Try assigning an invalid age
person.Age = -5;

Console.WriteLine($"Age after invalid assignment: {person.Age}");

class Person
{
    // Private field stores the age
    private int age;

    // Auto-property: C# handles the backing field
    public string Name { get; set; } = "";

    // Property with a getter and a setter
    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            // "value" is the number being assigned
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative.");
            }
        }
    }
}