using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int left = 0;
            int right = n - 1;
            int middle = 0;
            bool match = false;
            while(left<=right && match!=true)
            {
                middle = (left + right) / 2;
                if (x==numbers[middle])
                {
                    match = true;
                }
                else if(x> numbers[middle])
                {
                    left = middle + 1;

                }
                else if(x < numbers[middle])
                {
                    right = middle - 1;
                }
            }

            if (!match)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(middle);
            }

        }
    }
}
