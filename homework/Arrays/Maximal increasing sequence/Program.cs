using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = int.Parse(Console.ReadLine());
            int startElement = array[0];
            int currentCount = 1;
            int maxCount = 1;
            for (int i = 1; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (startElement < array[i])
                {

                    currentCount++;
                    maxCount = Math.Max(currentCount, maxCount);
                    startElement = array[i];
                }
                else
                {
                    startElement = array[i];
                    currentCount = 1;
                }

            }
            Console.WriteLine(maxCount);
        }
    }
}
