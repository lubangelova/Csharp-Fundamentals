using System;


namespace Trailing0inN_
{
    class Program
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong zeros = 0;
            ulong i = 1;
                while ((ulong)Math.Pow(5,i)<n)
                {
                    zeros += (n / (ulong)Math.Pow(5, i));
                     i++;
                }
            
            Console.WriteLine(zeros);
           

        }
    }
}
