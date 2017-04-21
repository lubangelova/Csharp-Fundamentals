using System;


namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string binary = "";

            if (n==0)
            {
                binary = "0";

            }
            while (n>0)
            {
                if (n%2==0)
                {
                    binary= "0"+binary;
                }
                else
                {
                    binary = "1"+binary;
                }
                n /= 2;
            }
            Console.WriteLine(binary);
        }
    }
}
