using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int currentSum = 0;
            int maxSum = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                currentSum += array[i];
              
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum<0)
                {
                    currentSum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
