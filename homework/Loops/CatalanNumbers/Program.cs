using System;
using System.Numerics;


namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = Factoriel(2*n) / (Factoriel(n+1) * Factoriel(n));
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
