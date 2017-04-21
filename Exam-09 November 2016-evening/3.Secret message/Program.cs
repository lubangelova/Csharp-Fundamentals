using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Secret_message
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            string S = "";
            string E = "";
            while (true)
            {
                S = Console.ReadLine();
                E = Console.ReadLine();
                text = Console.ReadLine();
                if (S == "end")
                {
                    break;
                }

            }
            string result = "";
            

            for (int i = int.Parse(S); i < int.Parse(E); i += 3)
            {
                char ch = text[i];
                result += ch.ToString();
            }
            Console.WriteLine(result);
        }
    }
}
