using System;

public class TriangleTypeIdentifier
{
    public static void Main(string[] args)
    {
        Console.Write("Enter side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        string triangleType = GetTriangleType(side1, side2, side3);

        Console.WriteLine($"The triangle is {triangleType}.");
    }

    public static string GetTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}