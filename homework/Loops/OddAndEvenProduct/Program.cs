using System;



namespace OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string [] arrayOfNumbers = input.Split(' ');
            ulong oddSum = 1;
            ulong evenSum = 1;

            for (int i = 1; i < arrayOfNumbers.Length + 1; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum *= ulong.Parse(arrayOfNumbers[i - 1]);
                }
                else
                {
                    evenSum *= ulong.Parse(arrayOfNumbers[i - 1]);
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("yes {0}", evenSum);
            }
            else
            {
                Console.WriteLine("no {0} {1}", oddSum, evenSum);
            }
        }
    }
}

