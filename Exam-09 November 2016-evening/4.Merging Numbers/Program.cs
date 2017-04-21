using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merging_Numbers
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int n = int.Parse(Console.ReadLine());
            int mergedNumbers;
            int sums=0;
            int [] numbers =new int[n];
            int[] arraySumms = new int[n - 1];
            int[] arrayMerged = new int[n - 1];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
    
            }
            for (int i = 0; i < n-1; i++)
            {
                sums = numbers[i] + numbers[i + 1];
                mergedNumbers =int.Parse((numbers[i] % 10).ToString() + (numbers[i + 1] / 10).ToString());
                for (int j = 0; j < n-1; j++)
                {
                    arraySumms[i] = sums;
                    arrayMerged[i] = mergedNumbers;

                }
  
            }
            foreach (var item in arrayMerged)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            foreach (var item in arraySumms)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

        }
    }
}
