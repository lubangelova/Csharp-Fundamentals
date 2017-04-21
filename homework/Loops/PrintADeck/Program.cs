using System;
using System.Collections.Generic;

namespace PrintADeck
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine().ToUpper();
            List<string> deck = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < deck.Count; i++)
            {
                if (n == deck[i])
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",deck[j]);
                    }
                    
                }
            }
        }
    }
}
