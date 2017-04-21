using System;
using System.Numerics;


namespace CalculateAgain
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger result = Factoriel(n) / Factoriel(k);
            Console.WriteLine(result);

           
        }

        public static BigInteger Factoriel(BigInteger n)
        {
            BigInteger factoriel = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
    }
}
