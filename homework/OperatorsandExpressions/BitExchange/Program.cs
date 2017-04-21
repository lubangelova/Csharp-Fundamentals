using System;


namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            int firstStartPosition = 3;
            int secondStartPosition = 24;
            uint firstBit = 0;
            uint secondBit = 0;
            uint newNumber = number;


            for (int i = 0; i < 3; i++)
            {
                firstBit = GetBit(number, firstStartPosition+i);
                secondBit = GetBit(number, secondStartPosition+i);
                newNumber = ModifyBit(newNumber, firstStartPosition + i, secondBit);
                newNumber = ModifyBit(newNumber, secondStartPosition + i, firstBit);

            }
            Console.WriteLine(newNumber);
        }

            public static uint GetBit(uint number,int position)
            {
                uint mask = 1;
                uint maskAndNumber = (mask<<position) & number;
                uint bit = maskAndNumber >> position;
                return bit;
            }

            public static uint ModifyBit(uint number,int position, uint bit )
            {
            uint newNumber;
                if (bit ==0)
            {
                uint mask = 1;
                newNumber = number & ~(mask<<position);
               
            } else
            {
                uint mask = (uint)1 << position;
                newNumber = number | mask;
                

            }
            return newNumber;
        }
           
        }
    }

