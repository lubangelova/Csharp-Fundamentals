using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string array1 = Console.ReadLine();
            string array2 = Console.ReadLine();
         
            int N = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < N; i++)
            {
                if (array1[i] == array2[i] && i == N - 1)
                {
                    if (array1.Length < array2.Length)
                        Console.WriteLine("<");
                    else if (array1.Length > array2.Length)
                        Console.WriteLine(">");
                    else
                        Console.WriteLine("=");
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine("<");
                    break;
                }
            }

        }
    }
}
