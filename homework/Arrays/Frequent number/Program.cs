using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count = 1;
            int maxCount = 1;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                array[i]= int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = 1; i < n; i++)
            {
                if (array[i-1]==array[i])
                {
                    count++;
                    if (count>maxCount)
                    {
                        maxCount = count;
                        number = array[i];
                    }  
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", number,maxCount);
        }
    }
}
