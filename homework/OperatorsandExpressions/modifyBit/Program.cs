using System;



    class modifyBit
    {
        static void Main()
        {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        byte v = byte.Parse(Console.ReadLine());


        if (p>=0 && p<64)
        {
            if (v==1)
            {
                ulong mask = (ulong) 1 << p;
                n = mask | n;
                Console.WriteLine(n);
            }
            else if (v==0)
            {
                ulong mask = (ulong)~(1 << p);
                n = mask & n;
                Console.WriteLine(n);
            }
        }
       


        }
    }

