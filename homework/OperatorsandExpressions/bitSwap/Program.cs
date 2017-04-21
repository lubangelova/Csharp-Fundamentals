using System;


namespace bitSwap
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint firstBit = 0;
            uint secondBit = 0;
            uint newNumber = number;


            for (int i = 0; i < k; i++)
            {
                firstBit = GetBit(number, p + i);
                secondBit = GetBit(number, q + i);
                newNumber = ModifyBit(newNumber, p + i, secondBit);
                newNumber = ModifyBit(newNumber, q + i, firstBit);

            }
            Console.WriteLine(newNumber);
        }

        public static uint GetBit(uint number, int position)
        {
            uint mask = 1;
            uint maskAndNumber = (mask << position) & number;
            uint bit = maskAndNumber >> position;
            return bit;
        }

        public static uint ModifyBit(uint number, int position, uint bit)
        {
            uint newNumber;
            if (bit == 0)
            {
                uint mask = 1;
                newNumber = number & ~(mask << position);

            }
            else
            {
                uint mask = (uint)1 << position;
                newNumber = number | mask;


            }
            return newNumber;
        }

    }
}
