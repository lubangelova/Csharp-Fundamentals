using System;


namespace biggestOf3
{
    class Program
    {
        static void Main()

        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest = 0;

            if (a>b)
            {
                if (a > c)
                {
                    biggest = a;
                }
                else
                {
                    biggest = c;
                }
            }
            else if (a<b)
            {
                if (b>c)
                {
                    biggest = b;
                }
                else
                {
                    biggest = c;
                }
            }
            else
            {
                if (a>c)
                {
                    biggest = a;
                }
                else
                {
                    biggest = c;
                }
            }
            Console.WriteLine(biggest);
        }


    }
}
