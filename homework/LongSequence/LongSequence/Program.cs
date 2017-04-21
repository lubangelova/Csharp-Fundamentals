using System;


namespace LongSequence
{
    class StarUp
    {
        static void Main()
        {
            int i,
                len = 1001;
            for (i=2; i<=len; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else Console.WriteLine(i * -1);
            }
        }
    }
}
