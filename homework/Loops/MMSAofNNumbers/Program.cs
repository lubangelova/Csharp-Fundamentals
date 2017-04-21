using System;


namespace MMSAofNNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double min=10000;
            double max=-10000;
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                min = Math.Min(numbers,min);
                max = Math.Max(numbers, max);
                sum += numbers;

            }
            avg = sum / n;

            Console.WriteLine("min={0:0.00}",min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", avg);
        }
    }
}
