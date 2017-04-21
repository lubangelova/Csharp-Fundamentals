using System;


namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int index = 0;
            double pow = 1;
            double result = 0;
            for (int i = input.Length-1; i >= 0; i--)
            {
                if (input[index]=='1')
                {
                    pow = Math.Pow(2, i);
                    result += pow;
                }
                index++;
            }
            Console.WriteLine(result);
        }
    }
}
