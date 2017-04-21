using System;

namespace PrintSequence
{
    class StartUp
    {
        static void Main()
        {
            int i,
                len = 10;
           
            for (i= 2; i<= len+1;i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * (-1));
                }
            }
        }
    }
}
