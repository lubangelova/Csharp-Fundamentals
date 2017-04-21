using System;



    class pointinCircle
    {
        static void Main()
        {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 2;
        double cx = 0;
        double cy = 0;
        double dx = x - cx;
        double dy = y - cy;
        double distance = Math.Sqrt(dx * dx + dy * dy);
        if(distance<=r)
        {
            Console.WriteLine("yes {0:0.00}",distance);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", distance);
        }

        }
    }

