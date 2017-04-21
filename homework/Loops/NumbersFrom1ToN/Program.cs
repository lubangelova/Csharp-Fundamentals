using System;


namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
