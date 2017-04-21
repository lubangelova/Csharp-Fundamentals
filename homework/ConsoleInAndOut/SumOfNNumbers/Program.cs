using System;


namespace SumOfNNumbers
{
    class Program
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            double sum = 0;
            for (int i=1; i<=n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                sum+= numbers;
            }
            Console.WriteLine(sum);

        }
    }
}
