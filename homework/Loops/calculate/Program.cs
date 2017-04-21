using System;


namespace calculate
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double factoriel = 1;
            for (int i = 1; i <=n; i++)
            {
                factoriel *= i;
                sum += factoriel / Math.Pow(x, i);
            }
           
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
