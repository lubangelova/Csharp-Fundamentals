using System;

    class ComparingFloats
    {
        static void Main()
        {
        
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (firstNumber - secondNumber > 0)
        {
            if (firstNumber - secondNumber < eps)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }
        else
        {
            if (secondNumber - firstNumber < eps)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }

    }
    }

