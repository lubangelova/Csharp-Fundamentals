﻿using System;


    class thirdDigit
    {
        static void Main()
        {
        int num = int.Parse(Console.ReadLine());
        int thirdDigit = (num / 100)%10;
        if (thirdDigit==7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit);
        }
        }
    }

