using System;

class Program
{
    static void Main()
    {
        // Constants cannot be changed after being declared
        const string SchoolName = "Greenwood School";
        const int MaxStudents = 30;
        const double Pi = 3.14159;

        Console.WriteLine($"School: {SchoolName}");
        Console.WriteLine($"Maximum students: {MaxStudents}");
        Console.WriteLine($"Pi: {Pi}");

        // Use a constant in a calculation
        double radius = 5;
        double area = Pi * radius * radius;

        Console.WriteLine($"Circle area: {area}");

        // This would cause an error:
        // MaxStudents = 40;
    }
}