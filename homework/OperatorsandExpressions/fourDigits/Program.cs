﻿using System;



    class fourDigits
    {
        static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int b = (number % 1000)/100;
        int c = (number % 100)/10;
        int d = number % 10;
        int sum = a + b + c + d;
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
    }

