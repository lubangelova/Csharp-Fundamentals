using System;


namespace HexToDecimal
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            long dec = 0;

            for (int i = 0; i < number.Length; i++)
            {
                switch(number[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': dec += long.Parse(number[i].ToString()) * (long)Math.Pow(16, number.Length - 1 - i); break;
                    case 'A': dec += 10*(long)Math.Pow(16, number.Length - 1 - i);break;
                    case 'B': dec += 11 * (long)Math.Pow(16, number.Length - 1 - i); break;
                    case 'C': dec += 12 * (long)Math.Pow(16, number.Length - 1 - i); break;
                    case 'D': dec += 13 * (long)Math.Pow(16, number.Length - 1 - i); break;
                    case 'E': dec += 14 * (long)Math.Pow(16, number.Length - 1 - i); break;
                    case 'F': dec += 15 * (long)Math.Pow(16, number.Length - 1 - i); break;
                    default:break;


                }
            }
            Console.WriteLine(dec);
            
        }
    }
}
