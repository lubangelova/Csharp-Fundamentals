using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            string [] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int D=0;
            int divident=0;
            int divisor=0;

            if (A > B)
            {
                divident = A;
                divisor = B;
            }
            else
            {
                divident = B;
                divisor = A;
            }
                while (divident!=0 && divisor!=0)
                {
                    D = divident;
                    divident = divisor;
                    divisor = D % divisor;
                    
                }
            
          

            Console.WriteLine("{0}", divident);
         
        }
    }
}
