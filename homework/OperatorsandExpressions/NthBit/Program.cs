using System;



    class NthBit
    {
        static void Main()
        {
        long P = long.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());
        long mask = 1 << N;
        long maskandP = mask & P;
        long bit = maskandP >> N;
        Console.WriteLine(bit);
        }
    }

