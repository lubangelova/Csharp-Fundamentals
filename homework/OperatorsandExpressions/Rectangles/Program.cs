using System;


    class Rectangles
    {
        static void Main()
        {
        double weight = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        string outputFormat = "{0:0.00} {1:0.00}";
        double area = weight * height;
        double perimetre = 2 * weight + 2 * height;
        Console.WriteLine(outputFormat, area,perimetre);
        }
    }

