using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i+97);
            }
            for (int i = 0; i < word.Length; i++)
            {
                int left = 0;
                int right = alphabet.Length - 1;
                int result = 0;
                while (left<=right)
                {
                    int  middle = (left + right) / 2;
                    if (word[i] == alphabet[middle])
                    {
                        result = middle;
                        break;
                       
                    }
                    else if(word[i] > alphabet[middle])
                    {
                        left = middle + 1;
                    }
                    else if (word[i] < alphabet[middle])
                    {
                        right = middle - 1;
                    }
                }
                Console.WriteLine(result);
            }

           
        }
    }
}
