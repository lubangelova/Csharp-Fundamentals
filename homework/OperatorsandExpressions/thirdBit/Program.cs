using System;


    class thirdBit
    {
        static void Main()
        {
        uint number = uint.Parse(Console.ReadLine());
       
      
        const int position= 3;

        uint mask = 1 << position;
        string bimask = Convert.ToString(mask, 2);
        Console.WriteLine(bimask);
        uint maskAndNumber = mask & number;
      
        uint bit = maskAndNumber >> position;
        Console.WriteLine(bit);

        }
    }

