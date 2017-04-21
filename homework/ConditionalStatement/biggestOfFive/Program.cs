using System;


namespace biggestOfFive
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double biggest;
            if (a>b && a>c && a>d && a>e)
            {
                biggest = a;
            }
            else if (b>c && b>d && b>e)
            {
                biggest = b;
            }
            else if (c>d && c>e)
            {
                biggest = c;
            }
            else if (d>e)
            {
                biggest = d;
            }
            else
            {
                biggest = e;
            }
            Console.WriteLine(biggest);
        }
    }
}
