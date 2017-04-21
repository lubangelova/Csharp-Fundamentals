using System;


namespace SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int n=int.Parse(Console.ReadLine());
            int number=1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == 0 && col < n  || col==n-1 && row>0 && row<n-1  )
                    {
                        Console.Write(number);
                        number++;
                    }
                    else if (row == n - 1 && col <= n-1)
                    {                   
                            Console.Write(number+n-1);
                            number--;
                   
                    }
                    //else if (col==0 && row<n-1 && row>0)
                    //{
                    //    Console.Write(number);
                    //    number ++;
                    //}
                    else
                    {
                        Console.Write(' ');
                    }
                   
                }
                Console.WriteLine();
            }
           
        }
    }
}
