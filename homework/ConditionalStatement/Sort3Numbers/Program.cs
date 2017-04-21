using System;

namespace Sort3Numbers
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double smaller;
            double middle;
            double biggest;

            if (a > b)
            {
                if (a > c)
                {
                    biggest = a;
                    if (b>c)
                    {
                        middle = b;
                        smaller = c;
                    }
                    else
                    {
                        middle = c;
                        smaller = b;
                    }
                    
                }
                else
                {
                    biggest = c;
                    middle = a;
                    smaller = b;
                }
            }
            else if (a < b)
            {
                if (b > c)
                {
                    biggest = b;
                    if (a>c)
                    {
                        middle = a;
                        smaller = c;
                    }
                    else
                    {
                        middle = c;
                        smaller = a;
                    }
                }
                else
                {
                    biggest = c;
                    middle = b;
                    smaller = a;
                }
            }
            else
            {
                if (a > c)
                {
                    biggest = middle= a;
                    smaller = c;
                }
                else
                {
                    biggest = c;
                    middle=smaller = a;

                }
            }
            Console.WriteLine("{0} {1} {2}", biggest,middle, smaller);
        }
    }
}
