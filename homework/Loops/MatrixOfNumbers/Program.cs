using System;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                int number = i;
                for (int j = 1; j <=n; j++)
                {
                    
                    Console.Write("{0} ",number);
                    number++;
                 
                }
                Console.WriteLine();
            }
        }
    }
}
