using System;

Animal animal = new Animal();
Dog dog = new Dog();
Cat cat = new Cat();

animal.Speak();
dog.Speak();
cat.Speak();

// An Animal reference can refer to a Dog object
Animal pet = new Dog();
pet.Speak(); // Calls Dog's version

class Animal
{
    // virtual allows child classes to override this method
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks: Woof!");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows: Meow!");
    }
}
