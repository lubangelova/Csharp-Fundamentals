using System;



    class PointCircleRectangle
    {
        static void Main()
        {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double cx = 1;
        double cy = 1;
        double r = 1.5;
        double TopY = 1;
        double LeftX = -1;
         double Width = 6;
         double Height = 2;
        double bottomY = TopY - Height;
        double RightX = LeftX + Width;

        double distance = Math.Pow((x - cx),2) + Math.Pow((y - cy),2);


        if (distance<=r*r)
        {
            if (x>=LeftX && x<=RightX && y>=bottomY && y<=TopY)
            {
                Console.WriteLine("inside circle inside rectangle");
            } 
            else
            {
                Console.WriteLine("inside circle outside rectangle");
            }
        }
        else if((x >= LeftX && x <= RightX && y >= bottomY && y <= TopY))
        {
            Console.WriteLine("outside circle inside rectangle");

        }
        else
        {
            Console.WriteLine("outside circle outside rectangle");
        }
}
    }

