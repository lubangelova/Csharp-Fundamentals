using System;


namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double diskriminant = Math.Pow(b, 2) - 4 * a * c;
            double x1;
            double x2;

            if (diskriminant<0)
            {
                Console.WriteLine("no real roots");
            }

            else if (diskriminant==0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("{0:F2}", x1);
            }
            else
            {
                x1 = ((-b) + Math.Sqrt(diskriminant)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(diskriminant)) / (2 * a);
                Console.WriteLine("{0:F2}", Math.Min(x1,x2));
                Console.WriteLine("{0:F2}", Math.Max(x1,x2));
            }
        }
    }
}
